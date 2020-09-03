#include <iostream>
#include <ctime>
#include <cstdlib>

using namespace std;

class loto {

      bool kupon[6][49];
      int sonuc[6];
      int kolonSayisi,numara;
      char kolonHarfleri[6];
      public:
      loto();
      void oyna();
      void karsilastir();
      };

loto::loto() {

             int i,j;
             for(i=65;i<72;i++)
             kolonHarfleri[i-65]=i;

             for(i=0;i<6;i++)
             for(j=0;j<49;j++)
             kupon[i][j]=false;

             int topNumarasi;
             bool flag=false;
             srand(time(NULL));
             for(i=0;i<6;i++)
             {
             topNumarasi=rand() % 49 + 1;
             for(j=0;j<i;j++)
             if(topNumarasi==sonuc[j]) {
             flag=true; break;
             }
             if(flag)
             i--;
             else
             sonuc[i]=topNumarasi;
             flag=false;
             }
             }
void loto::oyna() {

     cout << "Lutfen Oynayacaginiz Kolon Sayisini Giriniz:\n";
     cin >> kolonSayisi;
     int i,j,k;
     bool flag=false;
     for(i=0;i<kolonSayisi;i++) 
     {
     cout << kolonHarfleri[i] << ".Kolonu icin 6 adet numara giriniz:\n";
     for(j=0;j<6;j++) 
     {
     cin >> numara;
     if(numara > 0 && numara < 50) 
     {
     for(k=0;k<j;k++)
     if(kupon[i][numara]) {
     flag=true; break;
     }
     if(flag) {
     cout << "Bir numara en fazla bir kez kullanilabilir,Lutfen tekrar giriniz:\n";
     j--;
     }
     else
     kupon[i][numara]=true;
     flag=false;
     }
     else {
     cout << "Lutfen 1-49 araliginda numaralar giriniz\n";
     j--;
     }
     }
     }
     }

void loto::karsilastir() {

     int say=0;
     int i,j;

     cout << "Sizin Kuponunuz\n";
     for(i=0;i<kolonSayisi;i++) 
     {
     for(j=0;j<49;j++)
     if(kupon[i][j])
     cout << j << ' ';
     cout << "\n" << kolonHarfleri[i] << "\n";
     }

     cout << "Haftanin Sansli Numaralari\n";
     for(i=0;i<6;i++)
     cout << sonuc[i] << ' ';


     for(i=0;i<kolonSayisi;i++) {
     for(j=0;j<6;j++)
     if(kupon[i][sonuc[j]])
     say++;
     cout << kolonHarfleri[i] << ".kuponda " << say << " adet numara bildiniz:";
     }
     }

int main() {
           loto yeni;
           yeni.oyna();
           yeni.karsilastir();
           getchar();
           return 0;   
}   