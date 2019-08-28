Public Class Form1
    Dim timercount As Integer = 200
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Plz Enter Your Name And Save The Results When You Finish. Have Fun!!!")
        Form2.CheckBox1.Checked = False
        Form2.CheckBox2.Checked = False
        Form2.CheckBox3.Checked = False
        Form3.CheckBox4.Checked = False
        Form3.CheckBox5.Checked = False
        Form3.CheckBox6.Checked = False
        Form4.CheckBox4.Checked = False
        Form4.CheckBox5.Checked = False
        Form4.CheckBox6.Checked = False
        Form5.CheckBox4.Checked = False
        Form5.CheckBox5.Checked = False
        Form5.CheckBox6.Checked = False
        Form6.CheckBox4.Checked = False
        Form6.CheckBox5.Checked = False
        Form6.CheckBox6.Checked = False
        Form7.CheckBox4.Checked = False
        Form7.CheckBox5.Checked = False
        Form7.CheckBox6.Checked = False
        Form8.CheckBox1.Checked = False
        Form8.CheckBox5.Checked = False
        Form8.CheckBox6.Checked = False
        Form9.CheckBox4.Checked = False
        Form9.CheckBox5.Checked = False
        Form9.CheckBox6.Checked = False
        Form10.CheckBox4.Checked = False
        Form10.CheckBox5.Checked = False
        Form10.CheckBox6.Checked = False
        Form11.CheckBox4.Checked = False
        Form11.CheckBox5.Checked = False
        Form11.CheckBox6.Checked = False
        Form11.CheckBox4.Checked = False
        Form11.CheckBox5.Checked = False
        Form11.CheckBox6.Checked = False
        Form12.CheckBox5.Checked = False
        Form12.CheckBox6.Checked = False
        Form13.CheckBox5.Checked = False
        Form13.CheckBox6.Checked = False
        Form14.CheckBox4.Checked = False
        Form14.CheckBox5.Checked = False
        Form14.CheckBox6.Checked = False
        Form15.CheckBox4.Checked = False
        Form15.CheckBox5.Checked = False
        Form15.CheckBox6.Checked = False
        Form16.CheckBox4.Checked = False
        Form16.CheckBox5.Checked = False
        Form16.CheckBox6.Checked = False
        Form17.CheckBox4.Checked = False
        Form17.CheckBox5.Checked = False
        Form17.CheckBox6.Checked = False
        Form18.CheckBox4.Checked = False
        Form18.CheckBox5.Checked = False
        Form18.CheckBox6.Checked = False
        Form19.CheckBox4.Checked = False
        Form19.CheckBox5.Checked = False
        Form19.CheckBox6.Checked = False
        Form20.CheckBox4.Checked = False
        Form20.CheckBox5.Checked = False
        Form20.CheckBox6.Checked = False
        Form21.CheckBox4.Checked = False
        Form21.CheckBox5.Checked = False
        Form21.CheckBox6.Checked = False
        Timer1.Enabled = True
        Form2.TextBox1.Text = TextBox2.Text
        Form2.TextBox2.Text = TextBox1.Text
        Form2.PictureBox2.Image = PictureBox1.Image
        TextBox1.Text = "0BP"
        Form2.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.song2, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Form2.Label4.Text = timercount.ToString
        Form3.Label4.Text = timercount.ToString
        Form4.Label4.Text = timercount.ToString
        Form5.Label4.Text = timercount.ToString
        Form6.Label4.Text = timercount.ToString
        Form7.Label4.Text = timercount.ToString
        Form8.Label4.Text = timercount.ToString
        Form9.Label4.Text = timercount.ToString
        Form10.Label4.Text = timercount.ToString
        Form11.Label4.Text = timercount.ToString
        Form12.Label4.Text = timercount.ToString
        Form13.Label4.Text = timercount.ToString
        Form14.Label4.Text = timercount.ToString
        Form15.Label4.Text = timercount.ToString
        Form16.Label4.Text = timercount.ToString
        Form17.Label4.Text = timercount.ToString
        Form18.Label4.Text = timercount.ToString
        Form19.Label4.Text = timercount.ToString
        Form20.Label4.Text = timercount.ToString
        Form21.Label4.Text = timercount.ToString
        If timercount = 0 Then
            Timer1.Enabled = False
            Form2.Label4.Text = "Time's up"
            Form3.Label2.Text = "Time's up"
            Form4.Label4.Text = "Time's up"
            timercount = 200
            MsgBox("You Lose")
            MessageBox.Show("Χάσατε!!!", "Losing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim ask As MsgBoxResult
            ask = MessageBox.Show("Νέα Παρτίδα?", "Retry", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = MsgBoxResult.Yes Then
                Me.Show()
            ElseIf ask = MsgBoxResult.No Then
                Me.Close()
            End If
            Form2.Hide()
            Form3.Hide()
            Form4.Hide()
            Form5.Hide()
            Form6.Hide()
            Form7.Hide()
            Form8.Hide()
            Form9.Hide()
            Form10.Hide()
            Form11.Hide()
            Form12.Hide()
            Form13.Hide()
            Form14.Hide()
            Form15.Hide()
            Form16.Hide()
            Form17.Hide()
            Form18.Hide()
            Form19.Hide()
            Form20.Hide()
            Form21.Hide()
        Else
            Timer1.Enabled = True
            timercount -= 1
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("https://discord.gg/CRBHSAS")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.yugi
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.kaiba
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = My.Resources.joey
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PictureBox1.Image = My.Resources.marik
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        PictureBox1.Image = My.Resources.mai
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        PictureBox1.Image = My.Resources.alexis
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.song2, AudioPlayMode.Background)
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        PictureBox1.Image = My.Resources.aster
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        PictureBox1.Image = My.Resources.sartorius
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        PictureBox1.Image = My.Resources.chazz
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        PictureBox1.Image = My.Resources.bakura
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        PictureBox1.Image = My.Resources.zane
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        PictureBox1.Image = My.Resources.Ishizu
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        PictureBox1.Image = My.Resources.jesse
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        PictureBox1.Image = My.Resources.jaden
    End Sub
End Class

