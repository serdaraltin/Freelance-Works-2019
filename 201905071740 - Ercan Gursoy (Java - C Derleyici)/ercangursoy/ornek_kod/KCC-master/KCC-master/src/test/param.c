

int
main(int argc, char **argv)
{
    return f(1);
}

int
f(int i)
{
    printf("%d", i);
    i = 2;
    printf(";%d\n", i);
    return 0;
}

static int
printf(char *s, ...)
{
    return 1;
}
