Imports System.Windows.Forms

Public Class Dialog1
    Dim IP As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If CheckBox1.Checked And CheckBox2.Checked And CheckBox3.Checked Then
            IP = "https://" + TextBox1.Text + ":" + MaskedTextBox5.Text
        ElseIf CheckBox3.Checked = True Then
            IP = TextBox1.Text
        ElseIf CheckBox3.Checked And CheckBox2.Checked Then
            IP = "https://" + TextBox1.Text
        ElseIf CheckBox3.Checked And CheckBox1.Checked Then
            IP = "http://" + TextBox1.Text + ":" + MaskedTextBox5.Text
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            IP = "https://" + MaskedTextBox1.Text + "." + MaskedTextBox2.Text + "." + MaskedTextBox3.Text + "." + MaskedTextBox4.Text + ":" + MaskedTextBox5.Text
        ElseIf CheckBox1.Checked = True Then
            IP = "http://" + MaskedTextBox1.Text + "." + MaskedTextBox2.Text + "." + MaskedTextBox3.Text + "." + MaskedTextBox4.Text + ":" + MaskedTextBox5.Text
        ElseIf CheckBox2.Checked = True Then
            IP = "https://" + MaskedTextBox1.Text + "." + MaskedTextBox2.Text + "." + MaskedTextBox3.Text + "." + MaskedTextBox4.Text
        Else
            IP = "http://" + MaskedTextBox1.Text + "." + MaskedTextBox2.Text + "." + MaskedTextBox3.Text + "." + MaskedTextBox4.Text
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.WebBrowser1.Navigate(IP)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label6.Visible = True
            MaskedTextBox5.Visible = True
        Else
            Label6.Visible = False
            MaskedTextBox5.Visible = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Label1.Text = "URL:"
            TextBox1.Visible = True
            Label5.Text = "Enter the URL of the camera below:"
        Else
            Label1.Text = "IP Address:"
            TextBox1.Visible = False
            Label5.Text = "Enter the IP Address of the camera below:"
        End If
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
    End Sub
End Class

