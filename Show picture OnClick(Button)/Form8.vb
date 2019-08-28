Public Class Form8

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox1.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True Then
           BP = BP + 2
            Form1.TextBox1.Text = BP
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Form1.Timer1.Enabled = False
        Form1.TextBox1.Text = "0BP"
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If CheckBox1.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox1.Checked = False And CheckBox6.Checked = False Then
            MsgBox("correct")
            MsgBox("2BP")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True Then
            MsgBox("wrong answer")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True Then
            MsgBox("wrong answer")
            Form9.Show()
            Me.Hide()
        End If
        Form9.TextBox1.Text = Form1.TextBox2.Text
        Form9.TextBox2.Text = Form1.TextBox1.Text
        Form9.PictureBox2.Image = Form1.PictureBox1.Image
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox1.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form9.Show()
            Me.Hide()
        End If
    End Sub
End Class