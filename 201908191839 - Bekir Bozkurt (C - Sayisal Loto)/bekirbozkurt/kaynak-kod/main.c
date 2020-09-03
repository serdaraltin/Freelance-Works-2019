#include <stdio.h>
#include <time.h>
#include <stdlib.h>

//degiskenler
char kolonHarfler[10];
int kupon[10][49];
int sonuc[6];
int kolonSayi,numara;

//fonksiyon prototipleri
void loto();
void oyun();
void karsilastirma();
int ciftKontrol(int);
int tekKontrol(int);
int asalKontrol(int);
int ardisikKontrol(int,int);
void yazdir();
void sirala();
void doldur();

int main()
{

    loto();
    oyun();
    karsilastirma();
}

void loto()
{
    int i,j;
    for(i=0; i<8; i++)
    {
        for(j=0; j<49; j++)
        {
            kupon[i][j] = 0;
        }
    }

    int topNo,kontrol = 0;
    
    srand(time(NULL));
    
    for(i=0; i<6; i++)
    {
    	topNo=rand() % 49 + 1;
        for(j=0; j<i; j++)
        {
        	if(topNo == sonuc[j]) 
			{
            	kontrol = 1;
				break;
            }
        }
        
        if(kontrol)
        {
         	i--;
        }
    	else
    	{
       		sonuc[i] = topNo;
        	kontrol = 0;
    	}
    }
}

void oyun()
{
	giris:
    printf("Lutfen kolon sayisini giriniz : ");
    scanf("%d",&kolonSayi);
    if(kolonSayi > 8 || kolonSayi < 1)
    {
    	printf("!!! Kolon sayisi 1 ile 8 arasinda olmalidir !!!\n");
    	goto giris;
	}
	printf("\n");
	
	int i;
	for(i=0; i<kolonSayi; i++)
    {
        kolonHarfler[i] = i+65;
    }
    
	doldur();
}

void doldur()
{
	int i,j,k,kontrol = 0;
	
	int cift = 0,tek = 0,asal = 0,ardisik = 0,
	bir_dokuz = 0, on_ondokuz = 0, yirmi_yirmidokuz = 0, otuz_otuzdokuz = 0, kirk_kirkdokuz = 0;
  
 
    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<6; j++)
        {
          	numara = rand() % 49 + 1;
          	
            if(numara > 0 && numara < 50)
            {
                for(k=0; k<j; k++)
                {
					if(ciftKontrol(numara))
    					cift++;
    				if(tekKontrol(numara))
    					tek++;
    				if(asalKontrol(numara))
    					asal++;
    				if(ardisikKontrol(sonuc[j-1],numara))
						ardisik++;
					if(numara > 0 && numara < 10)
						bir_dokuz++;
					if(numara > 9 && numara < 20)
						on_ondokuz++;
					if(numara > 19 && numara < 30)
						yirmi_yirmidokuz++;
					if(numara > 29 && numara < 40)
						otuz_otuzdokuz++;
					if(numara > 39 && numara < 50)
						kirk_kirkdokuz++;
					
					if(kupon[i][numara] || cift == 4 || asal < 1 || asal == 3 || ardisik == 1 || bir_dokuz == 2 || on_ondokuz == 2 || yirmi_yirmidokuz == 2 || otuz_otuzdokuz == 2 || kirk_kirkdokuz == 2)
					{
						kontrol = 1;
						break;
					}
                }
                if(kontrol)
                {
                    j--;
                }
                else
                {
                    kupon[i][numara] = 1;
                }
                kontrol = 0;
            }
            else
            {
                j--;
                
            }
        }
    }
}

void karsilastirma()
{
    int i,j,say = 0,kontrol = 0;
    sirala();

    printf("Kuponunuz : \n\n");

    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<49; j++)
        {
            if(kupon[i][j])
            {
                printf("%d \t",j); 
            } 
			if(j == 48)
			{
				printf("\n");
			}
        }
  	
    }
    printf("\nKazanan numaralar : \n\n");
    for(i=0; i<6; i++)
    {
        printf("%d \t",sonuc[i]);
    }
	printf("\n");
    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<6; j++)
        {
            if(kupon[i][sonuc[j]])
            {
                say++;
            }
        }
        printf("\n%c > kuponunda dogru adet : %d",kolonHarfler[i],say);
    }
    yazdir();
}

int ciftKontrol(int sayi)
{
	if(sayi % 2 == 0)
		return 1;
	return 0;
}

int tekKontrol(int sayi)
{
	if(sayi % 2 != 0)
		return 1;
	return 0;
}

int asalKontrol(int sayi)
{
	int i,sayac = 0;
	for(i=2; i<sayi; i++)
	{
		if(sayi % i == 0)
			sayac++;
	}
	
	if(sayac == 0)
		return 1;
	return 0;
}

int ardisikKontrol(int sayi1,int sayi2)
{
	if((sayi1+1) == sayi2)
		return 1;
	return 0;
}

void sirala()
{
	int i,j,k,gecici,tut;
	
	for(gecici=1; gecici<6; gecici++)
	{
		for(i=0; i<6-1; i++)
		{
			if(sonuc[i] > sonuc[i+1])
			{
				tut = sonuc[i];
				sonuc[i] = sonuc[i+1];
				sonuc[i+1] = tut;
			}
		
		}
	}
	int oncekiSatir,sonrakiSatir;
	
	for(i = 0; i< kolonSayi; i++)
	{
		for(j=0; j<49; j++)
		{
			if(kupon[i][j])
			{
				oncekiSatir = j;
			}	
		}
		for(k=0; k<49; k++)
		{
			if(kupon[i+1][k])
			{
				sonrakiSatir = k;
			}
		}
		if(oncekiSatir > sonrakiSatir)
		{
			kupon[i][oncekiSatir] = 0;
			kupon[i][sonrakiSatir] = 1;
			kupon[i+1][sonrakiSatir] = 0;
			kupon[i+1][oncekiSatir] = 1;
		}	
	}
}

void yazdir()
{
	int i,j,say = 0;
    
	FILE *dosya = fopen("cikti.txt","w");
	fprintf(dosya,"","");
	dosya = fopen("cikti.txt","a");
	
	
   
    fprintf(dosya, "%s","Kuponunuz : \n\n");
    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<49; j++)
        {
            if(kupon[i][j])
            {               
                fprintf(dosya,"%d \t",j);
            }    
        }
       
        fprintf(dosya,"\n",j);
    }
   
	fprintf(dosya, "%s","\nKazanan numaralar : \n\n");
    for(i=0; i<6; i++)
    {
        fprintf(dosya,"%d \t",sonuc[i]);
    }
	fprintf(dosya,"\n");
    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<6; j++)
        {
            if(kupon[i][sonuc[j]])
            {
                say++;
            }
        }
        fprintf(dosya,"\n%c > kuponunda dogru adet : %d",kolonHarfler[i],say);
    }
    fclose(dosya);
}

/*
  Normalde projelerini yaptigim kisilere hizmet dahilinde olmasa bile yardimci olur kodlari
  aciklayan satirlar ekler sorularina cevap verirdim.
  Ama sizin gibi insanlar emek harcamak nedir bilmediklerinden bu sekilde.
  Istenilen butun ozellikler eklendi. Zaten fonksiyonlarin isimleri turkce.
  Derleyici ve derleme standartlarina gore ciktida kaymalar olabilir fakat program dogru calisiyor.
  Sabah saat 5 de bakip daha sonra ulasabildigi yerlerden tehdit savuran biri emin olun hayatta hicbir zaman basarili olamaz.
  Zaten kendisine verilen bir odevi bir baskasina yaptiran kisi davranislarini degistirmedigi surece yerinde sayar.
  Istenilenlerin hepsini ekledigime gore sizin gibi bir insanla bir daha iletisim halinde olmak istemedigimden bir da benimle iletisime gecmeyin.
  İyi gunler.


  Alinti >
  programlamaya giriş,operatörler,kontrol yapilari,dönguler,diziler,fonksiyonlara kadar gorduk bunun disinda bir seyi hoca kabul etmeyebilir 
  ve sizden ricam bunlari az cok kavramis  bir ogrencinin beyniyle yazmaniz cok ust duzey olmasini istemiyorum 
*/
