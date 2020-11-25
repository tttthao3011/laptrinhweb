<h2>Danh sách sản phẩm</h2>
<table border="1" style="border-collapse:collapse">
	<tr>
    	<th>Mã hàng</th>
        <th>Tên hàng</th>
        <th>Đơn vị tính</th>
        <th>Đơn giá</th>
    </tr>
   <?php
   $this->load->helper('url');
   foreach ($result as $row)
   {
	   echo "<tr>";
	   echo "<td>".$row['MaSP']."</td>";
	   $href=base_url().'index.php/Product/getProductDetail/'.$row['MaSP'];
	   $url="<a href='".$href."'>".$row['TenSP']."</a>";
	   echo "<td>".$url."</td>";
	   
	   echo "<td>".$row['Donvi']."</td>";
	   echo "<td>".number_format($row['Dongia'])."</td>";
	   echo "</tr>";
	}
   ?> 
</table>