union st {
    int x;
    int x;
};

int main(int argc, char **argv)
{
    union st s;
    s.x = 0;
    return s.x;
}
