void FillArray(int[] collection)
{
	int len = collection.Length;
	for (int i = 0; i < len; i++)
	{
		collection[i] = new Random().Next(1, 10);
	}

}

void PrintArray(int[] collection)
{
	int count = collection.Length;
	for (int pos = 0; pos < count; pos++)
	{
		Console.WriteLine(collection[pos]);
	}
}

int IndexOf(int[] collection, int f)
{
	int count = collection.Length;
	int pos = -1;
	for (int i = 0; i < count; i++)
	{
		if (collection[i] == f)
		{
			pos = i;
			break;
		}
	}
	return pos;
}

int[] arr = new int[100];

FillArray(arr);
Console.WriteLine("Введите искомое число ");
Console.WriteLine();
int position = IndexOf(arr, Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(position);