using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract16_2_oap_mamazhonova
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent( );
        }

        

        private void button1_Click (object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            string [ ] array = input.Split(new [ ] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = array.SelectMany(s => s).Count(char.IsDigit);
            label1.Text = $"Количество цифр в массиве: {count}";
            label2.Text = $"Элементы массива до символа / :";
            foreach ( string s in array.TakeWhile(s => s != "/") )
            {
                label3.Text=(s + "\n");
            }

            label4.Text = "Элементы массива после символа /, в верхнем нижнем регистре:";
            string [ ] newArray = array.SkipWhile(s => s != "/").Skip(1).Select(s => s.ToUpper( ) == s ? s.ToLower( ) : s.ToUpper( )).ToArray( );
            foreach ( string s in newArray )
            {
                label5.Text= (s + "\n");
            }

            File.WriteAllLines("output.txt", newArray);
  
        }
    }
}
