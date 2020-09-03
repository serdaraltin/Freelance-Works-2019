-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 12 May 2019, 15:55:48
-- Sunucu sürümü: 5.7.23
-- PHP Sürümü: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `meyvekesme`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `puanlar`
--

DROP TABLE IF EXISTS `puanlar`;
CREATE TABLE IF NOT EXISTS `puanlar` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Puan` int(11) NOT NULL,
  `KullaniciAdi` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf32 COLLATE=utf32_turkish_ci;

--
-- Tablo döküm verisi `puanlar`
--

INSERT INTO `puanlar` (`Id`, `Puan`, `KullaniciAdi`) VALUES
(8, 1300, 'serdar'),
(9, 950, 'mehmet'),
(10, 100, 'ahmet'),
(11, 400, 'selda'),
(12, 650, 'gulten'),
(13, 1050, 'nur'),
(14, 1600, 'muhammed'),
(15, 1550, 'hasan');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
