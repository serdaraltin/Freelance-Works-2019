
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <sys/wait.h>


int toplama(int n)
{
	int i,toplam = 0;
	for(i = 0; i < n; i++)
	{
		toplam += i;
	}
	return toplam;
}

void *thread_islem(void *input)
{
	//thread
	sleep(3);
	int sayi = (int)input;

	int sonuc = (sayi*sayi);
	printf("\n**************** THREAD **************\n");
	FILE *dosya = fopen("thread.txt","w");
	fprintf(dosya, "%d",sonuc);
	fclose(dosya);	
	printf("Thread toplam sonucun karesini aldi %d\n", sonuc);
	pthread_exit(NULL);
}

int main()
{
	fclose(fopen("parent.txt","w"));
	fclose(fopen("thread.txt","w"));

	pid_t pid;
	pid = fork();

	if(pid > 0)
	{
		wait(NULL);
		pid_t pid2;
		pid2 = fork();

		if(pid2 > 0)
		{
			//child2
			wait(NULL);
			int parent_value = 0,thread_value = 0;
			FILE *dosya_p = fopen("parent.txt","r");
			fscanf(dosya_p, "%d",&parent_value);
			fclose(dosya_p);	
			if(parent_value != 0)
			{
				printf("\n**************** CHILD 2 **************\n");	
				FILE *dosya_t = fopen("thread.txt","r");
				fscanf(dosya_t, "%d",&thread_value);
				fclose(dosya_t);	

				printf("Klavyeden alinan sayi %d \n",parent_value);
				printf("Threadin elde ettigi deger %d \n",thread_value);
				return 0;
			}
			else
			{
				return 0;
			}

		}
		else if(pid2 == 0)
		{
			//child1
			int sayi = 0;
			FILE *dosya = fopen("parent.txt","r");
			fscanf(dosya, "%d",&sayi);
			fclose(dosya);	
			if(sayi != 0)
			{
				printf("\n**************** CHILD 1 **************\n");
				sayi = toplama(sayi);
				printf("Toplam : %d \n",sayi);

				//thread
				pthread_t thread;
				pthread_create(&thread,NULL,thread_islem,(void *)sayi);
				pthread_join(thread,NULL);
				return 0;
			}
			else
			{	
				return 0;
			}
		}
	}
	else if(pid == 0)
	{
		//parent
		printf("************* PARENT ***************\n");
		printf("Bir Sayi Giriniz : ");
		int sayi;
		scanf("%d",&sayi);
		if(sayi > 20)
		{
			printf("\n20 den buyuk sayi kabul edilmiyor !!!\n");
			return 0;
		}

		FILE *dosya = fopen("parent.txt","w");
		fprintf(dosya, "%d",sayi);
		fclose(dosya);		
		return 0;
	}
	
	return 0;
}