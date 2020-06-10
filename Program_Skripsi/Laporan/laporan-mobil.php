<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Data Mobil</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;">
		<h3>
		Laporan Data Mobil <br>
		</h3>
		</div>
		<hr>
		<table class="table">
			<tr>
				<th class="table-th">No</th>
				<th class="table-th">Kode Mobil</th>
				<th class="table-th">No Polisi</th>
				<th class="table-th">Jenis</th>
				<th class="table-th">Merk</th>
				<th class="table-th">Warna</th>
				<th class="table-th">Bahan Bakar</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "Select * From tb_mobil");
				while($nilai = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td class="table-td"><?=$no?></td>
					<td class="table-td"><?=$nilai['kode_mobil']?></td>
					<td class="table-td"><?=$nilai['no_polisi']?></td>
					<td class="table-td"><?=$nilai['jenis']?></td>
					<td class="table-td"><?=$nilai['merk']?></td>
					<td class="table-td"><?=$nilai['warna']?></td>
					<td class="table-td"><?=$nilai['bahan_bakar']?></td>
				</tr>
			<?php
					$no++;
				}
			?>
		</table>
		<hr>

		<div style="float: right;width: 300px;text-align: center;">
			<?=tanggal_indo(date("Y-m-d"), true)?> <br>
			Admin
			<br>
			<br>
			<br>
			<br>
			(&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;)
		</div>

	</body>
</html>