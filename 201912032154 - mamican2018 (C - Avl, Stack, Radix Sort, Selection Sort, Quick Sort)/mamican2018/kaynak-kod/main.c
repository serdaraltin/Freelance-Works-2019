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
Ogrenci *Radiks_Siralama(Ogrenci *list, const int base , int rounds);

void Avl_Grupla(Ogrenci *root);
void Grupla_A(Ogrenci *root, Ogrenci **A);
void Grupla_B(Ogrenci *root, Ogrenci **B);

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
	printf("6. Cikis\n");
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
			Secerek_Siralama(&baslangic);
			Her_Iki_Dersi_Alanlar(Avl,baslangic);
			if(ortak == NULL)
				printf("bulunamadi !!!\n");
			else
				Yigin_Yazdir(ortak);
			menu();
			break;
		// +
		case 4:
			//Sadece Veritabani Yonetim Sistemleri dersi alanlar [Secmeli Siralama -> ad]
			Secerek_Siralama(&baslangic);
			Yigin_Yazdir(baslangic);
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
	char *tmp;
	list = baslangic;
	
	if(list == NULL)
		return NULL;
	
	while(list != NULL && list->sag != NULL){
		if(strcmp(list->ad, list->sag->ad) > 0){
			tmp = list->ad;
			list->ad = list->sag->ad;
			list->sag->ad = tmp;
			
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
Ogrenci *Radiks_Siralama(Ogrenci *list, const int base , int rounds){
	int n = 1;
	
	Ogrenci **bucket, *sag, *temp;
	
	bucket = (Ogrenci*)malloc(sizeof(Ogrenci));
	
	
	int j;
	for(j = 0; j < rounds; j++){
		
		while(list != NULL){
			sag = list->sag;
			list->sag = bucket[(list->numara/n)%base];
			bucket[(list->numara/n)%base] = list;
			list = list->sag;
			list = sag;
		}
		
		int i;
		for(i = 0; i < base; i++){
			while(bucket[i]!= NULL){
				temp = bucket[i]->sag;
				bucket[i]->sag = list;
				list = bucket[i];
				bucket[i] = bucket[i]->sag;
				bucket[i] = temp;
			}
		}
		n *= 10;	
	}
	return list;
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

// kisitli zaman ve odevin cok karmasik olmasindan dolayi gozumden kacmis bolumler olabilir
