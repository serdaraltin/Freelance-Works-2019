

int
main(int argc, char **argv)
{
    switch (argc) {
    case 1:
    case 2:
        puts("1 or 2");
        break;
    case 3:
    case 4:
        puts("3 or 4");
        break;
    case 5:
    case 6:
        puts("5 or 6");
        break;
    default:
        puts("other");
        break;
    }
    return 0;
}

static int puts(char * a){
    return 0;
}