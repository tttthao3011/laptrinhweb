<?php
	$this->load->view('layout/header');
?>
<h2>Chi tiết sản phẩm</h2>
<?php
$row = $result[0];
echo "Mã sản phẩm: ".$row['MaSP']."<br>";
echo "Tên sản phẩm: ".$row['TenSP']."<br>";
echo "Đơn vị tính: ".$row['Donvi']."<br>";
echo "Đơn giá: ".number_format($row['Dongia'])."<br>";
$this->load->view('layout/footer');
?>