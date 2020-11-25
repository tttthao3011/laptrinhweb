<body>
@extends('layout')
@section('content')
<h3>Chi tiết sản phẩm</h3>
<?php
echo "Mã SP: ".$sp->MaSP.'<br>';
echo "Tên Sản phẩm: ".$sp->TenSP.'<br>';
echo "Đơn vị tính: ".$sp->Donvi.'<br>';
echo "Đơn giá: ".$sp->Dongia.'<br>'
?>
@stop
</body>
