<?php
	include_once "koneksi.php";
	include_once "helper.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
        <title>Laporan Analisa Sistem Informasi</title>
        <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
		<?php include_once "style_laporan.php"; ?>
	</head>
	<body>
		<?php include_once "header_laporan.php"; ?>

		<div style="text-align: center;">
		<h3>
		Laporan Analisa Kualitas Sistem Informasi Penjualan Mobil <br>
		</h3>
		</div>
		<hr>
		<table class="table">
			<tr>
				<th class="table-th">No</th>
				<th class="table-th">Kode Domain</th>
				<th class="table-th">Nama Domain</th>
				<th class="table-th">Indeks Maturity</th>
				<th class="table-th">GAP</th>
				<th class="table-th">Harapan</th>
				<th class="table-th">Keterangan</th>
			</tr>
			<?php
				$no = 1;
				$sql_query = mysqli_query($koneksi, "Select * From laporan_analisa ORDER BY kd_domain");
				while($nilai = mysqli_fetch_assoc($sql_query))
				{
					$keterangan = "";
					$im = $nilai['indeks_maturity'];

				    if($im >= 0 && $im <= 0.49)
				    {
				      $keterangan = "Tidak Ada";
				    }
				    else if($im >= 0.50 && $im <= 1.49)
				    {
				      $keterangan = "Inisialisasi";
				    }
				    else if($im >= 1.50 && $im <= 2.49)
				    {
				      $keterangan = "Dapat Diulang";
				    }
				    else if($im >= 2.50 && $im <= 3.49)
				    {
				      $keterangan = "Ditetapkan";
				    }
				    else if($im >= 3.50 && $im <= 4.49)
				    {
				      $keterangan = "Terkelola";
				    }
				    else if($im >= 4.50 && $im <= 5)
				    {
				      $keterangan = "Optimal";
				    }
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