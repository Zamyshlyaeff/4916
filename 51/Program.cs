/* С клавиатуры вводится число N.
Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры*/
int N=0, c=0;
int Init()
{
N=Convert.ToInt32(Console.ReadLine());
return N;
}
int Schet(int a)
{ for (int i=0;i<a;i++)
 {
    int b=Convert.ToInt32(System.Console.ReadLine());
    if (b>0)
       {c++;}
   
 }
return c;
}
Init();
Schet(N);
 System.Console.WriteLine($"{c}");
