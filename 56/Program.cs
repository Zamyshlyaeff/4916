// Написать программу копирования массива
int [] arr = {15,8,9,3,10};
void Copy()
{ for (int i=0; i!=arr.Length;i++)
{ int[] arr2;
   arr2= new int[arr.Length];
    arr2[i]=arr[i];
System.Console.WriteLine($"{arr2[i]}");
}
}
Copy();
