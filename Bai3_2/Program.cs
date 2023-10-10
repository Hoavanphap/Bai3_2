using System;
namespace Bai3_2
{
    class BaiTapVeNha
    {
        static void Main(string[] args)
        {
            int rows, cols;
            int tong = 0;
            int min;
            Console.Write("Nhap so dong:");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot:");
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] mang = new int[rows, cols];
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu cho mang[{0},{1}]:", i, j);
                    mang[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i, j] + " ");
                    tong += mang[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong Cac phan tu co trong mang tren la: " + tong);
            min = mang[0, 0];
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    if (min > mang[i, j])
                    {
                        min = mang[i, j];

                    }
                }
                Console.WriteLine("Phan tu nho nhat trong cot:" + min);
            }
            Console.WriteLine("Phan tu chia het cho 7:");
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    if (mang[i, j] % 7 == 0)
                    {
                        Console.Write(mang[i, j] + " ");
                    }

                }
            }

        }
    }
}