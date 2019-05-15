using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadena = "13";
            string expresion = @"19[0-9][0-9]|20[0-9][0-9]|2100";
            string expresion2 = @"0[1-9]|10|11|12";
            //1900
            //2100

            Regex automata = new Regex(expresion);
            Regex automata2 = new Regex(expresion2);

            if (automata2.IsMatch(cadena)) MessageBox.Show("La genera");
            else MessageBox.Show("No la genera");

            this.Close();

        }


    }
}
