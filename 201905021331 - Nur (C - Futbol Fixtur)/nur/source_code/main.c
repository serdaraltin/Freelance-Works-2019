//kutuphaneler
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

//ayar verileri
struct ayarlar
{
    int takim_sayisi;
    int galibiyet_puan;
    int beraberlik_puan;
    int maglubiyet_puan;
}AYAR;

//takim verileri
struct takim
{
	char kisa_ad[2];
	char uzun_ad[50];
	int mac_sayisi;
	int galibiyet_sayisi;
	int beraberlik_sayisi;
	int maglubiyet_sayisi;
	int atilan_gol_sayisi;
	int yiyilen_gol_sayisi; //:D
	int averaj; //attigi yol - yedigi gol = averaj
	int puan;
};
struct takim takimlar[20];

//mac verileri
struct mac
{
	char takim1_ad[20];
		int takim1_gol;
		
	char takim2_ad[20];
		int takim2_gol;
};
struct mac maclar[50];

//prototipler
cizgi(int);
ayar_yapilandir(char[]);
ayar_isle(int,int,int,int);
takim_yapilandir(char[]);
puanisle(char[],int,int,int);
mac_yapilandir(char[]);
mac_ekle(char[]);
mac_ekle2(char[],int,char[],int);
mac_isle(char[],int,char[],int);

//string parcalama fonksiyonu prototipi
char* substring(char*, int, int);



//ana fonksiyon
int main()
{

	ana_menu();

}
//ekran temizleme
temizle()
{
	int i;
	for(i=0; i<30; i++)
		printf("\n");
}
//susleme
cizgi(int sayi)
{
	int i;
	for(i = 0; i< sayi; i++){
		printf("=");
	}
}
//ana menuye yonlendirme
yonlendirme()
{
	printf("\n\n\n1.Ana Menu\n2.Cikis\n\nSeciniz : ");
   			int sec;
			   scanf("%d",&sec);
			   switch(sec)
			   {
			   		case 1:
			   			ana_menu();
			   			break;
			   		case 2:
			   			//exit(1);
			   			break;
			   		default:
			   			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
			   			ana_menu();
			   			break;
			   }
}
//ana menu
ana_menu()
{
	
	int sec;
	printf("\n\n\n1.Varsayilan\n2.Dosyadan Aktar\n3.Elle Gir\n4.Tablolari Goruntule\n5.Cikis\n\nSeciniz : ");
	scanf("%d",&sec);
	switch(sec)
	{
		case 1: 
			temizle();
	   	    ayar_yapilandir("ayarlar.txt");
   			takim_yapilandir("takimlar.txt");
   			mac_yapilandir("maclar.txt");
   			yonlendirme();
   			break;
   		case 2:
   			dosya_menu();
   			break;
   		case 3:
   			temizle();
   			manuel_menu();
   			break;
   		case 4:
   			temizle();
   			tablo_menu();
   			break;
   		case 5:
   			return 0;
   			break;
   		default:
   			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   			ana_menu();
   			break;
	}
}
//tablo menusu
tablo_menu()
{
	printf("\n\n1.Tum tablolari goruntule\n2.Ayarlar Tablosu\n3.Takimlar Tablosu\n4.Maclar Tablosu\n5.Puan Tablosu\n6.Sirali Puan Tablosu\n7.Alfabetik Puan Tablosu\n8.Ana Menu\n\nSeciniz : ");
	int sec;
	scanf("%d",&sec);
	switch(sec)
	{
		case 1:
			temizle();
   			ayar_goruntule();
   			takim_goruntule();
   			mac_goruntule();
   			puan_goruntule();
			tablo_menu();
			break;
		case 2:
			ayar_goruntule();
			tablo_menu();
			break;
		case 3:
			takim_goruntule();
			tablo_menu();
			break;
		case 4:
			mac_goruntule();
			tablo_menu();
			break;
		case 5:
			puan_goruntule();
			tablo_menu();
			break;
		case 6:
			puan_goruntule2();
			tablo_menu();
			break;
		case 7:
			puan_goruntule3();
			tablo_menu();
			break;
		case 8:
			ana_menu();
			break;
		default:
   			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   			tablo_menu();
   			break;
	}
}
puan_tablo()
{
	//prototip
	printf("\n\n1.Normal goruntule\n");
}
//dosya menusu
dosya_menu()
{
	printf("\n\n\n1.Ayar Dosyasi ekle\n2.Takim Dosyasi ekle\n3.Mac Dosyasi Ekle\n4.Ana Menu\n\nSeciniz : ");
	int sec;
	scanf("%d",&sec);
	switch(sec)
	{
		case 1:
			printf("\n\nAyar Dosyasinin yolunu Giriniz : ");
			char dosya_ayar[100];
			scanf("%s",dosya_ayar);
			ayar_yapilandir(dosya_ayar);
			dosya_menu();
			break;
		case 2:
			printf("\n\nTakim Dosyasinin yolunu Giriniz : ");
			char dosya_takim[100];
			scanf("%s",dosya_takim);
			takim_yapilandir(dosya_takim);
			dosya_menu();
			break;
		case 3:
			printf("\n\nMac Dosyasinin yolunu Giriniz : ");
			char dosya_mac[100];
			scanf("%s",dosya_mac);
			mac_yapilandir(dosya_mac);
			dosya_menu();
			break;
		case 4:
			ana_menu();
			break;
		default:
			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   			dosya_menu();
			break;
	}
}
//manuel(elle ekleme) menusu
manuel_menu()
{

		printf("1.Ayar Yapilandirma\n2.Takim Yapilandirma\n3.Mac Yapilandirma\n4.Ana Menu\n\nSeciniz : ");
   			int sec;
			scanf("%d",&sec);
			
   			switch(sec)
   			{
   				case 1:
   					ayar_menu();
   					break;
   				case 2:
   					temizle();
   					takim_menu();
   					break;
   				case 3:
   					temizle();
   					mac_menu();
   					break;
   				case 4:
   					ana_menu();
   					break;
   				default:
   					printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   					manuel_menu();
   					break;
		    }
}
//ayar menusu
ayar_menu()
{
		temizle();
		printf("AYAR YAPILANDIRMA \n\n");
   					printf("1.Takim Sayisi\n2.Galibiyet Puan\n3.Beraberlik Puan\n4.Maglubiyet Puan\n5.Yapilandirmayi Goruntule\n6.Ana Menu\n\nSeciniz : ");
   					int ayar_sec;
   					scanf("%d",&ayar_sec);
   					switch(ayar_sec)
   					{
   						case 1:
   							printf("Takim Sayisi : ");
   							scanf("%d",&AYAR.takim_sayisi);
   							ayar_menu();
   							break;
   						case 2:
   							printf("Galibiyet Puani : ");
   							scanf("%d",&AYAR.galibiyet_puan);
   							ayar_menu();
   							break;
   						case 3:
   							printf("Beraberlik Puani : ");
   							scanf("%d",&AYAR.galibiyet_puan);
   							ayar_menu();
   							break;
   						case 4:
   							printf("Maglubiyet Puani : ");
   							scanf("%d",&AYAR.maglubiyet_puan);
   							ayar_menu();
   							break;
   						case 5:
   							ayar_goruntule();
   							ayar_menu();
   							break;
   						case 6:
   							ana_menu();
   							break;
   						default:
   							printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   							ayar_menu();
   							break;
					}
}
//ayar tablosu goruntuleme
ayar_goruntule()
{
	 printf("AYAR YAPILANDIRMASI\n=======================\n");
	 printf("Takim Sayisi\t: %d\nGalibiyet Puan\t: %d\nBeraberlik Puan\t: %d\nMaglubiyet puan\t: %d\n=======================\n\n",AYAR.takim_sayisi,AYAR.galibiyet_puan,AYAR.beraberlik_puan,AYAR.maglubiyet_puan);
}
//dosyadan ayar yapilandirma
ayar_yapilandir(char dosya[])
{
	FILE *ayar_Dosya;
    ayar_Dosya = fopen(dosya, "r");
	if(ayar_Dosya!=NULL)
	{
    // dosyayi ac:
    
    char tur[5][30];
    int girdi[5],i=0;
    while(!feof(ayar_Dosya))
	{
        fscanf(ayar_Dosya,"%s %d",&tur[i],&girdi[i]);   
        i++;
    }
    // dosyayi kapat
    fclose(ayar_Dosya);
    ayar_isle(girdi[0],girdi[1],girdi[2],girdi[3]);
    
    }
    else
	{
        printf("Ayar dosyasi bulunamadigi icin program sonlandiriliyor... \n");
        return 0;
    }
}
//ayar yapilandirma
ayar_isle(int ts, int gp, int bp, int mp)
{
    AYAR.takim_sayisi = ts;
    AYAR.galibiyet_puan = gp;
    AYAR.beraberlik_puan = bp;
    AYAR.maglubiyet_puan = mp;
    printf("\n\n\nAYAR YAPILANDIRMASI\n=======================\n");
    printf("Takim Sayisi\t: %d\nGalibiyet Puan\t: %d\nBeraberlik Puan\t: %d\nMaglubiyet puan\t: %d\n=======================\n\n",ts,gp,bp,mp);
}
//takim menusu
takim_menu()
{
	printf("1.Takim Ekle\n2.Yapilandirmayi Goruntule\n3.Ana Menu\n\nSeciniz :");
	int sec;
	scanf("%d",&sec);
	switch(sec)
	{
		case 1:
			temizle();
			int i;
			for(i=0; strlen(takimlar[i].kisa_ad) > 0 ; i++)
			{
				if(strlen(takimlar[i].kisa_ad) < 1)
					break;
			}
			printf("Yeni takim [%d] nolu siraya eklenecek !\n\n",(i+1));	
			printf("Uzun Adi Giriniz : ");
			scanf("%s",takimlar[i].uzun_ad);	
			printf("-> %s",takimlar[i].uzun_ad);
			printf("\n\nKisa Adi Giriniz : ");
			scanf("%s",takimlar[i].kisa_ad);
			
			takim_goruntule();
		   	takim_menu();
			break;	
		case 2:
			takim_goruntule();
			takim_menu();
			break;
		case 3:
			ana_menu();
			break;
		default:
   			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   			takim_menu();
   			break;
	}	
}
//puan tablosu goruntuleme
puan_goruntule()
{
	int i;
    printf("\n\n\nPUAN DURUMU TABLOSU\n");
 	cizgi(93);
    printf("\n\nNo\tAd\tUzun-Ad\t\tMac\tG-Sayi\tB-Sayi\tM-Sayi\tA-Gol\tY-Gol\tAvr\tPuan   \n\n");
    for(i = 0; strlen(takimlar[i].kisa_ad) >0 ; i++)
    {
    	printf("%d\t%s\t%s\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d  \n",
		(i+1),
		takimlar[i].kisa_ad,
		takimlar[i].uzun_ad,
		takimlar[i].mac_sayisi,
		takimlar[i].galibiyet_sayisi,
		takimlar[i].beraberlik_sayisi,
		takimlar[i].maglubiyet_sayisi,
		takimlar[i].atilan_gol_sayisi,
		takimlar[i].yiyilen_gol_sayisi,
		takimlar[i].averaj,
		takimlar[i].puan);
	}
    printf("\n");cizgi(93);printf("\n\n\n");
}
//puan tablosu goruntuleme sirali
puan_goruntule2()
{
	int i,j,gecici,sinir,gecici2;
	
    printf("\n\n\nPUAN DURUMU TABLOSU SIRALI\n");
 	cizgi(93);
    printf("\n\nNo\tAd\tUzun-Ad\t\tMac\tG-Sayi\tB-Sayi\tM-Sayi\tA-Gol\tY-Gol\tAvr\tPuan   \n\n");
    

  	int dizi[20],normal_dizi[20];

    for(i = 0; strlen(takimlar[i].kisa_ad) >0 ; i++)
    {
    	dizi[i] = takimlar[i].puan;
    	normal_dizi[i] = i;
		sinir = i+1;
	}

	//sort algoritmasi ile buyukten kucuge siralama
	for(i=0; i<sinir; i++){
        for(j=0; j<sinir-1-i; j++){
            if(dizi[j]< dizi[j+1]){
                gecici = dizi[j];
                gecici2 = normal_dizi[j];
              
                dizi[j] = dizi[j+1];
                normal_dizi[j] = normal_dizi[j+1];
              
                dizi[j+1] = gecici;
                normal_dizi[j+1] = gecici2;
                
            }
        }
    }
    
    /*for(i = 0; i < sinir; i++)
    	printf("%d\t%d\n", normal_dizi[i],dizi[i]);*/

	for(i = 0; i < sinir; i++)
    {
    		printf("%d\t%s\t%s\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d  \n",
			(i+1),
			takimlar[normal_dizi[i]].kisa_ad,
			takimlar[normal_dizi[i]].uzun_ad,
			takimlar[normal_dizi[i]].mac_sayisi,
			takimlar[normal_dizi[i]].galibiyet_sayisi,
			takimlar[normal_dizi[i]].beraberlik_sayisi,
			takimlar[normal_dizi[i]].maglubiyet_sayisi,
			takimlar[normal_dizi[i]].atilan_gol_sayisi,
			takimlar[normal_dizi[i]].yiyilen_gol_sayisi,
			takimlar[normal_dizi[i]].averaj,
			takimlar[normal_dizi[i]].puan);	
		
	
	}


    printf("\n");cizgi(93);printf("\n\n\n");
}
//puan tablosu goruntuleme alfabetik
puan_goruntule3()
{
	
struct harf
{
	char kisa_ad[2];
};
struct harf harfler[20];
	
	
	int i,j,gecici,sinir,gecici2;
	
    printf("\n\n\nPUAN DURUMU TABLOSU ALFABETIK\n");
 	cizgi(93);
    printf("\n\nNo\tAd\tUzun-Ad\t\tMac\tG-Sayi\tB-Sayi\tM-Sayi\tA-Gol\tY-Gol\tAvr\tPuan   \n\n");
    

  	int normal_dizi[20];
  	

    for(i = 0; strlen(takimlar[i].kisa_ad) >0 ; i++)
    {
    	
    	//substring(takimlar[i].kisa_ad,1,1);
    	strcpy(harfler[i].kisa_ad,substring(takimlar[i].kisa_ad,1,1));
    	//harfler[i] = substring(takimlar[i].kisa_ad,1,1);
    	normal_dizi[i] = i;
    	
    	//printf("%s\n",harfler[i].kisa_ad);
    	
		sinir = i+1;
	}

    	
//sort algoritmasi ile buyukten kucuge siralama
	for(i=0; i<sinir; i++){
        for(j=0; j<sinir-1-i; j++){
		  if(strcmp(harfler[j].kisa_ad ,harfler[j+1].kisa_ad)>0)
		  {
			    char temp[2];
                strcpy(temp, harfler[j].kisa_ad);
				strcpy(harfler[j].kisa_ad, harfler[j+1].kisa_ad);
				strcpy( harfler[j+1].kisa_ad, temp);
                
                
                gecici2 = normal_dizi[j];
              	normal_dizi[j] = normal_dizi[j+1];
                normal_dizi[j+1] = gecici2;
            }
        }
    }
    
    /*for(i = 0; i < sinir; i++)
    	printf("%d\t%s\n", normal_dizi[i],harfler[i].kisa_ad);*/
    	
    	
    	
	for(i = 0; i < sinir; i++)
    {
    		printf("%d\t%s\t%s\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d  \n",
			(i+1),
			takimlar[normal_dizi[i]].kisa_ad,
			takimlar[normal_dizi[i]].uzun_ad,
			takimlar[normal_dizi[i]].mac_sayisi,
			takimlar[normal_dizi[i]].galibiyet_sayisi,
			takimlar[normal_dizi[i]].beraberlik_sayisi,
			takimlar[normal_dizi[i]].maglubiyet_sayisi,
			takimlar[normal_dizi[i]].atilan_gol_sayisi,
			takimlar[normal_dizi[i]].yiyilen_gol_sayisi,
			takimlar[normal_dizi[i]].averaj,
			takimlar[normal_dizi[i]].puan);	
		
	
	}

	

    printf("\n");cizgi(93);printf("\n\n\n");
}
//takim tablosu goruntuleme
takim_goruntule()
{
	int i;
    printf("\n\n\nTAKIM YAPILANDIRMASI\n");
 	cizgi(20);
    printf("\n\nNo\tAd\tUzun-Ad\n\n");
    for(i = 0; strlen(takimlar[i].kisa_ad) >0 ; i++)
    {
    	printf("%d\t%s\t%s\n",
		(i+1),takimlar[i].kisa_ad,takimlar[i].uzun_ad);
	}
    printf("\n");cizgi(20);printf("\n\n\n");
}
//dosyadan takim yapilandirma
takim_yapilandir(char dosya[])
{
	FILE *takim_Dosya;
    takim_Dosya = fopen(dosya, "r");
	if(takim_Dosya!=NULL)
	{
    // dosyayi ac:
    
    int i=0;
    printf("\n\nTAKIM YAPILANDIRMASI\n============================\n");
    while(!feof(takim_Dosya))
	{
        fscanf(takim_Dosya,"%s %s",takimlar[i].kisa_ad,takimlar[i].uzun_ad);  	 
        printf("%d\t%s\t%s\n",(i+1),takimlar[i].kisa_ad,takimlar[i].uzun_ad);
        i++;
    }

    
   	 printf("============================\n\n");
 
    // dosyayi kapat
    fclose(takim_Dosya);

    }
    else
	{
        printf("Takim dosyasi bulunamadigi icin program sonlandiriliyor... \n\n");
        return 0;
    }
    
}
//mac menusu
mac_menu()
{
	printf("\n\n\n1.Mac Ekle\n2.Yapilandirmayi Goruntule\n3.Ana Menu\n\nSeciniz : ");
	int sec;
	scanf("%d",&sec);
	switch(sec)
	{
		case 1:
			temizle();		
			printf("Mac Sonucu [takim1 kisa_ad] [gol] [takim2] [gol] seklinde olmalidir !\nOrnek : A 3 B 1\n\nGiriniz : ");
			char girdi[10]; 
		
			scanf("%s",&girdi);
			mac_ekle(girdi);
			mac_menu();
			break;
		case 2:
			mac_goruntule();
			mac_menu();
			break;
		case 3:
			ana_menu();
		break;
		default:
			printf("Yanlis bir deger girdiniz. Tekrar deneyin.");
   			mac_menu();
   			break;
	}
}
//mac verisi ekleme
mac_ekle(char girdi[])
{
		char girdi_islm[4];
	
		girdi_islm[0] = girdi[0];
		gets(girdi);
		int len=strlen(girdi);
		int i,j;
		for(i=0; i<len; i++){
			if(girdi[i]==' '){
				for(j=i; j<len; j++)
					girdi[j]=girdi[j+1];
				len--;
			}
		}
		girdi_islm[1] = girdi[0];
		girdi_islm[2] = girdi[1];
		girdi_islm[3] = girdi[2];
			
		char *takim1_ad = substring(girdi_islm,1,1);
		char *s_takim1_gol = substring(girdi_islm,2,1);
		int takim1_gol = (int)strtol(s_takim1_gol, (char **)NULL, 10);
			
		char *takim2_ad = substring(girdi_islm,3,1);
		char *s_takim2_gol = substring(girdi_islm,4,1);
		int takim2_gol = (int)strtol(s_takim2_gol, (char **)NULL, 10);
			int l;
			//printf("%s\t%d\t%s\t%d\n",takim1_ad,takim1_gol,takim2_ad,takim2_gol);
			for(l = 0; strlen(maclar[l].takim1_ad) > 0; l++)
			{
				if(strcmp(maclar[l].takim1_ad,takim1_ad) == 0 && strcmp(maclar[l].takim2_ad,takim2_ad) == 0)
				{
					printf("\n\nAyni mac yapildigi icin tekrar yapilamaz !\n\n");
					mac_menu();
				}
			}
		
			strcpy(maclar[l].takim1_ad,takim1_ad);
			maclar[l].takim1_gol = takim1_gol;
			strcpy(maclar[l].takim2_ad,takim2_ad);
			maclar[l].takim2_gol = takim2_gol;
			
				
	    int var = 0;
	    int k;
	    for(k=0; strlen(takimlar[k].kisa_ad) >0; k++)
	    { 
	    	int puan;
	    	if(strcmp(takimlar[k].kisa_ad,takim1_ad) == 0)
			{
				
				//takimlar[k].atilan_gol_sayisi += takim1_gol;
				if(takim1_gol > takim2_gol)
					puan = AYAR.galibiyet_puan;
				else if(takim1_gol == takim2_gol)
					puan = AYAR.beraberlik_puan;
				else				
	    			puan = AYAR.maglubiyet_puan;
	    		puan_isle(takim1_ad,takim1_gol,takim2_gol,puan);
	        	//takim_isle(takimlar[k].kisa_ad,takim1_gol,1);
	    		//printf("%s \t %d\n",takimlar[k].uzun_ad,takimlar[k].atilan_gol_sayisi);
	    		var = 1;
			}
			else if(strcmp(takimlar[k].kisa_ad,takim2_ad) == 0)
			{
				//takimlar[k].atilan_gol_sayisi += takim2_gol;
				if(takim2_gol > takim1_gol)
					puan = AYAR.galibiyet_puan;
				else if(takim2_gol == takim1_gol)
					puan = AYAR.beraberlik_puan;
				else				
	    			puan = AYAR.maglubiyet_puan;
	    		puan_isle(takim2_ad,takim2_gol,takim1_gol,puan);
				//printf("%s \t %d\n",takimlar[k].uzun_ad,takimlar[k].atilan_gol_sayisi);
				var = 1;
			}
			//if(var == 1)
				//	mac_isle(takim1_ad,takim1_gol,takim2_ad,takim2_gol);
	    	
		}
		if(var == 0)
		{
			printf("\nMac verisine uygun takim bulunamadi !\n");
			mac_menu();
		}
		else
		{
		 	mac_goruntule();
		}
}
//mac verisi ekleme
mac_ekle2(char takim1_ad[2],int takim1_gol,char takim2_ad[2],int takim2_gol)
{
	
	    int var = 0;
	    int k;
	    for(k=0; strlen(takimlar[k].kisa_ad) >0; k++)
	    { 
	    	int puan;
	    	if(strcmp(takimlar[k].kisa_ad,takim1_ad) == 0)
			{
				
				//takimlar[k].atilan_gol_sayisi += takim1_gol;
				if(takim1_gol > takim2_gol)
					puan = AYAR.galibiyet_puan;
				else if(takim1_gol == takim2_gol)
					puan = AYAR.beraberlik_puan;
				else				
	    			puan = AYAR.maglubiyet_puan;
	    		puan_isle(takim1_ad,takim1_gol,takim2_gol,puan);
	        	//takim_isle(takimlar[k].kisa_ad,takim1_gol,1);
	    		//printf("%s \t %d\n",takimlar[k].uzun_ad,takimlar[k].atilan_gol_sayisi);
	    		var = 1;
			}
			else if(strcmp(takimlar[k].kisa_ad,takim2_ad) == 0)
			{
				//takimlar[k].atilan_gol_sayisi += takim2_gol;
				if(takim2_gol > takim1_gol)
					puan = AYAR.galibiyet_puan;
				else if(takim2_gol == takim1_gol)
					puan = AYAR.beraberlik_puan;
				else				
	    			puan = AYAR.maglubiyet_puan;
	    		puan_isle(takim2_ad,takim2_gol,takim1_gol,puan);
				//printf("%s \t %d\n",takimlar[k].uzun_ad,takimlar[k].atilan_gol_sayisi);
				var = 1;
			}
			//if(var == 1)
				//	mac_isle(takim1_ad,takim1_gol,takim2_ad,takim2_gol);
	    	
		}
		if(var == 0)
		{
			printf("\nMac verisine uygun takim bulunamadi !\n");
		}
		else
		{
		 	//mac_goruntule();
		}
}
//mac verisinin dosyadan alinmasi
mac_yapilandir(char dosya[])
{
   	FILE *mac_Dosya;
    mac_Dosya = fopen(dosya, "r");
	if(mac_Dosya!=NULL)
	{
    // dosyayi ac:
    
    int i=0;
    printf("\n\nMAC YAPILANDIRMASI\n===============\n");
    while(!feof(mac_Dosya))
	{
        fscanf(mac_Dosya,"%s %d %s %d",maclar[i].takim1_ad,&maclar[i].takim1_gol,maclar[i].takim2_ad,&maclar[i].takim2_gol);  
		
		printf("%s   %d - %d   %s\n",maclar[i].takim1_ad,maclar[i].takim1_gol,maclar[i].takim2_gol,maclar[i].takim2_ad);
		//mac_ekle(girdi);
			mac_ekle2(maclar[i].takim1_ad,maclar[i].takim1_gol,maclar[i].takim2_ad,maclar[i].takim2_gol);
        i++;
    }
    /*int len = sizeof(takimlar) / sizeof(takimlar[0]);
    strcat(takimlar[len].kisa_ad,"");
    strcat(takimlar[len].uzun_ad,"");*/
    
   	 printf("===============\n\n");
 
 	
    // dosyayi kapat
    fclose(mac_Dosya);

    }
    else
	{
        printf("Mac dosyasi bulunamadigi icin program sonlandiriliyor... \n\n");
        return 0;
    }
}
//mac tablosunu goruntuleme
mac_goruntule()
{
	int i;
    printf("\n\nMAC YAPILANDIRMASI\n===============\n");
    for(i = 0; strlen(maclar[i].takim1_ad) >0 ; i++)
    {
    	printf("%s   %d - %d   %s\n",maclar[i].takim1_ad,maclar[i].takim1_gol,maclar[i].takim2_gol,maclar[i].takim2_ad);
	}
    printf("===============\n\n");
}
//girilen mac verisinin tabloya islenmesi
mac_isle(char t1_ad[],int t1_gol,char t2_ad[],int t2_gol)
{
	//beynin suyu kayniyinca ne yaptigini bilmiyor insan
	int i;
	for(i = 0; strlen(maclar[i].takim1_ad) > 0; i ++)
	{
		if(strcmp(maclar[i].takim1_ad,t1_ad) == 0)
		{
			maclar[i].takim1_gol += t1_gol;
		}
	}
	int j;
	for(j = 0; strlen(maclar[j].takim2_ad) > 0; j++)
	{
		if(strcmp(maclar[j].takim2_ad,t1_ad) == 0)
		{
			maclar[j].takim2_gol += t2_gol;
		}
	}
}
//mac sonrasi puanlarin tabloya islenmesi
puan_isle(char kisa_ad[2],int atilan_gol,int yiyilen_gol,int puan)
{
	int i;
	for(i = 0; strlen(takimlar[i].kisa_ad) > 0; i++)
	{
		if(strcmp(takimlar[i].kisa_ad, kisa_ad) == 0 )
		{
			takimlar[i].mac_sayisi += 1;
			takimlar[i].atilan_gol_sayisi += atilan_gol;
			takimlar[i].yiyilen_gol_sayisi += yiyilen_gol;
			takimlar[i].puan += puan;
			takimlar[i].averaj = takimlar[i].atilan_gol_sayisi - takimlar[i].yiyilen_gol_sayisi;
			if(puan == AYAR.galibiyet_puan)
					takimlar[i].galibiyet_sayisi  += 1;
			else if(puan == AYAR.beraberlik_puan)
					takimlar[i].beraberlik_sayisi += 1;
			else if(puan == AYAR.maglubiyet_puan)
					takimlar[i].maglubiyet_sayisi += 1;

		}
		
	}
}

//string parcalama fonksiyonu
char *substring(char *string, int position, int length)
{
   char *pointer;
   int c;
 
   pointer = malloc(length+1);
   
   if (pointer == NULL)
   {
      printf("Unable to allocate memory.\n");
      exit(1);
   }
 
   for (c = 0 ; c < length ; c++)
   {
      *(pointer+c) = *(string+position-1);      
      string++;  
   }
 
   *(pointer+c) = '\0';
 
   return pointer;
}


