#include "pch.h"
#include <iostream>
#include <cstdio>
#include <string.h>


using namespace std;

//FONKSÝYONUN BAÞLANGÝCÝ
int find(char s1[], char s2[]) {
	//x86-64 Mimariye Sahip islemci ve GCC derleyicisinin(4.1.2) surumune uygun eklendi
  __asm__( 
"push    %rbp"
"mov     %rbp, %rsp"
"sub     %rsp, 48"
"mov     QWORD PTR [%rbp-24], %rdi"
"mov     QWORD PTR [%rbp-32], %rsi"
"mov     %rsi, QWORD PTR [%rbp-32]"
"mov     %rdi, QWORD PTR [%rbp-24]"
"call    strstr"
"mov     QWORD PTR [%rbp-8], %rax"
"cmp     QWORD PTR [%rbp-8], 0"
"je      .L2"
"mov     %rax, QWORD PTR [%rbp-8"
"mov     %edx, %eax"
"mov     %rax, QWORD PTR [%rbp-24]"
"mov     %ecx, %edx"
"sub     %ecx, %eax"
"mov     %eax, %ecx"
"mov     DWORD PTR [%rbp-36], %eax"
"jmp     .L4"
".L2:"
"mov     DWORD PTR [%rbp-36], -1"
".L4:"
"mov     %eax, DWORD PTR [%rbp-36]"
"leave"
"ret"
);
}
//fONKSÝYONUN BÝTÝSÝ

char* ReadFile(char *filename)
{
	char *buffer = NULL;
	int string_size, read_size;
	FILE *handler;
	errno_t err = fopen_s(&handler,filename, "r");

	if (err == 0)
	{
		fseek(handler, 0, SEEK_END);

		string_size = ftell(handler);

		rewind(handler);

		buffer = (char*)malloc(sizeof(char) * (string_size + 1));
	
		read_size = fread(buffer, sizeof(char), string_size, handler);
		

		buffer[read_size] = '\0';

	
		fclose(handler);
	}
	else
	{
		cout<<filename << " file was not open.\n";
	}

	return buffer;
}

int main()
{
	//deðiþken tanýmla
	FILE *fp;
	char isim[50];

	cout << "1. dosyanin adini giriniz:";
	//gets_s(isim);
	char *s1 = ReadFile(isim);
	cout << "2. dosyanin adini giriniz:";
	//gets_s(isim);
	char *s2 = ReadFile(isim);

	//konsola yazdýr
	//doluysa yazdýr
	if (s1)
	{
		printf("%s\n", s1);
	}
	
	
	if (s1 && s2) //boþ deðilse bu iþlemi yap
	{
		printf("Return: %d\n", find(s1, s2));
	}
	
	return 0;
}
