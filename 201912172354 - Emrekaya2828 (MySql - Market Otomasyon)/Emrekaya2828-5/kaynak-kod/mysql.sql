USE `EnesBurak`;
 
/****** Object:  StoredProcedure [dbo].[EnCokSatanlar]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure EnCokSatanlar()
Begin
	select UrunId,
	COUNT(UrunId) as sayi
	from SIPARIS group by
    UrunId having 
	Count (UrunId) > 1;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriEkle
(
p_UstKategori int,
p_Ad varchar(250)
)
Begin
	Insert Into KATEGORI (UstKategori,Ad) Values(p_UstKategori,p_Ad);
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriGetirAd]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriGetirAd
(
p_Id int
)
Begin
	Select *From KATEGORI Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriGetirId
(
p_Ad varchar(250)
)
Begin
	Select *From KATEGORI Where Ad=p_Ad;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriGuncelle
(
p_Id int,
p_UstKategori int,
p_Ad varchar(250)
)
Begin
	Update KATEGORI set
	UstKategori=p_UstKategori, Ad=p_Ad
	Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriKontrol
(
p_Ad varchar(250)
)
Begin
	Select *From KATEGORI Where Ad=p_Ad;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriListele]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriListele()
Begin
	Select *From KATEGORI;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KategoriSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KategoriSil
(
p_Id int
)
Begin
	Delete KATEGORI Where Id=p_Id
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciEkle
(
p_MusteriId int,
p_KullaniciAd varchar(250),
p_Sifre varchar(250)
)
Begin
	Insert Into KULLANICI (MusteriId,KullaniciAd,Sifre)
	Values (p_MusteriId,p_KullaniciAd,p_Sifre);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciGetirAd]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciGetirAd
(
p_Id int
)
Begin
	Select *From KULLANICI Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciGetirId
(
p_KullaniciAd varchar(250)
)
Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciGetirMusteriId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciGetirMusteriId
(
p_Id int
)
Begin
	Select *From KULLANICI Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciGuncelle
(
p_Id int,
p_MusteriId int,
p_KullaniciAd varchar(250),
p_Sifre varchar(250)
)
Begin
	Update KULLANICI set 
	MusteriId=p_MusteriId, KullaniciAd=p_KullaniciAd, Sifre=p_Sifre
	Where Id=p_Id;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciGuncelleHesap]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciGuncelleHesap
(
p_Id int,
p_Sifre varchar(250)
)
Begin
	Update KULLANICI set
	Sifre=p_Sifre Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciKayitKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciKayitKontrol
(
p_KullaniciAd varchar(250)
)
Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciKontrol
(
p_KullaniciAd varchar(250),
p_Sifre varchar(250)
)
Begin
	Select *From KULLANICI Where KullaniciAd=p_KullaniciAd and Sifre=p_Sifre;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[KullaniciSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure KullaniciSil
(
p_Id int
)
Begin
	Delete KULLANICI Where Id=p_Id
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaEkle
(
p_Ad varchar(250)
)
Begin
	Insert Into MARKA (Ad) Values(p_Ad);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaGetirAd]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaGetirAd
(
p_Id int
)
Begin
	Select *From MARKA Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaGetirId
(
p_Ad varchar(250)
)
Begin
	Select *From MARKA Where Ad=p_Ad;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaGuncelle
(
p_Id int,
p_Ad varchar(250)
)
Begin
	Update MARKA set
	Ad=p_Ad
	Where Id=p_Id;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaListele]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaListele()
Begin
	Select *From MARKA;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MarkaSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MarkaSil
(
p_Id int
)
Begin
	Delete MARKA Where Id=p_Id
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MusteriEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MusteriEkle
(
p_Ad varchar(250),
p_Soyad varchar(250),
p_Cinsiyet varchar(50),
p_Yas int,
p_TelefonNo varchar(250),
p_Eposta varchar(250)
)
Begin
	Insert Into MUSTERI (Ad,Soyad,Cinsiyet,Yas,TelefonNo,Eposta)
	Values (p_Ad,p_Soyad,p_Cinsiyet,p_Yas,p_TelefonNo,p_Eposta);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MusteriGetirAd]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MusteriGetirAd
(
p_Id int
)
Begin
	Select *From MUSTERI Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MusteriGetirHesap]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MusteriGetirHesap
(
p_Id int
)
Begin
	Select *From MUSTERI Where	Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MusteriGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MusteriGetirId
(
p_Ad varchar(250),
p_Soyad varchar(250),
p_TelefonNo varchar(250),
p_Eposta varchar(250)
)
Begin
	Select *From MUSTERI Where Ad=p_Ad and Soyad=p_Soyad and TelefonNo=p_TelefonNo and Eposta=p_Eposta;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[MusteriGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure MusteriGuncelle
(
p_Id int,
p_Ad varchar(250),
p_Soyad varchar(250),
p_Cinsiyet varchar(50),
p_Yas int,
p_TelefonNo varchar(250),
p_Eposta varchar(250)
)
Begin
	Update MUSTERI set
	Ad=p_Ad, Soyad=p_Soyad, Cinsiyet=p_Cinsiyet, Yas=p_Yas, TelefonNo=p_TelefonNo, Eposta=p_Eposta
	Where Id=p_Id;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetAdetGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetAdetGuncelle
(
p_Id int,
p_Adet int
)
Begin
	Update SEPET set
	Adet=p_Adet Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetEkle
(
p_KullaniciId int,
p_UrunId int,
p_Adet int
)
Begin
	Insert Into SEPET
	(KullaniciId,UrunId,Adet)
	Values (p_KullaniciId,p_UrunId,p_Adet);
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetGetirAdet]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetGetirAdet
(
p_KullaniciId int,
p_UrunId int
)
Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId and UrunId=p_UrunId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetGetirId
(
p_KullaniciId int,
p_UrunId int
)
Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId and UrunId=p_UrunId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetGuncelle
(
p_Id int,
p_UrunId int,
p_Adet int
)
Begin
	Update SEPET set
	UrunId=p_UrunId, Adet=p_Adet
	Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetKontrol
(
p_Id int
)
Begin
	Select *From SEPET Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetListele]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetListele
(
p_KullaniciId int
)
Begin
	Select *From SEPET Where KullaniciId=p_KullaniciId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SepetSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SepetSil
(
p_Id int
)
Begin
	Delete SEPET Where Id=p_Id
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SiparisEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SiparisEkle
(
p_KullaniciId int,
p_UrunId int,
p_Adet int,
p_Tarih datetime(3)
)
Begin
	Insert Into SIPARIS
	(KullaniciId,UrunId,Adet,Tarih)
	Values (p_KullaniciId,p_UrunId,p_Adet,p_Tarih);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SiparisGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SiparisGuncelle
(
p_Id int,
p_KullaniciId int,
p_UrunId int,
p_Adet int,
p_Tarih datetime(3)
)
Begin
	Update SIPARIS set
	KullaniciId=p_KullaniciId, UrunId=p_UrunId, Adet=p_Adet, Tarih=p_Tarih
	Where Id=p_Id;	
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SiparisListele]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SiparisListele()
Begin
	Select *From SIPARIS;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[SiparisSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure SiparisSil
(
p_Id int
)
Begin
	Delete SIPARIS Where Id=p_Id	
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[StokEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure StokEkle
(
p_UrunId int,
p_Adet int
)
Begin
	Insert Into STOK
	(UrunId,Adet)
	Values (p_UrunId,p_Adet);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[StokGetirAdet]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure StokGetirAdet
(
p_UrunId int
)
Begin
	Select *From STOK Where	UrunId=p_UrunId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[StokGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure StokGuncelle
(
p_Id int,
p_UrunId int,
p_Adet int
)
Begin
	Update STOK set
	UrunId=p_UrunId, Adet=p_Adet
	Where Id=p_Adet;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[StokSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure StokSil
(
p_Id int
)
Begin
	Delete STOK Where Id=p_Id
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunEkle
(
p_KategoriId int,
p_MarkaId int,
p_Miktar double,
p_Olcu varchar(250),
p_Ad varchar(250),
p_Fiyat double,
p_Aciklama longtext
)
Begin
	Insert Into URUN
	(KategoriId,MarkaId,Miktar,Olcu,Ad,Fiyat,Aciklama)
	Values (p_KategoriId,p_MarkaId,p_Miktar,p_Olcu,p_Ad,p_Fiyat,p_Aciklama);
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunGetirAd]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunGetirAd
(
p_Id int
)
Begin
	Select *From URUN Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunGetirBilgi]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunGetirBilgi
(
p_Id int
)
Begin
	Select *From URUN Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunGetirId
(
p_Ad varchar(250)
)
Begin
	Select *From URUN Where Ad=p_Ad;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunGetirOlcu]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunGetirOlcu
(
p_Id int
)
Begin
	Select *From URUN Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunGuncelle
(
p_Id int,
p_KategoriId int,
p_MarkaId int,
p_Miktar double,
p_Olcu varchar(250),
p_Ad varchar(250),
p_Fiyat double,
p_Aciklama longtext
)
Begin
	Update URUN set
	KategoriId=p_KategoriId, MarkaId=p_MarkaId, Miktar=p_Miktar, Olcu=p_Olcu, Ad=p_Ad, Fiyat=p_Fiyat, Aciklama=p_Aciklama
	Where Id=p_Id;
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunKontrol
(
p_Ad varchar(250)
)
Begin
	Select *From URUN Where Ad=p_Ad;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunMiktarListele]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunMiktarListele()
Begin
	Select *From URUN;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[UrunSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure UrunSil
(
p_Id int
)
Begin
	Delete URUN Where Id=p_Id
End;

//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[YoneticiEkle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure YoneticiEkle
(
p_KullaniciId int
)
Begin
	Insert Into YONETICI (KullaniciId) Values(p_KullaniciId);
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[YoneticiGetirId]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure YoneticiGetirId
(
p_KullaniciId int
)
Begin
	Select *From YONETICI Where KullaniciId=p_KullaniciId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[YoneticiGuncelle]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure YoneticiGuncelle
(
p_Id int,
p_KullaniciId int
)
Begin
	Update YONETICI set
	KullaniciId=p_KullaniciId Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[YoneticiKontrol]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure YoneticiKontrol
(
p_KullaniciId int
)
Begin
	Select *From YONETICI Where KullaniciId=p_KullaniciId;
End;
//

DELIMITER ;


/****** Object:  StoredProcedure [dbo].[YoneticiSil]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
Delimiter //

Create Procedure YoneticiSil
(
p_Id int
)
Begin
	Select *From YONETICI Where Id=p_Id;
End;
//

DELIMITER ;


/****** Object:  Table [dbo].[KATEGORI]    Script Date: 13.06.2019 21:36:48 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
/* SET ANSI_PADDING ON */
 
CREATE TABLE KATEGORI(
	`Id` int AUTO_INCREMENT NOT NULL,
	`UstKategori` int NOT NULL,
	`Ad` varchar(250) NULL,
 CONSTRAINT `PK_KATEGORI` PRIMARY KEY 
(
	`Id` ASC
) 
);

/* SET ANSI_PADDING OFF */
 
/****** Object:  Table [dbo].[KULLANICI]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
/* SET ANSI_PADDING ON */
 
CREATE TABLE KULLANICI(
	`Id` int AUTO_INCREMENT NOT NULL,
	`MusteriId` int NULL,
	`KullaniciAd` varchar(250) NULL,
	`Sifre` varchar(250) NULL,
 CONSTRAINT `PK_KULLANICI` PRIMARY KEY 
(
	`Id` ASC
) 
);

/* SET ANSI_PADDING OFF */
 
/****** Object:  Table [dbo].[MARKA]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
/* SET ANSI_PADDING ON */
 
CREATE TABLE MARKA(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Ad` varchar(250) NULL,
 CONSTRAINT `PK_MARKA` PRIMARY KEY 
(
	`Id` ASC
) 
);

/* SET ANSI_PADDING OFF */
 
/****** Object:  Table [dbo].[MUSTERI]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
/* SET ANSI_PADDING ON */
 
CREATE TABLE MUSTERI(
	`Id` int AUTO_INCREMENT NOT NULL,
	`Ad` varchar(250) NULL,
	`Soyad` varchar(250) NULL,
	`Cinsiyet` varchar(50) NULL,
	`Yas` int NULL,
	`TelefonNo` varchar(250) NULL,
	`Eposta` varchar(250) NULL,
 CONSTRAINT `PK_MUSTERI` PRIMARY KEY 
(
	`Id` ASC
) 
);

/* SET ANSI_PADDING OFF */
 
/****** Object:  Table [dbo].[SEPET]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE SEPET(
	`Id` int AUTO_INCREMENT NOT NULL,
	`KullaniciId` int NULL,
	`UrunId` int NULL,
	`Adet` int NULL,
 CONSTRAINT `PK_SEPET` PRIMARY KEY 
(
	`Id` ASC
) 
);

/****** Object:  Table [dbo].[SIPARIS]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE SIPARIS(
	`Id` int AUTO_INCREMENT NOT NULL,
	`KullaniciId` int NULL,
	`UrunId` int NULL,
	`Adet` int NULL,
	`Tarih` datetime(3) NULL,
 CONSTRAINT `PK_SIPARIS` PRIMARY KEY 
(
	`Id` ASC
) 
);

/****** Object:  Table [dbo].[STOK]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE STOK(
	`Id` int AUTO_INCREMENT NOT NULL,
	`UrunId` int NULL,
	`Adet` int NULL,
 CONSTRAINT `PK_STOK` PRIMARY KEY 
(
	`Id` ASC
) 
);

/****** Object:  Table [dbo].[URUN]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
/* SET ANSI_PADDING ON */
 
CREATE TABLE URUN(
	`Id` int AUTO_INCREMENT NOT NULL,
	`KategoriId` int NULL,
	`MarkaId` int NULL,
	`Miktar` varchar(250) NULL,
	`Olcu` varchar(250) NULL,
	`Ad` varchar(250) NULL,
	`Fiyat` Double NULL,
	`Aciklama` Longtext NULL,
 CONSTRAINT `PK_URUN` PRIMARY KEY 
(
	`Id` ASC
) 
); TEXTIMAGE_ON `PRIMARY`

GO
/* SET ANSI_PADDING OFF */
 
/****** Object:  Table [dbo].[YONETICI]    Script Date: 13.06.2019 21:36:49 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE YONETICI(
	`Id` int AUTO_INCREMENT NOT NULL,
	`KullaniciId` int NULL,
 CONSTRAINT `PK_YONETICI` PRIMARY KEY 
(
	`Id` ASC
) 
);

ALTER TABLE `dbo`.`KATEGORI` ADD  CONSTRAINT `DF_KATEGORI_UstKategori`  DEFAULT ((0)) FOR `UstKategori`
GO
ALTER TABLE `dbo`.`KULLANICI`  WITH CHECK ADD  CONSTRAINT `FK_KULLANICI_MUSTERI` FOREIGN KEY(`MusteriId`)
REFERENCES [dbo].[MUSTERI] (`Id`)
ON DELETE CASCADE
GO
ALTER TABLE `dbo`.`KULLANICI` CHECK CONSTRAINT `FK_KULLANICI_MUSTERI`
GO
ALTER TABLE `dbo`.`SIPARIS`  WITH CHECK ADD  CONSTRAINT `FK_SIPARIS_KULLANICI` FOREIGN KEY(`KullaniciId`)
REFERENCES [dbo].[KULLANICI] (`Id`)
ON DELETE CASCADE
GO
ALTER TABLE `dbo`.`SIPARIS` CHECK CONSTRAINT `FK_SIPARIS_KULLANICI`
GO
ALTER TABLE `dbo`.`SIPARIS`  WITH CHECK ADD  CONSTRAINT `FK_SIPARIS_URUN` FOREIGN KEY(`UrunId`)
REFERENCES [dbo].[URUN] (`Id`)
GO
ALTER TABLE `dbo`.`SIPARIS` CHECK CONSTRAINT `FK_SIPARIS_URUN`
GO
ALTER TABLE `dbo`.`STOK`  WITH CHECK ADD  CONSTRAINT `FK_STOK_URUN` FOREIGN KEY(`UrunId`)
REFERENCES [dbo].[URUN] (`Id`)
ON DELETE CASCADE
GO
ALTER TABLE `dbo`.`STOK` CHECK CONSTRAINT `FK_STOK_URUN`
GO
ALTER TABLE `dbo`.`URUN`  WITH CHECK ADD  CONSTRAINT `FK_URUN_KATEGORI` FOREIGN KEY(`KategoriId`)
REFERENCES [dbo].[KATEGORI] (`Id`)
ON DELETE CASCADE
GO
ALTER TABLE `dbo`.`URUN` CHECK CONSTRAINT `FK_URUN_KATEGORI`
GO
ALTER TABLE `dbo`.`URUN`  WITH CHECK ADD  CONSTRAINT `FK_URUN_MARKA` FOREIGN KEY(`MarkaId`)
REFERENCES [dbo].[MARKA] (`Id`)
ON DELETE CASCADE
GO
ALTER TABLE `dbo`.`URUN` CHECK CONSTRAINT `FK_URUN_MARKA`
GO
