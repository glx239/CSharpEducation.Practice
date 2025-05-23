namespace Task18;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {-1, 2, -3, 4, 5, 6, -7, 8, 9};
        int count;
        ArrayAbs(array, out count);
    }

    static int[] ArrayAbs(int[] array, out int acc)
    {
        int[] arr = new int[array.Length];
        int acc = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                arr[n] = array[i];
                n++;
                
            }
            else
            {
                acc++;
            }
        }
        return arr;
}
}
