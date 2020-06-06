-- Adminer 4.7.5 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP VIEW IF EXISTS `laporan_analisa`;
CREATE TABLE `laporan_analisa` (`total_responden` bigint(21), `skor_total` decimal(32,0), `kd_domain` varchar(6), `nm_domain` varchar(50), `total_pernyataan` bigint(21), `indeks_maturity` decimal(36,4), `gap` decimal(37,4), `harapan` int(1));


DROP TABLE IF EXISTS `tbl_admin`;
CREATE TABLE `tbl_admin` (
  `id_admin` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (`id_admin`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_admin` (`id_admin`, `username`, `password`, `email`) VALUES
(4,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'alamat admin');

DROP TABLE IF EXISTS `tbl_domain`;
CREATE TABLE `tbl_domain` (
  `kd_domain` varchar(6) NOT NULL,
  `nm_domain` varchar(50) NOT NULL,
  `no_urut` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`kd_domain`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_domain` (`kd_domain`, `nm_domain`, `no_urut`) VALUES
('AI4',	'Enable Operation and Use',	2),
('AI5',	'madam',	2),
('DS1',	'Define and Manage Service Levels',	3),
('DS10',	'Manage Problem',	9),
('DS13',	'Manage Operations',	10),
('DS2',	'Manage Third-party Services',	4),
('DS3',	'Manage Performance and Capacity',	5),
('DS4',	'Ensure Continuous Service',	6),
('DS7',	'Educate and Train Users',	7),
('DS8',	'Manage Service Desk and Incidents',	8),
('PO8',	'Manage Quality',	1);

DROP TABLE IF EXISTS `tbl_jawaban_kuesioner`;
CREATE TABLE `tbl_jawaban_kuesioner` (
  `id_jawaban` int(11) NOT NULL AUTO_INCREMENT,
  `id_pernyataan` int(11) NOT NULL,
  `id_kuesioner` int(11) NOT NULL,
  `skor` int(11) NOT NULL,
  PRIMARY KEY (`id_jawaban`),
  KEY `id_pernyataan` (`id_pernyataan`),
  KEY `id_kuesioner` (`id_kuesioner`),
  CONSTRAINT `tbl_jawaban_kuesioner_ibfk_1` FOREIGN KEY (`id_kuesioner`) REFERENCES `tbl_kuesioner` (`id_kuesioner`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tbl_jawaban_kuesioner_ibfk_2` FOREIGN KEY (`id_pernyataan`) REFERENCES `tbl_pernyataan` (`id_pernyataan`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_jawaban_kuesioner` (`id_jawaban`, `id_pernyataan`, `id_kuesioner`, `skor`) VALUES
(3,	25,	1,	3),
(4,	25,	1,	3),
(5,	25,	1,	3),
(6,	26,	1,	3),
(7,	26,	1,	3),
(8,	26,	1,	3),
(9,	26,	1,	3),
(10,	26,	1,	3),
(11,	27,	1,	3),
(12,	27,	1,	3),
(13,	27,	1,	3),
(14,	27,	1,	4),
(15,	27,	1,	4),
(16,	28,	1,	4),
(17,	28,	1,	4),
(18,	28,	1,	4),
(19,	28,	1,	4),
(20,	28,	1,	5),
(21,	29,	1,	5),
(22,	29,	1,	5),
(23,	29,	1,	5),
(24,	29,	1,	4),
(25,	29,	1,	4),
(26,	30,	1,	4),
(27,	30,	1,	4),
(28,	30,	1,	4),
(29,	30,	1,	4),
(30,	30,	1,	4),
(31,	31,	1,	4),
(32,	31,	1,	4),
(33,	31,	1,	4),
(34,	31,	1,	4),
(35,	31,	1,	5),
(36,	32,	1,	5),
(37,	32,	1,	5),
(38,	32,	1,	5),
(39,	32,	1,	4),
(40,	32,	1,	4),
(41,	33,	1,	4),
(42,	33,	1,	4),
(43,	33,	1,	4),
(44,	33,	1,	4),
(45,	33,	1,	4),
(46,	34,	1,	4),
(47,	34,	1,	4),
(48,	34,	1,	4),
(49,	34,	1,	4),
(50,	34,	1,	5),
(51,	35,	1,	5),
(52,	35,	1,	5),
(53,	35,	1,	5),
(54,	35,	1,	4),
(55,	35,	1,	4),
(56,	36,	1,	4),
(57,	36,	1,	4),
(58,	36,	1,	4),
(59,	36,	1,	4),
(60,	36,	1,	5),
(61,	37,	1,	5),
(62,	37,	1,	5),
(63,	37,	1,	5),
(64,	37,	1,	4),
(65,	37,	1,	4),
(66,	38,	1,	4),
(67,	38,	1,	4),
(68,	38,	1,	4),
(69,	38,	1,	4),
(70,	38,	1,	4),
(71,	39,	1,	4),
(72,	39,	1,	4),
(73,	39,	1,	4),
(74,	39,	1,	4),
(75,	39,	1,	5),
(76,	40,	1,	5),
(77,	40,	1,	5),
(78,	40,	1,	5),
(79,	40,	1,	4),
(80,	40,	1,	4),
(81,	41,	1,	4),
(82,	41,	1,	4),
(83,	41,	1,	4),
(84,	41,	1,	4),
(85,	41,	1,	5),
(86,	42,	1,	5),
(87,	42,	1,	5),
(88,	42,	1,	5),
(89,	42,	1,	4),
(90,	42,	1,	4),
(91,	43,	1,	4),
(92,	43,	1,	4),
(93,	43,	1,	4),
(94,	43,	1,	4),
(95,	43,	1,	4),
(96,	44,	1,	4),
(97,	44,	1,	4),
(98,	44,	1,	4),
(99,	44,	1,	4),
(100,	44,	1,	5),
(101,	25,	2,	1),
(102,	26,	2,	2),
(103,	27,	2,	3),
(104,	28,	2,	4),
(105,	29,	2,	5),
(106,	30,	2,	4),
(107,	31,	2,	3),
(108,	32,	2,	2),
(109,	33,	2,	1),
(110,	34,	2,	2),
(111,	35,	2,	3),
(112,	36,	2,	4),
(113,	37,	2,	5),
(114,	38,	2,	4),
(115,	39,	2,	3),
(116,	40,	2,	2),
(117,	41,	2,	1),
(118,	42,	2,	2),
(119,	43,	2,	3),
(120,	44,	2,	4);

DROP TABLE IF EXISTS `tbl_kuesioner`;
CREATE TABLE `tbl_kuesioner` (
  `id_kuesioner` int(11) NOT NULL AUTO_INCREMENT,
  `nm_responden` varchar(30) NOT NULL,
  `usia_responden` varchar(20) NOT NULL,
  `jk_responden` varchar(20) NOT NULL,
  `tanggal` date NOT NULL,
  PRIMARY KEY (`id_kuesioner`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_kuesioner` (`id_kuesioner`, `nm_responden`, `usia_responden`, `jk_responden`, `tanggal`) VALUES
(1,	'adwwda',	'10',	'Laki-Laki',	'2020-05-29'),
(2,	'ssccscx',	'18',	'Laki-Laki',	'2020-05-29');

DROP TABLE IF EXISTS `tbl_pernyataan`;
CREATE TABLE `tbl_pernyataan` (
  `id_pernyataan` int(11) NOT NULL AUTO_INCREMENT,
  `kd_domain` varchar(11) NOT NULL,
  `isi_pernyataan` varchar(255) NOT NULL,
  PRIMARY KEY (`id_pernyataan`),
  KEY `kd_domain` (`kd_domain`),
  CONSTRAINT `tbl_pernyataan_ibfk_1` FOREIGN KEY (`kd_domain`) REFERENCES `tbl_domain` (`kd_domain`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pernyataan` (`id_pernyataan`, `kd_domain`, `isi_pernyataan`) VALUES
(25,	'PO8',	'Sistem informasi pembayaran tagihan rekening air bulanan di pdam tirta alami tanah datar sudah memfokuskan manajemen kualitas pada konsumen dengan memastikan kebutuhan mereka dan menyesuaikannya pada standar dan operasi TI '),
(26,	'PO8',	'Sistem informasi pembayaran tagihan rekening air bulanan di pdam tirta alami tanah datar telah mengelola dan mengkomunikasikan secara berkala rencana kualitas secara umum yang mendukung perkembangan berkelanjutan'),
(27,	'AI4',	'Telah terdapat perencanaan untuk indentifikasi dan pendokumentasian penggunaan aplikasi pembayaran tagihan rekening air bulanan.'),
(28,	'AI4',	'Adanya transfer pengetahuan untuk pengguna yang memungkinkan pengguna untuk secara efektif dan efisien menggunakan sistem untuk mendukung proses bisnis'),
(29,	'DS1',	'Karakteristik pelayanan dan kebutuhan bisnis telah terorganisir dan disimpan secara terpusat'),
(30,	'DS1',	'Adanya pemantauan terhadap kinerja pelayanan khususnya dalam pelayanan pembayaran tagihan rekening air bulanan'),
(31,	'DS2',	'Adanya kerja sama dengan pelanggan pembayaran tagihan rekening air bulanan'),
(32,	'DS2',	'Adanya proses untuk memantau pelayanan pembayaran tagihan rekening air bulanan'),
(33,	'DS3',	'Terdapat suatu kapasitas mengenai sumber daya IT untuk menilai kapasitas dan kinerja sistem pembayaran tagihan rekening air bulanan saat ini.'),
(34,	'DS3',	'Adanya pengawasan dan pengumpulan data kinerja dan kapasitas sumber daya IT untuk memastikan proses bisnis dan pelaksanaan IT telah berjalan dengan baik.'),
(35,	'DS4',	'Adanya pelatihan bagi pihak yang berkepentingan mngenai prosedur dan peran serta tanggung jawab terhadap pelayanan pembayaran tagihan rekening air bulanan'),
(36,	'DS4',	'Telah ada tindakan untuk sistem pembayaran tagihan rekening air bulanan yaitu pemulihan apabila sistem mengalami kerusakan termasuk aktivasi situs backup'),
(37,	'DS7',	'Materi pendidikan dan pelatihan sistem informasi khususny pada sistem pembayaran tagihan rekening air bulanan telah didokumentasikan sesuai dengan proses bisnis saat ini'),
(38,	'DS7',	'Pelatihan dan pendidikan yang diberikan   selalu dievaluasi hasil pelatihannya'),
(39,	'DS8',	'Terdapat service desk yang membantu user jika mengalami masalah mengenai sistem pembayaran tagihan rekening air bulanan'),
(40,	'DS8',	'Telah terdapat pelaporan mengenai insiden yang terjadi kepada pimpinan'),
(41,	'DS10',	'Terdapat proses untuk melaporkan masalah yang sudah diidentifikasikan sebagai bagian dari manajemn insiden'),
(42,	'DS10',	'Terdapat fasilitas pada sistem manajemen untuk menganalisi dan menentukan akar penyebab permasalahan dari seluruh permasalahan'),
(43,	'DS13',	'Mendefinisikan, menerapkan dan memelihara prosedur untuk operasi IT, memastikan bahwa anggota staf operasi harus bisa terbiasa dengan semua tugas operasi yang relevan untuk mereka.'),
(44,	'DS13',	'Adanya pengaturan jadwal pekerjaan dan tugas agar menjadi efisien untuk memenuhi kebutuhan bisnis.');

DROP TABLE IF EXISTS `laporan_analisa`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `laporan_analisa` AS select count(distinct `tbl_kuesioner`.`id_kuesioner`) AS `total_responden`,sum(`tbl_jawaban_kuesioner`.`skor`) AS `skor_total`,`tbl_domain`.`kd_domain` AS `kd_domain`,`tbl_domain`.`nm_domain` AS `nm_domain`,count(`tbl_jawaban_kuesioner`.`id_pernyataan`) AS `total_pernyataan`,(sum(`tbl_jawaban_kuesioner`.`skor`) / (count(`tbl_jawaban_kuesioner`.`id_pernyataan`) * count(distinct `tbl_kuesioner`.`id_kuesioner`))) AS `indeks_maturity`,(5 - (sum(`tbl_jawaban_kuesioner`.`skor`) / (count(`tbl_jawaban_kuesioner`.`id_pernyataan`) * count(distinct `tbl_kuesioner`.`id_kuesioner`)))) AS `gap`,5 AS `harapan` from (((`tbl_kuesioner` join `tbl_jawaban_kuesioner` on((`tbl_jawaban_kuesioner`.`id_kuesioner` = `tbl_kuesioner`.`id_kuesioner`))) join `tbl_pernyataan` on((`tbl_jawaban_kuesioner`.`id_pernyataan` = `tbl_pernyataan`.`id_pernyataan`))) join `tbl_domain` on((`tbl_pernyataan`.`kd_domain` = `tbl_domain`.`kd_domain`))) group by `tbl_domain`.`kd_domain`;

-- 2020-05-31 22:22:33
