#include <stdio.h>
#include <stdlib.h>

struct bucket_entry
{
    char *str;
    size_t len;
    struct bucket_entry *next;
};
typedef struct bucket_entry bucket_entry;
 
/* A linked list */
struct bucket
{
    bucket_entry *head;
    bucket_entry *tail;
};
typedef struct bucket bucket;
 
/* Initialise buckets */
static void init_buckets(bucket *buckets)
{
    unsigned int b;
    for (b = 0; b < 256; b++) {
        buckets[b].head = NULL;
        buckets[b].tail = NULL;
    }
}
 
/*
 * Turn entries into a linked list of words with their lengths
 * Return the length of the longest word
 */
static size_t init_entries(char **strings, size_t len, bucket_entry *entries)
{
    unsigned int s;
    size_t maxlen = 0;
    for (s = 0; s < len; s++) {
        entries[s].str = strings[s];
        entries[s].len = strlen(strings[s]);
        if (entries[s].len > maxlen) {
            maxlen = entries[s].len;
        }
        if (s < len - 1) {
            entries[s].next = &entries[s + 1];
        }
        else {
            entries[s].next = NULL;
        }
    }
    return maxlen;
}
 
/* Put strings into buckets according to the character c from the right */
void bucket_strings(bucket_entry *head, bucket *buckets, unsigned int c)
{
    bucket_entry *current = head;
    while (current != NULL) {
        bucket_entry * next = current->next;
        current->next = NULL;
        int pos = current->len - 1 - c;
        unsigned char ch;
        if (pos < 0) {
            ch = 0;
        }
        else {
            ch = current->str[pos];
        }
        if (buckets[ch].head == NULL) {
            buckets[ch].head = current;
            buckets[ch].tail = current;
        }
        else {
            buckets[ch].tail->next = current;
            buckets[ch].tail = buckets[ch].tail->next;
        }
        current = next;
    }
}
 
/* Merge buckets into a single linked list */
bucket_entry *merge_buckets(bucket *buckets)
{
    bucket_entry *head = NULL;
    bucket_entry *tail;
    unsigned int b;
    for (b = 0; b < 256; b++) {
        if (buckets[b].head != NULL) {
            if (head == NULL) {
                head = buckets[b].head;
                tail = buckets[b].tail;
            }
            else {
                tail->next = buckets[b].head;
                tail = buckets[b].tail;
            }
        }
    }
    return head;
}
 
void print_buckets(const bucket *buckets)
{
    unsigned int b;
    for (b = 0; b < 256; b++) {
        if (buckets[b].head != NULL) {
            const bucket_entry *entry;
            printf("[%d] ", b);
            for (entry = buckets[b].head; entry != NULL; entry = entry->next) {
                printf("%s", entry->str);
                if (entry->next) {
                    printf(" -> ");
                }
            }
            putchar('\n');
        }
    }
    putchar('\n');
}
 
void print_list(const bucket_entry *head)
{
    const bucket_entry *current;
    for (current = head; current != NULL; current = current->next) {
        printf("%s", current->str);
        if (current->next != NULL) {
            printf(" -> ");
        }
    }
    printf("\n");
}
 
void copy_list(const bucket_entry *head, char **strings)
{
    const bucket_entry *current;
    unsigned int s;
    for (current = head, s = 0; current != NULL; current = current->next, s++) {
        strings[s] = current->str;
    }
}
 
void radix_sort_string(char **strings, size_t len)
{
    size_t maxlen;
    unsigned int c;
    bucket_entry *head;
    bucket_entry *entries = malloc(len * sizeof(bucket_entry));
    bucket *buckets = malloc(256 * sizeof(bucket));
    if (!entries || !buckets) {
        free(entries);
        free(buckets);
        return;
    }
    init_buckets(buckets);
    maxlen = init_entries(strings, len, entries);
    head = &entries[0];
    /* Main loop */
    for (c = 0; c < maxlen; c++) {
        printf("Bucketing on char %d from the right\n", c);
        bucket_strings(head, buckets, c);
        print_buckets(buckets);
        head = merge_buckets(buckets);
        print_list(head);
        init_buckets(buckets);
    }
    /* Copy back into array */
    copy_list(head, strings);
    free(buckets);
    free(entries);
}


int main(void)
{
    char *strings[] = {"The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};
    const size_t len = sizeof(strings) / sizeof(char*);
    unsigned int s;
    radix_sort_string(strings, len);
    for (s = 0; s < len; s++) {
        printf("%s\n", strings[s]);
    }
    return 0;
}
