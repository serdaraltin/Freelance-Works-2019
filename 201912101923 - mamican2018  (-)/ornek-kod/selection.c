
Node* selectionSort(Node* head) 
{ 
    Node *a, *b, *c, *d, *r; 
  
    a = b = head; 
    while (b->next) { 
        c = d = b->next; 
        while (d) { 
  
            if (b->data > d->data) { 
                if (b->next == d) {  
                    if (b == head) { 
                        b->next = d->next; 
                        d->next = b; 
                        r = b; 
                        b = d; 
                        d = r; 
                        c = d; 
                        head = b; 
                        d = d->next; 
                    } 
                    else {
                        b->next = d->next; 
                        d->next = b; 
                        a->next = d; 
                        r = b; 
                        b = d; 
                        d = r; 
                        c = d; 
                        d = d->next; 
                    } 
                } 

                else { 
                    if (b == head) { 
                        r = b->next; 
                        b->next = d->next; 
                        d->next = r; 
                        c->next = b;  
                        r = b; 
                        b = d; 
                        d = r; 
  
                        c = d; 
                        d = d->next; 
                        head = b; 
                    } 
                    else { 
                        r = b->next; 
                        b->next = d->next; 
                        d->next = r; 
                        c->next = b; 
                        a->next = d; 
                        r = b; 
                        b = d; 
                        d = r; 
                          c = d; 
                        d = d->next; 
                    } 
                } 
            } 
            else { 
                c = d; 
                d = d->next; 
            } 
        } 
        a = b; 
        b = b->next; 
    } 
    return head; 
} 
  
// Function to print the list 
void printList(Node* head) 
{ 
    while (head) { 
        cout << head->data << " "; 
        head = head->next; 
    } 
} 