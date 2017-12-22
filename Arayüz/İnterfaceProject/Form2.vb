Imports System.IO.Ports

Public Class Form2

    Dim port As Array
    Delegate Sub SetTextCallBack(ByVal [text] As String)
    Private Delegate Sub UpdateTextboxDelegate(ByVal myText As String)
    Dim derece, limitderece, mmm As Integer


    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ss.DataReceived
        Dim myResponse As String = ss.ReadLine
        UpdateTextbox(myResponse)
    End Sub

    Private Sub UpdateTextbox(ByVal myText As String)
        If Me.TextBox1.InvokeRequired Then
            Dim d As New UpdateTextboxDelegate(AddressOf UpdateTextbox)
            Me.TextBox1.Invoke(d, New Object() {myText})
        Else
            TextBox1.Text = myText
        End If
    End Sub

    Private Sub kaydet()
        Me.Validate()
        Me.DpplerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DppDataSet)
        Me.DpplerTableAdapter.Fill(Me.DppDataSet.dppler)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        tdeprem.Stop()
        tgaz.Stop()
        If ss.IsOpen = True Then
            ss.Close()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DppDataSet.dppler' table. You can move, or remove it, as needed.
        Me.DpplerTableAdapter.Fill(Me.DppDataSet.dppler)
        Label9.Text = My.Settings.banner
        Me.Text = My.Settings.baslik
        ss.PortName = My.Settings.port
        Try
            ss.Open()
        Catch ex As Exception

        End Try
        NumericUpDown1.Value = My.Settings.slimit
        limitderece = NumericUpDown1.Value
        listele()
        TextBox4.Text = My.Settings.baslik
        TextBox5.Text = My.Settings.banner
        mmm = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = "" Then

            If TextBox1.Text.IndexOf("derece") > -1 Then
                derece = Mid(TextBox1.Text, 7, TextBox1.TextLength - 5)
                Label2.Text = derece.ToString & "°"
                If derece > limitderece Then
                    ss.Write("alarmvar")
                    DpplerBindingSource.AddNew()
                    DpplerDataGridView.CurrentRow.Cells(0).Value = Now.ToShortDateString
                    DpplerDataGridView.CurrentRow.Cells(1).Value = Now.ToShortTimeString
                    DpplerDataGridView.CurrentRow.Cells(2).Value = "SICAKLIK ( " & derece & " )"
                    kaydet()
                    mmm = 1
                Else
                    If mmm = 1 Then
                        ss.Write("alarmyok")
                        mmm = 0
                    End If

                End If
            End If

            If TextBox1.Text.IndexOf("gaz") > -1 Then
                Label5.ForeColor = Color.Red
                Label5.Text = "ALARM"
                DpplerBindingSource.AddNew()
                DpplerDataGridView.CurrentRow.Cells(0).Value = Now.ToShortDateString
                DpplerDataGridView.CurrentRow.Cells(1).Value = Now.ToShortTimeString
                DpplerDataGridView.CurrentRow.Cells(2).Value = "GAZ ALARMI"
                kaydet()
                tgaz.Start()
            End If

            If TextBox1.Text.IndexOf("deprem") > -1 Then
                Label6.ForeColor = Color.Red
                Label6.Text = "ALARM"
                DpplerBindingSource.AddNew()
                DpplerDataGridView.CurrentRow.Cells(0).Value = Now.ToShortDateString
                DpplerDataGridView.CurrentRow.Cells(1).Value = Now.ToShortTimeString
                DpplerDataGridView.CurrentRow.Cells(2).Value = "DEPREM ALARMI"
                kaydet()
                tdeprem.Start()
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        limitderece = NumericUpDown1.Value
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Label1.Text = DpplerDataGridView.RowCount & " KAYIT BULUNDU"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DpplerBindingSource.RemoveFilter()
            Label1.Text = DpplerDataGridView.RowCount & " KAYIT BULUNDU"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            DpplerBindingSource.Filter = "ikaz like '%" & "SICAKLIK" & "%'"
            Label1.Text = DpplerDataGridView.RowCount & " KAYIT BULUNDU"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            DpplerBindingSource.Filter = "ikaz like '%" & "GAZ" & "%'"
            Label1.Text = DpplerDataGridView.RowCount & " KAYIT BULUNDU"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            DpplerBindingSource.Filter = "ikaz like '%" & "DEPREM" & "%'"
            Label1.Text = DpplerDataGridView.RowCount & " KAYIT BULUNDU"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count > 1 Then
            Dim cvp = MsgBox("SEÇİLİ KULLANICI SİLİNECEK", vbOKCancel, "KULLANICI İŞLEMLERİ")
            If cvp = MsgBoxResult.Ok Then
                My.Settings.user.RemoveAt(ListBox1.SelectedIndex)
                My.Settings.pass.RemoveAt(ListBox1.SelectedIndex)
                My.Settings.Save()
                listele()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox4.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox4.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not TextBox2.Text = "" Then
            If Not TextBox3.Text = "" Then
                My.Settings.user.Add(TextBox2.Text)
                My.Settings.pass.Add(TextBox3.Text)
                My.Settings.Save()
                listele()
                GroupBox4.Visible = False
            End If
        End If
    End Sub

    Private Sub listele()
        ListBox1.Items.Clear()
        For Each u In My.Settings.user
            ListBox1.Items.Add(u)
        Next

        ListBox2.Items.Clear()
        For Each p In My.Settings.pass
            ListBox2.Items.Add(p)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error Resume Next
        ss.Close()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Settings.baslik = TextBox4.Text
        My.Settings.banner = TextBox5.Text
        My.Settings.Save()
        TextBox4.Text = My.Settings.baslik
        TextBox5.Text = My.Settings.banner
        Me.Text = My.Settings.baslik
        Label9.Text = My.Settings.banner
    End Sub

    Private Sub tgaz_Tick(sender As Object, e As EventArgs) Handles tgaz.Tick
        tgaz.Stop()
        Label5.ForeColor = Color.Lime
        Label5.Text = "NORMAL"
    End Sub

    Private Sub tdeprem_Tick(sender As Object, e As EventArgs) Handles tdeprem.Tick
        tdeprem.Stop()
        Label6.ForeColor = Color.Lime
        Label6.Text = "NORMAL"
    End Sub
End Class