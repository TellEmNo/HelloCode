int[] arr = { 11, 52, 36, 42, 534, 36, 47, 83, 92 };

int n = arr.Length;
Console.WriteLine("Введите искомое число");
int f = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	if (arr[i] == f)
	{
		Console.WriteLine(i);
		break;
	}
}