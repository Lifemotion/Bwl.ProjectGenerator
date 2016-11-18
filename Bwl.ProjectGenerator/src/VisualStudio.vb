Partial Class ProjectGeneratorForm
    Private _refsRepo As String = IO.Path.Combine(AppBase.DataFolder, "Bwl.Binaries")
    Private _refsUrl As String = "https://github.com/Lifemotion/Bwl.Binaries"

    Public Sub GenerateVsVbStudioSolution()
        Dim prjs As New List(Of String)

        If vsGui.Checked Then
            prjs.Add(CopyVsGuiProject(""))
            CopyVsRefs(prjs(0))
        End If
        If vsLibraryGui.Checked Then
            prjs.Add(CopyVsGuiProject(".App"))
            prjs.Add(CopyVsLibProject(""))
            CopyVsRefs(prjs(1))
            AddVsRef(prjs(0), "bwl-framework")
            AddVsPrjRef(prjs(0), prjs(1))
        End If
        If vsLibraryTestGui.Checked Then
            prjs.Add(CopyVsGuiProject(".Test"))
            prjs.Add(CopyVsLibProject(""))
            CopyVsRefs(prjs(1))
            AddVsRef(prjs(0), "bwl-framework")
            AddVsPrjRef(prjs(0), prjs(1))
        End If
        If vsLibraryConsole.Checked Then
            prjs.Add(CopyVsCmdProject(".CmdApp"))
            prjs.Add(CopyVsLibProject(""))
            CopyVsRefs(prjs(1))
            AddVsRef(prjs(0), "bwl-framework")
            AddVsPrjRef(prjs(0), prjs(1))
        End If
        If vsConsole.Checked Then
            prjs.Add(CopyVsCmdProject(""))
            CopyVsRefs(prjs(0))
        End If
        GenerateVsSlnFile(prjs.ToArray)
    End Sub

    Public Sub GenerateVsSlnFile(prjs() As String)
        Dim lines As New List(Of String)
        Dim path = GetVsSlnFilePath()
        lines.Add("Microsoft Visual Studio Solution File, Format Version 12.00")
        lines.Add("# Visual Studio 14")
        lines.Add("VisualStudioVersion = 14.0.25420.1")
        lines.Add("MinimumVisualStudioVersion = 10.0.40219.1")
        lines.Add("#")
        For Each prj In prjs
            Dim ext = IO.Path.GetExtension(prj)
            Dim name = IO.Path.GetFileNameWithoutExtension(prj)
            Dim guid = GetVsProjectGuid(prj)
            If ext = ".vbproj" Then
                Dim prjLine = "Project(""{F184B08F-C81C-45F6-A57F-5ABD9991F28F}"") = """ + name + """, """ + name + "\" + name + ".vbproj"", """ + guid + """"
                lines.Add(prjLine)
                lines.Add("EndProject")
            End If
        Next
        lines.Add("Global")
        lines.Add("GlobalSection(SolutionConfigurationPlatforms) = preSolution")
        lines.Add("Debug|Any CPU = Debug|Any CPU")
        lines.Add("Release|Any CPU = Release|Any CPU")
        lines.Add("EndGlobalSection")
        lines.Add("GlobalSection(SolutionProperties) = preSolution")
        lines.Add("HideSolutionNode = False")
        lines.Add("EndGlobalSection")
        lines.Add("EndGlobal")
        IO.File.WriteAllLines(path, lines.ToArray)
    End Sub

    Public Function GetVsProjectGuid(path As String) As String
        Dim result = IOTools.FindInFile(path, "<ProjectGuid>", "</ProjectGuid>")
        If result Is Nothing OrElse result.Length < 10 Then Throw New Exception
        Return result
    End Function

    Public Function GetVsSlnFilePath()
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + ".sln")
        Return path
    End Function

    Public Function GetVsProjectPath(postfix As String)
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + postfix)
        If IO.Directory.Exists(path) = False Then IO.Directory.CreateDirectory(path)
        Return path
    End Function

    Public Function CopyVsCmdProject(postfix As String) As String
        Return CopyVsVbProject("templates\vs-vb\VsGeneratorTemplateCmd", GetVsProjectPath(postfix))
    End Function

    Public Function CopyVsLibProject(postfix As String) As String
        Return CopyVsVbProject("templates\vs-vb\VsGeneratorTemplateLib", GetVsProjectPath(postfix))
    End Function

    Public Function CopyVsGuiProject(postfix As String) As String
        If vsAutoUi.Checked Then
            Dim prj = CopyVsVbProject("templates\vs-vb\VsGeneratorTemplateGuiMain", GetVsProjectPath(postfix))
            Dim prjPath = IO.Path.GetDirectoryName(prj)
            IO.File.Copy("templates\vs-vb\AutoUiApp.vb", IO.Path.Combine(prjPath, "App.vb"), True)
            Return prj
        Else
            Dim prj = CopyVsVbProject("templates\vs-vb\VsGeneratorTemplateGui", GetVsProjectPath(postfix))
            IOTools.ReplaceInFile(IO.Path.Combine(GetVsProjectPath(postfix), "App.Designer.vb"), "Me.Text = ""Form1""", "Me.Text = """ + basicProjectName.Text + """")
            If vsFormAppBase.Checked Then
                IOTools.ReplaceInFile(IO.Path.Combine(GetVsProjectPath(postfix), "App.Designer.vb"), "Inherits System.Windows.Forms.Form", "Inherits Bwl.Framework.FormAppBase")
            End If
            Return prj
        End If
    End Function

    Public Function CopyVsVbProject(source As String, target As String) As String
        If IO.Directory.Exists(source) = False Then Throw New Exception
        If IO.Directory.Exists(target) = False Then Throw New Exception
        IOTools.DirectoryCopy(source, target, True)
        Dim oldPrjName = IO.Path.GetFileName(source)
        Dim targetPrjName = IO.Path.GetFileName(target)
        Dim oldPrjFilePath = IO.Directory.GetFiles(target, "*.vbproj")(0)
        Dim targetPrjFilePath = IO.Path.Combine(IO.Path.GetDirectoryName(oldPrjFilePath), targetPrjName + ".vbproj")
        IO.File.Move(oldPrjFilePath, targetPrjFilePath)
        Dim newguid = "{" + Guid.NewGuid.ToString.ToUpper + "}"
        IOTools.ReplaceInFile(targetPrjFilePath, "<ProjectGuid>", newguid, "</ProjectGuid>")
        IOTools.ReplaceInFile(targetPrjFilePath, oldPrjName, targetPrjName)
        IOTools.ReplaceInFile(IO.Path.Combine(target, "My Project", "AssemblyInfo.vb"), oldPrjName, targetPrjName)
        IOTools.ReplaceInFile(IO.Path.Combine(target, "My Project", "Application.Designer.vb"), oldPrjName, targetPrjName)
        IOTools.ReplaceInFile(IO.Path.Combine(target, "My Project", "Resources.Designer.vb"), oldPrjName, targetPrjName)
        IOTools.ReplaceInFile(IO.Path.Combine(target, "My Project", "Settings.Designer.vb"), oldPrjName, targetPrjName)
        Return targetPrjFilePath
    End Function

    Public Sub CopyVsRefs(includeInProject As String)
        Dim reflist As New List(Of String)
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text, "refs")
        IO.Directory.CreateDirectory(targetpath)
        Dim srcpath = IO.Path.Combine(_refsRepo, "fw4.5-debug")
        If vsBwlFramework.Checked Then CopyVsRef(srcpath, targetpath, "bwl-framework", reflist)
        If vsBwlHardwareSerial.Checked Then CopyVsRef(srcpath, targetpath, "bwl-hardware-serial", reflist)
        If vsBwlImaging.Checked Then CopyVsRef(srcpath, targetpath, "bwl-imaging", reflist)
        If vsBwlNetworkTransport.Checked Then CopyVsRef(srcpath, targetpath, "bwl-network-transport", reflist)
        If vsBwlUniversalOrm.Checked Then CopyVsRef(srcpath, targetpath, "bwl-universal-orm", reflist)
        If vsBwlVideo.Checked Then CopyVsRef(srcpath, targetpath, "bwl-video", reflist)
        Dim refstring As String = ""
        For Each ref In reflist
            Dim refRel As String = ref.Replace(basicProjectPath.Text, "")
            refstring += "<Reference Include = """ + IO.Path.GetFileNameWithoutExtension(ref) + """ >" + vbCrLf
            refstring += "<HintPath>.." + refRel + "</HintPath>" + vbCrLf
            refstring += "</Reference>" + vbCrLf
        Next
        IOTools.ReplaceInFile(includeInProject, "<!--REFS-->", refstring)
    End Sub

    Private Sub CopyVsRef(source As String, target As String, refsubdir As String, reflist As List(Of String))
        IOTools.DirectoryCopy(IO.Path.Combine(source, refsubdir), IO.Path.Combine(target, refsubdir), True)
        Dim exes = IO.Directory.GetFiles(IO.Path.Combine(target, refsubdir), "*.exe")
        Dim dlls = IO.Directory.GetFiles(IO.Path.Combine(target, refsubdir), "*.dll")
        reflist.AddRange(exes)
        reflist.AddRange(dlls)
    End Sub

    Public Sub AddVsPrjRef(includeInProject As String, refProject As String)
        Dim refstring As String = ""
        Dim refguid = GetVsProjectGuid(refProject)
        Dim refRel As String = refProject.Replace(basicProjectPath.Text, "")
        refstring += "<ItemGroup>" + vbCrLf
        refstring += "<ProjectReference Include = "".." + refRel + """>" + vbCrLf
        refstring += "<Project>" + refguid + "</Project>" + vbCrLf
        refstring += "<Name>" + IO.Path.GetFileNameWithoutExtension(refProject) + "</Name>" + vbCrLf
        refstring += "</ProjectReference>" + vbCrLf
        refstring += "</ItemGroup>" + vbCrLf
        IOTools.ReplaceInFile(includeInProject, "<!--PRJREFS-->", refstring)
    End Sub

    Public Sub AddVsRef(includeInProject As String, refSubdir As String)
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text, "refs")
        Dim reflist As New List(Of String)
        reflist.AddRange(IO.Directory.GetFiles(IO.Path.Combine(targetpath, refSubdir), "*.exe"))
        reflist.AddRange(IO.Directory.GetFiles(IO.Path.Combine(targetpath, refSubdir), "*.dll"))
        Dim refstring As String = ""
        For Each ref In reflist
            Dim refRel As String = ref.Replace(basicProjectPath.Text, "")
            refstring += "<Reference Include = """ + IO.Path.GetFileNameWithoutExtension(ref) + """ >" + vbCrLf
            refstring += "<HintPath>.." + refRel + "</HintPath>" + vbCrLf
            refstring += "</Reference>" + vbCrLf
        Next
        IOTools.ReplaceInFile(includeInProject, "<!--REFS-->", refstring)
    End Sub

End Class
