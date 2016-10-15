using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using StringToBin;

namespace FinkaCode
{
    class WorkWithFinka // Класс для кодирования по методу Финка
    {
        static public string[] CodeViaFinka(string str) // Функция кодирует каждый символ строи в код Финка и возвращает массив строк с закодированными двоичными значениями
        {
            string[] bin_arr = StrngToBin.StrToBin(str), code_arr, res_arr = new string[str.Length];

            for(int i = 0; i < bin_arr.Length; i++)
            {
                code_arr = CodeArr(bin_arr[i]);
                for (int j = 0; j < bin_arr[i].Length - 1; j++)
                {
                    res_arr[i] += bin_arr[i][j] + code_arr[j];
                }
            }

            return res_arr;
        }

        static public string[] UncodeFinkaArr(string[] finka_str_arr) // Функция раскодирует указанный массив бинарных строк (каждая строка закодирована кодом Финка) и возвращает массив исходных строк
        {
            string[] res_arr = new string[finka_str_arr.Length];

            for(int i = 0; i < res_arr.Length; i++)
            {
                res_arr[i] = finka_str_arr[i][0].ToString();
                for(int j = 1, k = 0; j < finka_str_arr[i].Length; j += 2, k++)
                {
                    res_arr[i] += AddingByModule(res_arr[i][k], finka_str_arr[i][j]);
                }
            }

            return res_arr;
        }

        static public string[] CodeArr(string binstr) // Функция получает на вход битовую строку и возвращает массив, который является результатом сложения по модулю каждого элемента этой строки
        {
            List<int> Adit_coll = new List<int>();

            for(int i = 0; i < binstr.Length - 1; i++)
            {
                Adit_coll.Add(AddingByModule(binstr[i], binstr[i+1]));
            }

            string[] Adit_arr = new string[Adit_coll.Count];

            for(int i = 0; i < Adit_arr.Length; i++)
            {
                Adit_arr[i] = Adit_coll[i].ToString();
            }

            return Adit_arr;
        }        

        static private int AddingByModule(char a, char b) // Функция получает на вход два бита и возвращает результат их сложения по модулю
        {
            return ( int.Parse(Convert.ToString(a)) ^ int.Parse(Convert.ToString(b)) );
        }
    }
}