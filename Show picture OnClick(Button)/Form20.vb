﻿Public Class Form20

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        My.Computer.Audio.Stop()
        Form1.Timer1.Enabled = False
        Form1.TextBox1.Text = "0BP"
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True Then
            BP = BP + 2
            Form1.TextBox1.Text = BP
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True And CheckBox4.Checked = False And CheckBox5.Checked = False Then
            MsgBox("correct")
            MsgBox("2BP")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True Then
            MsgBox("wrong answer")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True Then
            MsgBox("wrong answer")
            Form21.TextBox2.Text = TextBox2.Text
            Form21.Show()
            Me.Hide()
        End If
        Form21.TextBox2.Text = Form1.TextBox2.Text
        Form21.TextBox2.Text = Form1.TextBox1.Text
        Form21.PictureBox2.Image = Form1.PictureBox1.Image
        Form21.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True Then
            BP = BP + 2
            Form1.TextBox1.Text = BP
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Form1.Timer1.Enabled = False
        Form1.TextBox1.Text = "0BP"
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox5.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True And CheckBox6.Checked = True Then
            MsgBox("wrong answer ")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox6.Checked = True And CheckBox4.Checked = False And CheckBox5.Checked = False Then
            MsgBox("correct")
            MsgBox("2BP")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox4.Checked = True Then
            MsgBox("wrong answer")
            Form21.Show()
            Me.Hide()
        ElseIf CheckBox5.Checked = True Then
            MsgBox("wrong answer")
            Form21.Show()
            Me.Hide()
        End If
        Form21.TextBox1.Text = Form1.TextBox2.Text
        Form21.TextBox2.Text = Form1.TextBox1.Text
        Form21.PictureBox2.Image = Form1.PictureBox1.Image
        Form21.Show()
        Me.Hide()
    End Sub
End Class