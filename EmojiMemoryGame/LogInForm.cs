using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmojiMemoryGame
{
    public partial class LogInForm : Form
    {
        public delegate void loggingok(string s);
        public loggingok onLoggingOk;
        public LogInForm()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.SendToBack();
            this.Text = "Regisztráció";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 5 && textBox4.Text.Length > 5 && textBox5.Text.Length > 5 && textBox6.Text.Length > 5)
            {
                if (textBox5.Text != textBox6.Text) 
                {
                    button2.Enabled = false;
                    return;
                }
                button2.Enabled = true;
            }
            else button2.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.PasswordChar = char.Parse("\0");
                textBox6.PasswordChar = char.Parse("\0");
            }
            else 
            {
                textBox5.PasswordChar = char.Parse("*");
                textBox6.PasswordChar = char.Parse("*");
            }
        }
        private void button3_Click(object sender, EventArgs e)// bejelentkezés
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("COM", "login");
            data.Add("unev", textBox8.Text.Trim());
            data.Add("jelszo", MD5.MD5Hash(textBox7.Text.Trim()));
            string result = Pinger.send_com_post(data);
            if (result == "OK")
            {
                onLoggingOk(textBox8.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!","Bejelentkezési hiba!");
                textBox8.Text = "";
                textBox7.Text = "";
                textBox8.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)// regisztráció
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("COM", "register");
            data.Add("unev",textBox3.Text.Trim());
            data.Add("nev", textBox4.Text.Trim());
            data.Add("jelszo",MD5.MD5Hash( textBox5.Text.Trim()));
            string result = Pinger.send_com_post(data);
            if ( result== "OK")
            {
                MessageBox.Show("Sikerült a regisztráció!");
                onLoggingOk(textBox3.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Létező felhasználónév! Válassz mást!");
                textBox3.Text = "";
                textBox3.Focus();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 5 && textBox8.Text.Length > 5)
            {
                 button3.Enabled = true;
            }
            else button3.Enabled = false;
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(button3.Enabled && this.Text == "Bejelentkezés") button3.PerformClick();
                else if (button2.Enabled && this.Text == "Regisztráció") button2.PerformClick();
            }
        }
    }
}
