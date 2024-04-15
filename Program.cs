namespace Sort_Matrix_HW
{
    internal class Program
    {
        static void Main()
        {
            int[,] a = 
            { 
                { 7, 3, 2 }, 
                { 4, 9, 6 }, 
                { 1, 8, 5 } 
            };

            Sort_Matrix(a);

            Print_Matrix(a);
        }

        static void Sort_Matrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < cols; y++)
                        {
                            if (matrix[i, j] < matrix[x, y])
                            {
                                (matrix[i, j], matrix[x, y]) = (matrix[x, y], matrix[i, j]);
                            }
                        }
                    }
                }
            }
        }

        static void Print_Matrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
