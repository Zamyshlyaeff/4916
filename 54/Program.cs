/* С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
Принять первые числа равными 0 и 1*/
void Fib(int g)
{ int a=0,b=1,c=0;
for (int i=0;i<g;i++)
{System.Console.WriteLine($"{c}");
c=a+b;
a=b;
b=c;


}


}
int N=Convert.ToInt32(Console.ReadLine());
Fib(N);
