using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string matrix;
            string[,] matrix1 = new string[10, 10];
            string[,] matrix2 = new string[10, 10];
            string[] temp = new string[10];
            int row1 = 0, row2 = 0, col1 = 0, col2 = 0;
            Console.WriteLine("請輸入矩陣一(輸入空行完成):");
            for (int i = 0; i < 10; i++)  //直接NULL?
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix1[i, j] = "*";
                    matrix2[i, j] = "*";
                }
            }

            while (true)
            {
                matrix = Console.ReadLine();
                if (matrix == "9")
                {
                    break;
                }
                else
                {
                    temp = matrix.Split(' ');
                    col1 = temp.Length;
                }
                for(int i = col1 - 1; i >= 0; i--)
                {
                    //int num = int.Parse(temp[i]);
                    matrix1[row1, i] = temp[i];
                }
                row1++;
            }

            Console.WriteLine("請輸入矩陣二(輸入空行完成):");
            while (true)
            {
                matrix = Console.ReadLine();
                if (matrix == "9")
                {
                    break;
                }
                else
                {
                    temp = matrix.Split(' ');
                    col2 = temp.Length;
                }
                for (int i = col2 - 1; i >= 0; i--)
                {
                    //int num = int.Parse(temp[i]);
                    matrix1[row2, i] = temp[i];
                }
                row2++;
            }

            int[,] ans = new int[row1, col2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    ans[i, j] = 0;
                }
            }

            if (row2 != col1)
            {
                Console.WriteLine("矩陣大小不一致，不能相乘");
                Console.Read();
            }
            else
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        for (int z = 0; z < col1; z++)
                            ans[i, j] = ans[i, j] + int.Parse(matrix1[i, z]) * int.Parse(matrix2[z, j]);
                    }
                }

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        Console.Write("{0}", ans[i, j]);
                    }
                    Console.WriteLine();
                }
            }


           


        }
    }
}
