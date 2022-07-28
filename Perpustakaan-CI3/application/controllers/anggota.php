<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class anggota extends CI_Controller {
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
        $query = $this->MSudi->GetData('anggota')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_anggota' => urldecode($this->uri->segment(3)),
            'nama' => urldecode($this->uri->segment(4))
        ];
        $input = $this->MSudi->AddData('anggota', $data);
        if($input){
            redirect('anggota');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_anggota=urldecode($this->uri->segment(3));
        $update['nama']= urldecode($this->uri->segment(4));
        $update=$this->MSudi->UpdateData('anggota','kd_anggota',$kd_anggota,$update);    
        if($update){
            redirect('anggota');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_anggota=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('anggota','kd_anggota',$kd_anggota);
        if($delete){
            redirect('anggota');
        } else {echo 'Error';}
    }
}