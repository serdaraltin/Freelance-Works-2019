

struct s1 {
    char a;
    short b;
    short x;
    int c;
};

struct s2 {
    int x[4];
    char a;
};

struct s3 {
    char x;
};

struct s4 {
    char x;
    char y;
};

struct s5 {
    char x;
    short y;
    char z;
};

struct s6 {
    char x;
    char y;
    char z;
};

int
main(int argc, char **argv)
{
    printf("%ld", sizeof(struct s1));
    printf(";%ld", sizeof(struct s2));
    printf(";%ld", sizeof(struct s3));
    printf(";%ld", sizeof(struct s4));
    printf(";%ld", sizeof(struct s5));
    printf(";%ld", sizeof(struct s6));


    return 0;
}

static int
printf(char *s, ...)
{
    return 1;
}
