<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
class sanpham extends Model
{
    protected $table = "sanpham";
	public function loaihang(){
		return $this->belongsTo("app\loaihang","MaLoai","MaSP");	
	}

}
