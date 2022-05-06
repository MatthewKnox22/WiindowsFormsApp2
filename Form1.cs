using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPigLatin : Form
    {
        const string EXTENSION = "ay";
        public FormPigLatin()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string translation = "";
            string input = txtInput.Text;
            string[] tempInput = input.Split(' ');

            for (int i = 0; i < tempInput.Length; i++)
            {
                translation += getPigLatin(tempInput[i]);
            }
            txtOutput.Text = translation;
        }
        private string getPigLatin(string input)
        {
            string word;
            string firstLetter = input.Substring(0, 1);

            word = input.Substring(1) + firstLetter + EXTENSION + " ";

            return word;
        }
    }
}
