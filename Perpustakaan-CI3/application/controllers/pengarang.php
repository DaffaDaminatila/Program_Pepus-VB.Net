<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class pengarang extends CI_Controller {
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
        $query = $this->MSudi->GetData('pengarang')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_pengarang' => urldecode($this->uri->segment(3)),
            'nama' => urldecode($this->uri->segment(4))
        ];
        $input = $this->MSudi->AddData('pengarang', $data);
        if($input){
            redirect('pengarang');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_pengarang=urldecode($this->uri->segment(3));
        $update['nama']= urldecode($this->uri->segment(4));
        $update=$this->MSudi->UpdateData('pengarang','kd_pengarang',$kd_pengarang,$update);    
        if($update){
            redirect('pengarang');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_pengarang=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('pengarang','kd_pengarang',$kd_pengarang);
        if($delete){
            redirect('pengarang');
        } else {echo 'Error';}
    }
}