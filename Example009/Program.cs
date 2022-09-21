int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 77, a2 = 7, a3 = 96,
    b1 = 25, b2 = 89, b3 = 567,
    c1 = 5, c2 = 78, c3 = 895;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
          Max(a1, b1, c1),
          Max(a2, b2, c2),
          Max(a3, b3, c3));

Console.WriteLine(max);