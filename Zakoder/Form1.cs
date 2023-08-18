using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zakoder
{
    public partial class Form1 : Form
    {
        //Простой шифр - масив для Eng
        string[,] Mass_English =
        {
            { "№" , "Q" , "j" , "X" , "!" , "J" , "}" , "u" , "r" , "9" },
            { "k" , "W" , "/" , "f" , "^" , "?" , "C" , "L" , "-" , "7" },
            { "+" , "x" , "." , "v" , "A" , "V" , "@" , "T" , "_" , "1" },
            { "N" , "K" , ":" , "Y" , "i" , "P" , "o" , "t" , "a" , "3" },
            { "G" , "O" , "s" , "d" , "=" , "," , "R" , "n" , "%" , "0" },
            { "~" , ">" , "h" , "q" , "F" , "y" , ")" , "*" , ";" , "4" },
            { "H" , "|" , "]" , "$" , "{" , "M" , "z" , "l" , "`" , "8" },
            { "Z" , "p" , "S" , "I" , "b" , "-" , "(" , "w" , "D" , "2" },
            { "'" , "E" , "#" , "e" , "m" , "g" , "U" , "c" , "[" , "5" },
            { "B" , "<" , " " , "\"", "6" , "\\", ""  , "\n", ""  , ""  }
        };

        string[,] Mass_V_Rus =
        {
            { "Й" , "Я" , "У" , "А" , ")" , "м" , "1" , "]" , "П" , "\n"},
            { "." , "Ы" , "@" , "5" , "й" , "Ю" , "|" , ":" , "," , "=" },
            { "И" , "+" , "#" , "Х" , "3" , "В" , "н" , "х" , "ф" , "Т" },
            { "(" , "Г" , "З" , "е" , "^" , "ш" , "ж" , "М" , "~" , "\\"},
            { "Б" , "Ф" , "\"", "0" , "д" , "я" , "2" , "ъ" , "Д" , "ы" },
            { "з" , "с" , "4" , "р" , ">" , "9" , "п" , "Ж" , "'" , "Ч" },
            { "7" , "ё" , "№" , "?" , ";" , "[" , "&" , "$" , "ь" , "`" },
            { "к" , "т" , "%" , "6" , "/" , "л" , "8" , "-" , "Щ" , "и" },
            { "<" , "Л" , "щ" , "!" , "О" , "Р" , "ч" , "С" , "{" , "Ц" },
            { "Э" , "_" , "*" , "г" , "о" , "э" , "Н" , "Ш" , "ю" , "б" },
        };

        string[] Mass_Rusian =
        {
              "." , "Ы" , "@" , "5" , "й" , "Ю" , "|" , ":" ,
              "," , "=" , "И" , "+" , "#" , "Х" , "3" , "В" ,
              "н" , "х" , "ф" , "Т" , "к" , "т" , "%" , "6" ,
              "/" , "л" , "8" , "-" , "Щ" , "и" , "(" , "Г" ,
              "З" , "е" , "^" , "ш" , "ж" , "М" , "~" , "\\",
              "7" , "ё" , "№" , "?" , ";" , "[" , "Ь" , "$" ,
              "ь" , "`" , "Э" , "_" , "*" , "г" , "о" , "э" ,
              "Н" , "Ш" ,  "" , "б" , "Й" , "Я" , "У" , "А" ,
              ")" , "м" , "1" , "а" , "П" , "в" , "з" , "с" ,
              "4" , "р" , ">" , "9" , "п" , "Ж" , "'" , "Ч" ,
              "<" , "Л" , "щ" , "!" , "О" , "Р" , "ч" , "С" ,
              "{" , "Ц" , "Б" , "Ф" , "\"", "0" , "д" , "я" ,
              "2" , "ъ" , "Д" , "ы" , "К" , "}" , "ц" , "Ё" ,
              "Ъ" , "&" , "у" , "]" , " " , "\n" , "ю","Е"
        };

        string[] Mass_V_Eng =
        {
             "№" , "®"  , "j" , "X" , "!" , "J" , "}" , "u" , "r" , "9" ,
             "+" , "x" , "." , "v" , "A" , "V" , "@" , "T" , "_" , "1" ,
             "G" , "O" , "s" , "d" , "=" , "," , "R" , "n" , "%" , "0" ,
             "'" , "◉"  , "#" , "e" , "m" , "g" , "U" , "◊"  , "[" , "5" ,
             "~" , ">" , "h" , "q" , "F" , "y" , ")" , "*" , ";" , "4" ,
             "k" , "W" , "/" , "f" , "^" , "?" , "C" , "L" , "-" , "7" ,
             "B" , "<" ,  "Q" , "\"", "6" , "\\", "◌"  , "\n", "۞"  , "★"  ,
             "Z" , "p" , "S" , "I" , "b" , "-" , "(" , "w" , "D" , "2" ,
             "N" , "K" , ":" , "Y" , "i" , "P" , "o" , "t" , "a" , "3" ,
             "H" , "|" , "]" , "$" , "{" , "¤"  , "z" , "l" , "`" , "8" ,
             "♂"  , "♀"  , "E" , "▷"  , "c" , "┼"  , "M" , "๑"  , "٭"  , "︶"  ,
             " ",""
        };

        string[] Mas_Instruct_Coder = { "#!45@", "?<,.?", "*&#$_=", "^:;'}",
            /*для случ*/ ":'[.&",/*для шифр-дешифровки... бред*/ "^&*)_)" , "_+=@!" ,
            "<>?<%" , ":,^&;" , "(')#@" };

        public Form1()
        {
            InitializeComponent();
            CB_Vibor.SelectedIndex = 0;
            LB_Vibor.SelectedIndex = 0;
            //RTB_Vvod.Text = Mass_Rusian.Length.ToString();
            this.Size = new Size(1051, 610);
        }

        int Nomer_V_Masive = 0;
        string Instruct = "";
        int Colvo_Mass = 0;

        void Null_Dehifr()
        {

            string[] Mass_Rashifr = new string[RTB_Vvod.TextLength];
            Instruct = Mas_Instruct_Coder[5];
            foreach (char c in RTB_Vvod.Text)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;
            for (int Poisk_Stroks = 0; Poisk_Stroks < RTB_Vvod.TextLength; Poisk_Stroks++)
            {
                try
                {
                    RTB_Rezult.Text += Mass_English[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive])];
                    Nomer_V_Masive += 2;
                }
                catch { }
            }

        }
        void Null_Hifr()
        {
            Instruct = Mas_Instruct_Coder[0];
            string Hranenie = "";
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_English[Poisk_Stroks, Poisk_Stolbec])
                            Hranenie += Poisk_Stolbec + "" + Poisk_Stroks;
                    }

                }
            }
            RTB_Rezult.Text = Hranenie;
        }
        void One_Dehifr()
        {
            Instruct = Mas_Instruct_Coder[6];
            string Nabor = "";
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_V_Rus[Poisk_Stolbec, Poisk_Stroks])
                        {
                            Nabor += Poisk_Stolbec + "" + Poisk_Stroks;
                        }
                    }

                }
            }

            string Rashifr = "";
            string[] Mass_Rashifr = new string[Nabor.Length];

            foreach (char c in Nabor)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;
            for (int Poisk_Stroks = 0; Poisk_Stroks < Nabor.Length; Poisk_Stroks++)
            {
                try
                {
                    Rashifr += Mass_English[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1])];
                    Nomer_V_Masive += 2;
                }
                catch { }
            }
            RTB_Rezult.Text = Rashifr;
        }
        void One_Hifr()
        {
            Instruct = Mas_Instruct_Coder[3];
            string Hranenie = "";
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_English[Poisk_Stroks, Poisk_Stolbec])
                            Hranenie += Poisk_Stolbec + "" + Poisk_Stroks;
                    }

                }
            }
            RTB_Rezult.Text = Hranenie;
            string[] Mass_Rashifr = new string[RTB_Rezult.TextLength];

            foreach (char c in RTB_Rezult.Text)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;
            Hranenie = "";
            for (int Poisk_Stroks = 0; Poisk_Stroks < RTB_Vvod.TextLength; Poisk_Stroks++)
            {
                try
                {
                    Hranenie += Mass_V_Rus[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive])];
                    Nomer_V_Masive += 2;
                }
                catch { }
            }
            RTB_Rezult.Text = Hranenie;
            Hranenie = "";
        }
        void Fri_Dehifr()
        {
            Instruct = Mas_Instruct_Coder[7];
            string Tripl_Str = "";
            int Tripl_Kod = 0;
            foreach (char c in RTB_Vvod.Text)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    RTB_Rezult.Text += Mass_Rusian[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
        }
        void Fri_Hifr()
        {
            Instruct = Mas_Instruct_Coder[1];
            string Hranenie = "";
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_Rusian[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }
            RTB_Rezult.Text = Hranenie;
        }
        void Five_Dehifr()
        {

        }
        void Five_Hifr()
        {

        }
        void Seven_Dehifr()
        {
            Instruct = Mas_Instruct_Coder[9];
            string Hranenie = "";
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_V_Eng[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }
            RTB_Rezult.Text = Hranenie;
            string Tripl_Str = "";
            string Rashifr = "";
            int Tripl_Kod = 0;
            foreach (char c in Hranenie)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    Rashifr += Mass_Rusian[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
            RTB_Rezult.Text = Rashifr;
        }
        void Seven_Hifr()
        {
            string Hranenie = "";
            Instruct = Mas_Instruct_Coder[2];
            foreach (char c in RTB_Vvod.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_Rusian[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }

            string Tripl_Str = "";//
            string Rashifr = "";
            int Tripl_Kod = 0;
            foreach (char c in Hranenie)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    Rashifr += Mass_V_Eng[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
            RTB_Rezult.Text = Rashifr;
        }

        void Null_Dehifr_Instr()
        {
            RTB_Rezult.Text = "";
            string[] Mass_Rashifr = new string[RTB_Instr.TextLength];
            Instruct = Mas_Instruct_Coder[5];
            foreach (char c in RTB_Instr.Text)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;

            for (int Poisk_Stroks = 0; Poisk_Stroks < RTB_Vvod.TextLength; Poisk_Stroks++)
            {
                try
                {
                    RTB_Rezult.Text += Mass_English[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive])];
                    Nomer_V_Masive += 2;
                }
                catch { }
            }

            RTB_Instr.Text = RTB_Rezult.Text;
            RTB_Rezult.Text = "";

        }
        void Null_Hifr_Instr()
        {
            RTB_Rezult.Text = "";
            Instruct = Mas_Instruct_Coder[0];
            string Hranenie = "";
            foreach (char c in RTB_Instr.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_English[Poisk_Stroks, Poisk_Stolbec])
                            Hranenie += Poisk_Stolbec + "" + Poisk_Stroks;
                    }

                }
            }
            RTB_Instr.Text = Hranenie;
        }
        void One_Dehifr_Instr()
        {
            Instruct = Mas_Instruct_Coder[6];
            string Nabor = "";
            foreach (char c in RTB_Instr.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_V_Rus[Poisk_Stolbec, Poisk_Stroks])
                        {
                            Nabor += Poisk_Stolbec + "" + Poisk_Stroks;
                        }
                    }

                }
            }

            string Rashifr = "";
            string[] Mass_Rashifr = new string[Nabor.Length];

            foreach (char c in Nabor)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;
            for (int Poisk_Stroks = 0; Poisk_Stroks < Nabor.Length; Poisk_Stroks++)
            {
                try
                {
                    Rashifr += Mass_English[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1])];
                    Nomer_V_Masive += 2;
                }
                catch { }
            }
            RTB_Instr.Text = Rashifr;
        }
        void One_Hifr_Instr()
        {
            Instruct = Mas_Instruct_Coder[3];
            string Hranenie = "";
            foreach (char c in RTB_Instr.Text)
            {
                for (int Poisk_Stroks = 0; Poisk_Stroks <= 9; Poisk_Stroks++)
                {
                    for (int Poisk_Stolbec = 0; Poisk_Stolbec <= 9; Poisk_Stolbec++)
                    {
                        if (c.ToString() == Mass_English[Poisk_Stroks, Poisk_Stolbec])
                            Hranenie += Poisk_Stolbec + "" + Poisk_Stroks;
                    }

                }
            }
            RTB_Instr.Text = Hranenie;//////////здесь тут делать
            string[] Mass_Rashifr = new string[RTB_Vvod.TextLength];///

            foreach (char c in RTB_Instr.Text)
            {
                Mass_Rashifr[Nomer_V_Masive] = c.ToString();
                //RTB_Rezult.Text += Mass_Rashifr[Nomer_V_Masive];
                Nomer_V_Masive++;
            }
            Nomer_V_Masive = 0;
            Hranenie = "";
            for (int Poisk_Stroks = 0; Poisk_Stroks < RTB_Vvod.TextLength; Poisk_Stroks++)
            {
                ////
                Hranenie += Mass_V_Rus[Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive + 1]), Convert.ToInt32(Mass_Rashifr[Nomer_V_Masive])];
                Nomer_V_Masive += 2;

            }
            RTB_Vvod.Text = Hranenie;
            Hranenie = "";
        }
        void Fri_Dehifr_Instr()
        {
            Instruct = Mas_Instruct_Coder[7];
            string Tripl_Str = "";
            int Tripl_Kod = 0;
            foreach (char c in RTB_Instr.Text)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    RTB_Rezult.Text += Mass_Rusian[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
            RTB_Instr.Text = RTB_Rezult.Text;
        }
        void Fri_Hifr_Instr()
        {
            Instruct = Mas_Instruct_Coder[1];
            string Hranenie = "";
            foreach (char c in RTB_Instr.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_Rusian[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }
            // RTB_Rezult.Text = Hranenie;
            RTB_Instr.Text = Hranenie;
        }
        void Five_Dehifr_Instr()
        {

        }
        void Five_Hifr_Instr()
        {

        }
        void Seven_Dehifr_Instr()
        {
            Instruct = Mas_Instruct_Coder[9];
            string Hranenie = "";
            foreach (char c in RTB_Instr.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_V_Eng[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }

            string Tripl_Str = "";
            string Rashifr = "";
            int Tripl_Kod = 0;
            foreach (char c in Hranenie)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    Rashifr += Mass_Rusian[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
            RTB_Instr.Text = Rashifr;
        }
        void Seven_Hifr_Instr()
        {
            string Hranenie = "";
            Instruct = Mas_Instruct_Coder[2];
            foreach (char c in RTB_Instr.Text)
            {
                for (int Prohod_Mass = 0; Prohod_Mass < Mass_Rusian.Length; Prohod_Mass++)
                {
                    if (c.ToString() == Mass_Rusian[Prohod_Mass])
                    {
                        if (Prohod_Mass.ToString().Length == 1)
                            Hranenie += "000" + Prohod_Mass;
                        else if (Prohod_Mass.ToString().Length == 2)
                            Hranenie += "00" + Prohod_Mass;
                        else
                            Hranenie += "0" + Prohod_Mass;
                    }
                }
            }

            string Tripl_Str = "";//
            string Rashifr = "";
            int Tripl_Kod = 0;
            foreach (char c in Hranenie)
            {
                Tripl_Str += c.ToString();
                Tripl_Kod++;
                if (Tripl_Kod == 4)
                {

                    Tripl_Kod = 0;
                    Rashifr += Mass_V_Eng[Int32.Parse(Tripl_Str)];
                    Tripl_Str = "";
                }
            }
            RTB_Instr.Text = Rashifr;

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (RTB_Vvod.Text != "" && RTB_Vvod.Text != " ")
            {
                BTN_Start.Enabled = false;

                RTB_Rezult.Text = "";
                Nomer_V_Masive = 0;
                if (LB_Vibor.SelectedIndex == 0 && RTB_Vvod.Text != "")
                {

                    if (CB_Vibor.Text == "Зашифровка")
                    {
                        Null_Hifr();
                    }
                    else if (CB_Vibor.Text == "Дешифровка")
                    {
                        Null_Dehifr();
                    }
                }

                if (LB_Vibor.SelectedIndex == 1 && RTB_Vvod.Text != "")
                {
                    if (CB_Vibor.Text == "Зашифровка")
                    {
                        One_Hifr();
                    }
                    else if (CB_Vibor.Text == "Дешифровка")
                    {
                        One_Dehifr();
                    }
                }

                if (LB_Vibor.SelectedIndex == 3 && RTB_Vvod.Text != "")
                {
                    try
                    {
                        if (CB_Vibor.Text == "Зашифровка")
                        {
                            Fri_Hifr();
                        }
                        else if (CB_Vibor.Text == "Дешифровка")
                        {
                            Fri_Dehifr();
                        }
                    }
                    catch { MessageBox.Show("Произошла ошивка! Но все норм"); }

                }

                if (LB_Vibor.SelectedIndex == 5 && RTB_Vvod.Text != "")
                {

                }

                if (LB_Vibor.SelectedIndex == 7 && RTB_Vvod.Text != "")
                {
                    if (CB_Vibor.Text == "Зашифровка")
                    {
                        Seven_Hifr();
                    }
                    else if (CB_Vibor.Text == "Дешифровка")
                    {
                        Seven_Dehifr();
                    }
                }

                bool Ful_Block = false;

                foreach (char c in textBox1.Text)
                {
                    if (c.ToString() == " ")
                    {
                        Colvo_Mass++;
                        MessageBox.Show(Colvo_Mass + "");
                    }
                }
                if (textBox1.Text == "") { Ful_Block = true; }
                string[] Mass_De_hifr = new string[Colvo_Mass];
                int Nom_Mass = 0;
                string De_Kod = "";


                foreach (char c in textBox1.Text)
                {
                    if (c.ToString() != " ")
                    {
                        De_Kod += c.ToString();
                    }
                    else if (textBox1.Text != "")
                    {
                        Mass_De_hifr[Nom_Mass] = De_Kod;
                        De_Kod = "";
                        Nom_Mass++;

                    }

                }


                if (CB_Vibor.Text == "Дешифровка")
                {
                    if (LB_Vibor.SelectedIndex == 0)
                        Instruct = Mas_Instruct_Coder[0];
                    else if (LB_Vibor.SelectedIndex == 1)
                        Instruct = Mas_Instruct_Coder[3];
                    else if (LB_Vibor.SelectedIndex == 3)
                        Instruct = Mas_Instruct_Coder[1];
                    else if (LB_Vibor.SelectedIndex == 7)
                        Instruct = Mas_Instruct_Coder[2];

                    try
                    {
                        if (Mass_De_hifr[Nom_Mass - 1] == Instruct)
                        {
                            Mass_De_hifr[Nom_Mass - 1] = "";
                            textBox1.Text = "";
                            for (int i = 0; i < Mass_De_hifr.Length - 1; i++)
                            {

                                textBox1.Text += Mass_De_hifr[i] + " ";
                            }
                        }
                        else
                        {
                            if (LB_Vibor.SelectedIndex == 0)
                                Instruct = Mas_Instruct_Coder[5];
                            else if (LB_Vibor.SelectedIndex == 1)
                                Instruct = Mas_Instruct_Coder[6];
                            else if (LB_Vibor.SelectedIndex == 3)
                                Instruct = Mas_Instruct_Coder[7];
                            else if (LB_Vibor.SelectedIndex == 7)
                                Instruct = Mas_Instruct_Coder[8];
                            textBox1.Text += Instruct + " ";
                        }
                    }
                    catch { }

                }
                else
                {

                    bool block = false;
                    if (LB_Vibor.SelectedIndex == 0)
                        Instruct = Mas_Instruct_Coder[0];
                    else if (LB_Vibor.SelectedIndex == 1)
                        Instruct = Mas_Instruct_Coder[3];
                    else if (LB_Vibor.SelectedIndex == 3)
                        Instruct = Mas_Instruct_Coder[1];
                    else if (LB_Vibor.SelectedIndex == 7)
                        Instruct = Mas_Instruct_Coder[2];

                    //if (LB_Vibor.SelectedIndex == 0)
                    //    Instruct = Mas_Instruct_Coder[5];
                    //else if (LB_Vibor.SelectedIndex == 1)
                    //    Instruct = Mas_Instruct_Coder[6];
                    //else if (LB_Vibor.SelectedIndex == 3)
                    //    Instruct = Mas_Instruct_Coder[7];
                    //else if (LB_Vibor.SelectedIndex == 7)
                    //    Instruct = Mas_Instruct_Coder[8];

                    if (Ful_Block == false)
                    {
                        if (LB_Vibor.SelectedIndex == 0)
                            Instruct = Mas_Instruct_Coder[5];
                        else if (LB_Vibor.SelectedIndex == 1)
                            Instruct = Mas_Instruct_Coder[6];
                        else if (LB_Vibor.SelectedIndex == 3)
                            Instruct = Mas_Instruct_Coder[7];
                        else if (LB_Vibor.SelectedIndex == 7)
                            Instruct = Mas_Instruct_Coder[8];

                        if (Mass_De_hifr[Nom_Mass - 1] == Instruct)
                        {
                            block = true;
                            try
                            {
                                if (Mass_De_hifr[Nom_Mass - 1] == Instruct)
                                {
                                    Mass_De_hifr[Nom_Mass - 1] = "";
                                    textBox1.Text = "";
                                    for (int i = 0; i < Mass_De_hifr.Length - 1; i++)
                                    {

                                        textBox1.Text += Mass_De_hifr[i] + " ";
                                    }

                                }


                            }
                            catch { }
                        }
                        else
                        {

                            if (LB_Vibor.SelectedIndex == 0)
                                Instruct = Mas_Instruct_Coder[0];
                            else if (LB_Vibor.SelectedIndex == 1)
                                Instruct = Mas_Instruct_Coder[3];
                            else if (LB_Vibor.SelectedIndex == 3)
                                Instruct = Mas_Instruct_Coder[1];
                            else if (LB_Vibor.SelectedIndex == 7)
                                Instruct = Mas_Instruct_Coder[2];
                        }
                    }

                    if (block != true && CeckB_Save_Instr.Checked == true)
                        textBox1.Text += Instruct + " ";



                }


                Colvo_Mass = 0;

            }
            else if (BTN_Start.Enabled == true)
            {
                //DialogResult res = MessageBox.Show("Все данные будут утеряны. Для продолжения нынещней шифровки нажите No.", 
                //    " Хотите начать заново?(Yes)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if(res == DialogResult.Yes)
                //{
                //    Prov_Start = 0;
                //    RTB_Rezult.Text = "";
                //    textBox1.Text = "";
                //    BTN_Start.Enabled = false;
                //}
                //else if (res == DialogResult.No)
                //{
                //    BTN_Povtor_Shifr_Click(null, null);
                //    Prov_Start = 0;
                //    BTN_Start.Enabled = false;
                //}

            }



        }


        public void Instrux()
        {

            int Col_Instr = 0;
            string Instuxii = "";
            RTB_Rezult.Text = "";
            Stack<string> Instruxii = new Stack<string>();
            foreach (char c in textBox1.Text)
            {
                if (c.ToString() == " ")
                {
                    Instruxii.Push(Instuxii);
                    Col_Instr++;
                    Instuxii = "";
                }
                else
                    Instuxii += c.ToString();

            }
            Col_Instr--;

            Instuxii = "";
            foreach (var c in Instruxii)
                for (int i = 0; i < Mas_Instruct_Coder.Length; i++)
                {
                    Nomer_V_Masive = 0;
                    if (c.ToString() == Mas_Instruct_Coder[i])
                    {
                        if (i == 0)
                            Null_Dehifr_Instr();
                        else if (i == 3)
                            One_Dehifr_Instr();
                        else if (i == 1)
                            Fri_Dehifr_Instr();
                        else if (i == 2)
                            Seven_Dehifr_Instr();
                        else if (i == 5)
                            Null_Hifr_Instr();
                        else if (i == 6)
                            One_Hifr_Instr();
                        else if (i == 7)
                            Fri_Hifr_Instr();
                        else if (i == 9)
                            Seven_Hifr_Instr();

                    }
                }
            RTB_Rezult.Text = RTB_Instr.Text;



        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            RTB_Rezult.Text = "";
            RTB_Vvod.Text = "";
            textBox1.Text = "";
            RTB_Instr.Text = "";
            BTN_Start.Enabled = true;
        }

        private void BTN_Povtor_Shifr_Click(object sender, EventArgs e)
        {
            if (CB_Vibor.SelectedItem == "Зашифровка")
            {
                RTB_Vvod.Text = RTB_Rezult.Text; RTB_Rezult.Text = "";
            }
            else
            {
                RTB_Vvod.Text = RTB_Rezult.Text; RTB_Rezult.Text = "";
            }
            BTN_Start_Click(null, null);


        }

        private void CB_Vibor_TextChanged(object sender, EventArgs e)
        {
            if (CB_Vibor.SelectedItem == "Зашифровка")
            {
                BTN_Povtor.Text = "Продолжить шифрование";
            }
            else
            {
                BTN_Povtor.Text = "Продолжить дешифровку";
            }
        }

        private void LB_Vibor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Vibor.Text == "--------------------------------------------------------------------------------")
                LB_Vibor.SelectedIndex = LB_Vibor.SelectedIndex + 1;

        }

        private void BTN_Import_Click(object sender, EventArgs e)
        {

            OpenFileDialog opentext = new OpenFileDialog();
            opentext.Filter = "TXT Files|*.txt|Pusto Files|*";
            if (opentext.ShowDialog() == DialogResult.OK)
            {

                var Import = opentext.FileName;
                var sr = new StreamReader(Import);
                RTB_Vvod.Text = sr.ReadToEnd();
                //Globals.notes = opentext.FileName;
                sr.Close();

                MessageBox.Show("Файл загружен");
            }
        }

        public string Instr_Shifr(string instr)
        {

            return "";
        }
        
        private void BTN_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save_Dehifr = new SaveFileDialog();
            Save_Dehifr.Filter = "Текстовый документ (*.txt)|*.txt";
            string peremen;
            string innstruct="";

            if (Save_Dehifr.ShowDialog() == DialogResult.OK)
            {
               
               
                string filename = Save_Dehifr.FileName;
                //сохраняем текст в файл


                if (CeckB_Save_Instr.Checked == true)
                {
                    peremen = RTB_Rezult.Text;
                    Instruct = textBox1.Text.Replace(" ", "");
                    Instruct = "!/±)^#/" + innstruct + "!/±)^#/";
                    peremen = peremen.Insert(peremen.Length / 2, Instruct);
                    MessageBox.Show(peremen);

                    System.IO.File.WriteAllText(filename, peremen);
                }
                else
                {
                    System.IO.File.WriteAllText(filename, RTB_Rezult.Text);
                }
                MessageBox.Show("Файл сохранен");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RTB_Instr.Text = RTB_Vvod.Text;
                Instrux();
                Instruct = "";
            }
            catch{ }
            
        }

        private void TSMI_Setings_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1488, 610);
            CenterToScreen();
        }

        private void BTN_Close_Seting_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1051, 610);
            CenterToScreen();
        }
    }
}
