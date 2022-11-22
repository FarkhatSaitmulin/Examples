int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}
int[] array = { 123, 213, 342, 454, 598, 600, 775, 898, 902 };
array[0] = 2;
Console.WriteLine(array[3]);


