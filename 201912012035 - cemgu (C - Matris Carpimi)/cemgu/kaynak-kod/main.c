#include <stdio.h>
#include <stdlib.h>

int main(){
    

    FILE *dosya,*cikti;
    if((dosya = fopen("matrisler.txt","r") == NULL) || (cikti = fopen("sonuc.txt","w") == NULL))
    {
    	printf("dosya acilamadi !!!");
    	exit(1);
	}
    dosya = fopen("matrisler.txt","r");
	cikti = fopen("sonuc.txt","w");
	
	while(!feof(dosya)){
	char csatir[2],csutun[2];
	int satir = 0,sutun = 0;
	fscanf(dosya,"%cx%c",csatir,csutun);
	
	satir = atoi(csatir);
	sutun = atoi(csutun);
	
	int toplam = 0;
	int dizi1[satir][sutun], dizi2[satir][sutun];
    int diziboyut = satir*sutun;
    int diziSonuc[diziboyut];
	
    int i,j,k;
    
	for(i=0; i<satir; i++){
		for(j=0; j<sutun; j++){
			char deger[10];
			fscanf(dosya,"%s",deger);
			int eleman = atoi(deger);
			dizi1[i][j] = eleman;
		
		}
	}
	
	for(i=0; i<satir; i++){
		for(j=0; j<sutun; j++){
			char deger[10];
			fscanf(dosya,"%s",deger);
			int eleman = atoi(deger);
			dizi2[i][j] = eleman;
		}
	}
   
    int a=0;
    for(i=0; i<satir; i++){  
        for( j=0; j<sutun; j++){
            for(k=0; k<sutun; k++){
               toplam += dizi1[i][k] * dizi2[k][j];  
            }
            diziSonuc[a] = toplam;
            toplam = 0;   
		    a++;
        }
    }
	if(satir>0 && sutun > 0)
 		fprintf(cikti,"Sonuc (%dx%d)> ",satir,sutun);
    for(i=0; i<diziboyut; i++){
    	fprintf(cikti,"%d ",diziSonuc[i]);
	}
	if(satir>0 && sutun > 0)
		fprintf(cikti,"\n");
	}
	fclose(dosya);
	fclose(cikti);
    return 0;
}
