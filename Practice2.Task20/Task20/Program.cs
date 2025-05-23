namespace Task20;

class Program
{
    static void Main(string[] args)
    {
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,]  matrix = new int[rows, cols];
        for (int r = 0; r < rows; r++)
        {
            Random rnd = new Random();
            for (int c = 0; c < cols; c++)
            {
                matrix[r, c] = rnd.Next(0, 100);
            }
        }
        SubMatrix(matrix);
    }

    static void SubMatrix(int[,] matrix)
    {
        int[] arr =  new int[matrix.GetLength(0)];
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            int max = matrix[r, 0];
            int min = matrix[r, 0];
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if (matrix[r, c] >= max)
                {
                    max = matrix[r, c];
                }

                if (matrix[r, c] < min)
                {
                    min = matrix[r, c];
                }
            }
            arr[r] = max - min;
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}