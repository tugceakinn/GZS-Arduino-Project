<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DpplerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DpplerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DppDataSet = New DepremProje.dppDataSet()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ss = New System.IO.Ports.SerialPort(Me.components)
        Me.DpplerTableAdapter = New DepremProje.dppDataSetTableAdapters.dpplerTableAdapter()
        Me.TableAdapterManager = New DepremProje.dppDataSetTableAdapters.TableAdapterManager()
        Me.tgaz = New System.Windows.Forms.Timer(Me.components)
        Me.tdeprem = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DpplerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DpplerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 510)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ANA EKRAN"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Location = New System.Drawing.Point(648, 20)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(45, 45)
        Me.Button9.TabIndex = 8
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(463, 62)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(597, 20)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 45)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(546, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 45)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(485, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 393)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DEPREM PANELİ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ÖLÇÜM SONUCU"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 73)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NORMAL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 205)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(196, 182)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 393)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GAZ PANELİ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ÖLÇÜM SONUCU"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 73)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NORMAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 205)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 182)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 393)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SICAKLIK PANELİ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SICAKLIK LİMİTİ"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(162, 160)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(66, 26)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ÖLÇÜLEN SICAKLIK"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 73)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0°"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.RadioButton1)
        Me.TabPage2.Controls.Add(Me.RadioButton2)
        Me.TabPage2.Controls.Add(Me.DpplerDataGridView)
        Me.TabPage2.Controls.Add(Me.RadioButton3)
        Me.TabPage2.Controls.Add(Me.RadioButton4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UYARI GEÇMİŞİ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(593, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 78)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 20)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tüm Kayıtları Göster"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 80)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(227, 20)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Sadece Sıcaklık Kayıtlarını Göster"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DpplerDataGridView
        '
        Me.DpplerDataGridView.AllowUserToAddRows = False
        Me.DpplerDataGridView.AllowUserToDeleteRows = False
        Me.DpplerDataGridView.AutoGenerateColumns = False
        Me.DpplerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DpplerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DpplerDataGridView.DataSource = Me.DpplerBindingSource
        Me.DpplerDataGridView.Location = New System.Drawing.Point(7, 121)
        Me.DpplerDataGridView.Name = "DpplerDataGridView"
        Me.DpplerDataGridView.ReadOnly = True
        Me.DpplerDataGridView.RowHeadersVisible = False
        Me.DpplerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DpplerDataGridView.Size = New System.Drawing.Size(692, 291)
        Me.DpplerDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tarih"
        Me.DataGridViewTextBoxColumn2.HeaderText = "KAYIT TARİHİ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "saat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "KAYIT SAATİ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ikaz"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UYARI TÜRÜ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DpplerBindingSource
        '
        Me.DpplerBindingSource.DataMember = "dppler"
        Me.DpplerBindingSource.DataSource = Me.DppDataSet
        '
        'DppDataSet
        '
        Me.DppDataSet.DataSetName = "dppDataSet"
        Me.DppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(261, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(251, 20)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.Text = "Sadece Gaz Kokusu Kayıtlarını Göster"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(261, 80)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(229, 20)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Text = "Sadece Deprem Kayıtlarını Göster"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.ListBox2)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(707, 501)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AYARLAR"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(362, 371)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(148, 67)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "KAYDET"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 355)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "BAŞLIK YAZISI"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(8, 371)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(342, 20)
        Me.TextBox4.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(356, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(160, 182)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "KULLANICI ADI"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 140)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(148, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "KAYDET"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 111)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(148, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "İPTAL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "PAROLA"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(8, 417)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(342, 20)
        Me.TextBox5.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(593, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 78)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "BANNER YAZISI"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(356, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "YENİ KULLANICI EKLE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "KULLANICIYI SİL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(179, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "PAROLA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "KULLANICI ADI"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(182, 64)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(168, 264)
        Me.ListBox2.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 264)
        Me.ListBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 456)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(691, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'ss
        '
        Me.ss.PortName = "COM8"
        '
        'DpplerTableAdapter
        '
        Me.DpplerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dpplerTableAdapter = Me.DpplerTableAdapter
        Me.TableAdapterManager.UpdateOrder = DepremProje.dppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'tgaz
        '
        Me.tgaz.Interval = 2000
        '
        'tdeprem
        '
        Me.tdeprem.Interval = 2000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "İSMAİL KONTROL PANELİ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DpplerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DpplerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DppDataSet As DepremProje.dppDataSet
    Friend WithEvents DpplerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DpplerTableAdapter As DepremProje.dppDataSetTableAdapters.dpplerTableAdapter
    Friend WithEvents TableAdapterManager As DepremProje.dppDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DpplerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ss As System.IO.Ports.SerialPort
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tgaz As System.Windows.Forms.Timer
    Friend WithEvents tdeprem As System.Windows.Forms.Timer
End Class
