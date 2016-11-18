Imports Bwl.Framework
Imports Bwl.GitTools

Public Class ProjectGeneratorForm
    Inherits FormAppBase

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        If IO.Directory.Exists(basicProjectPath.Text) Then
            MsgBox("Directory already exists!")
            Return
        End If
        If vsNone.Checked = False Then GenerateVsVbStudioSolution() : CopyTools()
        If asNone.Checked = False Then GenerateAtmelStudioSolution() : CopyTools()
        Shell("explorer """ + basicProjectPath.Text + """", AppWinStyle.NormalFocus)
    End Sub

    Sub CopyTools()
        Dim targetpath = IO.Path.Combine(basicProjectPath.Text)
        IO.File.Copy(IO.Path.Combine(_refsRepo, "vs-tools.exe"), IO.Path.Combine(targetpath, "vs-tools.exe"), True)
        IO.File.Copy("templates\.gitignore", IO.Path.Combine(targetpath, ".gitignore"), True)
        If licenseApache.Checked Then
            IO.File.Copy("templates\LICENSE-APACHE", IO.Path.Combine(targetpath, "LICENSE"), True)
            IOTools.ReplaceInFile(IO.Path.Combine(targetpath, "LICENSE"), "##AUTHOR", Now.Year.ToString + " " + basicProjectAuthor.Text)
        End If
        IO.File.WriteAllText(IO.Path.Combine(targetpath, "README"), basicProjectName.Text + vbCrLf + basicProjectAuthor.Text + ", " + Now.Year.ToString)
    End Sub


    Private Sub bUpdateRepos_Click(sender As Object, e As EventArgs) Handles bUpdateRepos.Click
        GitTool.Init()
        GitTool.RepositoryPullOrClone(_refsRepo, _refsUrl)
        GitTool.RepositoryPullOrClone(_avrLibRepo, _avrLibUrl)
        GitTool.RepositoryPullOrClone(_avrSsRepo, _avrSsUrl)
        _logger.AddMessage("Repositories updated")
    End Sub
End Class
