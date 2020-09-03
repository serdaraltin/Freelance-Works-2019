struct Node *rsort(struct Node *list,  const int base, int rounds){
    int n = 1;
    struct Node **bucket, *next, *temp;
    // Dyamic bucket array
    bucket = (struct Node**)malloc(sizeof(struct Node)*base);
 
 
    for(int j = 0; j < rounds ;j++)
    {        
        //Place numbers into buckets.        
        while(list!= NULL)
        {    
 
 
                next                  = list->next;            
                list->next            = bucket[(list->data/n)%base];
                bucket[(list->data/n)%base]  = list;
                list                  = list->next;
                list                  = next;
        }
        //Rebuild list
        for(int i = 0; i < base; i++)
        {        
            while(bucket[i]!=NULL)
            {
                temp            = bucket[i]->next;
                bucket[i]->next = list;
                list            = bucket[i];
                bucket[i]       = bucket[i]->next;
                bucket[i]       = temp;
            }
        }
        n *=10;
    }
 
 
    return list;
}