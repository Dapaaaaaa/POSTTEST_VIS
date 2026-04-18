-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 13, 2026 at 02:20 PM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `geturcoffe`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_menu`
--

CREATE TABLE `tb_menu` (
  `id_menu` int NOT NULL,
  `nama_menu` varchar(100) NOT NULL,
  `kategori_menu` varchar(50) NOT NULL,
  `harga_menu` decimal(10,2) NOT NULL,
  `stok_menu` int NOT NULL,
  `deskripsi_menu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_menu`
--

INSERT INTO `tb_menu` (`id_menu`, `nama_menu`, `kategori_menu`, `harga_menu`, `stok_menu`, `deskripsi_menu`) VALUES
(1, 'Espresso', 'Kopi', 15000.00, 50, 'Kopi hitam pekat single shot'),
(2, 'Americano', 'Kopi', 18000.00, 50, 'Espresso dengan air panas'),
(3, 'Cappuccino', 'Kopi', 22000.00, 40, 'Espresso dengan susu berbusa'),
(4, 'Latte', 'Kopi', 23000.00, 40, 'Espresso dengan susu steamed'),
(5, 'V60 Manual Brew', 'Kopi', 27000.00, 30, 'Pour over dengan biji pilihan'),
(6, 'Cold Brew', 'Kopi', 25000.00, 35, 'Kopi cold brew 12 jam'),
(7, 'Croissant', 'Snack', 18000.00, 20, 'Croissant butter original'),
(8, 'Banana Cake', 'Snack', 15000.00, 25, 'Kue pisang homemade'),
(9, 'Kopi Susu', 'Kopi', 20000.00, 25, 'Kopi yang dicampur dengan susu berkualitas tinggi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_menu`
--
ALTER TABLE `tb_menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_menu`
--
ALTER TABLE `tb_menu`
  MODIFY `id_menu` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
