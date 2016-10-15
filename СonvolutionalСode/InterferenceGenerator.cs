using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СonvolutionalСode
{
    class InterferenceGenerator
    {
        static public System.Drawing.Point[] GenInter(ref string[] bin_arr, int interinten) // Функция вносит помехи в указанный массив двоичных строк и возвращает массив позиций, которые были изменены
        {
            Random rnd = new Random();
            StringBuilder[] SB_arr = new StringBuilder[bin_arr.Length];
            System.Drawing.Point[] interfbit_pos = new System.Drawing.Point[interinten];

            for (int i = 0; i < SB_arr.Length; i++)
            {
                SB_arr[i] = new StringBuilder(bin_arr[i]);
            }

            for (int i = 0; i < interinten; i++)
            {
                interfbit_pos[i].Y = rnd.Next(SB_arr.Length);
                interfbit_pos[i].X = rnd.Next(SB_arr[interfbit_pos[i].Y].Length);

                if (SB_arr[interfbit_pos[i].Y][interfbit_pos[i].X] == '0')
                {
                    SB_arr[interfbit_pos[i].Y][interfbit_pos[i].X] = '1';
                }
                else
                {
                    if (SB_arr[interfbit_pos[i].Y][interfbit_pos[i].X] == '1')
                    {
                        SB_arr[interfbit_pos[i].Y][interfbit_pos[i].X] = '0';
                    }
                }
            }

            for (int i = 0; i < bin_arr.Length; i++)
            {
                bin_arr[i] = SB_arr[i].ToString();
            }

            return interfbit_pos;
        }

        static public void GenInter(ref string[] bin_arr, int interinten, bool flag) // Функция вносит помехи в указанный массив двоичных строк
        {
            Random rnd = new Random();
            StringBuilder[] SB_arr = new StringBuilder[bin_arr.Length];
            int str_num, char_num;

            for (int i = 0; i < SB_arr.Length; i++)
            {
                SB_arr[i] = new StringBuilder(bin_arr[i]);
            }

            for (int i = 0; i < interinten; i++)
            {
                str_num = rnd.Next(SB_arr.Length);
                char_num = rnd.Next(SB_arr[str_num].Length);

                if (SB_arr[str_num][char_num] == '0')
                {
                    SB_arr[str_num][char_num] = '1';
                }
                else
                {
                    if (SB_arr[str_num][char_num] == '1')
                    {
                        SB_arr[str_num][char_num] = '0';
                    }
                }
            }

            for (int i = 0; i < bin_arr.Length; i++)
            {
                bin_arr[i] = SB_arr[i].ToString();
            }
        }

    }
}
