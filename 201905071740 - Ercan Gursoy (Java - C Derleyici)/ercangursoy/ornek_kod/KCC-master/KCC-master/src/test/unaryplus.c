

int
main(int argc, char **argv)
{
    int i = 1;
    int j = 0;
    int k = -1;

    printf("%d;%d;%d", +i, +j, +k);

    return 0;
}

static int
printf(char *s, ...)
{
    return 1;
}
