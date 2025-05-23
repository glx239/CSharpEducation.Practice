namespace Task19;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Random rnd = new Random();
            arr[i] = rnd.Next(1, 100);
        }
        Console.WriteLine(SubMaxMin(arr));
    }

    static int SubMaxMin(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return max - min;
    }
}