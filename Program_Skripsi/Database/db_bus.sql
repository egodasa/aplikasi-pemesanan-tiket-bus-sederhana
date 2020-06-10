-- Adminer 4.7.5 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `tb_mobil`;
CREATE TABLE `tb_mobil` (
  `kode_mobil` varchar(30) NOT NULL,
  `no_polisi` varchar(12) NOT NULL,
  `jenis` varchar(20) NOT NULL,
  `merk` varchar(20) NOT NULL,
  `warna` varchar(20) NOT NULL,
  `bahan_bakar` varchar(20) NOT NULL,
  PRIMARY KEY (`kode_mobil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tb_pemesanan`;
CREATE TABLE `tb_pemesanan` (
  `kode_pemesanan` varchar(10) NOT NULL,
  `kode_tiket` varchar(10) NOT NULL,
  `id_pengguna` int(11) NOT NULL,
  `nm_pembeli` varchar(100) NOT NULL,
  `tgl_transaksi` date NOT NULL,
  `tgl_berangkat` date NOT NULL,
  `jam_berangkat` time NOT NULL,
  `kode_mobil` varchar(10) NOT NULL,
  `jumlah_beli` int(11) NOT NULL,
  `no_bangku` varchar(10) NOT NULL,
  `total_bayar` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  PRIMARY KEY (`kode_pemesanan`),
  KEY `id_pengguna` (`id_pengguna`),
  CONSTRAINT `tb_pemesanan_ibfk_1` FOREIGN KEY (`id_pengguna`) REFERENCES `tb_pengguna` (`id_pengguna`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tb_pengguna`;
CREATE TABLE `tb_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` text NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `level` varchar(20) NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tb_tiket`;
CREATE TABLE `tb_tiket` (
  `kode_tiket` varchar(30) NOT NULL,
  `jurusan` varchar(100) NOT NULL,
  `jumlah_bus` int(11) NOT NULL,
  `kelas` varchar(100) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah_tiket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- 2020-06-10 03:57:45
