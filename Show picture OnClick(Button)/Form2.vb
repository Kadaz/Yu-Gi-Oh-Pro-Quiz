Public Class Form2
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Form1.Timer1.Enabled = False
        Form1.TextBox1.Text = "0BP"
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True Then
            MsgBox("wrong answer")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox3.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("correct")
            MsgBox("2BP")
            Form3.Show()
            Me.Hide()
        End If
        Form3.TextBox1.Text = Form1.TextBox2.Text
        Form3.TextBox2.Text = Form1.TextBox1.Text
        Form3.PictureBox2.Image = Form1.PictureBox1.Image
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            MsgBox("wrong answer ")
            Form3.Show()
            Me.Hide()
        ElseIf CheckBox3.Checked = True Then
            BP = BP + 2
            Form1.TextBox1.Text = BP
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class