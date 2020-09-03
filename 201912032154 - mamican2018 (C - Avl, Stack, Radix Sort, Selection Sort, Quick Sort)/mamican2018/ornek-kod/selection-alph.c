#include <stdlib.h>
#include <stdio.h>
#include <dirent.h>
#include <string.h>

// definition of the structure (global scope)
typedef struct  s_file
{
    char        *file_name;
    struct      s_file *next;
} t_file;

int static counter = 0;

void sort_alpha(t_file **begin_list)
{
  t_file    *list;
  char  *tmp;
  list = *begin_list;
  if (list)
    {
        while (list && list->next)
        {
            if (strcmp(list->file_name, list->next->file_name) > 0)
            {
                tmp = list->file_name;
                list->file_name = list->next->file_name;
                list->next->file_name = tmp;
                counter = counter + 1;
                printf("swap=%d\n",counter);
            }
        list = list->next;
        }
    }
}

int list_size(t_file **alst)
{
    int size = 0;
    t_file  *conductor;  // This will point to each node as it traverses the list
    conductor = *alst;      
    if ( conductor != 0 ) 
    {
        size = 1;
        while ( conductor->next != 0)
        {
            conductor = conductor->next;
            size = size + 1;
        }
     }
    return size;
}

void list_add(t_file **alst, t_file *newElement)
{
    printf("list_add->");
    if (newElement)
    {
         newElement->next = *alst;
         *alst = newElement;

        // Printing the added element
        printf("list_add:newElement=%s\n",(*alst)->file_name);

        // sorting:
        sort_alpha(alst); 
    }
    else
    {
        printf("NULL entry\n");
    }
}

t_file  *newEntry(char *file_name)
{
    t_file *file;
    file = (t_file *) malloc( sizeof(t_file) );
    printf("newEntry:file_name= %s\n",file_name);
    if (file)
    {
       file->file_name = file_name;
       file->next = NULL;
   }
   return (file);
}

// Untested
void read_dir(char *dir_name, t_file **begin_list)
{
    DIR *dir;   
    struct dirent *entry;
    dir = opendir(dir_name);
    if (!dir)
   {
        perror(dir_name);
        return;
   }
    while ((entry = readdir(dir)) != NULL){
        list_add(begin_list, newEntry(entry->d_name));
   }    
    closedir(dir);
}

int main(int ac, char **av)
{
    t_file *s,*iter,*e2,*e3,*e4,*e5,*e6,*e7;
    int j=0;

    printf("*Program Start*\n");        

    // Creating entries:
    s  = newEntry("dHea");
    e2 = newEntry("bbcx");
    e3 = newEntry("abcd");
    e4 = newEntry("cbcd");
    e5 = newEntry("cbad");
    e6 = newEntry("bbcd");
    e7 = newEntry("cbaa");

    // Adding entries to the list and sorting at the same time
    list_add(&s, e2);
    list_add(&s, e3);
    list_add(&s, e4);
    list_add(&s, e5);
    list_add(&s, e6);
    list_add(&s, e7);

    // It was done by:
    // read_dir(av[1], &s); // Untested

    // Print the sorted list
    iter = s;
    while (iter)
    {
        j++;
        printf("Printing sorted list: element %d = %s\n",j,iter->file_name);
        iter = iter->next;
    }

    printf("*Program End**\n");
    return 0;
}