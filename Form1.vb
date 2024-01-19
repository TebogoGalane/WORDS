Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label3.Text = Label3.Text.ToUpper()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("")
        Dim myItems
        myItems = InputBox("Enter new words")
        ListBox1.Items.Add(myItems)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        ListBox1.SelectedItem.ToString()
        Label3.BackColor = Color.White
        Dim selectedWord = (ListBox1.SelectedItem)
        Label3.Text = selectedWord
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label3.Text = Label3.Text.ToLower()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label3.ForeColor = Color.Purple
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label3.ForeColor = Color.Blue
    End Sub
End Class
