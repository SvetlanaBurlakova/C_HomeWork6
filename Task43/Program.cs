/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}
(float x,float y) Equition(int k1,int b1,int k2, int b2)
{
    float x=(float)(b2 - b1)/(k1 - k2);
    float y = k1 *x +b1;
    return (x,y);
}
int b1=GetNumber("Введите коэффициент b1 уравнения y=k1*x+b1");
int k1=GetNumber("Введите коэффициент k1 уравнения y=k1*x+b1");
int b2=GetNumber("Введите коэффициент b2 уравнения y=k2*x+b2");
int k2=GetNumber("Введите коэффициент k2 уравнения y=k2*x+b2");
( float x , float y) = Equition(k1,b1,k2,b2);
Console.WriteLine($"({x:0.00}; {y:0.00})");