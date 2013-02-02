<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utama))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_pasukan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCipher = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_encrytion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNilai = New System.Windows.Forms.TextBox()
        Me.tb_julat = New System.Windows.Forms.TrackBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_Reverse = New System.Windows.Forms.Button()
        Me.txt_decrytion = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.tb_julat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_pasukan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Special Team Members :"
        '
        'lbl_pasukan
        '
        Me.lbl_pasukan.AutoSize = True
        Me.lbl_pasukan.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pasukan.Location = New System.Drawing.Point(6, 23)
        Me.lbl_pasukan.Name = "lbl_pasukan"
        Me.lbl_pasukan.Size = New System.Drawing.Size(413, 15)
        Me.lbl_pasukan.TabIndex = 0
        Me.lbl_pasukan.Text = "Robbi Nespu , Ricky Muraldi, Shafeez Fazli && Fadzli Razali"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Chintzy CPU BRK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "R0X! ENCRYTION CIPHER TOOL"
        '
        'txtInput
        '
        Me.txtInput.ForeColor = System.Drawing.Color.Red
        Me.txtInput.Location = New System.Drawing.Point(6, 24)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(408, 25)
        Me.txtInput.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtInput)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 61)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plain Text :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCipher)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 67)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cipher Text :"
        '
        'txtCipher
        '
        Me.txtCipher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCipher.Location = New System.Drawing.Point(6, 27)
        Me.txtCipher.Name = "txtCipher"
        Me.txtCipher.ReadOnly = True
        Me.txtCipher.Size = New System.Drawing.Size(408, 25)
        Me.txtCipher.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_encrytion)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtNilai)
        Me.GroupBox4.Controls.Add(Me.tb_julat)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 93)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Encrytion :"
        '
        'btn_encrytion
        '
        Me.btn_encrytion.Location = New System.Drawing.Point(7, 55)
        Me.btn_encrytion.Name = "btn_encrytion"
        Me.btn_encrytion.Size = New System.Drawing.Size(407, 29)
        Me.btn_encrytion.TabIndex = 10
        Me.btn_encrytion.Text = "PROCESS !"
        Me.btn_encrytion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Shift Key :"
        '
        'txtNilai
        '
        Me.txtNilai.ForeColor = System.Drawing.Color.Purple
        Me.txtNilai.Location = New System.Drawing.Point(327, 26)
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(87, 25)
        Me.txtNilai.TabIndex = 8
        '
        'tb_julat
        '
        Me.tb_julat.Location = New System.Drawing.Point(98, 20)
        Me.tb_julat.Maximum = 100
        Me.tb_julat.Name = "tb_julat"
        Me.tb_julat.Size = New System.Drawing.Size(227, 42)
        Me.tb_julat.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_Reverse)
        Me.GroupBox5.Controls.Add(Me.txt_decrytion)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(420, 94)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Decrytion  :"
        '
        'btn_Reverse
        '
        Me.btn_Reverse.Location = New System.Drawing.Point(6, 24)
        Me.btn_Reverse.Name = "btn_Reverse"
        Me.btn_Reverse.Size = New System.Drawing.Size(408, 29)
        Me.btn_Reverse.TabIndex = 11
        Me.btn_Reverse.Text = "REVERSE IT !"
        Me.btn_Reverse.UseVisualStyleBackColor = True
        '
        'txt_decrytion
        '
        Me.txt_decrytion.ForeColor = System.Drawing.Color.Green
        Me.txt_decrytion.Location = New System.Drawing.Point(6, 59)
        Me.txt_decrytion.Name = "txt_decrytion"
        Me.txt_decrytion.ReadOnly = True
        Me.txt_decrytion.Size = New System.Drawing.Size(408, 25)
        Me.txt_decrytion.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 443)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(422, 63)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Greetz && Thanks to :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Allah, My Parent, JTMK Lecturers (Especialy to en.hamzi )," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "google, my housemate " & _
            "&& all DIP6B members :)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.R0X_TOOL.My.Resources.Resources.Paper_Mario2
        Me.PictureBox1.Location = New System.Drawing.Point(384, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(444, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Utama"
        Me.Text = "r0x! - F5015 : Network Security (MINI PROJECT)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.tb_julat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_pasukan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCipher As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNilai As System.Windows.Forms.TextBox
    Friend WithEvents tb_julat As System.Windows.Forms.TrackBar
    Friend WithEvents btn_encrytion As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Reverse As System.Windows.Forms.Button
    Friend WithEvents txt_decrytion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
