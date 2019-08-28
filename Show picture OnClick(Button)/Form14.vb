Public Class Form14

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True And CheckBox4.Checked = False And CheckBox5.Checked = False Then
            MsgBox("correct")
            MsgBox("2BP")
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True Then
            MsgBox("wrong answer")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True Then
            MsgBox("wrong answer")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        End If
        Form15.TextBox1.Text = Form1.TextBox2.Text
        Form15.TextBox2.Text = Form1.TextBox1.Text
        Form15.PictureBox2.Image = Form1.PictureBox1.Image
        Form15.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True Then
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

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            Form15.TextBox2.Text = TextBox2.Text
            MsgBox("wrong answer ")
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            Form15.TextBox2.Text = TextBox2.Text
            MsgBox("wrong answer ")
            Form15.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form15.TextBox2.Text = TextBox2.Text
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            Form15.TextBox2.Text = TextBox2.Text
            MsgBox("wrong answer ")
            Form15.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            Form15.TextBox2.Text = TextBox2.Text
            MsgBox("wrong answer ")
            Form15.Show()
            Me.Hide()
        End If
    End Sub
End Class