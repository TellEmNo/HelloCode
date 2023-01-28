/* string[,] table = new string[2, 5];

// String.Empty - строки инициализируются пустой строкой 
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++){
	for (int columns = 0; columns < 5; columns++){
		Console.WriteLine($"-{table[rows, columns]}-");
	}
} */
/* 
int[,] matrix = new int[10, 10];

for (int rows = 0; rows < matrix.GetLength(0); rows++){
	for (int columns = 0; columns < matrix.GetLength(1); columns++){
		matrix[rows, columns] = new Random().Next(0, 101);
		Console.Write($"{matrix[rows, columns]} ");
	}
	Console.WriteLine();
}
 */
/* 
void PrintMatrix(int rows, int columns, int down, int up){
	int[,] matrix = new int[rows, columns];
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			matrix[i, j] = new Random().Next(down, up + 1);
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижний предел рандомайзера: ");
int down = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите врехний предел рандомайзера: ");
int up = Convert.ToInt32(Console.ReadLine());

PrintMatrix(rows, columns, down, up);
 */

// Если есть фиксированные данные, то необязательно указывать количество строчек и столбцов
/*
int[,] pic = new int[,] {

{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void ImageArray(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i,j] == 0) Console.Write($" ");
			else Console.Write($"*");
		}
		Console.WriteLine();
	}
}

void FillImage(int row, int col){
	if (pic[row, col] == 0){
		pic[row, col] = 1;
		FillImage(row - 1, col);
		FillImage(row, col - 1);
		FillImage(row + 1, col);
		FillImage(row, col + 1);
	}
}
ImageArray(pic);
FillImage(2, 12);
ImageArray(pic);
 */
/* 
double Factorial(int n){
	// 1! = 1
	// 0! = 1
	if (n == 1 || n == 0) return 1;
	else return n * Factorial(n - 1);
}

for (int i = 0; i <= 30; i++)
{
	Console.WriteLine($"{i}! = {Factorial(i)}");
}
 */

// F(1) = 1, F(2) = 1, F(n) = F(n-1) + F(n-2)
/* 
double Fibonacci(int n){
	if (n == 1 || n == 2) return 1;
	else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i <= 40; i++)
{
	Console.WriteLine($"f({i}) = {Fibonacci(i)} ");
}
 */
/* 
void FindWords(string alphabet, char[] word, int length = 0)
{
	if (length == word.Length)
	{
		int n = 0;
		Console.WriteLine($"{n++} {new String(word)}"); return;
	}
	for (int i = 0; i < alphabet.Length; i++)
	{
		word[length] = alphabet[i];
		FindWords(alphabet, word, length + 1);
	}
}

FindWords("аисв", new char[2]); */
--