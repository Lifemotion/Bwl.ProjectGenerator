Imports System.IO

Public Class IOTools

    Public Shared Function FindInFile(file As String, stringStart As String, stringEnd As String) As String
        Dim lines = IO.File.ReadAllLines(file)
        For i = 0 To lines.Length - 1
            If lines(i).Contains(stringStart) And lines(i).Contains(stringEnd) Then
                Dim result = lines(i).Replace(stringStart, "").Replace(stringEnd, "").Trim
                Return result
            End If
        Next
        IO.File.WriteAllLines(file, lines)
        Return Nothing
    End Function

    Public Shared Function ReplaceInFile(file As String, stringStart As String, replace As String, stringEnd As String) As Integer
        Dim replaces As Integer
        Dim lines = IO.File.ReadAllLines(file)
        For i = 0 To lines.Length - 1
            If lines(i).Contains(stringStart) And lines(i).Contains(stringEnd) Then
                lines(i) = stringStart + replace + stringEnd
                replaces += 1
            End If
        Next
        IO.File.WriteAllLines(file, lines)
        Return replaces
    End Function

    Public Shared Function ReplaceInFile(file As String, search As String, replace As String) As Integer
        Dim replaces As Integer
        Dim lines = IO.File.ReadAllLines(file)
        For i = 0 To lines.Length - 1
            If lines(i).Contains(search) Then
                lines(i) = lines(i).Replace(search, replace)
                replaces += 1
            End If
        Next
        IO.File.WriteAllLines(file, lines)
        Return replaces
    End Function

    Public Shared Sub DirectoryCopy(ByVal sourceDirName As String, ByVal destDirName As String, ByVal copySubDirs As Boolean)

        ' Get the subdirectories for the specified directory.
        Dim dir As DirectoryInfo = New DirectoryInfo(sourceDirName)

        If Not dir.Exists Then
            Throw New DirectoryNotFoundException(
                "Source directory does not exist or could not be found: " _
                + sourceDirName)
        End If

        Dim dirs As DirectoryInfo() = dir.GetDirectories()
        ' If the destination directory doesn't exist, create it.
        If Not Directory.Exists(destDirName) Then
            Directory.CreateDirectory(destDirName)
        End If
        ' Get the files in the directory and copy them to the new location.
        Dim files As FileInfo() = dir.GetFiles()
        For Each file In files
            Dim temppath As String = Path.Combine(destDirName, file.Name)
            file.CopyTo(temppath, True)
        Next file

        ' If copying subdirectories, copy them and their contents to new location.
        If copySubDirs Then
            For Each subdir In dirs
                Dim temppath As String = Path.Combine(destDirName, subdir.Name)
                DirectoryCopy(subdir.FullName, temppath, copySubDirs)
            Next subdir
        End If
    End Sub
End Class
