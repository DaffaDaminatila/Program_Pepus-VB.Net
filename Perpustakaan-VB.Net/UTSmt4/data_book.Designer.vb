<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class data_book
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kd_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_jenis_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_pengarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cari = New System.Windows.Forms.Button()
        Me.peminjaman = New System.Windows.Forms.TextBox()
        Me.buku = New System.Windows.Forms.TextBox()
        Me.anggota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pinjam = New System.Windows.Forms.Button()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_buku, Me.judul, Me.kd_jenis_buku, Me.kd_penerbit, Me.kd_pengarang, Me.stok})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(63, 107)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(743, 177)
        Me.DataGridView1.TabIndex = 0
        '
        'kd_buku
        '
        Me.kd_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kd_buku.HeaderText = "NO_BUKU"
        Me.kd_buku.MinimumWidth = 8
        Me.kd_buku.Name = "kd_buku"
        Me.kd_buku.Width = 122
        '
        'judul
        '
        Me.judul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.judul.HeaderText = "JUDUL"
        Me.judul.MinimumWidth = 8
        Me.judul.Name = "judul"
        Me.judul.Width = 98
        '
        'kd_jenis_buku
        '
        Me.kd_jenis_buku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kd_jenis_buku.HeaderText = "JENIS"
        Me.kd_jenis_buku.MinimumWidth = 8
        Me.kd_jenis_buku.Name = "kd_jenis_buku"
        Me.kd_jenis_buku.Width = 91
        '
        'kd_penerbit
        '
        Me.kd_penerbit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kd_penerbit.HeaderText = "PENERBIT"
        Me.kd_penerbit.MinimumWidth = 8
        Me.kd_penerbit.Name = "kd_penerbit"
        Me.kd_penerbit.Width = 125
        '
        'kd_pengarang
        '
        Me.kd_pengarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kd_pengarang.HeaderText = "PENGARANG"
        Me.kd_pengarang.MinimumWidth = 8
        Me.kd_pengarang.Name = "kd_pengarang"
        Me.kd_pengarang.Width = 148
        '
        'stok
        '
        Me.stok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.stok.HeaderText = "STOK"
        Me.stok.MinimumWidth = 8
        Me.stok.Name = "stok"
        Me.stok.Width = 87
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(63, 68)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(465, 26)
        Me.txt_search.TabIndex = 1
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(534, 65)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(88, 33)
        Me.cari.TabIndex = 2
        Me.cari.Text = "CARI"
        Me.cari.UseVisualStyleBackColor = True
        '
        'peminjaman
        '
        Me.peminjaman.Location = New System.Drawing.Point(213, 316)
        Me.peminjaman.Name = "peminjaman"
        Me.peminjaman.Size = New System.Drawing.Size(187, 26)
        Me.peminjaman.TabIndex = 3
        '
        'buku
        '
        Me.buku.Location = New System.Drawing.Point(213, 400)
        Me.buku.Name = "buku"
        Me.buku.Size = New System.Drawing.Size(187, 26)
        Me.buku.TabIndex = 7
        '
        'anggota
        '
        Me.anggota.Location = New System.Drawing.Point(213, 358)
        Me.anggota.Name = "anggota"
        Me.anggota.Size = New System.Drawing.Size(187, 26)
        Me.anggota.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NO_PINJAMAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NO_ANGGOTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "JUMLAH PINJAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "TANGGAL PINJAM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NO_BUKU"
        '
        'pinjam
        '
        Me.pinjam.Location = New System.Drawing.Point(469, 485)
        Me.pinjam.Name = "pinjam"
        Me.pinjam.Size = New System.Drawing.Size(110, 35)
        Me.pinjam.TabIndex = 16
        Me.pinjam.Text = "PINJAM"
        Me.pinjam.UseVisualStyleBackColor = True
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(213, 443)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(187, 26)
        Me.jumlah.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 487)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(187, 26)
        Me.DateTimePicker1.TabIndex = 19
        '
        'data_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 584)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.anggota)
        Me.Controls.Add(Me.buku)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.peminjaman)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "data_book"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cari As System.Windows.Forms.Button
    Friend WithEvents kd_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents judul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kd_jenis_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kd_penerbit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kd_pengarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents peminjaman As System.Windows.Forms.TextBox
    Friend WithEvents buku As System.Windows.Forms.TextBox
    Friend WithEvents anggota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pinjam As System.Windows.Forms.Button
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
