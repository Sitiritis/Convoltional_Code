using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinkaCode;
using StringToBin;
using System.IO;
using System.Collections;
using StringArray;

namespace СonvolutionalСode
{
    public partial class FM_Main : Form
    {
        static string[] bin_arr, adit_elem, convol_code, convol_code_inter, recovered_convol_code;
        static string str_recovered;        

        public FM_Main()
        {
            InitializeComponent();
        }

        private void BT_InsertInterf_MouseUp(object sender, MouseEventArgs e)
        {            
            System.Drawing.Point[] InterferdBits_arr = InterferenceGenerator.GenInter(ref convol_code_inter, (int)NUD_InterfIntensive.Value);
            recovered_convol_code = WorkWithFinka.UncodeFinkaArr(convol_code_inter);
            str_recovered = StrngToBin.BinToStr(recovered_convol_code);

            for (int i = 0; i < RTB_ConvolCodeWithInter.TextLength; i++) // Должно раскрашивать красным цветом помехи в свёрточном коде (изменённые биты), но не работает...
            {
                if (RTB_ConvolCodeWithInter.Text[i] != RTB_ConvolCode.Text[i])
                {
                    RTB_ConvolCodeWithInter.Select(i, 1);
                    RTB_ConvolCodeWithInter.SelectionColor = Color.Red;
                    RTB_ConvolCodeWithInter.DeselectAll();
                }
            }

            for (int i = 0; i < RTB_RecoveredCode.TextLength; i++) // Должно раскрашивать красным цветом помехи в восстановленом коде (изменённые биты), но не работает...
            {
                if (RTB_RecoveredCode.Text[i] != RTB_BinStr.Text[i])
                {
                    RTB_RecoveredCode.Select(i, 1);
                    RTB_RecoveredCode.SelectionColor = Color.Red;
                    RTB_RecoveredCode.DeselectAll();
                }
            }

            FillInterfRTB();
        }

        private void FM_Main_FormClosing(object sender, FormClosingEventArgs e) // На закрытие формы запоминаем данные о состоянии формы
        {
            if (Directory.Exists(@"Config\") == false)
            {
                Directory.CreateDirectory(@"Config\");
            }

            FileStream fs_Fmcnfg = new FileStream(@"Config\Fmcnfg.txt", FileMode.Create, FileAccess.Write); // Создаём поток для записи данных в файл
                                                                                                            // насильно создавая файл
            StreamWriter sw_cnfgs = new StreamWriter(fs_Fmcnfg); // Создаём экземпляр класса, который будет записывать данные в наш файловый поток

            sw_cnfgs.WriteLine("DesktopLocation.X =" + DesktopLocation.X); // Записываем в файл значения расположения формы
            sw_cnfgs.WriteLine("DesktopLocation.Y =" + DesktopLocation.Y); // на робочем столе

            sw_cnfgs.Close(); // Закрываем поток для записи в файл
            fs_Fmcnfg.Close(); // Закрываем файловый поток
        }

        private void FM_Main_Load(object sender, EventArgs e) // На событие создания формы передаём ей данные о её состоянии из конфигурационного файла
        {
            if (File.Exists(@"Config\Fmcnfg.txt") == false)
            {
                return;
            }

            string[] FileData_arr = File.ReadAllLines(@"Config\Fmcnfg.txt"); // В этот массив записываються строки из файла
            
            DesktopLocation = new Point(WorkWithStrArr.GetParamValue(FileData_arr[WorkWithStrArr.SearchStr(FileData_arr, "DesktopLocation.X =")]),
                WorkWithStrArr.GetParamValue(FileData_arr[WorkWithStrArr.SearchStr(FileData_arr, "DesktopLocation.Y =")]));
        }

        private void BT_Code_MouseUp(object sender, MouseEventArgs e)
        {
            //Очистка RichTextBox-ов
            RTB_BinStr.Clear();
            RTB_AditElems.Clear();
            RTB_ConvolCode.Clear();            

            bin_arr = StrngToBin.StrToBin(RTB_Source.Text);
            adit_elem = WorkWithFinka.CodeArr(StrngToBin.StrArrToStr(bin_arr));
            convol_code = WorkWithFinka.CodeViaFinka(RTB_Source.Text);
            convol_code_inter = convol_code;
            recovered_convol_code = WorkWithFinka.UncodeFinkaArr(convol_code_inter);
            str_recovered = StrngToBin.BinToStr(recovered_convol_code);
                       
            FillRTB(RTB_BinStr, bin_arr); // Выводим каждый элемент исходной строки в двоичном коде
                                    
            FillRTB(RTB_AditElems, adit_elem, true); // Вывод дополнительных элементов

            for (int i = 0; i < convol_code.Length; i++) // Вывод свёрточного кода
            {
                for(int j = 0; j < convol_code[i].Length; j++)
                {
                    RTB_ConvolCode.Text += convol_code[i][j];
                    RTB_ConvolCode.Select(j, 1);
                    RTB_ConvolCode.SelectionColor = j % 2 == 0 ? Color.Black : Color.Green; // Цвет для выделенной строки не задаётся почему-то...
                    RTB_ConvolCode.DeselectAll();
                }

                RTB_ConvolCode.Text += " ";
            }

            FillInterfRTB(); // Заполняем панель с помехами
        }

        void FillInterfRTB() // Процедура заполняент панель с помехами
        {
            RTB_ConvolCodeWithInter.Clear();
            RTB_RecoveredCode.Clear();
            RTB_RecoveredStr.Clear();

            FillRTB(RTB_ConvolCodeWithInter, convol_code); // Заполняем RTB с изменённым свёрточным кодом (пока что совпадающим с обычны, помехи будут вноситься нажатием соответствующей кнопки)

            FillRTB(RTB_RecoveredCode, recovered_convol_code); // Заполняем RTB с восстановленным кодом

            RTB_RecoveredStr.Text = str_recovered; // Заполняем RTB с восстановленой строкой
        }

        void FillRTB(RichTextBox RTB, string[] arr) // Процедура для заполнения RichTextBox строковым массивом (с пробелами между элементами)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                RTB.Text += arr[i] + " ";
            }
        }

        void FillRTB(RichTextBox RTB, string[] arr, bool flag) // Процедура для заполнения RichTextBox строковым массивом (без пробелов между элементами)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                RTB.Text += arr[i];
            }
        }

    }
}