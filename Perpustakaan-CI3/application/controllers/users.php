<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class users extends CI_Controller {
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
        $query = $this->MSudi->GetData('users')->result();
        echo json_encode($query);
    }

    public function PostData()
    {
        $data = [
            'kd_users' => urldecode($this->uri->segment(3)),
            'nama' => urldecode($this->uri->segment(4)),
            'username' => urldecode($this->uri->segment(5)),
            'password' => urldecode($this->uri->segment(6)),
            'status' => urldecode($this->uri->segment(7)),
            'level' => urldecode($this->uri->segment(8))
        ];
        $input = $this->MSudi->AddData('users', $data);
        if($input){
            redirect('users');;
        } else {
            echo "Error";
        }
    }

    public function PutData()
    {
        $kd_users=urldecode($this->uri->segment(3));
        $update['nama']= urldecode($this->uri->segment(4));
        $update['username']= urldecode($this->uri->segment(5));
        $update['password']= urldecode($this->uri->segment(6));
        $update['status']= urldecode($this->uri->segment(7));
        $update['level']= urldecode($this->uri->segment(8));
        $update=$this->MSudi->UpdateData('users','kd_users',$kd_users,$update);    
        if($update){
            redirect('users');
        } else {echo 'Error';}
    }

    public function DeleteData()
    {
        $kd_users=urldecode($this->uri->segment(3));
        $delete=$this->MSudi->DeleteData('users','kd_users',$kd_users);
        if($delete){
            redirect('users');
        } else {echo 'Error';}
    }
}