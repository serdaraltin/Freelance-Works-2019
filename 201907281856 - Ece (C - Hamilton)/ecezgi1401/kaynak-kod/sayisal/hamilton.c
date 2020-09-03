//-----------------------------------------------------------------------------------------------------
/*
standart input output kutuphanesi yani "stdio.h" ý programa dahil ettik
boylece ekrana yazi bastirma gibi standart islemleri yapabilecegiz
*/
#include <stdio.h>
//-----------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------

/*
define onislemcisi ile V adýnda bir sabit tanimlayip degerini 5 yaptik
boylece programda "V" gorulen her yerin degeri 5 olacaktir
*/
#define V 5 //burada ki degeri degistirerek matrisin degerini belirleyebilirsiniz (ornek 3 degeri icin [3][3] bir matris olusur)
//-----------------------------------------------------------------------------------------------------



//-----------------------------------------------------------------------------------------------------
/*
yazdirCozum isimli fonksiyonun prototipini tanimladik
*/
void yazdirCozum(int yol[]);
//-----------------------------------------------------------------------------------------------------



//-----------------------------------------------------------------------------------------------------
/*
int deger donduren "dogrula" adinda bir fonksiyon hazirladik
bu fonksiyon verilen parametreler dogrusunda 0 veya 1 yani
true veya false deger dondurerek matrisi kontrol edecek
*/
int dogrula(int v, int grafik[V][V], int yol[], int pozisyon)
{
	//-----------------------------------------------------------------------------------------------------
	/*
	verilen "grafik" ismindeki fonksiyon parametresinin
	sirasiyla 
	satir icin [yol [pozisyon-1]]
	stun icin [v]
	ve buradaki degerin 0 a esit olma durumunda geriye 0 yani false donduruyor
	*/
	if(grafik[yol[pozisyon-1]][v] == 0)
	{
		return 0;
	}
	//-----------------------------------------------------------------------------------------------------
	
	
	
	//-----------------------------------------------------------------------------------------------------
	/*
	0 dan baslayip parametre olarak verilen pozisyon degerine kadar ilerleyen bir dongu tanimladik
	boylece "yol" dizisinin index "i" degeri ile yine parametre olarak gelen "v" tamsayisini karsilastirdik
	esit olmalari durumunda 0 yani false , esit olmamalari durumunda 1 yani true degerlerini dondurduk
	*/
	int i;
	for(i=0; i<pozisyon; i++)
	{
		if(yol[i] == v)
		{
			return 0;
		}
	}
	
	return 1;
	//-----------------------------------------------------------------------------------------------------
}
//-----------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------
/*
hamilton_cycle_util adinda bir fonksiyon olusturduk ve parametre olarak sirasiyla
grafik , yol , posizyon degerlerini aldik
*/
int hamilton_cycle_util(int grafik[V][V], int yol[], int pozisyon)
{  
	//-----------------------------------------------------------------------------------------------------
	/*
	parametre olarak gelen "pozisyon" degerinin onislemci olarak tanimlanan "V" yani 5 tamsayisina esit olma durumunu kontrol ettik
	esit olmasi durumunda;
	*/
	if (pozisyon == V) 
    {   
    	//-----------------------------------------------------------------------------------------------------
    	/*
    	parametre olarak verilen;
    	grafik matrisinin;
    	satir [yol[pozisyon-1]]
    	stun [yol[0]]
    	degerinin 1 yani true degerine esit olma durumunu kontrol ettik kosul saglaniyorsa geriye 1 yani true
    	kosul saglanmiyosa geriye 0 yani false degerini dondurduk
    	*/
        if ( grafik[ yol[pozisyon-1] ][ yol[0] ] == 1 ) 
        {
        	return 1;
		}
        else
        {
        	return 0; 
		}
		//-----------------------------------------------------------------------------------------------------
    } 
    //-----------------------------------------------------------------------------------------------------
  
  
	//-----------------------------------------------------------------------------------------------------
	/*
	bir for dongusu olusturup 1 den baslayip onislemci komutu olarak belirlenen "V" yani 5 tamsayisindan kucuk
	olana dek devam ettirdik
	*/
    int v;
    for (v = 1; v < V; v++) 
    { 
       //-----------------------------------------------------------------------------------------------------
       /*
       parametre olarak gelen sirasiyla;
       v , grafik , yol , pozisyon
       degerlerini "dogrula" fonksiyonuna parametre olarak gonderip gelen degerin 1 veya 0 yani true veya false olma
       durumlarýný kontrol ettik
       not: c99 kurallari uzerine derleme yapildigindan 1 tamsayisi if kosulunda dogru(true) deger olarak kabul gorur
       */
        if (dogrula(v, grafik, yol, pozisyon)) 
        { 
       		//-----------------------------------------------------------------------------------------------------
       		/*
       		"yol" dizisinin "pozisyon" degerine esit olan indis degerindeki veriyi donguden gelen "v" degerine esitledik
       		not : v degeri dongu icerisinde degisiyor
       		*/
            yol[pozisyon] = v; 
           	//-----------------------------------------------------------------------------------------------------
           	
           	
           	//-----------------------------------------------------------------------------------------------------
           	/*
           	"hamilton_cycle_util" adinda olusturdugumuz fonksiyona sirasiyla;
           	grafik, yol , pozisyon+1 degerlerini parametre olarak gonderdik ve
           	geri donen veri 1 yani true ise verilen if kosulu saglanacak ve geriye 1 yani true degeri dondurulecektir
           	*/
            if (hamilton_cycle_util (grafik, yol, pozisyon+1) == 1)
			{
				return 1; 
			} 
			
 			//-----------------------------------------------------------------------------------------------------
 			/*
 			"yol" dizisinin "pozisyon" degerine esit olan indis degerindeki veriyi "-1" degerine esitledik
 			*/
            yol[pozisyon] = -1; 
            //-----------------------------------------------------------------------------------------------------
            
            //-----------------------------------------------------------------------------------------------------
        } 
        //-----------------------------------------------------------------------------------------------------
    } 
    //-----------------------------------------------------------------------------------------------------
  
  
   //-----------------------------------------------------------------------------------------------------
   /*
   yukaridaki islemler sonucunda geriye deger dondurulmez ise son olarak olumsuz yani 0(false) degeri dondurulecek
   */
    return 0;
   //----------------------------------------------------------------------------------------------------- 
}
//-----------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------
/*
"hamilton_cycle" adinda bir fonsiyon tanimlayip icerisine parametre olarak "V" ye "V" lik bir matris alacagini bildirdik
matrisin adini "grafik" olarak belirleyip icerisindeki degerlerin "int(tamsayi)" oldugunu bildirdik 
yani fonksiyon geriye int bir deger dondurecektir
*/
int hamilton_cycle(int grafik[V][V])
{
	//-----------------------------------------------------------------------------------------------------
	/*
	 "yol" adinda bir pointer(isaretci) tanimlayip bu pointer(isaretci) icin ram(bellek) yer ayirdik
	 pointer = bilgisayar belleginde halk arasinda ram olarak bilinen donanim parcasindaki adreslerin verilerini tutar
	 yani verilen adresteki veriyi isaret eder
	 "malloc" fonksyionunu cagirip icerisine parametre olarak;
	 V*sizeof(int)
	 yani "V" olarak onislemcide belirledigimiz 5 tamsayisi kadar bellekte int verilik yer ayirmasini istedik
	 "malloc" fonksiyonu icerisinde cagrilan "sizeof" fonksiyonu icerisine verdigimiz parametrenin(veri turu) bellekte kapladigi alani geri dondurur(ornek : int icin 4 veya 8 byte)
	 sonuc olarak bellekte "V(5)" adet int(4 veya 8 byte (islemci mimarisine gore degisir)) verisini tutacak kadarlik yer ayirdik
	*/
	int *yol = malloc(V*sizeof(int));
	//-----------------------------------------------------------------------------------------------------
	
	//-----------------------------------------------------------------------------------------------------
	/*
	0 dan baslayarak onislemci bolumunde 5 degerini verdigimiz "V" degerine kadar her seferinde 1 artacak
	bir "for" dongusu olusturduk
	*/
	int i;
	for(i=0; i<V; i++)
	{
		//-----------------------------------------------------------------------------------------------------
		/*
		"yol" gostericisinin(isaretci) dongunun o anki durumundan gelen "i" degerininci indisindeki veriyi "-1" degerine esitledik
		not: esitlemek ne kadar dogru bir tanim olmasa da aliskanlik aslinda atamdik demeliyiz.
		*/
		yol[i] = -1;
		//-----------------------------------------------------------------------------------------------------
	}
	//-----------------------------------------------------------------------------------------------------
	 
	//-----------------------------------------------------------------------------------------------------
	/*
	"yol" gostericisinin(isaretci) ilk indisini 0 a esitledik.
	*/
	yol[0] = 0;
	//-----------------------------------------------------------------------------------------------------
	//-----------------------------------------------------------------------------------------------------
	/*
	"hamilton_cycle_util" fonksiyonuna parametre olarak sirasiyla;
	grafik, yol(gosterici), 1 degerlerini gonderdik ve
	fonksiyondan gelen verinin 0 (false) esit olma durumunu kontrol ettik
	*/
	if(hamilton_cycle_util(grafik, yol, 1) == 0)
	{
		//-----------------------------------------------------------------------------------------------------
		/*
		kosulun saglanmasi durumunda verilen degerler dogrultusunda Cozum olmadigindan ekrana "Cozum yok" yazdirdik
		*/
		printf("\nCozum yok");
		return 0;
		//-----------------------------------------------------------------------------------------------------
	}
	//-----------------------------------------------------------------------------------------------------
	
	//-----------------------------------------------------------------------------------------------------
	/*
	yukaridaki islemlerin sonucunda geriye bir deger dondurulmez ise "yazdirCozum" fonksiyonu cagirilip
	icerisine "yol(gosterici)" parametre olarak verildi
	boylece ekrana sonucu yazdirdik
	ve geriye 1(true) degerini dondurduk
	*/
	yazdirCozum(yol);
	return 1;
	//-----------------------------------------------------------------------------------------------------
}
//-----------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------
/*
"void" tipinde yani geriye herhangi bir deger dondurmeyen "yazdirCozum" adinda bir fonksiyon olusturduk
ve bu fonksiyonun parametre olarak int veri turunda "yol" adinda bir dizi alacagini bildirdik
*/
void yazdirCozum(int yol[])
{
	//-----------------------------------------------------------------------------------------------------
	/*
	bu fonksiyona girilmis ise Cozum vardir yani verilen deger bir hamilton dongusudur
	bundan mutevellit :D
	bir dongu olusturup gelen "yol" dizisindeki degerleri ekrana bastirdik
	*/
	printf("Cozum var (Bu bir hamilton dongusu): \n");
	int i;
	for(i=0; i<V; i++)
	{
		printf(" %d ", yol[i]);
	}
	//-----------------------------------------------------------------------------------------------------
	/*
	son olarak bu bir gecerli hamilton dongusu oldugundan verilen "yol" dizisinin ilk degeri yani
	0 inci indisini ekrana bastirdik
	not : printf fonksiyonunda "%d" verilen veririn int(tamsayi) oldugunu bildirdik
	*/
	//-----------------------------------------------------------------------------------------------------
	printf(" %d \n", yol[0]); 
	//-----------------------------------------------------------------------------------------------------
}
//-----------------------------------------------------------------------------------------------------



int main()
{
	
	
	//-----------------------------------------------------------------------------------------------------
	/*
	"grafik" adinda int veri turunda "V" ye "V" lik bir matris olusturduk
	*/
	int grafik[V][V];
	//-----------------------------------------------------------------------------------------------------

	//-----------------------------------------------------------------------------------------------------
	/*
	ic ice dongu olusturup "grafik" matrisinin tum elemanlarini gerezerek
	her bir matris degeri icin veri girilmesini istedik
	boylece kullanici matrisin icerisini doldurdu
	*/
	int i;
	for(i=0; i<V; i++)
	{
		int j;
		for(j=0; j<V; j++)
		{
			//-----------------------------------------------------------------------------------------------------
			/*
			"printf" fonksiyonunda "[%d][%d]" yani matrisin dongu icerisindeki o anki degeri icin veri
			girilmesini istiyoruz, i satir, j stun veya tamtersini verir
			*/
			printf("matrisin [%d][%d] degerini giriniz : ",i,j);
			/*
			"scanf" fonksiyonu ile kullanicinin girecegi degerin "%d" yani int(tamsayi) bir deger
			oldugunu bildirip gelen degeri "grafik" matrisinin o anki indisine atiyoruz
			*/
			scanf("%d",&grafik[i][j]);
			//-----------------------------------------------------------------------------------------------------
		}
	}
	//-----------------------------------------------------------------------------------------------------

	//-----------------------------------------------------------------------------------------------------
	/*
	kullanici "grafik" matrisinin icerisini doldurdugundan
	artik "hamilton_cycle" fonksiyonumuzu cagirip parametre olarak "grafik" matrisini veriyoruz
	*/
	hamilton_cycle(grafik);
	//-----------------------------------------------------------------------------------------------------

	
/*
ornek : hamilton dongusu
	{0, 1, 0, 1, 0}, 
    {1, 0, 1, 1, 1}, 
    {0, 1, 0, 0, 1}, 
    {1, 1, 0, 0, 1}, 
    {0, 1, 1, 1, 0}, 

    
	
	 
ornek : cozum yok
	{0, 1, 0, 1, 0}, 
    {1, 0, 1, 1, 1}, 
    {0, 1, 0, 0, 1}, 
    {1, 1, 0, 0, 0}, 
    {0, 1, 1, 0, 0}, 
*/
                     
	
	
	return 0;
	
}






