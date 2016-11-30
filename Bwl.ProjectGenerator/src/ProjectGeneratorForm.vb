Imports Bwl.Framework
Imports Bwl.GitTools

Public Class ProjectGeneratorForm
    Inherits FormAppBase

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        If basicProjectName.Text > "" Then
            If IO.Directory.Exists(basicProjectPath.Text) And basicAddToExisting.Checked = False Then
                MsgBox("Directory already exists!")
                Return
            End If
            If vsNone.Checked = False Then GenerateVsVbStudioSolution() : CopyTools()
            If asNone.Checked = False Then GenerateAtmelStudioSolution() : CopyTools()
            Shell("explorer """ + basicProjectPath.Text + """", AppWinStyle.NormalFocus)
        Else
            MsgBox("Project Name cannot be empty!")
        End If
    End Sub

    Sub CopyTools()
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text)
        If miscVsTools.Checked Then IO.File.Copy(IO.Path.Combine(_refsRepo, "vs-tools.exe"), IO.Path.Combine(targetpath, "vs-tools.exe"), True)
        If miscGitIgnore.Checked Then     IO.File.Copy("templates\.gitignore", IO.Path.Combine(targetpath, ".gitignore"), True)
        If licenseApache.Checked Then
            IO.File.Copy("templates\LICENSE-APACHE", IO.Path.Combine(targetpath, "LICENSE"), True)
            IOTools.ReplaceInFile(IO.Path.Combine(targetpath, "LICENSE"), "##AUTHOR", Now.Year.ToString + " " + basicProjectAuthor.Text)
        End If
        If miscReadme.Checked Then IO.File.WriteAllText(IO.Path.Combine(targetpath, "README"), basicProjectName.Text + vbCrLf + basicProjectAuthor.Text + ", " + Now.Year.ToString)
        If miscGitInit.Checked Then
            GitTool.Init()
            GitTool.Execute(basicProjectPath.Text, "init")
            GitTool.RepositoryAdd(basicProjectPath.Text, "*")
            GitTool.RepositoryCommit(basicProjectPath.Text, "Project stub created with Bwl.ProjectGenerator")
        End If
    End Sub


    Private Sub bUpdateRepos_Click(sender As Object, e As EventArgs) Handles bUpdateRepos.Click
        GitTool.Init()
        GitTool.RepositoryPullOrClone(_refsRepo, _refsUrl)
        GitTool.RepositoryPullOrClone(_avrLibRepo, _avrLibUrl)
        GitTool.RepositoryPullOrClone(_avrSsRepo, _avrSsUrl)
        _logger.AddMessage("Repositories updated")
    End Sub

    Private Sub basicAddToExisting_CheckedChanged(sender As Object, e As EventArgs) Handles basicCreateNewWithFolder.CheckedChanged, basicCreateNew.CheckedChanged, basicAddToExisting.CheckedChanged
        If basicAddToExisting.Checked Then
            miscGitIgnore.Checked = False
            miscReadme.Checked = False
            miscVsTools.Checked = False
            miscGitInit.Checked = False
            licenseNone.Checked = True
        Else
            miscGitIgnore.Checked = True
            miscReadme.Checked = True
            miscVsTools.Checked = True
            miscGitInit.Checked = True
            licenseApache.Checked = True
        End If
        basicPath_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub basicPath_TextChanged(sender As Object, e As EventArgs) Handles basicPath.TextChanged, basicProjectName.TextChanged
        If basicCreateNewWithFolder.Checked Then
            basicProjectPath.Text = IO.Path.Combine(basicPath.Text, basicProjectName.Text)
        Else
            basicProjectPath.Text = basicPath.Text
        End If
    End Sub

    Private Sub ProjectGeneratorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text += " " + Application.ProductVersion
        If basicPath.Text = "" Then
            basicPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        End If
        Dim rnd As New Random
        If basicProjectName.Text = "" Then basicProjectName.Text = "Project" + rnd.Next.ToString
        If basicProjectAuthor.Text = "" Then basicProjectAuthor.Text = My.User.Name

    End Sub
End Class
