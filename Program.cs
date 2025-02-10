namespace massiv;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[4];
        Random randomizer = new Random();
        for (int i = 0; i < arr.Length; i++) 
        {
            arr[i] = randomizer.Next(20, 999);
        }
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Кол-во нечетных чисел = " + count);
    }
}
