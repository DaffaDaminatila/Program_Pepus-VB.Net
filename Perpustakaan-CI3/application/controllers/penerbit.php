<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class penerbit extends CI_Controller {
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
        $query = $this->MSudi->GetData('penerbit')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_penerbit' => urldecode($this->uri->segment(3)),
            'nama' => urldecode($this->uri->segment(4))
        ];
        $input = $this->MSudi->AddData('penerbit', $data);
        if($input){
            redirect('penerbit');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_penerbit=urldecode($this->uri->segment(3));
        $update['nama']= urldecode($this->uri->segment(4));
        $update=$this->MSudi->UpdateData('penerbit','kd_penerbit',$kd_penerbit,$update);    
        if($update){
            redirect('penerbit');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_penerbit=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('penerbit','kd_penerbit',$kd_penerbit);
        if($delete){
            redirect('penerbit');
        } else {echo 'Error';}
    }
}