using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class FormLab8 : Form
    {
        public string UserName { get; set; }
        public float Age { get; set; }
        public FormLab8()
        {
            InitializeComponent();
            

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            UserName = TextBoxYourName.Text;
            Age = float.Parse(TextBoxYourAge.Text);
            TextBoxYourName.Text = string.Empty;
            TextBoxYourAge.Text = string.Empty;

            OutputLabel.Text = UserName + " " + Age;

        }

        private void TextBoxYourAge_TextChanged(object sender, EventArgs e)
        {
            ButtonSubmit.Enabled = true;
        }
    }
}
