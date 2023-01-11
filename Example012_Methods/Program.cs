// Вид 1: Ничего не принимают и ничего не возвращают
/* 
void Method1(){
	Console.WriteLine("text");
}

Method1(); // Так вызывается метод такого типа, (скобки обязательны)
 */

// Вид 2: Ничего не возвращают, но принимают какое-то значение
/* 
void Method2(string msg){
	Console.WriteLine(msg);
}
Method2("Message!");
 */
/* Так же существуют именованные аргументы, 
когда явно может быть указанно какому аргументу, какое значение мы хотим присвоить
это бывает часто нужно в случае, если метод принимает какое-то значение аргументов, отличное от одного.
Именованные аргументы не обязательно вызывать по порядку
*/

/* void Method21(string msg, int count){
	for (int i = 0; i < count; i++)
		Console.WriteLine(msg);
}
Method21(msg: "Message", count: 4);
Method21(count: 4, msg: "Jops");
 */
/* Кстати, увеличение переменной на единицу называют инкрементом, а вычитание единицы декрементом */

// Вид 3: Возвращает какое-то значение, но не принимает никаких значений
/* 
int Method3(){
	return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Вид 4: Принимает какое-то значение и возвращает
/*
string Method4(int count, string c){
	string result = String.Empty;
	for (int i = 0; i < count; i++){
		result = result + c;
	}
	return result;
}

string res = Method4(3, "Jopa + ");
Console.WriteLine(res);
*/

/*
for(int i = 2; i < 10; i++){
	for(int j = 1; j <= 10; j++){
	Console.WriteLine($"{i} * {j} = {i*j}");
	}
	Console.WriteLine();
}
*/

/* Работа с текстом
Дан текст. В тексте нужно заменить все пробелы нижним подчеркиванием,
маленькие буквы "к" заменить большими "К"
и большие "с" заменить маленькими "С" */
/* 
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
						+ "ежели бы вас послали вместо нашего милого Винценгероде"
						+ "вы бы взяли приступом согласие прусского короля."
						+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue){
	string result = String.Empty;

	int length = text.Length;
	for (int i = 0; i < length; i++)
	{
		if(text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}

	return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
 */
/* 
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array){
	int count = array.Length;
	for (int i = 0; i < count; i++){
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array){
	for (int i = 0; i < array.Length - 1; i++){
		int minPosition = i;
		for (int j = i + 1; j < array.Length; j++){
			if(array[j]<array[minPosition]) minPosition = j;
		}
			int temporary = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temporary;
	}
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
 */

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array){
	int count = array.Length;
	for (int i = 0; i < count; i++){
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array){
	for (int i = 0; i < array.Length - 1; i++){
		int maxPosition = i;
		for (int j = i + 1; j < array.Length; j++){
			if(array[j]>array[maxPosition]) maxPosition = j;
		}
			int temporary = array[i];
		array[i] = array[maxPosition];
		array[maxPosition] = temporary;
	}
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);