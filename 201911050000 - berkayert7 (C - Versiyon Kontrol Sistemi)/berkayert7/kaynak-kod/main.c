#include <stdio.h>
#include <string.h> 
#include <stdlib.h> 
#include <string.h> 

int comment;
int diff(FILE *input1, FILE *input2, FILE *output, int comment);
int init(FILE *input);
void push2file(int comment);
void f_comment(FILE *input);
void file2file(char *input, char *output);
int del_line(char veri[1000],FILE *input,FILE *output, int baslangic);

int main(int argc, char *argv[]){
	
	FILE *input,*input2,*output;
	int islem_no = (int)*argv[1] - 48;
	int arg;
	char dosya[100];
	switch(islem_no){
		case 0:
			input = fopen(argv[2],"r");
			init(input);
			break;
		case 1:
			input = fopen(argv[2],"r");
			f_comment(input);
			break;
		case 2:
			 arg = (int)*argv[2]-48;
			break;
		default:
			printf("Gecersiz bir arguman girildi!");
			break;
	}
}

int diff(FILE *input1, FILE *input2, FILE *output, int comment){
	if(input1 == NULL){
		printf("input1 bulunamadi !");
		return -1;
	}
	if(input2 == NULL){
		printf("input2 bulunamadi !");
		return -1;
	}
    char ch1 = fgetc(input1); 
    char ch2 = fgetc(input2); 
    int degisiklik = 0, satir = 1,o_pos = 0; 
  	char veri1[1000],veri2[1000];
  	fseek(input1,0,SEEK_SET);
  	fseek(input2,0,SEEK_SET);
    while (fgets(veri1,1000,input1) != NULL && fgets(veri2,1000,input2) != NULL) { 
        if(strcmp(veri1,veri2) == 0){
        	fprintf(output,"%s",veri1);
		}
        else{
        	int pos2 = ftell(input2);
        	int donut = find_line(veri1,input2);
  			if(donut == 0){
  				fprintf(output,">%d>%s",comment,veri1);
			}
			else{
				int n_pos = del_line(veri1,input2,output,pos2-o_pos);	
				fseek(input2,n_pos,SEEK_SET);
			  /*fgets(veri2,1000,input2);	
				fprintf(output,"%s",veri2);*/
			}
			degisiklik++;
		}
		o_pos = ftell(input2);
        satir++;
    } 
  	if(degisiklik == 0){
  		printf("Degisiklik yok");
  		file_copy(input1,output);
		return -1;	
	}
	else{
		printf("Tum degisiklikler: %d",degisiklik);
		return 0;
	}
}

int init(FILE *input){
	if(input == NULL){
		printf("input bulunamadi !");
		return -1;
	}
	FILE *output = fopen("push.txt","r");
	if(output != NULL){
		printf("push.txt mevcut");
		return -1;
	}
	char ch;
	output = fopen("push.txt","w");
	while((ch = fgetc(input)) != EOF){
		fputc(ch,output);
	}
	fclose(input);
	fclose(output);
	comment = 1;
	return 0;
}

void push2file(int comment){
	FILE *input = fopen("push.txt","w");
	FILE *output = fopen("mevcut.txt","r");
	char veri[1000];
	 while (fgets(veri,1000,input) != NULL) { 
        if(strchr(veri,'<') == NULL && strchr(veri,'>') == NULL){
        	fprintf(output,"%s",veri);
		}
        else{
        	int pos;
        	if(pos = strstr(veri,'<')){
        		if(((int)veri[pos+1]-48) > comment){
        			removeSubstr(veri,"<"); removeSubstr(veri,"<");
        			fprintf(output,"%s",veri);
				}		
			}
			if(pos = strstr(veri,'>')){
        		if(((int)veri[pos+1]-48) <= comment){
        			removeSubstr(veri,">"); removeSubstr(veri,">");
        			fprintf(output,"%s",veri);
				}		
			}
		}
    } 
}

void f_comment(FILE *input){
	FILE *input2 = fopen("mevcut.txt","r"), *output = fopen("push.txt","r");
	comment += 1;
	diff(input,input2,output,comment);
}

void file_copy(FILE *input, FILE *output){
	fseek(input,0,SEEK_SET);
	char ch;
    while ((ch = fgetc(input)) != EOF)
        fputc(ch, output);
}

int find_line(char veri1[1000],FILE *input){
	fseek(input,0,SEEK_SET);
	char veri2[1000];
	while (fgets(veri2,1000,input) != NULL) {
		if(strcmp(veri1,veri2) == 0)
        	return ftell(input); 	
    } 
    return 0;
}

int del_line(char veri[1000],FILE *input,FILE *output, int baslangic){
	fseek(input,baslangic,SEEK_SET);
	char veri2[1000];
	int pos;
	while(fgets(veri2,1000,input) != NULL){
		if(strcmp(veri2,veri) == 0)
			return pos;
		pos = ftell(input);
		fprintf(output,"<%d<%s",comment,veri2);
	}
	return 0;
}

void removeSubstr (char *string, char *sub) {
    char *match = string;
    int len = strlen(sub);
    while ((match = strstr(match, sub))) {
        *match = '\0';
        strcat(string, match+len);
                match++;
    }
}






