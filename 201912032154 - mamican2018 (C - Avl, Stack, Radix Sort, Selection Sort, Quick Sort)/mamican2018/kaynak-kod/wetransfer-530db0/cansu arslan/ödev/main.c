#include <stdio.h>
#include <stdlib.h>

struct ogr{
	int numara;
	char *ad;
	char *soyad;
	char *bolum;
	int yukseklik;
	struct ogr *sol;
	struct ogr *sag;
};

typedef struct ogr Ogrenci;

Ogrenci *Avl = NULL, *Yigin = NULL, *baslangic = NULL, *bitis = NULL, *ortak = NULL;
/*
	avl - Veritabani Yonetim Sistemleri 
		A -> numara [tek]
		B -> numara [cift]
		 
	avl - Veri Yapilari ve Algoritmalar
		A -> ad A-K araligindaki harflerle baslayan
		B -> ad L-Z araligindaki harflerle baslayan
		
	stack - Her iki dersi de alan
		baska bolum ogrencileri olanlar
*/
int static counter = 0;

int max(int a, int b);
int height(Ogrenci *agac);
int getBalance(Ogrenci *agac);
Ogrenci *leftRotate(Ogrenci *agac);
Ogrenci *rightRotate(Ogrenci *agac);
void preOrder(Ogrenci *root);

void menu();

void veriTabani_Ekle();
void veriYapilari_Ekle();

Ogrenci *Yeni_Avl_Ekle(int numara, char *ad, char *soyad, char *bolum);
Ogrenci *Avl_Ekle(Ogrenci *agac, int numara, char *ad, char *soyad, char *bolum);

void Yigin_Ekle(Ogrenci *baslangic, int numara, char *ad, char *soyad, char *bolum);

void Hizli_Siralama(Ogrenci **baslangic);
Ogrenci *Hizli_Siralama_Ozyineli(Ogrenci *baslangic, Ogrenci *bitis);
void Yigin_Yazdir(Ogrenci *root);

Ogrenci *Secerek_Siralama(Ogrenci *baslangic);

void Her_Iki_Dersi_Alanlar(Ogrenci *ders1 , Ogrenci *ders2);

Ogrenci *getTail(Ogrenci *cur);
Ogrenci *partition(Ogrenci *baslangic, Ogrenci *bitis, Ogrenci **yeniBaslangic, Ogrenci **yeniBitis);


void Avl_Grupla(Ogrenci *root);
void Grupla_A(Ogrenci *root, Ogrenci **A);
void Grupla_B(Ogrenci *root, Ogrenci **B);

void Radiks_Siralama(Ogrenci *agac);
void radixsort(int arr[], int n);
int getMax(int arr[], int n);
void countSort(int arr[], int n, int exp);
Ogrenci *bul(Ogrenci *agac, int numara);

// +
int main(){
	
	baslangic = (Ogrenci*)malloc(sizeof(Ogrenci));
	bitis =  (Ogrenci*)malloc(sizeof(Ogrenci));
	baslangic->sag = bitis;
	
	menu();	
	return 0;
}

// +
void menu(){
	printf("\n\n============================================\n");
	printf("1. Avl - Ekle \t\t\t\t\t\t[Veritabani Yonetim Sistemleri]\n");
	printf("2. Yigin - Ekle \t\t\t\t\t[Veri Yapilari ve Algoritmalar]\n");
	printf("3. Her iki dersi alanlar \t\t\t\t[Radiks -> soyad]\n");
	printf("4. Sadece Veritabani Yonetim Sistemleri dersi alanlar \t[Secmeli Siralama -> ad]\n");
	printf("5. Veri Yapilari ve Algoritma dersi alanlar \t\t[Hizli Siralama -> numara]\n"); // karmasiklik log2n (log 2 tabaninda n)
	printf("6. Veritabani Yonetim Sistemleri grupla \t\t[A(tek)-B(cift)]\n");
	printf("7. Cikis\n");
	printf("============================================\n");
	printf("\nSeciniz > ");
	int secim;
	scanf("%d",&secim);
	
	switch(secim){
		// +
		case 1:
			// Avl - Ekle [Veritabani Yonetim Sistemleri]
			veriTabani_Ekle();
			menu();
			break;
		// +
		case 2:
			//Yigin - Ekle [Veri Yapilari ve Algoritmalar]
			veriYapilari_Ekle();
			menu();
			break;
		case 3:
			//Her iki dersi alanlar [Radiks -> soyad]
			//Secerek_Siralama(&baslangic);
			ortak = NULL;
			Her_Iki_Dersi_Alanlar(Avl,baslangic);
			Radiks_Siralama(ortak);
			menu();
			break;
		// +
		case 4:
			//Sadece Veritabani Yonetim Sistemleri dersi alanlar [Secmeli Siralama -> ad]
			Secerek_Siralama(baslangic);
			preOrder(Avl);
			menu();
			break;
		// +
		case 5:
			//Veri Yapilari ve Algoritma dersi alanlar [Hizli Siralama -> numara]
			//Yigin_Yazdir(baslangic);
			Hizli_Siralama(&baslangic);
			Yigin_Yazdir(baslangic);
			menu();
			break;
		// +
		case 6:
			//Veritabani Yonetim Sistemleri dersi alanlari A ve B gruplarina ayirarak listeleme
			Avl_Grupla(Avl);
			menu();
			break;
		case 7:
			//Cikis
			exit(1);
			break;
		// +
		default:
			printf("Hatali bir secim yaptiniz !\n");
			menu();
			break;
	}
}

// +
int max(int a, int b){
	return (a > b)? a : b;
}

// +
int height(Ogrenci *agac){
	if(agac == NULL)
		return 0;
	return agac->yukseklik;
}

// +
int getBalance(Ogrenci *agac){
	if(agac == NULL)
		return 0;
	return height(agac->sol) - height(agac->sag);
}

// +
Ogrenci *leftRotate(Ogrenci *agac){
	Ogrenci *y = agac->sag;
	Ogrenci *T2 = y->sol;
	
	y->sol = agac;
	agac->sag = T2;
	
	agac->yukseklik = max(height(agac->sol), height(agac->sag))+1;
	y->yukseklik = max(height(y->sol), height(y->sag))+1;
	
	return y;
}

// +
Ogrenci *rightRotate(Ogrenci *agac){
	Ogrenci *x = agac->sol;
	Ogrenci *T2 = x->sag;
	
	x->sag = agac;
	agac->sol = T2;
	
	agac->yukseklik = max(height(agac->sol), height(agac->sag))+1;
	x->yukseklik = max(height(x->sol), height(x->sag))+1;
	
	return x;
}

// +
void preOrder(Ogrenci *root){
	if(root != NULL)
	{
		printf("\n==============\nNumara\t: %d\nAd\t: %s\nSoyad\t: %s\nBolum\t: %s",root->numara,root->ad,root->soyad,root->bolum);
		preOrder(root->sol);
		preOrder(root->sag);
	}
	return;
}

// +	
void veriTabani_Ekle(){

	int numara;
	char *ad = (char*)malloc(sizeof(char)*50);
	char *soyad = (char*)malloc(sizeof(char)*50);
	char *bolum = (char*)malloc(sizeof(char)*20);
	printf("\n\n");
	printf("Numara\t: ");
	scanf("%d",&numara);
	printf("Ad\t: ");
	scanf("%s",ad);
	printf("Soyad\t: ");
	scanf("%s",soyad);
	printf("Bolum\t: ");
	scanf("%s",bolum);
	
	Avl = Avl_Ekle(Avl,numara,ad,soyad,bolum);
	
	return;
}

// +
void veriYapilari_Ekle(){
	int numara;
	char *ad = (char*)malloc(sizeof(char)*50);
	char *soyad = (char*)malloc(sizeof(char)*50);
	char *bolum = (char*)malloc(sizeof(char)*20);
	printf("\n\n");
	printf("Numara\t: ");
	scanf("%d",&numara);
	printf("Ad\t: ");
	scanf("%s",ad);
	printf("Soyad\t: ");
	scanf("%s",soyad);
	printf("Bolum\t: ");
	scanf("%s",bolum);
	
    Yigin_Ekle(baslangic,numara,ad,soyad,bolum);
	
	return;
}

// +
Ogrenci *Yeni_Avl_Ekle(int numara, char *ad, char *soyad, char *bolum){
	Ogrenci *yeni = (Ogrenci*)malloc(sizeof(Ogrenci));
	yeni->numara = numara;
	yeni->ad = ad;
	yeni->soyad = soyad;
	yeni->bolum = bolum;
	yeni->sol = NULL;
	yeni->sag = NULL;
	yeni->yukseklik = 1;
	
	return(yeni);
}

// +
Ogrenci *Avl_Ekle(Ogrenci *agac, int numara, char *ad, char *soyad, char *bolum){
	if(agac == NULL)
		return(Yeni_Avl_Ekle(numara,ad,soyad,bolum));
	
	if(numara < agac->numara)
		agac->sol = Avl_Ekle(agac->sol,numara,ad,soyad,bolum);
	else if(numara > agac->numara)
		agac->sag = Avl_Ekle(agac->sag,numara,ad,soyad,bolum);
	else
		return agac;
	
	agac->yukseklik = 1 + max(height(agac->sol),height(agac->sag));
	
	
	int balance = getBalance(agac);
	
	if(balance > 1 && numara < agac->sol->numara)
		return rightRotate(agac);
	
	if(balance < -1 && numara > agac->sag->numara)
		return leftRotate(agac);
	
	if(balance > 1 && numara > agac->sol->numara){
		agac->sol = leftRotate(agac->sol);
		return rightRotate(agac);		
	}
	
	if(balance < -1 && numara < agac->sag->numara){
		agac->sag = rightRotate(agac->sag);
		return leftRotate(agac);
	}
	
	return agac;
}

// +
void Yigin_Ekle(Ogrenci *baslangic, int numara, char *ad, char *soyad, char *bolum){
	Ogrenci *yeni = (Ogrenci*)malloc(sizeof(Ogrenci));
	yeni->numara = numara;
	yeni->ad = ad;
	yeni->soyad = soyad;
	yeni->bolum = bolum;
	yeni->sag = baslangic->sag;
	baslangic->sag = yeni;
	return;
}

// +
void Hizli_Siralama(Ogrenci **baslangic){
	
	(*baslangic) = Hizli_Siralama_Ozyineli(*baslangic, getTail(*baslangic)); 
	return; 
}

// +
Ogrenci *Hizli_Siralama_Ozyineli(Ogrenci *baslangic, Ogrenci *bitis){
if (!baslangic || baslangic == bitis) 
		return baslangic; 
	Ogrenci *newbaslangic = NULL, *newEnd = NULL; 
	Ogrenci *pivot = partition(baslangic, bitis, &newbaslangic, &newEnd); 
	if (newbaslangic != pivot) 
	{ 
		Ogrenci *tmp = newbaslangic; 
		while (tmp->sag != pivot) 
			tmp = tmp->sag; 
		tmp->sag = NULL; 

		newbaslangic = Hizli_Siralama_Ozyineli(newbaslangic, tmp); 

		tmp = getTail(newbaslangic); 
		tmp->sag = pivot; 
	} 
	pivot->sag = Hizli_Siralama_Ozyineli(pivot->sag, newEnd); 
	return newbaslangic; 
}

// +
Ogrenci *partition(Ogrenci *baslangic, Ogrenci *bitis, Ogrenci **yeniBaslangic, Ogrenci **yeniBitis){
	
	Ogrenci *pivot = bitis; 
	Ogrenci *prev = NULL, *cur = baslangic, *tail = pivot; 

	while (cur != pivot) 
	{ 
		if (cur->numara < pivot->numara) 
		{ 
			
			if ((*yeniBaslangic) == NULL) 
				(*yeniBaslangic) = cur; 

			prev = cur; 
			cur = cur->sag; 
		} 
		else 
		{ 
			if (prev) 
				prev->sag = cur->sag; 
			Ogrenci *tmp = cur->sag; 
			cur->sag = NULL; 
			tail->sag = cur; 
			tail = cur; 
			cur = tmp; 
		} 
	} 

	if ((*yeniBaslangic) == NULL) 
		(*yeniBaslangic) = pivot; 

	(*yeniBitis) = tail; 

	return pivot; 
}

// +
Ogrenci *getTail(Ogrenci *cur){
	while(cur != NULL && cur->sag != NULL)
		cur = cur->sag;
	return cur;
}

// +
void Yigin_Yazdir(Ogrenci *root){
	while(root != NULL){
		if(root->bolum == NULL)
		{
			root = root->sag;
			continue;
		}
		printf("\n==============\nNumara\t: %d\nAd\t: %s\nSoyad\t: %s\nBolum\t: %s",root->numara,root->ad,root->soyad,root->bolum);
		root = root->sag;
	}
	return;
}

// +
Ogrenci *Secerek_Siralama(Ogrenci *baslangic){
	
	Ogrenci *list;
	Ogrenci *temp = (Ogrenci*)malloc(sizeof(Ogrenci));
	list = baslangic;
	
	if(list == NULL)
		return NULL;
	
	while(list != NULL && list->sag != NULL){
		if(strcmp(list->ad, list->sag->ad) > 0){
			temp = list;
			list = list->sag;
			list->sag = temp;
			
		}
		list = list->sag;
	}
	return list;
}

// +
void Her_Iki_Dersi_Alanlar(Ogrenci *ders1 , Ogrenci *ders2){
	if(ders1 != NULL){
		Ogrenci *iter = ders2;
		while(iter->sag != NULL){
			if(iter->bolum == NULL){
				iter = iter->sag;
				continue;
			}
			if(ders1->numara == iter->numara){
				Ogrenci *yeni = (Ogrenci*)malloc(sizeof(Ogrenci));
				yeni->numara = ders1->numara;
				yeni->ad = ders1->ad;
				yeni->soyad = ders1->soyad;
				yeni->bolum = ders1->bolum;
				yeni->sag = NULL;
				yeni->sol = NULL;
				yeni->yukseklik = 0;
				
				if(ortak == NULL){
					ortak = yeni;
					break;
				}
				Ogrenci *iter2 = ortak;
				while(iter2->sag != NULL)
					iter2 = iter2->sag;
				iter2->sag = yeni;
				break;
			}
		
			iter = iter->sag;
		}
		Her_Iki_Dersi_Alanlar(ders1->sol, ders2);
		Her_Iki_Dersi_Alanlar(ders1->sag, ders2);
	}

}

// +
void Avl_Grupla(Ogrenci *root){
	
	Ogrenci *A = NULL, *B = NULL;
	
	Grupla_A(root, &A);
	Grupla_B(root, &B);
	
	printf("\nGRUP A >>>>>>>\n");
	Ogrenci *iterA = A, *iterB = B;
	while(iterA != NULL){
		printf("\n==============\nNumara\t: %d\nAd\t: %s\nSoyad\t: %s\nBolum\t: %s",iterA->numara,iterA->ad,iterA->soyad,iterA->bolum);
		iterA = iterA->sag;
	}
	printf("\nGRUP B >>>>>>>\n");
	while(iterB != NULL){
		printf("\n==============\nNumara\t: %d\nAd\t: %s\nSoyad\t: %s\nBolum\t: %s",iterB->numara,iterB->ad,iterB->soyad,iterB->bolum);
		iterB = iterB->sag;
	}
	return;
}

// +
void Grupla_A(Ogrenci *root, Ogrenci **A){
	if(root != NULL){
		if(root->numara % 2 != 0){
			
			Ogrenci *yeni = (Ogrenci*)malloc(sizeof(Ogrenci));
			yeni->numara = root->numara;
			yeni->ad = root->ad;
			yeni->soyad = root->soyad;
			yeni->bolum = root->bolum;
			yeni->sag = NULL;
			yeni->sol = NULL;
			yeni->yukseklik = 0;
			
			if(*A == NULL){
				*A = yeni;
			}
			else{
			
				Ogrenci *iter = *A;
			
				while(iter->sag != NULL)
					iter = iter->sag;
				iter->sag = yeni;
				
			}
				
		}
		
		Grupla_A(root->sol, A);
		Grupla_A(root->sag, A);
	}
	return;
}

// +
void Grupla_B(Ogrenci *root, Ogrenci **B){
	if(root != NULL){
		if(root->numara % 2 == 0){
			
			Ogrenci *yeni = (Ogrenci*)malloc(sizeof(Ogrenci));
			yeni->numara = root->numara;
			yeni->ad = root->ad;
			yeni->soyad = root->soyad;
			yeni->bolum = root->bolum;
			yeni->sag = NULL;
			yeni->sol = NULL;
			yeni->yukseklik = 0;
			
			if(*B == NULL){
				*B = yeni;
			}
			else{
			
				Ogrenci *iter = *B;
			
				while(iter->sag != NULL)
					iter = iter->sag;
				iter->sag = yeni;
				
			}
				
		}
		
		Grupla_A(root->sol, B);
		Grupla_A(root->sag, B);
	}
	return;
}

// +
Ogrenci *bul(Ogrenci *agac, int numara){
	Ogrenci *iter = agac;
	while(iter != NULL){
		if(iter->numara == numara)
			return iter;
		iter = iter->sag;
	}
	return NULL;
}
// +
int getMax(int arr[], int n){
	int mx = arr[0];
	int i;
	for(i= 1; i < n; i++)
		if(arr[i] > mx)
			mx = arr[i];
	return mx;
}

// +
void countSort(int arr[], int n, int exp){
	int output[n];
	int i, count[10] = {0};
	
	for (i = 0; i < n; i++)
        count[ (arr[i]/exp)%10 ]++;
 
    for (i = 1; i < 10; i++) 
		count[i] += count[i - 1]; 
    
	for (i = n - 1; i >= 0; i--)
    {
        output[count[ (arr[i]/exp)%10 ] - 1] = arr[i];
        count[ (arr[i]/exp)%10 ]--;
		
    }
    	
    for (i = 0; i < n; i++) 
		arr[i] = output[i]; 
}

// +
void radixsort(int arr[], int n) { 

	int m = getMax(arr, n); 
	int exp;
	for (exp = 1; m/exp > 0; exp *= 10)
		countSort(arr, n, exp);
}

// + Soyad bilgisine gore siralama algoritmasini olusturamadigim icin Radiks siralama ile numaraya gore siralama yapildi
void Radiks_Siralama(Ogrenci *agac){
	Ogrenci *list = agac;
	Ogrenci *iter = list;
	
	int max = 0;
	while(iter != NULL){
		max++;
		iter = iter->sag;
	}
	
	int arr[max];
	
	int i = 0;
	iter = list;
	while(iter != NULL){
		arr[i] = iter->numara;
		i++;
		iter = iter->sag;
	}
	int n = sizeof(arr)/sizeof(arr[0]);
	radixsort(arr,n);
	
	
	for(i = 0; i < n; i++)
	{
		Ogrenci *ogr = bul(agac,arr[i]);
	
		if(ogr->bolum != NULL)
			printf("\n==============\nNumara\t: %d\nAd\t: %s\nSoyad\t: %s\nBolum\t: %s",ogr->numara,ogr->ad,ogr->soyad,ogr->bolum);
	
	}

	return;
}



// kisitli zaman ve odevin cok karmasik olmasindan dolayi gozumden kacmis bolumler olabilir
