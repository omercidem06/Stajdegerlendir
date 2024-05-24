-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 23:30:12
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `sorular`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sorular`
--

CREATE TABLE `sorular` (
  `isim` varchar(255) NOT NULL,
  `soyisim` varchar(255) NOT NULL,
  `ders_kodu` int(11) NOT NULL,
  `isyeri_degerlendirmesi` int(11) NOT NULL,
  `sekil_bicim` int(11) NOT NULL,
  `soru_1` int(11) NOT NULL,
  `soru_2` int(11) NOT NULL,
  `soru_3` int(11) NOT NULL,
  `soru_4` int(11) NOT NULL,
  `soru_5` int(11) NOT NULL,
  `soru_6` int(11) NOT NULL,
  `soru_7` int(11) NOT NULL,
  `soru_8` int(11) NOT NULL,
  `soru_9` int(11) NOT NULL,
  `soru_10` int(11) NOT NULL,
  `soru_11` int(11) NOT NULL,
  `soru_12` int(11) NOT NULL,
  `soru_13` int(11) NOT NULL,
  `soru_14` int(11) NOT NULL,
  `soru_15` int(11) NOT NULL,
  `soru_16` int(11) NOT NULL,
  `soru_17` int(11) NOT NULL,
  `soru_18` int(11) NOT NULL,
  `soru_19` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `sorular`
--

INSERT INTO `sorular` (`isim`, `soyisim`, `ders_kodu`, `isyeri_degerlendirmesi`, `sekil_bicim`, `soru_1`, `soru_2`, `soru_3`, `soru_4`, `soru_5`, `soru_6`, `soru_7`, `soru_8`, `soru_9`, `soru_10`, `soru_11`, `soru_12`, `soru_13`, `soru_14`, `soru_15`, `soru_16`, `soru_17`, `soru_18`, `soru_19`) VALUES
('ÖMER', 'BEY', 321, 9, 3, 4, 5, 3, 2, 5, 1, 4, 2, 4, 4, 5, 3, 4, 2, 5, 2, 3, 5, 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
