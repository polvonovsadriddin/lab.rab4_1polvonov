//вариант 5 высокий     
Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine());
int [] mas = new int [n];
Random rnd = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(10,100) ;
    Console.Write(Convert.ToString(mas[i], 2) + " ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    
    Console.Write(Convert.ToString(mas[i], 8) + " ");
}
