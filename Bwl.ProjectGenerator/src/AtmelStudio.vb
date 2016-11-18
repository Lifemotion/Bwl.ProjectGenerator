Partial Public Class ProjectGeneratorForm
    Private _avrLibRepo As String = IO.Path.Combine(AppBase.DataFolder, "Bwl.AVRLib")
    Private _avrLibUrl As String = "https://github.com/Lifemotion/Bwl.AVRLib.git"

    Private _avrSsRepo As String = IO.Path.Combine(AppBase.DataFolder, "Bwl.AvrBootloader")
    Private _avrSsUrl As String = "https://github.com/Lifemotion/Bwl.AvrBootloader.git"

    Public Sub GenerateAtmelStudioSolution()
        If asProjectC.Checked Then
            Dim prj = CopyAtmelProject("templates\atmel\Atmel7AvrTemplateC", GetAtmelProjectPath(".Fw"))
            CopyAtmelAtslnFile(prj, ".Fw")
            CopyAtmelLibs(prj)
            'CopyVsRefs(prjs(0))
        End If
    End Sub

    Public Sub CopyAtmelAtslnFile(prj As String, postfix As String)
        Dim sln = GetAtmelAtslnFilePath(postfix)
        Dim prjName = IO.Path.GetFileNameWithoutExtension(prj)
        IO.File.Copy("templates\atmel\Atmel7AvrTemplateC.atsln", sln)
        Dim prjGuid = GetAtmelProjectGuid(prj)
        IOTools.ReplaceInFile(sln, "Atmel7AvrTemplateC", prjName)
        IOTools.ReplaceInFile(sln, "{DCE6C7E3-EE26-4D79-826B-08594B9AD897}", prjGuid)
    End Sub

    Public Function GetAtmelProjectGuid(path As String) As String
        Dim result = IOTools.FindInFile(path, "<ProjectGuid>", "</ProjectGuid>")
        If result Is Nothing OrElse result.Length < 10 Then Throw New Exception
        Return result
    End Function

    Public Function GetAtmelAtslnFilePath(postfix As String)
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + postfix + ".atsln")
        Return path
    End Function

    Public Function GetAtmelProjectPath(postfix As String)
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + postfix)
        If IO.Directory.Exists(path) = False Then IO.Directory.CreateDirectory(path)
        Return path
    End Function

    Public Function CopyAtmelProject(source As String, target As String) As String
        If IO.Directory.Exists(source) = False Then Throw New Exception
        If IO.Directory.Exists(target) = False Then Throw New Exception
        IOTools.DirectoryCopy(source, target, True)
        Dim oldPrjName = IO.Path.GetFileName(source)
        Dim targetPrjName = IO.Path.GetFileName(target)
        Dim oldPrjFilePath = IO.Directory.GetFiles(target, "*.cproj")(0)
        Dim targetPrjFilePath = IO.Path.Combine(IO.Path.GetDirectoryName(oldPrjFilePath), targetPrjName + ".cproj")
        IO.File.Move(oldPrjFilePath, targetPrjFilePath)
        Dim oldPrjFilePath1 = IO.Directory.GetFiles(target, "*.componentinfo.xml")(0)
        Dim targetPrjFilePath1 = IO.Path.Combine(IO.Path.GetDirectoryName(oldPrjFilePath), targetPrjName + ".componentinfo.xml")
        IO.File.Move(oldPrjFilePath1, targetPrjFilePath1)

        Dim newguid = "{" + Guid.NewGuid.ToString.ToUpper + "}"
        IOTools.ReplaceInFile(targetPrjFilePath, "<ProjectGuid>", newguid, "</ProjectGuid>")
        IOTools.ReplaceInFile(targetPrjFilePath, oldPrjName, targetPrjName)
        Return targetPrjFilePath
    End Function

    Public Sub CopyAtmelLibs(includeInProject As String)
        Dim prjName = IO.Path.GetFileNameWithoutExtension(includeInProject)
        Dim prjPath = IO.Path.GetDirectoryName(includeInProject)

        Dim liblist As New List(Of String)
        Dim targetpath = IO.Path.Combine(prjPath, "libs")
        If IO.Directory.Exists(targetpath) = False Then IO.Directory.CreateDirectory(targetpath)
        Dim libspath = IO.Path.Combine(_avrLibRepo, "lib-src")
        Dim sspath = IO.Path.Combine(_avrSsRepo, "Bwl.SimplSerial.AvrExampleProgram", "libs")

        If asBwlUart.Checked Then CopyAtmelLib(sspath, targetpath, "bwl_uart", liblist)
        If asBwlSimplSerial.Checked Then CopyAtmelLib(sspath, targetpath, "bwl_simplserial", liblist)
        If asBwlAdc.Checked Then CopyAtmelLib(libspath, targetpath, "bwl_adc", liblist)
        If asBwlI2c.Checked Then CopyAtmelLib(libspath, targetpath, "bwl_i2c", liblist)
        If asBwlIr.Checked Then CopyAtmelLib(libspath, targetpath, "bwl_ir", liblist)
        If asBwlStrings.Checked Then CopyAtmelLib(libspath, targetpath, "bwl_strings", liblist)
        If asBwlTools.Checked Then CopyAtmelLib(libspath, targetpath, "bwl_tools", liblist)
        If asBwlSpi.Checked Then CopyAtmelLib(libspath, targetpath, "spi", liblist)

        Dim includeString = ""
        Dim fileString = ""
        For Each file In liblist
            fileString += "<Compile Include = ""libs\" + file + """>" + vbCrLf
            fileString += "<SubType>compile</SubType>" + vbCrLf
            fileString += "</Compile>" + vbCrLf
            If IO.Path.GetExtension(file).ToLower = ".h" Then
                includeString += "#include ""../libs/" + file + """" + vbCrLf
            End If
        Next
        IOTools.ReplaceInFile(includeInProject, "#INCFILES", fileString)
        IOTools.ReplaceInFile(IO.Path.Combine(prjPath, "board", "board.h"), "//#INCLUDE", includeString)
    End Sub

    Public Sub CopyAtmelLib(srcpath As String, targetpath As String, filename As String, liblist As List(Of String))
        Dim files = IO.Directory.GetFiles(srcpath)
        For Each file In files
            Dim fname = IO.Path.GetFileName(file)
            If fname.Contains(filename) Then
                IO.File.Copy(file, IO.Path.Combine(targetpath, fname), True)
                liblist.Add(fname)
            End If
        Next
    End Sub

End Class
