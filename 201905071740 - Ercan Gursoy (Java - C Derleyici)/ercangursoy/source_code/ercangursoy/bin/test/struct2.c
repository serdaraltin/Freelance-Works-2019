

struct t5 {
    int x;
};

struct t4 {
    struct t5 x;
};

struct t3 {
    struct t4 x;
};

struct t2 {
    struct t3 x;
};

struct t1 {
    struct t2 x;
};

struct t1 b;
static struct t1 d;

int
main(int argc, char **argv)
{
    struct t1 a;
    static struct t1 c;

    a.x.x.x.x.x = 701;
    printf("%d", a.x.x.x.x.x);

    b.x.x.x.x.x = 702;
    printf(";%d", b.x.x.x.x.x);

    c.x.x.x.x.x = 703;
    printf(";%d", c.x.x.x.x.x);

    d.x.x.x.x.x = 704;
    printf(";%d", d.x.x.x.x.x);


    return 0;
}

static int
printf(char *s, ...)
{
    return 1;
}