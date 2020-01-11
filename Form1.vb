Public Class Form1
    Dim passstr As String

    Public Function GetStr(str As String) As String
        Dim initials As String = Nothing
        Dim arr As String() = str.Split(" ")
        For Each i As String In arr
            If i.Length > 0 Then
                initials += i(0)
            End If
        Next
        Return initials
    End Function
    Public Function GetLast(srt As String) As String
        Dim out As String = Nothing
        out = srt.Substring(srt.Length - 3)

        Return out
    End Function
    Private Sub Create_psssword_Click(sender As Object, e As EventArgs) Handles Create_psssword.Click
        passstr = TextBox4.Text + GetStr(TextBox1.Text) + TextBox5.Text.ToUpper + TextBox3.Text + GetLast(TextBox2.Text)
        TextBox6.Text = passstr


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Password.Items.Clear()
        For Each i As Control In Me.Controls
            If TypeOf i Is TextBox Then
                i.Text = ""
            End If
        Next

    End Sub


End Class

