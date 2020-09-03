#include <stdio.h>

#define V 5

void yazdirCozum(int yol[]);
int dogrula(int v, int grafik[V][V], int yol[], int pozisyon)
{	
	if(grafik[yol[pozisyon-1]][v] == 0)
	{
		return 0;
	}
	int i;
	for(i=0; i<pozisyon; i++)
	{
		if(yol[i] == v)
		{
			return 0;
		}
	}	
	return 1;
}
int hamilton_cycle_util(int grafik[V][V], int yol[], int pozisyon)
{  	
	if (pozisyon == V) 
    {   
        if ( grafik[ yol[pozisyon-1] ][ yol[0] ] == 1 ) 
        {
        	return 1;
		}
        else
        {
        	return 0; 
		}		
    } 
    int v;
    for (v = 1; v < V; v++) 
    {      
        if (dogrula(v, grafik, yol, pozisyon)) 
        {      	
           yol[pozisyon] = v; 
      
            if (hamilton_cycle_util (grafik, yol, pozisyon+1) == 1)
			{
				return 1; 
			} 			
            yol[pozisyon] = -1;       
        } 
    } 
    return 0;
}
int hamilton_cycle(int grafik[V][V])
{
	int *yol = malloc(V*sizeof(int));
	int i;
	for(i=0; i<V; i++)
	{
		yol[i] = -1;
	}
	yol[0] = 0;
	if(hamilton_cycle_util(grafik, yol, 1) == 0)
	{	
		printf("\nCozum yok");
		return 0;	
	}
	yazdirCozum(yol);
	return 1;	
}

void yazdirCozum(int yol[])
{
	printf("Cozum var (Bu bir hamilton dongusu): \n");
	int i;
	for(i=0; i<V; i++)
	{
		printf(" %d ", yol[i]);
	}
	printf(" %d \n", yol[0]); 
}
int main()
{
	int grafik[V][V];
	int i;
	for(i=0; i<V; i++)
	{
		int j;
		for(j=0; j<V; j++)
		{
			printf("matrisin [%d][%d] degerini giriniz : ",i,j);
			char sehir[30];
			scanf("%s",sehir);
			
			int sehir_sayisal=0;
			int a;
			for(a=0; a<sizeof(sehir); a++)
			{
				if(sehir[a]>96 && sehir[a]<123)
				{
					sehir_sayisal+=sehir[a];
				}
			}
		//	printf("sehir %d\n",sehir_sayisal);
			sehir_sayisal = (sehir_sayisal / 2)/a;
		
			printf("sehir ort %d\n\n",sehir_sayisal);
	
		}
	}
	hamilton_cycle(grafik);
	return 0;
}






