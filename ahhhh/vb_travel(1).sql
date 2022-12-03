-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 16, 2022 at 12:57 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_travel`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `id` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `usertipe` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id`, `username`, `password`, `usertipe`) VALUES
(123, '1231', '1231', '1231');

-- --------------------------------------------------------

--
-- Table structure for table `manage_destinasi`
--

CREATE TABLE `manage_destinasi` (
  `id` int(11) NOT NULL,
  `tujuan` varchar(20) NOT NULL,
  `tarif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manage_destinasi`
--

INSERT INTO `manage_destinasi` (`id`, `tujuan`, `tarif`) VALUES
(213, '1sad', 1234);

-- --------------------------------------------------------

--
-- Table structure for table `manage_mobil`
--

CREATE TABLE `manage_mobil` (
  `id` int(11) NOT NULL,
  `Nama_Driver` varchar(20) NOT NULL,
  `Tipe_Mobil` varchar(20) NOT NULL,
  `Jml_Kursi` int(11) NOT NULL,
  `No_Hp` bigint(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manage_mobil`
--

INSERT INTO `manage_mobil` (`id`, `Nama_Driver`, `Tipe_Mobil`, `Jml_Kursi`, `No_Hp`) VALUES
(1, 'gilang', 'Bus', 12, 62867542316),
(2, 'Sendy', 'Truck Panjang', 100, 666),
(4, 'zun', 'Bus', 20, 12314);

-- --------------------------------------------------------

--
-- Table structure for table `pesanan`
--

CREATE TABLE `pesanan` (
  `id` int(11) NOT NULL,
  `pemesan` varchar(50) NOT NULL,
  `telepon` int(13) NOT NULL,
  `tgl` varchar(15) NOT NULL,
  `jam_pemberangkatan` varchar(8) NOT NULL,
  `tujuan` varchar(20) NOT NULL,
  `tipe_mobil` varchar(20) NOT NULL,
  `jml_tiket` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pesanan`
--

INSERT INTO `pesanan` (`id`, `pemesan`, `telepon`, `tgl`, `jam_pemberangkatan`, `tujuan`, `tipe_mobil`, `jml_tiket`) VALUES
(12, '', 0, '', '', 'Depok', 'Inova', 0),
(123, '12', 12, '2/3/2022', '12', '12', '12', 12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_destinasi`
--
ALTER TABLE `manage_destinasi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `manage_mobil`
--
ALTER TABLE `manage_mobil`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;

--
-- AUTO_INCREMENT for table `manage_destinasi`
--
ALTER TABLE `manage_destinasi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=214;

--
-- AUTO_INCREMENT for table `manage_mobil`
--
ALTER TABLE `manage_mobil`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `pesanan`
--
ALTER TABLE `pesanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123442;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
