int Max( int num1, int num2, int num3)
{
    int result = num1;
    if (num2 > result) result = num2;
    if (num3 > result) result = num3;
    return result;
}

int a1 = 20;
int b1 = 30;
int c1 = 300;
int a2 = 50;
int b2 = 256;
int c2 = 1000;
int a3 = 40009;
int b3 = 376;
int c3 = 226;


int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3)
);

Console.WriteLine(max);