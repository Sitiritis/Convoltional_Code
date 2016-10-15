using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class WorkWithStrArr
    {
        public string[] main_arr;
        private int arrlength = 0;
        Random rnd = new Random();

        public WorkWithStrArr(int ar_leng) // Конструктор класса
        {
            arrlength = ar_leng; // Задаём длину массива при создании объекта
            main_arr = new string[arrlength]; // Создаём массив
            ArrayRndFill(main_arr); // Заполняем этот массив
        }

        public static int SearchStr(string[] str_arr, string SeekingStr) // Функция получает массив строк и искомую подстроку, а затем возвразает номер элемента массива, в котором первый раз встретилась искомая строка
        {
            for(int i = 0; i < str_arr.Length; i++)
            {
                if (str_arr[i].Contains(SeekingStr))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetParamValue(string Param) // Функция получает параметр и возвращает его значение (число после знака '=')
        {
            int i = 0;
            while (Param[i] != '=')
            {
                i++;
            }

            string ParamValue = "";
            for (int j = i + 1; j < Param.Length; j++)
            {
                ParamValue += Param[j];
            }

            return Convert.ToInt32(ParamValue);
        }

        public void ArrayRndFill(string[] arr) // Заполнение указанного строкового массива случайными строками
        {
            for (int i = 0; i < arrlength; i++)
            {
                arr[i] = randstr();
            }
        }
        
        public string randstr() // Создание случайной строки
        {
            string s_ret = "";
            int randlength = rnd.Next(1, 51);

            for (int i = 0; i < randlength; i++)
            {
                s_ret += randchar();
            }

            return s_ret;
        }

        public char randchar() //Создание случайного символа
        {            
            
            int i_flag = rnd.Next(2);

            if (i_flag == 0)
            {
                return (char)rnd.Next(65, 91);
            } else
            {
                return (char)rnd.Next(97, 123);
            }
        }

        public string[] Sort(string[] str_arr) // Функция возвращает отсортированный строковый массив
        {
            for (int i = 0; i < str_arr.Length; i++)
            {
                for (int j = str_arr.Length - 1; j > i; j--)
                {
                    if ( IfSwap(str_arr[i], str_arr[j]) )
                    {
                        Swap(ref str_arr[i], ref str_arr[j]);
                    }
                }
            }

            return str_arr;
        }

        public bool IfSwap(string str1, string str2) // Функция проверяет какая из входящих строк должна стоять выше в массиве, если это превая, то возвращает false
        {

            for (int i = 0; i < str1.Length; i++)
            {
                if (i == str2.Length)
                {
                    return true;
                }

                if ( (int)str1[i] > (int)str2[i] )
                {
                    return true;
                }
                else
                {
                    if ((int)str1[i] < (int)str2[i])
                    {
                        return false;
                    }
                }                
            }

            return false;
        }

        public void Swap(ref string str1, ref string str2) // Процедура меняет местами 2 элемента строкового массива
        {
            string buff = str1;
            str1 = str2;
            str2 = buff;
        }

    }
}