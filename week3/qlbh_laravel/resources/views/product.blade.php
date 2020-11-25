<!doctype html>
<html>
<head>
<meta charset="utf-8" >
<title>Quản lý bán hàng</title>
</head>
<body>
@extends('layout')
@section('content')
<h3>DANH MỤC SẢN PHẨM</h3>
<table border="1">
<tr>
<th>Mã SP</th>
<th>Tên SP</th>
<th>Đơn vị tính</th>
<th>Đơn giá</th>
</tr>
<?php
use App\Controllers\HomeController;
foreach ($sanpham as $sp)
{
	echo '<tr>';
	echo '<td>'.$sp->MaSP.'</td>';
	$url = action('HomeController@getProductdetail', ['MaSP' => $sp->MaSP]);
	echo '<td>'."<a href='".$url."'>".$sp->TenSP.'</a></td>';
	echo '<td>'.$sp->Donvi.'</td>';
	echo '<td>'.$sp->Dongia.'</td>';
	echo '</tr>';
}
?>
</table>
@stop
</table>
</body>
</html>