<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') or exit('No direct script access allowed');

class peminjaman extends CI_Controller
{
    function __construct()
    {
        parent::__construct();
        $this->load->model('MSudi');
    }

    public function index()
    {
        $status = array(
            'status' => 'Ok'
        );
        echo json_encode($status);
    }

    public function GetData()
    {
        $query = $this->MSudi->GetData('peminjaman')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_peminjaman' => urldecode($this->uri->segment(3)),
            'kd_anggota' => urldecode($this->uri->segment(4)),
            'kd_buku' => urldecode($this->uri->segment(5)),
            'jumlah_pinjam' => urldecode($this->uri->segment(6)),
            'tanggal_pinjam' => urldecode($this->uri->segment(7))
        ];
        $input = $this->MSudi->AddData('peminjaman', $data);
        if ($input) {
            redirect('peminjaman');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_peminjaman = urldecode($this->uri->segment(3));
        $update['kd_anggota'] = urldecode($this->uri->segment(4));
        $update['kd_buku'] = urldecode($this->uri->segment(5));
        $update['jumlah_pinjam'] = urldecode($this->uri->segment(6));
        $update['tanggal_pinjam'] = urldecode($this->uri->segment(7));
        $update = $this->MSudi->UpdateData('peminjaman', 'kd_peminjaman', $kd_peminjaman, $update);
        if ($update) {
            redirect('peminjaman');
        } else {
            echo 'Error';
        }
    }

    public function DeleteData()
    {
        $kd_peminjaman = urldecode($this->uri->segment(3));
        $delete = $this->MSudi->DeleteData('peminjaman', 'kd_peminjaman', $kd_peminjaman);
        if ($delete) {
            redirect('peminjaman');
        } else {
            echo 'Error';
        }
    }
}
