#include <stdio.h>
#include <time.h>

//degiskenler
char kolonHarfler[6];
int kupon[6][49];
int sonuc[6];
int kolonSayi,numara;

//fonksiyon prototipleri
void loto();
void oyun();
void karsilastirma();

int main()
{
    loto();
    oyun();
    karsilastirma();
}

void loto()
{
    int i,j;

    for(i=65; i<72; i++)
    {
        kolonHarfler[i-65] = i;
    }

    for(i=0; i<6; i++)
    {
        for(j=0; j<49; j++)
        {
            kupon[i][j] = 0;
        }
    }

    int topNo,kontrol = 0;
    srand(time(NULL));
    for(i=0; j<i; j++)
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

void oyun()
{
    printf("\nLutfen kolon sayisini giriniz : ");
    scanf("%d",&kolonSayi);

    int i,j,k,kontrol = 0;

    for(i=0; i<kolonSayi; i++)
    {
        printf("\n%c > Kolunu icin 6 adet numara giriniz : ",kolonHarfler[i]);
        for(j=0; j<6; j++)
        {
            scanf("%d",numara);
            if(numara > 0 && numara < 50)
            {
                for(k=0; k<j; k++)
                {
                    if(kupon[i][numara])
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if(kontrol)
                {
                    printf("\nAyni numara kabul edilmiyor, Lutfen farkli bir numara giriniz : ");
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
                printf("\n1 ile 49 araliginda numaralar giriniz : ");
                j--;
            }
        }
    }
}

void karsilastirma()
{
    int i,j,say = 0;

    printf("\nKuponunuz");
    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<49; j++)
        {
            if(kupon[i][j])
            {
                printf("%d \t",j);
            }
            printf("\n%c Kolonu",kolonHarfler[i]);
        }
    }

    printf("\nKazanan numaralar\n");

    for(i=0; i<6; i++)
    {
        printf("%d \t",sonuc[i]);
    }

    for(i=0; i<kolonSayi; i++)
    {
        for(j=0; j<6; j++)
        {
            if(kupon[i][sonuc[j]])
            {
                say++;
            }
        }
        printf("\n%c > kuponunda %d adet numara dogru : ",kolonHarfler[i],say);
    }
}









