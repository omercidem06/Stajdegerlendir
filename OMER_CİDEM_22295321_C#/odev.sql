-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 23:30:03
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
-- Veritabanı: `odev`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrbilgileri`
--

CREATE TABLE `ogrbilgileri` (
  `kayitNo` int(11) NOT NULL,
  `tcKimlikNo` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `ogrenciNo` int(11) NOT NULL,
  `sinif` int(11) NOT NULL,
  `cepTelNo` int(11) NOT NULL,
  `eposta` varchar(255) NOT NULL,
  `stajKodu` int(11) NOT NULL,
  `stajYeri` varchar(255) NOT NULL,
  `stajbaslangic` int(11) NOT NULL,
  `stajbitis` int(11) NOT NULL,
  `stajEvraklari` varchar(255) NOT NULL,
  `zorunluStajYazisi` varchar(255) NOT NULL,
  `end300400Yazisi` varchar(255) NOT NULL,
  `basvuruDilekçesi` varchar(255) NOT NULL,
  `kabulYazisi` varchar(255) NOT NULL,
  `müstehaklıkBelgesi` varchar(255) NOT NULL,
  `kimlikFotokopisi` varchar(255) NOT NULL,
  `stajDegerlendirmeFormu` varchar(255) NOT NULL,
  `stajrapor` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `ogrbilgileri`
--

INSERT INTO `ogrbilgileri` (`kayitNo`, `tcKimlikNo`, `ad`, `soyad`, `ogrenciNo`, `sinif`, `cepTelNo`, `eposta`, `stajKodu`, `stajYeri`, `stajbaslangic`, `stajbitis`, `stajEvraklari`, `zorunluStajYazisi`, `end300400Yazisi`, `basvuruDilekçesi`, `kabulYazisi`, `müstehaklıkBelgesi`, `kimlikFotokopisi`, `stajDegerlendirmeFormu`, `stajrapor`) VALUES
(123123, 2147483647, 'ÖMER', 'BEY', 12, 1, 2147483647, 'omerbey@gmail.com', 321, 'ANKARA', 2022, 2023, 'EVET', 'EVET', 'EVET', 'HAYIR', 'HAYIR', 'HAYIR', 'EVET', 'EVET', 'EVET'),
(777, 2147483647, 'ALİ', 'BEY', 32432, 1, 543534531, 'alibey@gmail.com', 657, 'MAN', 2023, 2024, 'EVET', 'EVET', 'HAYIR', 'HAYIR', 'EVET', 'EVET', 'EVET', 'HAYIR', 'EVET');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
