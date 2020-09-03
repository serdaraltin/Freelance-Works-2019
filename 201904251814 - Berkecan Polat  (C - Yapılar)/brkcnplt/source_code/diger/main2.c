#include <stdio.h> //standart giris cikis kutuphanemizi ekledik.
#include <stdlib.h> //malloc ile bellekte yer ayirmak icin "stdlib" kutuphanemizi ekledik.
//degiskenleri turkce yaptim cunku anlatımı kolaylastirmak istedim


struct yapi{ // yapimizi(struct) tanimlamak icin "yapi" ismini verdik.
	int veri; //veri depolamak icin int turunde "veri" isminde bir degisken tanimliyoruz.
	yapi * sonraki; // yapimiz isaretcinin(pointer) gosterdigi dugumden sonrasina bag olusturuyor, sonraki dugumu gosteriyor.
};

typedef yapi dugum; // olusturdugumuz yapidan(struct) bir dugum(node) yaratiyoruz.





int main(){//ana fonksiyonu(main) tanimladik.
	
	dugum * kok; //dugumumuzun basi icin kok(root) isaretcisini(pointer) tanimladik.
	kok = (dugum *)malloc(sizeof(dugum)); // kok(root) dugumumuzu ilk isaretci(pointer) olarak ayarladik
	/* 
	(dugum *) : gelen veri tipsiz(void) oldugu icin tip donusumu(cast) yaptik.
	malloc(sizeof(dugum)) : "malloc" fonksiyonu ile bellekte yer ayirdik.
	sizeof(dugum) : bellekte ayiracagimiz yerin boyutunu "sizeof" fonksiyonu ile dugumden(node) aldik.
	*/
	kok -> veri = 1; // kokun(root) gosterdigi veriyi atadik.
	kok -> ileri = (dugum *)malloc(sizeof(dugum));
	
	printf("%d\n",kok->veri);

}

