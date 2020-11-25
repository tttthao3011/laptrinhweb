<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8" >
<title>Untitled Document</title>
<style>
h1.banner{color: yellow;height: 30px;background-color:blue;}
p.footer{color: yellow;height: 30px;background-color:blue;}
</style>
</head>
<body>
<h1 class="banner">QUẢN LÝ BÁN HÀNG</h1>
<hr>
@yield('content')
<hr>
<p class="footer">Copyright <?php echo date('m/Y') ?></p>
</body>
</html>
