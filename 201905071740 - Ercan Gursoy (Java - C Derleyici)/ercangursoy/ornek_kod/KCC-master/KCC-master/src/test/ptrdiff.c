

int
main(int argc, char** argv)
{
    int x, y;
    void *p = &x;
    void *q = &y;

    printf("%d", q - p);
    printf(";%d", q - (p + 1));
    printf(";%d", q - (1 + p));
    printf(";%d", q - (p - 1));

    return 0;
}

static int
printf(char *s, ...)
{
    return 1;
}
