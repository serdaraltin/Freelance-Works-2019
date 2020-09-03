/*
Navicat MySQL Data Transfer

Source Server         : localServer
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : kurs

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2016-04-15 16:57:14
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for dersler
-- ----------------------------
DROP TABLE IF EXISTS `dersler`;
CREATE TABLE `dersler` (
  `ders_id` smallint(5) NOT NULL AUTO_INCREMENT,
  `ders_adi` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `eklenme_tarihi` datetime DEFAULT NULL,
  PRIMARY KEY (`ders_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of dersler
-- ----------------------------
INSERT INTO `dersler` VALUES ('1', 'android', '2016-03-11 16:52:51');
INSERT INTO `dersler` VALUES ('2', 'java', '2016-03-26 18:22:27');
INSERT INTO `dersler` VALUES ('3', 'sistem', '2016-03-28 18:22:24');

-- ----------------------------
-- Table structure for etut
-- ----------------------------
DROP TABLE IF EXISTS `etut`;
CREATE TABLE `etut` (
  `etutID` int(11) NOT NULL AUTO_INCREMENT,
  `Saatler` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `cumartesiSinif` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `cumartesiOgretmen` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `cumartesiDers` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `pazarSinif` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `pazarOgretmen` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `pazarDers` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`etutID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of etut
-- ----------------------------
INSERT INTO `etut` VALUES ('1', '11.00-12.30', '7', 'Ali Bilmem', 'C++', '7', 'Ali Bilmem', 'F#');
INSERT INTO `etut` VALUES ('2', '13.00-14.30', '7', 'Ali Bilmem', 'C++', 'SC-505', 'ali bilsin', 'ASP');
INSERT INTO `etut` VALUES ('3', '15.00-16.30', '7', 'Ali Bilmem', 'C++', 'SC-505', 'ali bilsin', 'ASP');

-- ----------------------------
-- Table structure for giris_islemi
-- ----------------------------
DROP TABLE IF EXISTS `giris_islemi`;
CREATE TABLE `giris_islemi` (
  `kullanici_id` int(11) DEFAULT NULL,
  `girisTarihi` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of giris_islemi
-- ----------------------------
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:01:28');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 15:41:32');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:41:54');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:42:28');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:42:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:43:13');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:44:36');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:44:53');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:45:43');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:45:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:46:13');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:46:37');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:47:06');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:47:51');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 15:48:30');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 15:50:15');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 15:56:03');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 15:57:34');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 15:59:27');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:01:56');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:02:40');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:03:16');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:04:11');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:05:54');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:08:26');
INSERT INTO `giris_islemi` VALUES ('21', '2016-04-05 16:52:34');
INSERT INTO `giris_islemi` VALUES ('22', '2016-04-05 16:53:42');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:04:00');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:12:45');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:15:25');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:17:12');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:17:49');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:18:47');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:20:55');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:25:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:28:03');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:35:18');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 17:54:51');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:25:01');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:26:49');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:28:46');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:30:41');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:31:56');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:35:03');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:37:37');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-05 18:38:16');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 15:02:38');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 15:57:27');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 15:57:52');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:29:23');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:31:26');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:36:16');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:36:50');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:37:40');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:40:22');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:41:53');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:42:57');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 16:54:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:03:53');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:13:50');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:14:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:23:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:25:04');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:26:04');
INSERT INTO `giris_islemi` VALUES ('25', '2016-04-06 17:28:18');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:30:20');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:33:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:36:03');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:38:55');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:48:31');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:48:32');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:48:45');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:48:46');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:49:03');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:51:12');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 17:57:55');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:02:45');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:02:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:11:01');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:24:29');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:24:29');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:24:49');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:29:41');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-06 18:44:16');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:35:02');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:37:38');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:38:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:40:48');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:41:12');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:45:28');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:45:53');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:46:48');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:50:28');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:50:51');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-12 15:54:45');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 15:57:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:00:01');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:00:44');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:01:39');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:02:23');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:02:44');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:03:31');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:04:32');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:04:39');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:06:58');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:06:59');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:07:08');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:07:38');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:07:47');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:08:05');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:08:41');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:09:47');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:17:07');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:18:18');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:21:43');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:29:43');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:36:50');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:39:49');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:40:46');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:43:26');
INSERT INTO `giris_islemi` VALUES ('1', '2016-04-15 16:54:28');

-- ----------------------------
-- Table structure for grup
-- ----------------------------
DROP TABLE IF EXISTS `grup`;
CREATE TABLE `grup` (
  `grupID` int(11) NOT NULL AUTO_INCREMENT,
  `grupNo` varchar(25) COLLATE utf8_turkish_ci NOT NULL,
  `grupAciklama` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `grupKontenjan` int(11) NOT NULL,
  `grupDanisman` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `grupAcilisTarihi` date DEFAULT NULL,
  `grupBitisTarihi` date DEFAULT NULL,
  PRIMARY KEY (`grupID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of grup
-- ----------------------------
INSERT INTO `grup` VALUES ('3', '7', 'C++', '4', 'tacettin baran', '2015-02-11', '2015-02-20');
INSERT INTO `grup` VALUES ('5', '9', 'F#', '30', 'ali bilsin', '2016-03-19', '2016-06-24');
INSERT INTO `grup` VALUES ('9', 'SC-205', 'Java-Android', '15', 'ali bilsin', '2016-02-08', '2016-06-23');
INSERT INTO `grup` VALUES ('18', 'SC-505', 'ASP', '15', 'ali bilsin', '2016-02-08', '2016-03-24');
INSERT INTO `grup` VALUES ('19', 'N-303', 'Network-1', '25', 'ali bilsin', '2016-03-01', '2016-05-19');
INSERT INTO `grup` VALUES ('26', 'N-402', 'Network-2', '25', 'ali bilsin', '2016-03-06', '2016-05-20');

-- ----------------------------
-- Table structure for kasa
-- ----------------------------
DROP TABLE IF EXISTS `kasa`;
CREATE TABLE `kasa` (
  `islem_id` int(11) NOT NULL AUTO_INCREMENT,
  `hareket` tinyint(1) NOT NULL,
  `islem_tarihi` datetime DEFAULT NULL,
  `miktar` decimal(10,2) DEFAULT NULL,
  `odeme_sekli` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `islem_tipi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `aciklama` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kasa_ogrenci_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`islem_id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of kasa
-- ----------------------------
INSERT INTO `kasa` VALUES ('1', '0', '2016-04-04 17:15:18', '15000.00', 'Senet', 'öğrenci', 'asdasdasd', '12345');
INSERT INTO `kasa` VALUES ('2', '0', '2016-04-04 17:17:04', '15000.00', 'Nakit', 'öğrenci', 'bla bla', '12345');
INSERT INTO `kasa` VALUES ('3', '0', '2016-04-04 17:17:17', '25000.00', 'Senet', 'öğrenci', 'bla bla bla', '123');
INSERT INTO `kasa` VALUES ('4', '0', '2016-04-04 17:17:54', '10000.00', 'Senet', 'öğrenci', 'bla bla', '111');
INSERT INTO `kasa` VALUES ('5', '0', '2016-04-04 18:19:00', '123.00', 'Nakit', 'tahsilat', 'açşğşöüğşşIıi', '0');
INSERT INTO `kasa` VALUES ('6', '0', '2016-04-04 18:38:59', '121.00', 'Nakit', 'uyhfujt öğrenci', 'öğrenci', '12312');
INSERT INTO `kasa` VALUES ('7', '0', '2016-04-04 18:42:07', '9000.00', 'Senet', 'uyhfujt öğrenci', 'jnh m', '11111');
INSERT INTO `kasa` VALUES ('8', '0', '2016-04-05 14:34:00', '120.00', 'Nakit', 'uyhfujt öğrenci', '', '121');
INSERT INTO `kasa` VALUES ('9', '0', '2016-04-05 14:36:29', '3000.00', 'Senet', 'uyhfujt öğrenci', '', '1212');
INSERT INTO `kasa` VALUES ('10', '0', '2016-04-05 14:53:35', '6789.00', 'Senet', 'gvjghhjb', '324', '0');
INSERT INTO `kasa` VALUES ('11', '0', '2016-04-05 14:57:35', '23213.00', 'Nakit', 'gvjghhjb', '', '0');
INSERT INTO `kasa` VALUES ('12', '0', '2016-04-06 15:41:58', '1231231.00', 'Nakit', 'gvjghhjbogrenci', '', '1231');
INSERT INTO `kasa` VALUES ('13', '0', '2016-04-06 15:50:22', '1231.00', 'Nakit', 'gvjghhjb', '', '0');
INSERT INTO `kasa` VALUES ('14', '0', '2016-04-06 15:55:44', '23423.00', 'Nakit', 'ogrenci', '', '25345');
INSERT INTO `kasa` VALUES ('15', '0', '2016-04-06 15:56:34', '131231.00', 'Nakit', 'dfsdfs', '', '0');
INSERT INTO `kasa` VALUES ('16', '1', '2016-04-06 17:08:18', '1200.00', 'Nakit', 'ogrenci', 'ali ödemesi', '95');
INSERT INTO `kasa` VALUES ('17', '0', '2016-04-06 17:10:57', '600.00', 'Senet', 'ogrenci', 'özcan ödemesi', '95');
INSERT INTO `kasa` VALUES ('18', '0', '2016-04-06 18:33:01', '10000.00', 'Kredi Kartı', 'asa', 'dwedd', '0');
INSERT INTO `kasa` VALUES ('19', '1', '2016-04-06 18:33:41', '35000.00', 'Kredi Kartı', 'asa', 'sefw', '0');
INSERT INTO `kasa` VALUES ('20', '1', '2016-04-12 15:41:10', '100000.00', 'Kredi Kartı', 'asa', '24342', '100');
INSERT INTO `kasa` VALUES ('21', '0', '2016-04-12 15:45:49', '25000.00', 'Kredi Kartı', 'asdfsdfaöğrenci', 'sfasfsd', '90');

-- ----------------------------
-- Table structure for kasalt
-- ----------------------------
DROP TABLE IF EXISTS `kasalt`;
CREATE TABLE `kasalt` (
  `tip` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of kasalt
-- ----------------------------
INSERT INTO `kasalt` VALUES ('asa');
INSERT INTO `kasalt` VALUES ('asdfsdfaöğrenci');

-- ----------------------------
-- Table structure for kullanicilar
-- ----------------------------
DROP TABLE IF EXISTS `kullanicilar`;
CREATE TABLE `kullanicilar` (
  `kullanici_id` smallint(5) NOT NULL AUTO_INCREMENT,
  `kullanici_isim` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kullanici_sifre` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kullanici_yetki` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personalID` int(11) DEFAULT NULL,
  PRIMARY KEY (`kullanici_id`),
  UNIQUE KEY `isimBenzersiz` (`kullanici_isim`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of kullanicilar
-- ----------------------------
INSERT INTO `kullanicilar` VALUES ('1', 'admin', 'admin', '11111111111111111111111111111111111', '4');
INSERT INTO `kullanicilar` VALUES ('4', 'gokhan', 'diker', '011111000000000000', '44');
INSERT INTO `kullanicilar` VALUES ('5', 'ali', 'bilmem', '010110100110', '48');
INSERT INTO `kullanicilar` VALUES ('7', 'gökhan45', 'diker', '000010010000', '48');
INSERT INTO `kullanicilar` VALUES ('12', 'alili', 'bilmem', '010110100110', '51');
INSERT INTO `kullanicilar` VALUES ('14', 'gökhan455', 'diker', '000100011100', '53');
INSERT INTO `kullanicilar` VALUES ('18', 'deneme', 'deneme', '000000000000', '45');
INSERT INTO `kullanicilar` VALUES ('20', 'deneme34', 'deneme', '010011110100', '45');
INSERT INTO `kullanicilar` VALUES ('21', 'aytac', '123', '10001000100010001001000010001000', '45');
INSERT INTO `kullanicilar` VALUES ('22', 'alideneme', '123', '000000000000000000000', '45');
INSERT INTO `kullanicilar` VALUES ('25', 'alii', '12345', '111111101110111111', '54');
INSERT INTO `kullanicilar` VALUES ('27', 'denemedeme', 'bilmem', '010110100110000000', '51');
INSERT INTO `kullanicilar` VALUES ('29', 'ddeneme', '123', '000000000000000000', '123');
INSERT INTO `kullanicilar` VALUES ('31', 'aliiiiiiiiiiiiiii', 'bilmem', '010110100110000000', '48');

-- ----------------------------
-- Table structure for ogrenci
-- ----------------------------
DROP TABLE IF EXISTS `ogrenci`;
CREATE TABLE `ogrenci` (
  `ogrenciId` int(11) NOT NULL AUTO_INCREMENT,
  `ogrenciAdi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciSoyadi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciDogumTarihi` date DEFAULT NULL,
  `grupNo` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciTc` varchar(11) COLLATE utf8_turkish_ci NOT NULL,
  `ogrenciTel` varchar(20) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciMail` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciAdres` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `veliAdSoyad` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `veliTel` varchar(20) COLLATE utf8_turkish_ci DEFAULT NULL,
  `veliMail` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kayitTarihi` datetime DEFAULT NULL,
  `dokumantasyon` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kayitDurumu` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`ogrenciId`),
  FULLTEXT KEY `oAdi` (`ogrenciAdi`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogrenci
-- ----------------------------
INSERT INTO `ogrenci` VALUES ('11', 'hasan', 'hüseyin', '2016-04-03', '11', '132131851', '31561611631', 'sdfsdf', '', 'hüseyin hasan', '0321511651', 'yagmur.bakti@hotmail.com', null, 'kitap mitap github', null);
INSERT INTO `ogrenci` VALUES ('12', 'ahmet', 'bilmmez', '2016-04-03', '1', '5161210651', '650560561', 'sdfs', 'beşiktaş fenerbahçe galatasaray', 'hasan hüseyin', '2+616151', 'tcttnbrn@hotmail.com', null, 'kiiiiitaaaaaaap', 'Aktif');
INSERT INTO `ogrenci` VALUES ('44', '8978', '876', '2016-04-03', 'SC-505', '7676876', '76867', '678', '678', '678', '678', '678', '2016-04-01 18:26:25', '678', 'aktif');
INSERT INTO `ogrenci` VALUES ('46', 'kaan', 'gençtürl', '2016-04-14', 'SC-205', '1351355', '12564816', 'oklas@gmail.com', 'dfafasdsaf', 'Hasan Hüseyin', '266629598', 'asdsa@gmail.com', '2016-04-04 14:55:04', 'asdvasd', 'aktif');
INSERT INTO `ogrenci` VALUES ('47', 'sfasdf', 'asdfasdf', '2016-04-13', 'SC-120', '21312321', '123213', '213213', '131313', '21312', '3131', '3131', '2016-04-04 15:53:18', '3131', 'Aktif');
INSERT INTO `ogrenci` VALUES ('85', 'fmsdklf', 'sfkmsdf', null, null, '34232423532', '23423423423', 'mxg@g.com', null, 'osafko', '324234', 'sfmdkfmelmg@g.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('86', 'Gökhan', 'Diker', '2019-04-14', 'N-303', '66666666666', '09009009090', 'dsa@sadk.com', 'asdasd', 'dsfsdf', '09009009091', 'sad@sd.com', '2016-04-05 16:50:54', 'sdsad', 'aktif');
INSERT INTO `ogrenci` VALUES ('90', 'sadja', 'şıdhfs', '2016-04-03', 'N-303', '324324', '344324', 'dsa@sd.com', 'sadadasd', 'sdsadasd', '324234', 'dsa@sd.com', '2016-04-05 16:55:41', 'asfsaf', 'aktif');
INSERT INTO `ogrenci` VALUES ('91', 'sdaasd', 'safsaf', '2016-04-10', 'N-303', '32443244234', '324234', 'sdasad@sad.com', 'sdadasdas', 'asdasd', '161618', 'sdasad@sad.com', '2016-04-05 17:01:05', 'sadas', 'aktif');
INSERT INTO `ogrenci` VALUES ('95', 'özcan', 'Bilsin', '2016-04-06', 'SC-205', '17485865645', '11111111111', 'ali@ali.commm', 'jyfhf', 'Ali', '45456464654', 'ali@ali.co', '2016-04-06 17:25:58', '15 dk java', 'Aktif');
INSERT INTO `ogrenci` VALUES ('96', 'a', 'b', null, null, '32423423423', '+90 (555)-5', '324@sad.com', null, 'aa', '34223432423', '324@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('97', 'asd', 'saf', null, null, '65468464684', '+90 (545)-646 46 84', '64864@sad.com', null, 'sadas', '+90 (654)-646 54 65', '64864@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('98', 'sda', 'asd', null, null, '23243243423', '+90 (   )-', 'sad@sad.com', null, 'dasd', '+90 (   )-', 'sad@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('99', 'sad@sad.com', 'sad@sad.com', null, null, '34232432432', '+90 (516)-513 61 65', 'sad@sad.com', null, 'sad@sad.com', '+90 (032)-505 61 35', 'sad@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('100', 'sad@sad.com', 'sad@sad.com', null, null, '34232432411', '+90 (516)-513 61 65', 'sad@sad.com', null, 'sad@sad.com', '+90 (032)-505 61 35', 'sad@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('101', 'sad@sad.com', 'sad@sad.com', null, null, '34232430000', '+90 (516)-513 61 65', 'sad@sad.com', null, 'sad@sad.com', '+90 (032)-505 61 35', 'sad@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('102', 'safkj', 'dfdalgks', null, null, '32342322223', '+90 (   )-', 'sad@sad.com', null, 'asf', '+90 (   )-', 'sad@sad.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('103', 'adasdds', 'dsgdsg', null, null, '00022555888', '+90 (165)-165 16 16', 'sad@cos.com', null, 'dsgds', '+90 (616)-681 68 16', 'sad@cos.com', null, null, 'Pasif');
INSERT INTO `ogrenci` VALUES ('104', 'ad', 'soy', '2016-04-15', '7', '12345678911', '11111111111', 'as@as.com', 'adres bölümü', 'veli', '22222222222', 'veli@veli.com', '2016-04-15 16:10:37', 'kitap', 'aktif');

-- ----------------------------
-- Table structure for ogrencidersnotlari
-- ----------------------------
DROP TABLE IF EXISTS `ogrencidersnotlari`;
CREATE TABLE `ogrencidersnotlari` (
  `dersNotuID` int(11) NOT NULL AUTO_INCREMENT,
  `ogrenciID` int(11) DEFAULT NULL,
  `sinifi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciAdi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciSoyadi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciNo` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `1_notu` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `2_notu` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`dersNotuID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogrencidersnotlari
-- ----------------------------
INSERT INTO `ogrencidersnotlari` VALUES ('1', '46', 'SC-205', 'kaan', 'gençtürl', '1351355', '23', '35');
INSERT INTO `ogrencidersnotlari` VALUES ('2', '48', 'SC-505', 'ali', 'bilmem', '0101', '56', '56');
INSERT INTO `ogrencidersnotlari` VALUES ('3', '44', 'SC-505', '8978', '876', '7676876', '10', '15');
INSERT INTO `ogrencidersnotlari` VALUES ('4', '95', 'SC-205', 'özcan', 'Bilsin', '17485865645', '12', '32');

-- ----------------------------
-- Table structure for ogrencidersprog
-- ----------------------------
DROP TABLE IF EXISTS `ogrencidersprog`;
CREATE TABLE `ogrencidersprog` (
  `ogrenciProID` int(11) NOT NULL AUTO_INCREMENT,
  `Saatler` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `sinifGrupAciklama` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Pazartesi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Sali` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Carsamba` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Persembe` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Cuma` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`ogrenciProID`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogrencidersprog
-- ----------------------------
INSERT INTO `ogrencidersprog` VALUES ('1', '09.00-10.30', '7', 'java', 'sistem', 'android', 'java', 'sistem');
INSERT INTO `ogrencidersprog` VALUES ('2', '11.00-12.30', '7', 'java', 'android', 'android', 'java', 'java');
INSERT INTO `ogrencidersprog` VALUES ('3', '13.00-14.30', '7', 'sistem', 'java', 'java', 'sistem', 'java');
INSERT INTO `ogrencidersprog` VALUES ('4', '15.00-16.30', '7', 'android', 'android', 'java', 'java', 'android');
INSERT INTO `ogrencidersprog` VALUES ('5', '09.00-10.30', 'SC-505', 'java', 'java', 'android', 'sistem', 'java');
INSERT INTO `ogrencidersprog` VALUES ('6', '11.00-12.30', 'SC-505', 'java', 'java', 'sistem', 'android', 'java');
INSERT INTO `ogrencidersprog` VALUES ('7', '13.00-14.30', 'SC-505', 'sistem', 'sistem', 'java', 'java', 'sistem');
INSERT INTO `ogrencidersprog` VALUES ('8', '15.00-16.30', 'SC-505', 'java', 'android', 'android', 'android', 'java');
INSERT INTO `ogrencidersprog` VALUES ('9', '09.00-10.30', 'ali bilsin', '9', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogrencidersprog` VALUES ('10', '09.00-10.30', 'ali bilsin', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogrencidersprog` VALUES ('11', '11.00-12.30', 'ali bilsin', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogrencidersprog` VALUES ('12', '13.00-14.30', 'ali bilsin', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogrencidersprog` VALUES ('13', '15.00-16.30', 'ali bilsin', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogrencidersprog` VALUES ('14', '09.00-10.30', 'N-303', 'android', 'java', 'java', 'sistem', 'java');
INSERT INTO `ogrencidersprog` VALUES ('15', '11.00-12.30', 'N-303', 'java', 'android', 'android', 'sistem', 'java');
INSERT INTO `ogrencidersprog` VALUES ('16', '13.00-14.30', 'N-303', 'java', 'sistem', 'sistem', 'java', 'java');
INSERT INTO `ogrencidersprog` VALUES ('17', '15.00-16.30', 'N-303', 'android', 'android', 'java', 'java', 'android');
INSERT INTO `ogrencidersprog` VALUES ('18', '09.00-10.30', 'SC-205', 'android', 'java', 'sistem', 'android', 'java');
INSERT INTO `ogrencidersprog` VALUES ('19', '11.00-12.30', 'SC-205', 'java', 'android', 'sistem', 'android', 'sistem');
INSERT INTO `ogrencidersprog` VALUES ('20', '13.00-14.30', 'SC-205', 'android', 'sistem', 'android', 'java', 'java');
INSERT INTO `ogrencidersprog` VALUES ('21', '15.00-16.30', 'SC-205', 'sistem', 'android', 'java', 'android', 'java');

-- ----------------------------
-- Table structure for ogretmen
-- ----------------------------
DROP TABLE IF EXISTS `ogretmen`;
CREATE TABLE `ogretmen` (
  `ogretmenID` int(11) DEFAULT NULL,
  `ogretmenAdi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogretmenSoyadi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogretmen
-- ----------------------------
INSERT INTO `ogretmen` VALUES ('54', 'Ali', 'Bilmem');
INSERT INTO `ogretmen` VALUES ('48', 'ali', 'bilsin');
INSERT INTO `ogretmen` VALUES ('44', 'tacettin', 'baran');

-- ----------------------------
-- Table structure for ogretmenbilgileri
-- ----------------------------
DROP TABLE IF EXISTS `ogretmenbilgileri`;
CREATE TABLE `ogretmenbilgileri` (
  `ogretmenID` int(11) NOT NULL AUTO_INCREMENT,
  `ogretmenAdi` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `ogretmenSoyadi` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `ogrtBrans` varchar(15) CHARACTER SET utf8 DEFAULT NULL,
  `dersUcreti` int(15) DEFAULT NULL,
  `baslamaTarihi` datetime(6) DEFAULT NULL,
  `maas` int(15) DEFAULT NULL,
  PRIMARY KEY (`ogretmenID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogretmenbilgileri
-- ----------------------------
INSERT INTO `ogretmenbilgileri` VALUES ('1', 'Ali', 'yildiz', 'Tarih', '70', '2016-03-30 18:16:01.000000', '4550');
INSERT INTO `ogretmenbilgileri` VALUES ('2', 'veli', 'yildirim', 'Java', '50', '2016-03-16 16:25:45.000000', '500');
INSERT INTO `ogretmenbilgileri` VALUES ('3', 'Ayşe', 'bilir', 'ASP', null, '2016-03-15 17:22:12.000000', null);
INSERT INTO `ogretmenbilgileri` VALUES ('4', 'Nizamettin', 'Ateş', 'Matematik', '60', '2016-04-02 17:22:53.000000', '660');
INSERT INTO `ogretmenbilgileri` VALUES ('5', 'Vatan', 'Savaş', 'Java', null, '2016-02-16 17:45:06.000000', null);
INSERT INTO `ogretmenbilgileri` VALUES ('6', 'Murat', 'Bardakçı', 'Tarih', null, '2016-03-31 17:45:34.000000', null);

-- ----------------------------
-- Table structure for ogretmendersprog
-- ----------------------------
DROP TABLE IF EXISTS `ogretmendersprog`;
CREATE TABLE `ogretmendersprog` (
  `ogretmenProID` int(11) NOT NULL AUTO_INCREMENT,
  `Saatler` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Ogretmen` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Pazartesi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Sali` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Carsamba` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Persembe` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Cuma` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`ogretmenProID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of ogretmendersprog
-- ----------------------------
INSERT INTO `ogretmendersprog` VALUES ('1', '09.00-10.30', 'Ali Bilmem', '7', 'SC-505', 'SC-505', 'SC-505', 'SC-505');
INSERT INTO `ogretmendersprog` VALUES ('2', '11.00-12.30', 'Ali Bilmem', 'Ders yok', 'SC-505', 'Ders yok', 'Ders yok', 'Ders yok');
INSERT INTO `ogretmendersprog` VALUES ('3', '13.00-14.30', 'Ali Bilmem', 'Ders yok', 'Ders yok', 'Ders yok', 'N-402', 'Ders yok');
INSERT INTO `ogretmendersprog` VALUES ('4', '15.00-16.30', 'Ali Bilmem', 'Ders yok', 'SC-205', 'Ders yok', 'Ders yok', 'Ders yok');

-- ----------------------------
-- Table structure for personel
-- ----------------------------
DROP TABLE IF EXISTS `personel`;
CREATE TABLE `personel` (
  `personelID` int(11) NOT NULL AUTO_INCREMENT,
  `personelTC` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelAdi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelSoyadi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelMail` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelAdres` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelEvTel` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelCepTel` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelGirisTarih` date DEFAULT NULL,
  `personelCikisTarih` date DEFAULT NULL,
  `personelMaas` decimal(10,2) DEFAULT NULL,
  `personelGorev` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelAciklama` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `personelSskNo` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`personelID`),
  KEY `personelAdi` (`personelAdi`,`personelSoyadi`,`personelGorev`)
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of personel
-- ----------------------------
INSERT INTO `personel` VALUES ('44', '12123', 'tacettin', 'baran', 'd@mail.com', 'f', '1123', '25432', '2016-03-06', '2017-03-12', '1500.00', 'Öğretmen', 'k', '3');
INSERT INTO `personel` VALUES ('48', '312312', 'ali', 'bilsin', 'd@mail.com', 'f', '1123', '25432', '2016-03-06', '2017-03-12', '1500.00', 'Öğretmen', 'k', '3');
INSERT INTO `personel` VALUES ('53', '233', 'tacettin', 'baran', 'baran@mail.com', 'fasdfghjk', '1123', '25432', '2016-03-06', '2017-03-12', '1500.00', 'Müdür', 'k', '3');
INSERT INTO `personel` VALUES ('54', '3453453453', 'Ali', 'Bilmem', 'ali@ali.com', 'Ali adres', '45152', '4525252', '2016-04-06', '2017-04-06', '4400.00', 'Öğretmen', 'Ali açıklama yaptı', '1');

-- ----------------------------
-- Table structure for rehberlik
-- ----------------------------
DROP TABLE IF EXISTS `rehberlik`;
CREATE TABLE `rehberlik` (
  `rehberlikID` int(11) NOT NULL AUTO_INCREMENT,
  `rehberlikOgrenciID` int(11) DEFAULT NULL,
  `rehberlikOgretmenID` int(11) DEFAULT NULL,
  `yoklamaID` int(11) DEFAULT NULL,
  `ogrenciProID` int(11) DEFAULT NULL,
  `rehberlikDersID` int(11) DEFAULT NULL,
  `ogretmenProID` int(11) DEFAULT NULL,
  `etutID` int(11) DEFAULT NULL,
  PRIMARY KEY (`rehberlikID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of rehberlik
-- ----------------------------

-- ----------------------------
-- Table structure for senet
-- ----------------------------
DROP TABLE IF EXISTS `senet`;
CREATE TABLE `senet` (
  `senet_id` int(11) NOT NULL AUTO_INCREMENT,
  `senet_ogrenci_id` int(11) DEFAULT NULL,
  `toplam_taksit` tinyint(4) DEFAULT NULL,
  `taksit_id` tinyint(4) DEFAULT NULL,
  `toplam_miktar` decimal(10,2) DEFAULT NULL,
  `odeme_miktari` decimal(10,2) DEFAULT NULL,
  `vade_tarihi` datetime DEFAULT NULL,
  `odenme_bilgisi` tinyint(1) DEFAULT '0',
  `odeme_tarihi` datetime DEFAULT NULL,
  PRIMARY KEY (`senet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of senet
-- ----------------------------
INSERT INTO `senet` VALUES ('1', '123', '12', '1', '25000.00', '2083.00', '2016-04-04 00:00:00', '1', '2016-04-04 18:09:49');
INSERT INTO `senet` VALUES ('2', '123', '12', '2', '25000.00', '2083.00', '2016-05-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('3', '123', '12', '3', '25000.00', '2083.00', '2016-06-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('4', '123', '12', '4', '25000.00', '2083.00', '2016-07-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('5', '123', '12', '5', '25000.00', '2083.00', '2016-08-04 00:00:00', '1', '2016-04-04 18:09:37');
INSERT INTO `senet` VALUES ('6', '123', '12', '6', '25000.00', '2083.00', '2016-09-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('7', '123', '12', '7', '25000.00', '2083.00', '2016-10-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('8', '123', '12', '8', '25000.00', '2083.00', '2016-11-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('9', '123', '12', '9', '25000.00', '2083.00', '2016-12-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('10', '123', '12', '10', '25000.00', '2083.00', '2017-01-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('11', '123', '12', '11', '25000.00', '2083.00', '2017-02-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('12', '123', '12', '12', '25000.00', '2083.00', '2017-03-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('13', '111', '10', '1', '10000.00', '1000.00', '2016-04-04 00:00:00', '1', '2016-04-04 18:13:04');
INSERT INTO `senet` VALUES ('14', '111', '10', '2', '10000.00', '1000.00', '2016-05-04 00:00:00', '1', '2016-04-04 18:13:36');
INSERT INTO `senet` VALUES ('15', '111', '10', '3', '10000.00', '1000.00', '2016-06-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('16', '111', '10', '4', '10000.00', '1000.00', '2016-07-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('17', '111', '10', '5', '10000.00', '1000.00', '2016-08-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('18', '111', '10', '6', '10000.00', '1000.00', '2016-09-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('19', '111', '10', '7', '10000.00', '1000.00', '2016-10-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('20', '111', '10', '8', '10000.00', '1000.00', '2016-11-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('21', '111', '10', '9', '10000.00', '1000.00', '2016-12-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('22', '111', '10', '10', '10000.00', '1000.00', '2017-01-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('23', '123324', '2', '1', '323.00', '161.00', '2016-04-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('24', '123324', '2', '2', '323.00', '161.00', '2016-05-04 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('25', '1212', '2', '1', '3000.00', '1500.00', '2016-04-13 00:00:00', '1', '2016-04-05 14:38:03');
INSERT INTO `senet` VALUES ('26', '1212', '2', '2', '3000.00', '1500.00', '2016-05-13 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('27', '1', '2', '1', '1212.00', '606.00', '2016-04-05 00:00:00', '1', '2016-04-05 17:04:08');
INSERT INTO `senet` VALUES ('28', '1', '2', '2', '1212.00', '606.00', '2016-05-05 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('29', '95', '4', '1', '650.00', '162.00', '2016-04-06 00:00:00', '1', '2016-04-06 17:15:12');
INSERT INTO `senet` VALUES ('30', '95', '4', '2', '650.00', '162.00', '2016-05-06 00:00:00', '1', '2016-04-06 17:32:09');
INSERT INTO `senet` VALUES ('31', '95', '4', '3', '650.00', '162.00', '2016-06-06 00:00:00', '0', null);
INSERT INTO `senet` VALUES ('32', '95', '4', '4', '650.00', '162.00', '2016-07-06 00:00:00', '0', null);

-- ----------------------------
-- Table structure for yoklama
-- ----------------------------
DROP TABLE IF EXISTS `yoklama`;
CREATE TABLE `yoklama` (
  `yoklamaID` int(11) NOT NULL AUTO_INCREMENT,
  `ogrenciID` int(11) DEFAULT NULL,
  `sinif` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciAdi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciSoyadi` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ogrenciNo` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `durum` varchar(255) COLLATE utf8_turkish_ci DEFAULT NULL,
  `yoklamaTarihi` date DEFAULT NULL,
  PRIMARY KEY (`yoklamaID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- ----------------------------
-- Records of yoklama
-- ----------------------------
INSERT INTO `yoklama` VALUES ('1', '12', 'C++', 'ahmet', 'bilmmez', '5161210651', 'RAPORLU', '2016-04-05');
INSERT INTO `yoklama` VALUES ('2', '95', 'SC-205', 'özcan', 'Bilsin', '17485865645', 'DEVAMSIZ', '2016-04-06');
INSERT INTO `yoklama` VALUES ('3', '44', 'SC-505', '8978', '876', '7676876', 'RAPORLU', '2016-04-15');
INSERT INTO `yoklama` VALUES ('4', '46', 'SC-205', 'kaan', 'gençtürl', '1351355', 'RAPORLU', '2016-04-15');

-- ----------------------------
-- View structure for viewmail
-- ----------------------------
DROP VIEW IF EXISTS `viewmail`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER  VIEW `viewmail` AS select o.ogrenciAdi,o.ogrenciSoyadi,o.ogrenciTc,y.yoklamaTarihi,y.durum,o.veliMail,od.1_notu,od.2_notu from ogrenci as o LEFT JOIN yoklama as y on o.ogrenciId=y.ogrenciID LEFT JOIN ogrencidersnotlari as od on y.ogrenciNo=od.ogrenciNo ;

-- ----------------------------
-- Procedure structure for asilKayit
-- ----------------------------
DROP PROCEDURE IF EXISTS `asilKayit`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `asilKayit`(IN dogum date, IN adi varchar(255), IN soyadi varchar(255), IN kimlik varchar(255), IN ogrtel varchar(255), IN omail varchar(255), IN vadisoyadi varchar(255), IN vtel varchar(255), IN vmail varchar(255), IN adres varchar(255) , IN dokuman varchar(255) , IN TC varchar(255))
BEGIN
	
update ogrenci SET ogrenciDogumTarihi = dogum, 
ogrenciAdi = adi, ogrenciSoyadi = soyadi, ogrenciTc = kimlik, ogrenciTel = ogrtel, ogrenciMail = omail, veliAdSoyad = vadisoyadi,
veliTel=vtel, veliMail = vmail, 
ogrenciAdres = adres, dokumantasyon = dokuman, 
kayitTarihi=NOW(), kayitDurumu= 'Aktif' WHERE ogrenciTc = TC;


END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for etutprog1
-- ----------------------------
DROP PROCEDURE IF EXISTS `etutprog1`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `etutprog1`(IN `ID` int(11),IN `Ders_2` varchar(255),IN `cumartesisinif1` varchar(255),IN `choca1` varchar(255),IN `cders1` varchar(255),IN `psinif1` varchar(255),IN `phoca1` varchar(255),IN `pders1` varchar(255))
BEGIN
	insert into etut values (null,Ders_2,cumartesisinif1,choca1, cders1,psinif1, phoca1, pders1);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for grupBilgisiGetirme
-- ----------------------------
DROP PROCEDURE IF EXISTS `grupBilgisiGetirme`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `grupBilgisiGetirme`(IN `grupNumarasi` varchar(255))
BEGIN
SELECT * from grup where grupNo=grupNumarasi;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for grupBilgisiGuncelle
-- ----------------------------
DROP PROCEDURE IF EXISTS `grupBilgisiGuncelle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `grupBilgisiGuncelle`(IN `grupNumarasi` varchar(25),IN `grupAciklamasi` varchar(255),IN `grupKontenjani` int(11),IN `grupDanismani` varchar(255),IN `grupAcilisTarih` date,IN `grupBitisTarih` date,IN `grupids` int(11))
BEGIN
	UPDATE grup set grupNo=grupNumarasi ,grupAciklama=grupAciklamasi, grupKontenjan=grupKontenjani, grupDanisman=grupDanismani,grupAcilisTarihi=grupAcilisTarih , grupBitisTarihi=grupBitisTarih 
where grupID=grupids;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for grupBilgisiSilme
-- ----------------------------
DROP PROCEDURE IF EXISTS `grupBilgisiSilme`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `grupBilgisiSilme`(IN `grupadi` varchar(25))
BEGIN
	
DELETE FROM grup WHERE grupNo = grupadi;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for grupEkle
-- ----------------------------
DROP PROCEDURE IF EXISTS `grupEkle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `grupEkle`(IN `grupNo` varchar(25),IN `grupAciklama` varchar(255),IN `grupKontenjan` int(11),IN `grupDanisman` varchar(255),IN `baslangicTarih` date,IN `bitisTarih` date)
BEGIN

	INSERT INTO grup VALUES(null,grupNo,grupAciklama,grupKontenjan,grupDanisman,baslangicTarih,bitisTarih);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for kayitInsert
-- ----------------------------
DROP PROCEDURE IF EXISTS `kayitInsert`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `kayitInsert`(IN `Adı` varchar(20), IN `Soyadı` varchar(20), IN `Dogum` date, IN `grupNo` varchar(20),IN `TC` varchar(11),IN `Cep` varchar(20),IN `adres` varchar(100),IN `VeliAdSoyad` varchar(30), IN `VeliCep` varchar(20) , IN `dokuman` varchar(140) , IN `durum` varchar(15),IN `ogrenciMail` varchar(255),IN `veliMail` varchar(255))
BEGIN
insert into ogrenci(ogrenciId,ogrenciAdi,ogrenciSoyadi,ogrenciDogumTarihi,
grupNo,ogrenciTc,ogrenciTel,ogrenciAdres,veliAdSoyad,VeliTel,kayitTarihi,dokumantasyon,
kayitDurumu,ogrenciMail,veliMail) 
values(null,Adı,Soyadı,Dogum,grupNo,TC,Cep,adres,VeliAdSoyad,VeliCep,NOW(),dokuman,durum,ogrenciMail,veliMail);


END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogrenciAra
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogrenciAra`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogrenciAra`(IN `data1` varchar(100),IN `data2` varchar(100),IN `data3` varchar(100))
BEGIN
	#VARCHAR(100) ogrenci tablosu içinden data arama
	#SELECT * FROM ogrenci WHERE ogrenciTc LIKE CONCAT('%',data,'%');
	SELECT * FROM ogrenci WHERE ogrenciTc LIKE CONCAT('%',data1,'%') OR ogrenciAdi LIKE CONCAT('%',data2,'%') OR ogrenciSoyadi LIKE CONCAT('%',data3,'%');

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogrenciBilgiGetir
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogrenciBilgiGetir`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogrenciBilgiGetir`(IN `grupNumara` varchar(255))
BEGIN
	select ogrenciId,ogrenciAdi,ogrenciSoyadi, ogrenciTc,ogrenciTel from ogrenci where ogrenci.grupNo=grupNumara;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogrenciDersNotuGirme
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogrenciDersNotuGirme`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogrenciDersNotuGirme`(IN `OgrenciID` int(11),IN `Sinif` varchar(255),IN `ogrAdi` varchar(255),IN `ogrSoyadi` varchar(255),IN `ogrTc` varchar(255),IN `not1` int(11),IN `not2` int(11))
BEGIN
	insert into ogrenciDersNotlari values (null,OgrenciID, Sinif, ogrAdi, ogrSoyadi, ogrTc, not1,not2);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogrencidersprogekle1
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogrencidersprogekle1`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogrencidersprogekle1`(IN `derss2id` int(11),IN `derss2` varchar(255),IN `siniff` varchar(255),IN `pazartesii9` varchar(255),IN `salii9` varchar(255),IN `carsambaa9` varchar(255),IN `persembee9` varchar(255),IN `cumaa9` varchar(255))
BEGIN
	insert into ogrencidersprog values (NULL,derss2,siniff,pazartesii9,salii9, carsambaa9, persembee9,cumaa9);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogretmendersprogekle1
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogretmendersprogekle1`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogretmendersprogekle1`(IN `derss2id` int(11),IN `derss2` varchar(255),IN `siniff` varchar(255),IN `pazartesii9` varchar(255),IN `salii9` varchar(255),IN `carsambaa9` varchar(255),IN `persembee9` varchar(255),IN `cumaa9` varchar(255))
BEGIN
	insert into ogretmendersprog values (NULL,derss2,siniff,pazartesii9,salii9, carsambaa9, persembee9,cumaa9);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for ogretmenEkle
-- ----------------------------
DROP PROCEDURE IF EXISTS `ogretmenEkle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `ogretmenEkle`()
BEGIN

DELETE FROM ogretmen;
INSERT INTO ogretmen (ogretmenID,ogretmenAdi,ogretmenSoyadi) 
SELECT personelID, personelAdi,personelSoyadi FROM personel WHERE personelGorev = 'Öğretmen' ;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for onKayıtEkle
-- ----------------------------
DROP PROCEDURE IF EXISTS `onKayıtEkle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `onKayıtEkle`(IN `Adı` varchar(20),IN `Soyadı` varchar(20),IN `TC` varchar(11),IN `Cep` varchar(20),IN `VeliAdSoyad` varchar(50),IN `VeliCep` varchar(20),IN `durum` varchar(15),IN `ogrenciMail` varchar(255),IN `veliMail` varchar(255))
BEGIN
insert into ogrenci(ogrenciId,ogrenciAdi,ogrenciSoyadi,ogrenciDogumTarihi,grupNo,ogrenciTc,ogrenciTel,ogrenciAdres,veliAdSoyad,VeliTel,kayitTarihi,dokumantasyon,kayitDurumu,ogrenciMail,veliMail) values(null,Adı,Soyadı,NULL,NULL,TC,Cep,NULL,VeliAdSoyad,VeliCep,NULL,NULL,durum,ogrenciMail,veliMail);


END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for personelEkle
-- ----------------------------
DROP PROCEDURE IF EXISTS `personelEkle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `personelEkle`(IN adi varchar(255),IN soyadi varchar(255),IN mail varchar(255),IN adres varchar(255),IN evTel varchar(255),IN cepTel varchar(255),IN girisTarih date,IN cikisTarih date,IN maas decimal(10,2),IN gorev varchar(255),IN aciklama varchar(255),IN sskNo varchar(255))
BEGIN
	
	insert into personel  values(null, adi, soyadi, mail, adres, evTel, cepTel, girisTarih, cikisTarih, maas, gorev, aciklama, sskNo);

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for personelGetir
-- ----------------------------
DROP PROCEDURE IF EXISTS `personelGetir`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `personelGetir`()
BEGIN
	
	select *from personel;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for personelGuncelle
-- ----------------------------
DROP PROCEDURE IF EXISTS `personelGuncelle`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `personelGuncelle`(IN adi varchar(255),IN soyadi varchar(255),IN mail varchar(255),IN adres varchar(255),IN evTel varchar(255),IN cepTel varchar(255),IN girisTarih date,IN cikisTarih date,IN maas decimal(10,2),IN gorev varchar(255),IN aciklama varchar(255),IN sskNo varchar(255), IN id int(11))
BEGIN
	
	update personel set personelAdi = adi , personelSoyadi = soyadi,

										  personelMail = mail , personelAdres = adres,

											personelEvTel = evTel , personelCepTel = cepTel,

									    personelGirisTarih = girisTarih , personelCikisTarih = cikisTarih,

                      personelMaas = maas , personelGorev = gorev,

                      personelAciklama =aciklama , personelSskNo =sskNo 

                      where personelID =id;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for personelSec
-- ----------------------------
DROP PROCEDURE IF EXISTS `personelSec`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `personelSec`(IN id int)
BEGIN
	
	select *from personel where personelID =id;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for personelSil
-- ----------------------------
DROP PROCEDURE IF EXISTS `personelSil`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `personelSil`(IN id int)
BEGIN

	delete from personel where personelID = id;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proKasaKaydi
-- ----------------------------
DROP PROCEDURE IF EXISTS `proKasaKaydi`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proKasaKaydi`(IN `nere` tinyint(4),IN `tarih` datetime,IN `tutar` decimal(10,2),IN `odeme` varchar(255),IN `islem` varchar(255),IN `acik` varchar(255),IN `id` int(11))
BEGIN
	insert into kasa values(null,nere,tarih,tutar,odeme,islem,acik,id);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proMailArama
-- ----------------------------
DROP PROCEDURE IF EXISTS `proMailArama`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proMailArama`(IN isim varchar(150))
BEGIN

	select *from viewmail as goster where MATCH(ogrenciAdi) AGAINST (isim IN BOOLEAN MODE);
	

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proSenet
-- ----------------------------
DROP PROCEDURE IF EXISTS `proSenet`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proSenet`(IN `ogrenci` int(11),IN `totaksit` tinyint(4),IN `totutar` decimal(10,2),IN `tutar` decimal(10,2),IN `vade` datetime)
BEGIN

DECLARE i INT;

DECLARE y VARCHAR(50);
DECLARE a VARCHAR(50);
DECLARE r VARCHAR(50);
DECLARE yi INT;
DECLARE ai INT;

SET i = 0;

SET y = SUBSTRING(vade, 3, 2);
SET a = SUBSTRING(vade, 6, 2);
SET ai = a;
SET yi = y;

WHILE i < totaksit DO
SET i = i + 1;


IF i=1 THEN SET i=1 ;
		ELSEIF ai < 12 THEN SET ai = ai + 1;
    ELSE SET yi = yi + 1, ai = 1;
    END IF;

set r = CONCAT(SUBSTRING(vade, 1, 2),yi,'-',ai,SUBSTRING(vade, 8));

insert into senet values(null,ogrenci,totaksit,i,totutar,tutar,r,'0',null);

END WHILE;


END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proSenetGetir
-- ----------------------------
DROP PROCEDURE IF EXISTS `proSenetGetir`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proSenetGetir`(IN `ogrenci` int(11))
BEGIN
	select * from senet where senet_ogrenci_id = ogrenci;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proSenetOde
-- ----------------------------
DROP PROCEDURE IF EXISTS `proSenetOde`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proSenetOde`(IN `ogrenci` int(11),IN `taksit` tinyint(4))
BEGIN
	update senet set odenme_bilgisi = '1', odeme_tarihi = NOW() where senet_ogrenci_id = ogrenci and taksit_id = taksit;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proTipOku
-- ----------------------------
DROP PROCEDURE IF EXISTS `proTipOku`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proTipOku`()
BEGIN
	select * from kasalt;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proTipSil
-- ----------------------------
DROP PROCEDURE IF EXISTS `proTipSil`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proTipSil`(IN `val` varchar(255))
BEGIN
	delete from kasalt where tip = val;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proTipYaz
-- ----------------------------
DROP PROCEDURE IF EXISTS `proTipYaz`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proTipYaz`(IN `yazi` varchar(255))
BEGIN
	insert into kasalt values(yazi);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for proViewMail
-- ----------------------------
DROP PROCEDURE IF EXISTS `proViewMail`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `proViewMail`()
BEGIN
	SELECT * from viewmail;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for yoklamaOgrenciDurumuEkleme
-- ----------------------------
DROP PROCEDURE IF EXISTS `yoklamaOgrenciDurumuEkleme`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `yoklamaOgrenciDurumuEkleme`(IN `ogrencid` int(11),IN `sinifi` varchar(255),IN `ogrenciadi` varchar(255),IN `ogrencisoyadi` varchar(255),IN `ogrencitc` varchar(255),IN `durumuu` varchar(255),IN `saat` datetime)
BEGIN
	insert into yoklama values (null, ogrencid, sinifi,ogrenciadi, ogrencisoyadi, ogrencitc, durumuu,saat);
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for yoklamaOgrenciGetir
-- ----------------------------
DROP PROCEDURE IF EXISTS `yoklamaOgrenciGetir`;
DELIMITER ;;
CREATE DEFINER=`root`@`%` PROCEDURE `yoklamaOgrenciGetir`(IN `aciklama` varchar(255))
BEGIN
	select *from grup left join ogrenci on grup.grupNo=ogrenci.grupNo where grup.grupNo = aciklama; 

END
;;
DELIMITER ;
