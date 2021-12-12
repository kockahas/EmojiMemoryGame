using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmojiMemoryGame
{
    public partial class localnameinputform : Form 
    { 
        public localnameinputform()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            mainForm.loc_username = textBox1.Text;
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();

        }
    }
}
