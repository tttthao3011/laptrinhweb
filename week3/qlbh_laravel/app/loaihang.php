<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class loaihang extends Model
{
    protected $table = "loaihang";
	public function sanpham(){
		return $this->hasMany("app\sanpham","MaLoai","Maloai");	
	}
}
