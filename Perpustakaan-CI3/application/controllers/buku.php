<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class buku extends CI_Controller {
	function __construct(){
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
        $query = $this->MSudi->GetData('buku')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_buku' => urldecode($this->uri->segment(3)),
            'judul' => urldecode($this->uri->segment(4)),
            'kd_jenis_buku' => urldecode($this->uri->segment(5)),
            'kd_penerbit' => urldecode($this->uri->segment(6)),
            'kd_pengarang' => urldecode($this->uri->segment(7)),
            'stok' => urldecode($this->uri->segment(8))
        ];
        $input = $this->MSudi->AddData('buku', $data);
        if($input){
            redirect('buku');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_buku=urldecode($this->uri->segment(3));
        $update['judul']= urldecode($this->uri->segment(4));
        $update['kd_jenis_buku']= urldecode($this->uri->segment(5));
        $update['kd_penerbit']= urldecode($this->uri->segment(6));
        $update['kd_pengarang']= urldecode($this->uri->segment(7));
        $update['stok']= urldecode($this->uri->segment(8));
        $update=$this->MSudi->UpdateData('buku','kd_buku',$kd_buku,$update);    
        if($update){
            redirect('buku');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_buku=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('buku','kd_buku',$kd_buku);
        if($delete){
            redirect('buku');
        } else {echo 'Error';}
    }
}