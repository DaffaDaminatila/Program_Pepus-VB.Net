Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class data_book
    Public id As String
    Private Sub getdata()
        Try

            Dim uriString As String = "http://localhost/utsbook/index.php/Buku/GetData"
            Dim uri As New Uri(uriString)
            Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse()
            Dim read = New StreamReader(response.GetResponseStream())
            Dim raw As String = read.ReadToEnd()
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
            For Each item As Object In dict
                DataGridView1.Rows.Add(item("kd_buku").ToString, item("judul").ToString, item("kd_jenis_buku").ToString, item("kd_penerbit").ToString, item("kd_pengarang").ToString, item("stok").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try

    End Sub

    Private Sub Clear()
        peminjaman.Text = ""
        anggota.Text = ""
        buku.Text = ""
        jumlah.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari.Click
        getdata()
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        Dim no As Integer
        Me.DataGridView1.Rows.Clear()
        buka()
        rec.Open("Select * from buku where judul like '%" & txt_search.Text & "%' order by kd_buku", con, 3, 2)
        no = 1
        Do While Not rec.EOF

            Me.DataGridView1.Rows.Add(rec.Fields("kd_buku").Value, rec.Fields("judul").Value, rec.Fields("kd_jenis_buku").Value, rec.Fields("kd_pengarang").Value, rec.Fields("kd_penerbit").Value, rec.Fields("stok").Value)
            rec.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub api()
        Dim uriString As String = "http://localhost/utsbook/index.php/Buku/PostData/" + peminjaman.Text + "/" + anggota.Text + "/" + buku.Text + "/" + jumlah.Text + "/" + Format(Date.Now, "yyyy-MM-dd").ToString
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
        MsgBox("Input Data Peminjaman Sukses", MsgBoxStyle.Information, "Pemberitahuan")

    End Sub

    Private Sub pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinjam.Click
        api()
        Clear()


    End Sub

    Private Sub data_book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        peminjaman.Text = ""
        anggota.Text = ""
        buku.Text = ""
        jumlah.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        buku.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clear()
    End Sub
End Class
