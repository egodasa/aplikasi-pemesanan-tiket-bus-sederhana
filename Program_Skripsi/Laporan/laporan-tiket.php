<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Data Tiket</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;">
		<h3>
		Laporan Data Tiket <br>
		</h3>
		</div>
		<hr>
		<table class="table">
			<tr>
				<th class="table-th">No</th>
				<th class="table-th">Kode Tiket</th>
				<th class="table-th">Jurusan</th>
				<th class="table-th">Kelas</th>
				<th class="table-th">Harga</th>
				<th class="table-th">Jumlah Bus</th>
				<th class="table-th">Jumlah Bus</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "Select * From laporan_analisa ORDER BY kd_domain");
				while($nilai = mysqli_fetch_assoc($sql_query))
				{
			?>
				<tr>
					<td class="table-td"><?=$no?></td>
					<td class="table-td"><?=$nilai['kd_domain']?></td>
					<td class="table-td"><?=$nilai['nm_domain']?></td>
					<td class="table-td"><?=$nilai['indeks_maturity']?></td>
					<td class="table-td"><?=$nilai['gap']?></td>
					<td class="table-td"><?=$nilai['harapan']?></td>
					<td class="table-td"><?=$keterangan?></td>
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