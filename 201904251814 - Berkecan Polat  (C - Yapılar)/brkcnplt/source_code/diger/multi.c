#include<stdio.h> 
#include<stdlib.h> 

struct LNode { 
    int data; 
    struct LNode* next; 
}; 

struct TNode { 
    int data; 
    struct TNode* left; 
    struct TNode* right; 
}; 
  
struct TNode* newNode(int data); 
int countLNodes(struct LNode *head); 
struct TNode* sortedListToBSTRecur(struct LNode **head_ref, int n); 

struct TNode* sortedListToBST(struct LNode *head) { 
    int n = countLNodes(head); 
    return sortedListToBSTRecur(&head, n); 
} 
 
struct TNode* sortedListToBSTRecur(struct LNode **head_ref, int n) { 
    if (n <= 0) 
        return NULL; 
    struct TNode *left = sortedListToBSTRecur(head_ref, n/2); 
    struct TNode *root = newNode((*head_ref)->data); 
    root->left = left; 
     *head_ref = (*head_ref)->next; 
    root->right = sortedListToBSTRecur(head_ref, n-n/2-1); 
    return root; 
} 
  

int countLNodes(struct LNode *head) { 
    int count = 0; 
    struct LNode *temp = head; 
    while(temp) { 
        temp = temp->next; 
        count++; 
    } 
    return count; 
} 
  
void push(struct LNode** head_ref, int new_data) {
    struct LNode* new_node =(struct LNode*) malloc(sizeof(struct LNode)); 
    new_node->data  = new_data; 
    new_node->next = (*head_ref); 
(*head_ref)    = new_node; 
} 
  
void printList(struct LNode *node) { 
    while(node!=NULL) { 
        printf("%d ", node->data); 
        node = node->next; 
    } 
} 
  
struct TNode* newNode(int data) { 
    struct TNode* node = (struct TNode*) malloc(sizeof(struct TNode)); 
    node->data = data; 
    node->left = NULL; 
    node->right = NULL; 
    
    return node; 
} 
  
void preOrder(struct TNode* node) { 
    if (node == NULL) 
        return; 
    printf("%d ", node->data); 
    preOrder(node->left); 
    preOrder(node->right); 
} 
  
int main() { 
    
    struct LNode* head = NULL; 
  
    push(&head, 7); 
    push(&head, 6); 
    push(&head, 5); 
    push(&head, 4); 
    push(&head, 3); 
    push(&head, 2); 
    push(&head, 1); 
  
    printf("\n Verilen Baðlantili Liste "); 
    printList(head); 
  

    struct TNode *root = sortedListToBST(head); 
    printf("\n PreOrder Traversal of constructed BST "); 
    preOrder(root); 
  
    return 0; 
} 
