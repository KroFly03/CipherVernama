using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherVernama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<char, string> binaryRusAlphabet = new Dictionary<char, string>()
        {
            [' '] = "00100000",
            ['а'] = "11100000",
            ['А'] = "11000000",
            ['б'] = "11100001",
            ['Б'] = "11000001",
            ['в'] = "11100010",
            ['В'] = "11000010",
            ['г'] = "11100011",
            ['Г'] = "11000011",
            ['д'] = "11100100",
            ['Д'] = "11000100",
            ['е'] = "11100101",
            ['Е'] = "11000101",
            ['ж'] = "11100110",
            ['Ж'] = "11000110",
            ['з'] = "11100111",
            ['З'] = "11000111",
            ['и'] = "11101000",
            ['И'] = "11001000",
            ['й'] = "11101001",
            ['Й'] = "11001001",
            ['к'] = "11101010",
            ['К'] = "11001010",
            ['л'] = "11101011",
            ['Л'] = "11001011",
            ['м'] = "11101100",
            ['М'] = "11001100",
            ['н'] = "11101101",
            ['Н'] = "11001101",
            ['о'] = "11101110",
            ['О'] = "11001110",
            ['п'] = "11101111",
            ['П'] = "11001111",
            ['р'] = "11110000",
            ['Р'] = "11010000",
            ['с'] = "11110001",
            ['С'] = "11010001",
            ['т'] = "11110010",
            ['Т'] = "11010010",
            ['у'] = "11110011",
            ['У'] = "11010011",
            ['ф'] = "11110100",
            ['Ф'] = "11010100",
            ['х'] = "11110101",
            ['Х'] = "11010101",
            ['ц'] = "11110110",
            ['Ц'] = "11010110",
            ['ч'] = "11110111",
            ['Ч'] = "11010111",
            ['ш'] = "11111000",
            ['Ш'] = "11011000",
            ['щ'] = "11111001",
            ['Щ'] = "11011001",
            ['ъ'] = "11111010",
            ['Ъ'] = "11011010",
            ['ы'] = "11111011",
            ['Ы'] = "11011011",
            ['ь'] = "11111100",
            ['Ь'] = "11011100",
            ['э'] = "11111101",
            ['Э'] = "11011101",
            ['ю'] = "11111110",
            ['Ю'] = "11011110",
            ['я'] = "11111111",
            ['Я'] = "11011111",
        };

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
            KeyInput.Text = "";
            CipheredOutput.Text = "";
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            if(KeyInput.Text != "")
            {
                string key = KeyInput.Text;
                string output = "";
                string cipher = "";
                string binKey = "";
                foreach (char symbol in Input.Text)
                {
                    foreach (var dictSymbol in binaryRusAlphabet)
                    {
                        if (symbol == dictSymbol.Key)
                        {
                            output = output + dictSymbol.Value;
                        }
                    }
                }

                foreach (char symbol in key)
                {
                    foreach (var dictSymbol in binaryRusAlphabet)
                    {
                        if (symbol == dictSymbol.Key)
                        {
                            binKey = binKey + dictSymbol.Value;
                        }
                    }
                }
                Output.Text = output;
                KeyOutput.Text = binKey;
                key = KeyOutput.Text;
                int keyIndex = 0;

                for (int i = 0; i < output.Length; i++)
                {
                    if (keyIndex < key.Length)
                    {
                        keyIndex = 0;
                    }
                    string elem = output[i].ToString() + key[keyIndex].ToString();
                    keyIndex++;
                    switch (elem)
                    {
                        case "00":
                            cipher = cipher + "0";
                            break;
                        case "01":
                            cipher = cipher + "1";
                            break;
                        case "10":
                            cipher = cipher + "1";
                            break;
                        case "11":
                            cipher = cipher + "0";
                            break;
                    }
                }
                CipheredOutput.Text = cipher;
            }
            else
            {
                MessageBox.Show("Сгенирируйте ключ");
            }
        }
    }
}
