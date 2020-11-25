<?php
class Product_Model extends CI_Model{
	public function __construct(){
		parent::__construct();
		$this->load->database();	
	}	
	public function product_list(){
		$query=$this->db->get("sanpham");
		return $query->result_array();	
	}
}