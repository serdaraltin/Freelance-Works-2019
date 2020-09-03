-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2019 at 07:11 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `market`
--
CREATE DATABASE IF NOT EXISTS `market` DEFAULT CHARACTER SET utf8 COLLATE utf8_turkish_ci;
USE `market`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `EnCokSatanlar`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `EnCokSatanlar` ()  Begin
	select UrunId,
	COUNT(UrunId) as sayi
	from SIPARIS group by
    UrunId having 
	Count (UrunId) > 1;
End$$

DROP PROCEDURE IF EXISTS `KategoriEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriEkle` (`p_UstKategori` INT, `p_Ad` VARCHAR(250))  Begin
	Insert Into KATEGORI (UstKategori,Ad) Values(p_UstKategori,p_Ad);
End$$

DROP PROCEDURE IF EXISTS `KategoriGetirAd`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriGetirAd` (`p_Id` INT)  Begin
	Select *From KATEGORI Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KategoriGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriGetirId` (`p_Ad` VARCHAR(250))  Begin
	Select *From KATEGORI Where Ad=p_Ad;
End$$

DROP PROCEDURE IF EXISTS `KategoriGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriGuncelle` (`p_Id` INT, `p_UstKategori` INT, `p_Ad` VARCHAR(250))  Begin
	Update KATEGORI set
	UstKategori=p_UstKategori, Ad=p_Ad
	Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KategoriKontrol`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriKontrol` (`p_Ad` VARCHAR(250))  Begin
	Select *From KATEGORI Where Ad=p_Ad;
End$$

DROP PROCEDURE IF EXISTS `KategoriListele`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KategoriListele` ()  Begin
	Select *From KATEGORI;
End$$

DROP PROCEDURE IF EXISTS `KullaniciEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciEkle` (`p_MusteriId` INT, `p_KullaniciAd` VARCHAR(250), `p_Sifre` VARCHAR(250))  Begin
	Insert Into KULLANICI (MusteriId,KullaniciAd,Sifre)
	Values (p_MusteriId,p_KullaniciAd,p_Sifre);
End$$

DROP PROCEDURE IF EXISTS `KullaniciGetirAd`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciGetirAd` (`p_Id` INT)  Begin
	Select *From KULLANICI Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KullaniciGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciGetirId` (`p_KullaniciAd` VARCHAR(250))  Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd;
End$$

DROP PROCEDURE IF EXISTS `KullaniciGetirMusteriId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciGetirMusteriId` (`p_Id` INT)  Begin
	Select *From KULLANICI Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KullaniciGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciGuncelle` (`p_Id` INT, `p_MusteriId` INT, `p_KullaniciAd` VARCHAR(250), `p_Sifre` VARCHAR(250))  Begin
	Update KULLANICI set 
	MusteriId=p_MusteriId, KullaniciAd=p_KullaniciAd, Sifre=p_Sifre
	Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KullaniciGuncelleHesap`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciGuncelleHesap` (`p_Id` INT, `p_Sifre` VARCHAR(250))  Begin
	Update KULLANICI set
	Sifre=p_Sifre Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `KullaniciKayitKontrol`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciKayitKontrol` (`p_KullaniciAd` VARCHAR(250))  Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd;
End$$

DROP PROCEDURE IF EXISTS `KullaniciKontrol`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `KullaniciKontrol` (`p_KullaniciAd` VARCHAR(250), `p_Sifre` VARCHAR(250))  Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd and Sifre=p_Sifre;
End$$

DROP PROCEDURE IF EXISTS `MarkaEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkaEkle` (`p_Ad` VARCHAR(250))  Begin
	Insert Into MARKA (Ad) Values(p_Ad);
End$$

DROP PROCEDURE IF EXISTS `MarkaGetirAd`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkaGetirAd` (`p_Id` INT)  Begin
	Select *From MARKA Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `MarkaGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkaGetirId` (`p_Ad` VARCHAR(250))  Begin
	Select *From MARKA Where Ad=p_Ad;
End$$

DROP PROCEDURE IF EXISTS `MarkaGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkaGuncelle` (`p_Id` INT, `p_Ad` VARCHAR(250))  Begin
	Update MARKA set
	Ad=p_Ad
	Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `MarkaListele`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MarkaListele` ()  Begin
	Select *From MARKA;
End$$

DROP PROCEDURE IF EXISTS `MusteriEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriEkle` (`p_Ad` VARCHAR(250), `p_Soyad` VARCHAR(250), `p_Cinsiyet` VARCHAR(50), `p_Yas` INT, `p_TelefonNo` VARCHAR(250), `p_Eposta` VARCHAR(250))  Begin
	Insert Into MUSTERI (Ad,Soyad,Cinsiyet,Yas,TelefonNo,Eposta)
	Values (p_Ad,p_Soyad,p_Cinsiyet,p_Yas,p_TelefonNo,p_Eposta);
End$$

DROP PROCEDURE IF EXISTS `MusteriGetirAd`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriGetirAd` (`p_Id` INT)  Begin
	Select *From MUSTERI Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `MusteriGetirHesap`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriGetirHesap` (`p_Id` INT)  Begin
	Select *From MUSTERI Where	Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `MusteriGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriGetirId` (`p_Ad` VARCHAR(250), `p_Soyad` VARCHAR(250), `p_TelefonNo` VARCHAR(250), `p_Eposta` VARCHAR(250))  Begin
	Select *From MUSTERI Where Ad=p_Ad and Soyad=p_Soyad and TelefonNo=p_TelefonNo and Eposta=p_Eposta;
End$$

DROP PROCEDURE IF EXISTS `MusteriGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MusteriGuncelle` (`p_Id` INT, `p_Ad` VARCHAR(250), `p_Soyad` VARCHAR(250), `p_Cinsiyet` VARCHAR(50), `p_Yas` INT, `p_TelefonNo` VARCHAR(250), `p_Eposta` VARCHAR(250))  Begin
	Update MUSTERI set
	Ad=p_Ad, Soyad=p_Soyad, Cinsiyet=p_Cinsiyet, Yas=p_Yas, TelefonNo=p_TelefonNo, Eposta=p_Eposta
	Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `SepetAdetGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetAdetGuncelle` (`p_Id` INT, `p_Adet` INT)  Begin
	Update SEPET set
	Adet=p_Adet Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `SepetEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetEkle` (`p_KullaniciId` INT, `p_UrunId` INT, `p_Adet` INT)  Begin
	Insert Into SEPET
	(KullaniciId,UrunId,Adet)
	Values (p_KullaniciId,p_UrunId,p_Adet);
End$$

DROP PROCEDURE IF EXISTS `SepetGetirAdet`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetGetirAdet` (`p_KullaniciId` INT, `p_UrunId` INT)  Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId and UrunId=p_UrunId;
End$$

DROP PROCEDURE IF EXISTS `SepetGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetGetirId` (`p_KullaniciId` INT, `p_UrunId` INT)  Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId and UrunId=p_UrunId;
End$$

DROP PROCEDURE IF EXISTS `SepetGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetGuncelle` (`p_Id` INT, `p_UrunId` INT, `p_Adet` INT)  Begin
	Update SEPET set
	UrunId=p_UrunId, Adet=p_Adet
	Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `SepetKontrol`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetKontrol` (`p_Id` INT)  Begin
	Select *From SEPET Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `SepetListele`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SepetListele` (`p_KullaniciId` INT)  Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId;
End$$

DROP PROCEDURE IF EXISTS `SiparisEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SiparisEkle` (`p_KullaniciId` INT, `p_UrunId` INT, `p_Adet` INT, `p_Tarih` DATETIME(3))  Begin
	Insert Into SIPARIS
	(KullaniciId,UrunId,Adet,Tarih)
	Values (p_KullaniciId,p_UrunId,p_Adet,p_Tarih);
End$$

DROP PROCEDURE IF EXISTS `SiparisGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SiparisGuncelle` (`p_Id` INT, `p_KullaniciId` INT, `p_UrunId` INT, `p_Adet` INT, `p_Tarih` DATETIME(3))  Begin
	Update SIPARIS set
	KullaniciId=p_KullaniciId, UrunId=p_UrunId, Adet=p_Adet, Tarih=p_Tarih
	Where Id=p_Id;	
End$$

DROP PROCEDURE IF EXISTS `SiparisListele`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SiparisListele` ()  Begin
	Select *From SIPARIS;
End$$

DROP PROCEDURE IF EXISTS `StokEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `StokEkle` (`p_UrunId` INT, `p_Adet` INT)  Begin
	Insert Into STOK
	(UrunId,Adet)
	Values (p_UrunId,p_Adet);
End$$

DROP PROCEDURE IF EXISTS `StokGetirAdet`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `StokGetirAdet` (`p_UrunId` INT)  Begin
	Select *From STOK Where	UrunId=p_UrunId;
End$$

DROP PROCEDURE IF EXISTS `StokGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `StokGuncelle` (`p_Id` INT, `p_UrunId` INT, `p_Adet` INT)  Begin
	Update STOK set
	UrunId=p_UrunId, Adet=p_Adet
	Where Id=p_Adet;
End$$

DROP PROCEDURE IF EXISTS `UrunEkle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunEkle` (`p_KategoriId` INT, `p_MarkaId` INT, `p_Miktar` DOUBLE, `p_Olcu` VARCHAR(250), `p_Ad` VARCHAR(250), `p_Fiyat` DOUBLE, `p_Aciklama` LONGTEXT)  Begin
	Insert Into URUN
	(KategoriId,MarkaId,Miktar,Olcu,Ad,Fiyat,Aciklama)
	Values (p_KategoriId,p_MarkaId,p_Miktar,p_Olcu,p_Ad,p_Fiyat,p_Aciklama);
End$$

DROP PROCEDURE IF EXISTS `UrunGetirAd`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunGetirAd` (`p_Id` INT)  Begin
	Select *From URUN Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `UrunGetirBilgi`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunGetirBilgi` (`p_Id` INT)  Begin
	Select *From URUN Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `UrunGetirId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunGetirId` (`p_Ad` VARCHAR(250))  Begin
	Select *From URUN Where Ad=p_Ad;
End$$

DROP PROCEDURE IF EXISTS `UrunGetirOlcu`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunGetirOlcu` (`p_Id` INT)  Begin
	Select *From URUN Where Id=p_Id;
End$$

DROP PROCEDURE IF EXISTS `UrunGuncelle`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UrunGuncelle` (`p_Id` INT, `p_KategoriId` INT, `p_MarkaId` INT, `p_Miktar` DOUBLE, `p_Olcu` VARCHAR(250), `p_Ad` VARCHAR(250), `p_Fiyat` DOUBLE, `p_Aciklama` LONGTEXT)  Begin
	Update URUN set
	KategoriId=p_KategoriId, MarkaId=p_MarkaId, Miktar=p_Miktar, Olcu=p_Olcu, Ad=p_Ad, Fiyat=p_Fiyat, Aciklama=p_Aciklama
	Where Id=p_Id;
End$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `islem`
--
-- Creation: Dec 17, 2019 at 05:27 PM
--

DROP TABLE IF EXISTS `islem`;
CREATE TABLE IF NOT EXISTS `islem` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `islemAd` text COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `islem`:
--

--
-- Truncate table before insert `islem`
--

TRUNCATE TABLE `islem`;
--
-- Dumping data for table `islem`
--

INSERT DELAYED IGNORE INTO `islem` (`Id`, `islemAd`) VALUES
(1, 'Eti eklendi.');

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--
-- Creation: Dec 17, 2019 at 05:34 PM
--

DROP TABLE IF EXISTS `kategori`;
CREATE TABLE IF NOT EXISTS `kategori` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UstKategori` int(11) NOT NULL,
  `Ad` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `UstKategori` (`UstKategori`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `kategori`:
--

--
-- Truncate table before insert `kategori`
--

TRUNCATE TABLE `kategori`;
--
-- Dumping data for table `kategori`
--

INSERT DELAYED IGNORE INTO `kategori` (`Id`, `UstKategori`, `Ad`) VALUES
(1, 0, 'Sut Urunleri');

--
-- Triggers `kategori`
--
DROP TRIGGER IF EXISTS `bir_kategori_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_kategori_eklendi` BEFORE INSERT ON `kategori` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.Ad, ' kategorisi eklendi.'));
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `bir_kategori_silindi`;
DELIMITER $$
CREATE TRIGGER `bir_kategori_silindi` BEFORE DELETE ON `kategori` FOR EACH ROW BEGIN
	INSERT INTO islem(islemAd) VALUES(CONCAT(OLD.Ad, ' kategorisi silindi.'));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `kullanici`
--
-- Creation: Dec 17, 2019 at 05:41 PM
--

DROP TABLE IF EXISTS `kullanici`;
CREATE TABLE IF NOT EXISTS `kullanici` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `MusteriId` int(11) DEFAULT NULL,
  `KullaniciAd` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Sifre` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `MusteriId` (`MusteriId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `kullanici`:
--   `MusteriId`
--       `musteri` -> `Id`
--

--
-- Truncate table before insert `kullanici`
--

TRUNCATE TABLE `kullanici`;
--
-- Dumping data for table `kullanici`
--

INSERT DELAYED IGNORE INTO `kullanici` (`Id`, `MusteriId`, `KullaniciAd`, `Sifre`) VALUES
(1, 1, 'sakar', '12345678');

--
-- Triggers `kullanici`
--
DROP TRIGGER IF EXISTS `bir_kullanici_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_kullanici_eklendi` BEFORE INSERT ON `kullanici` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.KullaniciAd, ' kullanıcısı eklendi.'));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `marka`
--
-- Creation: Dec 17, 2019 at 04:37 PM
--

DROP TABLE IF EXISTS `marka`;
CREATE TABLE IF NOT EXISTS `marka` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Ad` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `marka`:
--

--
-- Truncate table before insert `marka`
--

TRUNCATE TABLE `marka`;
--
-- Dumping data for table `marka`
--

INSERT DELAYED IGNORE INTO `marka` (`Id`, `Ad`) VALUES
(1, 'Sutas'),
(2, 'Eti');

--
-- Triggers `marka`
--
DROP TRIGGER IF EXISTS `bir_marka_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_marka_eklendi` BEFORE INSERT ON `marka` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.Ad, ' markası eklendi.'));
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `bir_marka_silindi`;
DELIMITER $$
CREATE TRIGGER `bir_marka_silindi` BEFORE DELETE ON `marka` FOR EACH ROW BEGIN
	INSERT INTO islem(islemAd) VALUES(CONCAT(OLD.Ad, ' markası silindi.'));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `musteri`
--
-- Creation: Dec 17, 2019 at 04:37 PM
--

DROP TABLE IF EXISTS `musteri`;
CREATE TABLE IF NOT EXISTS `musteri` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Ad` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Soyad` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Cinsiyet` varchar(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Yas` int(11) DEFAULT NULL,
  `TelefonNo` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Eposta` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `musteri`:
--

--
-- Truncate table before insert `musteri`
--

TRUNCATE TABLE `musteri`;
--
-- Dumping data for table `musteri`
--

INSERT DELAYED IGNORE INTO `musteri` (`Id`, `Ad`, `Soyad`, `Cinsiyet`, `Yas`, `TelefonNo`, `Eposta`) VALUES
(1, 'sakar', 'sakir', 'erkek', 34, '05555555555', 'sakarsakir@mail.com');

--
-- Triggers `musteri`
--
DROP TRIGGER IF EXISTS `bir_musteri_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_musteri_eklendi` BEFORE INSERT ON `musteri` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.Ad, ' müşterisi eklendi.'));
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `bir_musteri_silindi`;
DELIMITER $$
CREATE TRIGGER `bir_musteri_silindi` BEFORE DELETE ON `musteri` FOR EACH ROW BEGIN
	INSERT INTO islem(islemAd) VALUES(CONCAT(OLD.Ad, ' musterisi silindi.'));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `sepet`
--
-- Creation: Dec 17, 2019 at 05:14 PM
--

DROP TABLE IF EXISTS `sepet`;
CREATE TABLE IF NOT EXISTS `sepet` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `KullaniciId` int(11) DEFAULT NULL,
  `UrunId` int(11) DEFAULT NULL,
  `Adet` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `KullaniciId` (`KullaniciId`,`UrunId`),
  KEY `UrunId` (`UrunId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `sepet`:
--   `KullaniciId`
--       `kullanici` -> `Id`
--   `UrunId`
--       `urun` -> `Id`
--

--
-- Truncate table before insert `sepet`
--

TRUNCATE TABLE `sepet`;
--
-- Dumping data for table `sepet`
--

INSERT DELAYED IGNORE INTO `sepet` (`Id`, `KullaniciId`, `UrunId`, `Adet`) VALUES
(1, 1, 1, 2),
(2, 1, 1, 23),
(3, 1, 1, 3),
(4, 1, 1, 6);

-- --------------------------------------------------------

--
-- Table structure for table `siparis`
--
-- Creation: Dec 17, 2019 at 05:14 PM
--

DROP TABLE IF EXISTS `siparis`;
CREATE TABLE IF NOT EXISTS `siparis` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `KullaniciId` int(11) DEFAULT NULL,
  `UrunId` int(11) DEFAULT NULL,
  `Adet` int(11) DEFAULT NULL,
  `Tarih` datetime(3) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `KullaniciId` (`KullaniciId`,`UrunId`),
  KEY `UrunId` (`UrunId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `siparis`:
--   `KullaniciId`
--       `kullanici` -> `Id`
--   `UrunId`
--       `urun` -> `Id`
--

--
-- Truncate table before insert `siparis`
--

TRUNCATE TABLE `siparis`;
--
-- Dumping data for table `siparis`
--

INSERT DELAYED IGNORE INTO `siparis` (`Id`, `KullaniciId`, `UrunId`, `Adet`, `Tarih`) VALUES
(1, 1, 1, 2, '2019-12-17 00:00:00.000'),
(2, 1, 1, 3, '2019-12-17 00:00:00.000'),
(3, 1, 1, 6, '2019-12-17 00:00:00.000'),
(4, 1, 1, 3, '2019-12-17 00:00:00.000'),
(5, 1, 1, 23, '2019-12-17 00:00:00.000');

-- --------------------------------------------------------

--
-- Table structure for table `stok`
--
-- Creation: Dec 17, 2019 at 05:14 PM
--

DROP TABLE IF EXISTS `stok`;
CREATE TABLE IF NOT EXISTS `stok` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UrunId` int(11) DEFAULT NULL,
  `Adet` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `UrunId` (`UrunId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `stok`:
--   `UrunId`
--       `urun` -> `Id`
--

--
-- Truncate table before insert `stok`
--

TRUNCATE TABLE `stok`;
--
-- Dumping data for table `stok`
--

INSERT DELAYED IGNORE INTO `stok` (`Id`, `UrunId`, `Adet`) VALUES
(1, 1, 122);

-- --------------------------------------------------------

--
-- Table structure for table `urun`
--
-- Creation: Dec 17, 2019 at 05:14 PM
--

DROP TABLE IF EXISTS `urun`;
CREATE TABLE IF NOT EXISTS `urun` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `KategoriId` int(11) DEFAULT NULL,
  `MarkaId` int(11) DEFAULT NULL,
  `Miktar` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Olcu` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Ad` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Fiyat` double DEFAULT NULL,
  `Aciklama` longtext COLLATE utf8_turkish_ci,
  PRIMARY KEY (`Id`),
  KEY `KategoriId` (`KategoriId`,`MarkaId`),
  KEY `MarkaId` (`MarkaId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `urun`:
--   `Id`
--       `kategori` -> `Id`
--   `MarkaId`
--       `marka` -> `Id`
--   `KategoriId`
--       `kategori` -> `Id`
--

--
-- Truncate table before insert `urun`
--

TRUNCATE TABLE `urun`;
--
-- Dumping data for table `urun`
--

INSERT DELAYED IGNORE INTO `urun` (`Id`, `KategoriId`, `MarkaId`, `Miktar`, `Olcu`, `Ad`, `Fiyat`, `Aciklama`) VALUES
(1, 1, 1, '1 Litre', '--', 'Günlük Süt', 12, 'günlük taze süt');

--
-- Triggers `urun`
--
DROP TRIGGER IF EXISTS `bir_urun_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_urun_eklendi` BEFORE INSERT ON `urun` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.Ad, ' ürünü eklendi.'));
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `bir_urun_silindi`;
DELIMITER $$
CREATE TRIGGER `bir_urun_silindi` BEFORE DELETE ON `urun` FOR EACH ROW BEGIN
	INSERT INTO islem(islemAd) VALUES(CONCAT(OLD.Ad,' ürünü silindi.'));
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `yonetici`
--
-- Creation: Dec 17, 2019 at 05:41 PM
--

DROP TABLE IF EXISTS `yonetici`;
CREATE TABLE IF NOT EXISTS `yonetici` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Kullanici_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Kullanici_Id` (`Kullanici_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- RELATIONSHIPS FOR TABLE `yonetici`:
--   `Kullanici_Id`
--       `kullanici` -> `Id`
--   `Kullanici_Id`
--       `kullanici` -> `Id`
--

--
-- Truncate table before insert `yonetici`
--

TRUNCATE TABLE `yonetici`;
--
-- Dumping data for table `yonetici`
--

INSERT DELAYED IGNORE INTO `yonetici` (`Id`, `Kullanici_Id`) VALUES
(1, 1);

--
-- Triggers `yonetici`
--
DROP TRIGGER IF EXISTS `bir_yonetici_eklendi`;
DELIMITER $$
CREATE TRIGGER `bir_yonetici_eklendi` BEFORE INSERT ON `yonetici` FOR EACH ROW BEGIN
	 INSERT INTO islem(islemAd) VALUES(CONCAT(NEW.Kullanici_Id, ' numaralı kullanıcı yönetici olarak eklendi.'));
END
$$
DELIMITER ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kullanici`
--
ALTER TABLE `kullanici`
  ADD CONSTRAINT `kullanici_ibfk_1` FOREIGN KEY (`MusteriId`) REFERENCES `musteri` (`Id`);

--
-- Constraints for table `sepet`
--
ALTER TABLE `sepet`
  ADD CONSTRAINT `sepet_ibfk_1` FOREIGN KEY (`KullaniciId`) REFERENCES `kullanici` (`Id`),
  ADD CONSTRAINT `sepet_ibfk_2` FOREIGN KEY (`UrunId`) REFERENCES `urun` (`Id`);

--
-- Constraints for table `siparis`
--
ALTER TABLE `siparis`
  ADD CONSTRAINT `siparis_ibfk_1` FOREIGN KEY (`KullaniciId`) REFERENCES `kullanici` (`Id`),
  ADD CONSTRAINT `siparis_ibfk_2` FOREIGN KEY (`UrunId`) REFERENCES `urun` (`Id`);

--
-- Constraints for table `stok`
--
ALTER TABLE `stok`
  ADD CONSTRAINT `stok_ibfk_1` FOREIGN KEY (`UrunId`) REFERENCES `urun` (`Id`);

--
-- Constraints for table `urun`
--
ALTER TABLE `urun`
  ADD CONSTRAINT `urun_ibfk_1` FOREIGN KEY (`Id`) REFERENCES `kategori` (`Id`),
  ADD CONSTRAINT `urun_ibfk_2` FOREIGN KEY (`MarkaId`) REFERENCES `marka` (`Id`),
  ADD CONSTRAINT `urun_ibfk_3` FOREIGN KEY (`KategoriId`) REFERENCES `kategori` (`Id`);

--
-- Constraints for table `yonetici`
--
ALTER TABLE `yonetici`
  ADD CONSTRAINT `yonetici_ibfk_1` FOREIGN KEY (`Kullanici_Id`) REFERENCES `kullanici` (`Id`);


--
-- Metadata
--
USE `phpmyadmin`;

--
-- Metadata for table islem
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table kategori
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table kullanici
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table marka
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table musteri
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table sepet
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table siparis
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table stok
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table urun
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for table yonetici
--

--
-- Truncate table before insert `pma__column_info`
--

TRUNCATE TABLE `pma__column_info`;
--
-- Truncate table before insert `pma__table_uiprefs`
--

TRUNCATE TABLE `pma__table_uiprefs`;
--
-- Truncate table before insert `pma__tracking`
--

TRUNCATE TABLE `pma__tracking`;
--
-- Metadata for database market
--

--
-- Truncate table before insert `pma__bookmark`
--

TRUNCATE TABLE `pma__bookmark`;
--
-- Truncate table before insert `pma__relation`
--

TRUNCATE TABLE `pma__relation`;
--
-- Dumping data for table `pma__relation`
--

INSERT DELAYED IGNORE INTO `pma__relation` (`master_db`, `master_table`, `master_field`, `foreign_db`, `foreign_table`, `foreign_field`) VALUES
('market', 'yonetici', 'Kullanici_Id', 'market', 'kullanici', 'Id');

--
-- Truncate table before insert `pma__savedsearches`
--

TRUNCATE TABLE `pma__savedsearches`;
--
-- Truncate table before insert `pma__central_columns`
--

TRUNCATE TABLE `pma__central_columns`;SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
