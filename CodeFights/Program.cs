﻿using System;
using System.Text;

namespace CodeFights {
    class Program {
        static void Main (string[] args) {

            var input = new int[][] { new int[] { 10,9,6,3,7 }, new int[] { 6, 10, 2, 9, 7 }, new int[] { 7, 6, 3, 8, 2 }, new int[] { 8, 9, 7, 9, 9 }, new int[] { 6, 8, 6, 8, 2 } };
            var ans = Methods.RotateImage(input);

            for (int i = 0; i < ans.Length; i++)
            {
                for (int j = 0; j < ans.Length; j++)
                {
                    Console.Write(ans[i][j] + "\t");
                }

                System.Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}