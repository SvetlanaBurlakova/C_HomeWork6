/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int NumberofPositive(int [] array)
{
    int number =0;
    for (int i=0;i<array.Length; i++) if (array[i]>0) number+=1;
    return number;
}
Console.WriteLine("Введите массив через запятую:");
string str =Console.ReadLine();
string [] arrayStr = str.Split(',');
int [] array =new int[arrayStr.Length];

for (int i=0;i<arrayStr.Length;i++) array[i]=Convert.ToInt32(arrayStr[i]);
int result =NumberofPositive(array);
Console.WriteLine($"Количество положительных чисел равно {result}");

