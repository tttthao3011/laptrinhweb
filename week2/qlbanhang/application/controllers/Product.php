<?php
defined('BASEPATH') OR exit('No direct script access allowed');
class Product extends CI_Controller{
	function __construct()
	{
		parent::__construct();
		$this->load->Model("Product_Model");	
	}
	public function index()
	{
		$result = $this->Product_Model->product_list();
		$data['result'] = $result;
		$data['content'] = 'products';
		$this->load->view('layout/index', $data);
	}
	public function getProductDetail($masp)
	{
		$result = $this->Product_Model->product_detail($masp);
		$data['result'] = $result;
		$data['content'] = 'product_detail';
		$this->load->view('layout/index', $data);	
	}
}