Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form1

    Private Function GetBetweenAll(ByVal Source As String, ByVal Str1 As String, ByVal Str2 As String) As String()
        Dim Results, T As New List(Of String)
        T.AddRange(Regex.Split(Source, Str1))
        T.RemoveAt(0)
        For Each I As String In T
            Results.Add(Regex.Split(I, Str2)(0))
        Next
        Return Results.ToArray
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim trd As Thread = New Thread(AddressOf extract)
        trd.IsBackground = True
        trd.Start()
    End Sub

    Private Function extract()
        If (TextBox1.Text.StartsWith("http://") Or TextBox1.Text.StartsWith("https://")) Then
            Dim r As HttpWebRequest = HttpWebRequest.Create(TextBox1.Text)
            r.KeepAlive = True
            r.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/29.0.1547.2 Safari/537.36"
            Dim re As HttpWebResponse = r.GetResponse()
            Dim src As String = New StreamReader(re.GetResponseStream()).ReadToEnd()
            Dim words As String() = src.Split(" ")
            For Each word As String In words
                If (word.Contains("@") And word.Contains(".")) Then
                    If (word.Contains("<") And word.Contains(">")) Then
                        Dim toAdd As New List(Of String)
                        Dim noTags As String() = GetBetweenAll(word, ">", "<")
                        For Each w As String In noTags
                            If (w.Contains("@") And w.Contains(".") And Not w.Contains("=")) Then
                                If (w.EndsWith(",") Or w.EndsWith(".")) Then
                                    toAdd.Add(w.Substring(0, w.Length - 1))
                                Else
                                    toAdd.Add(w)
                                End If
                            End If
                        Next
                        If (toAdd.Count > 0) Then
                            If (toAdd.Count > 1) Then
                                For Each t As String In toAdd
                                    ListBox1.Items.Add(t)
                                Next
                            Else
                                ListBox1.Items.Add(toAdd(0))
                            End If
                        End If
                    Else
                        ListBox1.Items.Add(word)
                    End If
                End If
            Next
        Else : MsgBox("That is not a valid link!")
        End If
    End Function

    Private Function removeTags(ByVal w As String)
        Dim toReturn As New List(Of String)
        Dim noTags As String() = GetBetweenAll(w, ">", "<")
        For Each word As String In noTags
            If (word.Contains("@") And word.Contains(".") And Not word.Contains("=")) Then
                toReturn.Add(word)
            End If
        Next
        Return toReturn
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim items As New List(Of String)
        For Each i As String In ListBox1.Items
            Dim isNew As Boolean = True
            For Each it As String In items
                If (it = i) Then isNew = False
            Next
            If (isNew) Then items.Add(i)
        Next
        ListBox1.Items.Clear()
        For Each i As String In items
            ListBox1.Items.Add(i)
        Next
    End Sub
End Class
