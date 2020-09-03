#include <stdio.h>
#include <stdlib.h>
 
int main(){
    
    int satir, sutun1, sutun2, toplam = 0;
    
    printf("1. matris satir sayisi giriniz: ");
    scanf("%d", &satir);
    printf("1. matris sutun sayisi giriniz: ");
    scanf("%d", &sutun1);
    printf("2. matris sutun sayisi giriniz: ");
    scanf("%d", &sutun2);
    
    int dizi1[satir][sutun1], dizi2[sutun1][sutun2], diziCarp[satir][sutun2];
    int diziboyut = satir*sutun1;
    int diziSonuc[diziboyut];
    //1. matrisi kullanýcýdan alýr
    int i,j,k;
    for(i=0; i<satir; i++){
        for(j=0; j<sutun1; j++){
            printf("%dx%d)Sayi giriniz ", i+1, j+1);
            scanf("%d", &dizi1[i][j]);
        }
    }
    printf("\n");
    
    //2. matrisi kullanýcýdan alýr
    for(i=0; i<sutun1; i++){
        for(j=0; j<sutun2; j++){
            printf("%dx%d)Sayi giriniz ", i+1, j+1);
            scanf("%d", &dizi2[i][j]);
        }
    }
    
    
    //2 matrisi çarpar ve ekrana yazdýrýrlýr
    int a=0;
    for(i=0; i<satir; i++){  
        for( j=0; j<sutun2; j++){
            for(k=0; k<sutun1; k++){
                toplam += dizi1[i][k] * dizi2[k][j];  // Matris çarpma iþleminin algoritmasý
                
            }
            diziSonuc[a] = toplam;
            toplam = 0;   
		    a++;
        }
    }
    printf("Sonuc >\n");
    for(i=0; i<diziboyut; i++){
    	printf("%d ",diziSonuc[i]);
	}
    
    printf("\n");
    system("pause");
    return 0;
}
