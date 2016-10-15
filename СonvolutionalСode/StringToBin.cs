using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToBin
{
    class StrngToBin // Класс для преобразования строки в двоичный код и наоборот
    {
        static public string[] StrToBin(string str) // Функция переводит каждый символ строки в двоичный код и возвращает массив со строками (каждая строка массива - двоичный код соответствующего символа)
        {
            string[] temp_st = new string[str.Length];
            int[] code_arr = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                temp_st[i] = Convert.ToString(Convert.ToInt32(str[i]), 2);
            }

            return temp_st;
        }

        static public string[] StrTo16Bin(string str) // Функция переводит каждый символ строки в шестнадцатизначный двоичный код и возвращает массив со строками (каждая строка массива - двоичный код соответствующего символа)
        {
            string[] temp_st = new string[str.Length];
            int[] code_arr = new int[str.Length];            

            for (int i = 0; i < str.Length; i++)
            {
                temp_st[i] = To16Digits(Convert.ToString(Convert.ToInt32(str[i]), 2));
            }

            return temp_st;
        }

        static public string StrArrToStr(string[] str_arr) // Функция получает массив строк и склеивает его в одну строку
        {
            string res = "";
            for(int i = 0; i < str_arr.Length; i++)
            {
                res += str_arr[i];
            }

            return res;
        }

        static public string BinToStr(string[] coded_str_arr) // Функция получает строку битов и возвращает строку соответствующих символов
        {
            string str = "";
            for (int i = 0; i < coded_str_arr.Length; i++)
            {
                str += Convert.ToChar(Convert.ToUInt32(coded_str_arr[i], 2));
            }

            return str;
        }

        static public string To16Digits(string str) // Функция добавляет 0 перед строкой, до тех пор, пока строка не будет = 16 символам
        {
            int delta = 16 - str.Length;

            if (delta <= 0)
            {
                return str;
            }
            else
            {
                string temp_str = "";
                for (int i = 0; i < delta; i++)
                {
                    temp_str += "0";
                }
                return (temp_str + str);
            }
        }
    }
}