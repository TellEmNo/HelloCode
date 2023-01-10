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

string Method4(int count, string c){
	string result = String.Empty;
	for (int i = 0; i < count; i++){
		result = result + c;
	}
	return result;
}

string res = Method4(3, "Jopa + ");
Console.WriteLine(res);