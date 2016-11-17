Imports Bwl.Framework

Public Class ProjectGeneratorForm
    Inherits FormAppBase

    Private _refsRepo = "C:\Users\heart\Repositories\Bwl.Binaries"

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        If vsNone.Checked = False Then GenerateVisualStudioSolution
    End Sub

    Sub GenerateVisualStudioSolution()
        Dim prjs As New List(Of String)

        If vsGui.Checked Then
            prjs.Add(CopyGuiProject(""))
            CopyRefs(prjs(0))
        End If
        If vsLibraryGui.Checked Then
            prjs.Add(CopyGuiProject(".App"))
            prjs.Add(CopyLibProject(""))
            CopyRefs(prjs(1))
            AddRef(prjs(0), "bwl-framework")
            AddPrjRef(prjs(0), prjs(1))
        End If
        If vsLibraryTestGui.Checked Then
            prjs.Add(CopyGuiProject(".Test"))
            prjs.Add(CopyLibProject(""))
            CopyRefs(prjs(1))
            AddRef(prjs(0), "bwl-framework")
            AddPrjRef(prjs(0), prjs(1))
        End If
        If vsLibraryConsole.Checked Then
            prjs.Add(CopyCmdProject(".CmdApp"))
            prjs.Add(CopyLibProject(""))
            CopyRefs(prjs(1))
            AddRef(prjs(0), "bwl-framework")
            AddPrjRef(prjs(0), prjs(1))
        End If
        If vsConsole.Checked Then
            prjs.Add(CopyCmdProject(""))
            CopyRefs(prjs(0))
        End If
        CopyTools()
        GenerateSolutionFile(prjs.ToArray)
        Shell("explorer """ + basicProjectPath.Text + """", AppWinStyle.NormalFocus)
    End Sub

    Sub GenerateSolutionFile(prjs() As String)
        Dim lines As New List(Of String)
        Dim path = GetSolutionPath()
        lines.Add("Microsoft Visual Studio Solution File, Format Version 12.00")
        lines.Add("# Visual Studio 14")
        lines.Add("VisualStudioVersion = 14.0.25420.1")
        lines.Add("MinimumVisualStudioVersion = 10.0.40219.1")
        lines.Add("#")
        For Each prj In prjs
            Dim ext = IO.Path.GetExtension(prj)
            Dim name = IO.Path.GetFileNameWithoutExtension(prj)
            Dim guid = GetProjectGuid(prj)
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

    Function GetProjectGuid(path As String) As String
        Dim result = IOTools.FindInFile(path, "<ProjectGuid>", "</ProjectGuid>")
        If result Is Nothing OrElse result.length < 10 Then Throw New Exception
        Return result
    End Function

    Function GetSolutionPath()
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + ".sln")
        Return path
    End Function

    Function GetProjectPath(postfix As String)
        Dim path = IO.Path.Combine(basicProjectPath.Text, basicProjectName.Text + postfix)
        If IO.Directory.Exists(path) = False Then IO.Directory.CreateDirectory(path)
        Return path
    End Function

    Function CopyCmdProject(postfix As String) As String
        Return CopyProjectVB("templates\vs-vb\VsGeneratorTemplateCmd", GetProjectPath(postfix))
    End Function

    Function CopyLibProject(postfix As String) As String
        Return CopyProjectVB("templates\vs-vb\VsGeneratorTemplateLib", GetProjectPath(postfix))
    End Function

    Function CopyGuiProject(postfix As String) As String
        If vsAutoUi.Checked Then
            Dim prj = CopyProjectVB("templates\vs-vb\VsGeneratorTemplateGuiMain", GetProjectPath(postfix))
            Dim prjPath = IO.Path.GetDirectoryName(prj)
            IO.File.Copy("templates\vs-vb\AutoUiApp.vb", IO.Path.Combine(prjPath, "App.vb"),True )
            Return prj
        Else
            Dim prj = CopyProjectVB("templates\vs-vb\VsGeneratorTemplateGui", GetProjectPath(postfix))
            IOTools.ReplaceInFile(IO.Path.Combine(GetProjectPath(postfix), "App.Designer.vb"), "Me.Text = ""Form1""", "Me.Text = """ + basicProjectName.Text + """")
            If vsFormAppBase.Checked Then
                IOTools.ReplaceInFile(IO.Path.Combine(GetProjectPath(postfix), "App.Designer.vb"), "Inherits System.Windows.Forms.Form", "Inherits Bwl.Framework.FormAppBase")
            End If
            Return prj
        End If
    End Function

    Function CopyProjectVB(source As String, target As String) As String
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

    Sub CopyTools()
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text)
        IO.File.Copy(IO.Path.Combine(_refsRepo, "vs-tools.exe"), IO.Path.Combine(targetpath, "vs-tools.exe"))
        IO.File.Copy("templates\.gitignore", IO.Path.Combine(targetpath, ".gitignore"))
        If licenseApache.Checked Then
            IO.File.Copy("templates\LICENSE-APACHE", IO.Path.Combine(targetpath, "LICENSE"))
            IOTools.ReplaceInFile(IO.Path.Combine(targetpath, "LICENSE"), "##AUTHOR", Now.Year.ToString + " " + basicProjectAuthor.Text)
        End If
        IO.File.WriteAllText(IO.Path.Combine(targetpath, "README"), basicProjectName.Text + vbCrLf + basicProjectAuthor.Text + ", " + Now.Year.ToString)
    End Sub

    Sub CopyRefs(includeInProject As String)
        Dim reflist As New List(Of String)
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text, "refs")
        IO.Directory.CreateDirectory(targetpath)
        Dim srcpath = IO.Path.Combine(_refsRepo, "fw4.5-debug")
        If vsBwlFramework.Checked Then CopyRef(srcpath, targetpath, "bwl-framework", reflist)
        If vsBwlHardwareSerial.Checked Then CopyRef(srcpath, targetpath, "bwl-hardware-serial", reflist)
        If vsBwlImaging.Checked Then CopyRef(srcpath, targetpath, "bwl-imaging", reflist)
        If vsBwlNetworkTransport.Checked Then CopyRef(srcpath, targetpath, "bwl-network-transport", reflist)
        If vsBwlUniversalOrm.Checked Then CopyRef(srcpath, targetpath, "bwl-universal-orm", reflist)
        If vsBwlVideo.Checked Then CopyRef(srcpath, targetpath, "bwl-video", reflist)
        Dim refstring As String = ""
        For Each ref In reflist
            Dim refRel As String = ref.Replace(basicProjectPath.Text, "")
            refstring += "<Reference Include = """ + IO.Path.GetFileNameWithoutExtension(ref) + """ >" + vbCrLf
            refstring += "<HintPath>.." + refRel + "</HintPath>" + vbCrLf
            refstring += "</Reference>" + vbCrLf
        Next
        IOTools.ReplaceInFile(includeInProject, "<!--REFS-->", refstring)
    End Sub

    Sub AddPrjRef(includeInProject As String, refProject As String)
        Dim refstring As String = ""
        Dim refguid = GetProjectGuid(refProject)
        Dim refRel As String = refProject.Replace(basicProjectPath.Text, "")
        refstring += "<ItemGroup>" + vbCrLf
        refstring += "<ProjectReference Include = "".." + refRel + """>" + vbCrLf
        refstring += "<Project>" + refguid + "</Project>" + vbCrLf
        refstring += "<Name>" + IO.Path.GetFileNameWithoutExtension(refProject) + "</Name>" + vbCrLf
        refstring += "</ProjectReference>" + vbCrLf
        refstring += "</ItemGroup>" + vbCrLf
        IOTools.ReplaceInFile(includeInProject, "<!--PRJREFS-->", refstring)
    End Sub

    Sub AddRef(includeInProject As String, refSubdir As String)
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

    Private Sub CopyRef(source As String, target As String, refsubdir As String, reflist As List(Of String))
        IOTools.DirectoryCopy(IO.Path.Combine(source, refsubdir), IO.Path.Combine(target, refsubdir), True)
        Dim exes = IO.Directory.GetFiles(IO.Path.Combine(target, refsubdir), "*.exe")
        Dim dlls = IO.Directory.GetFiles(IO.Path.Combine(target, refsubdir), "*.dll")
        reflist.AddRange(exes)
        reflist.AddRange(dlls)
    End Sub

    Private Sub ProjectGeneratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
