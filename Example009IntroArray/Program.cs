int Max(int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2 > result) result = arg2;
	if (arg3 > result) result = arg3;
	return result;
}
int max = 0;
int[] arr = { 11, 32, 343, 24, 55, 76, 77, 683, 94, };

for (int count = 0; count < arr.Length; count++)
{
	if (arr[count] > arr[max]) arr[max] = arr[count];
}

Console.WriteLine(arr[max]);


