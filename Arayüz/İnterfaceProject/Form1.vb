Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        For Each port In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(port)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            If My.Settings.user.Contains(TextBox1.Text) = True Then
                If My.Settings.pass.Contains(TextBox2.Text) = True Then
                    My.Settings.port = ComboBox1.Text
                    Form2.Show()
                    Me.Close()
                Else
                    MsgBox("HATALI PAROLA", MsgBoxStyle.Critical, "HATA")
                End If
            Else
                MsgBox("HATALI KULLANICI ADI", MsgBoxStyle.Critical, "HATA")
            End If
        End If
    End Sub
End Class
