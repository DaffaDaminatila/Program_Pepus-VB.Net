<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class jenis_buku extends CI_Controller {
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
        $query = $this->MSudi->GetData('jenis_buku')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_jenis_buku' => urldecode($this->uri->segment(3)),
            'nama' => urldecode($this->uri->segment(4))
        ];
        $input = $this->MSudi->AddData('jenis_buku', $data);
        if($input){
            redirect('jenis_buku');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_jenis_buku=urldecode($this->uri->segment(3));
        $update['nama']= urldecode($this->uri->segment(4));
        $update=$this->MSudi->UpdateData('jenis_buku','kd_jenis_buku',$kd_jenis_buku,$update);    
        if($update){
            redirect('jenis_buku');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_jenis_buku=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('jenis_buku','kd_jenis_buku',$kd_jenis_buku);
        if($delete){
            redirect('jenis_buku');
        } else {echo 'Error';}
    }
}