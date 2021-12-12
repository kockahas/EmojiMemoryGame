using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using System.IO;


namespace EmojiMemoryGame
{
    public partial class mainForm : Form
    {
        private const string nb = "Nincs bejelentkezve.";
        private WMPLib.WindowsMediaPlayer musicplayer = new WMPLib.WindowsMediaPlayer();
        private string scorefilePath;
        private bool scoreboardChanged;
        private bool music_is_on;
        public static string loc_username;
        private bool user_is_Logged;
        public bool user_is_logged 
        {
            set
            {
                
                user_is_Logged = value;
                loggingfressh.Enabled = user_is_Logged;
            } 
            get 
            {
                return user_is_Logged;
            }
        }
        List<playerValues> RankList = new List<playerValues>();
        public const string serverurl = "http://gome.ddns.net/MGComm/com.php";
        public bool isnet { set; get; }
        public bool isserver { set; get; }
        private string loggeduser;
        public string loggedUser
        {
            get { return loggeduser; }
            set
            {
                if (loggeduser == value)
                {
                    return;
                }
                loggeduser = value;
                label2.Text = loggeduser;
                if (user_is_logged) label1.Text = "Bejelentkezve"; else label1.Text = nb; 
            }
        }
        public mainForm()
        {
            InitializeComponent();
            isnet = false;
            isserver = false;
            music_is_on = true;
            musicplayer.URL = "gotg.mp3";
            musicplayer.controls.play();
            button1.BackgroundImage = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("SoundON"), new Size(50, 50));
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            scorefilePath = Application.StartupPath + @"\scores.txt";
            if (File.Exists(scorefilePath))
            {
                StreamReader sr = new StreamReader(scorefilePath);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('\t');
                    RankList.Add(new playerValues { playername = line[0], steps = int.Parse(line[1]), time = TimeSpan.Parse(line[2]), gametype = int.Parse(line[3]) });
                }
                sr.Close();
            }
            this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage1"];
            radioButton1.Checked = true;
            label1.Text = nb;
        }
        private void timer_netpinger_Tick(object sender, EventArgs e)
        {
            isserver = Pinger.chk_server();
            if (!isserver) isnet = Pinger.Ping("google.com");
            else isnet = true;
            if (!isserver || !isnet)
                login_button5.Enabled = false;
            else login_button5.Enabled = true;
            if (isnet) toolStripStatusLabel1.Text = "Van Internetkapcsolat.";
            else toolStripStatusLabel1.Text = "Nincs Internetkapcsolat!";
            if (isserver) toolStripStatusLabel2.Text = " Van szerverkapcsolat. ";
            else toolStripStatusLabel2.Text = " Nincs szerver kapcsolat!";
            if(isserver)
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("COM", "LC");
                string res = Pinger.send_com_post(data);
                if (res == "NemOK")
                {
                    MessageBox.Show("Nem sikerült a játékadatokat a szerverre elküldeni!!!", "Hiba...");
                }
                else 
                {
                    label3.Text = string.Format("Bejelentkezve {0} játékos.", res);
                }
            }
        }
        private void btn_4x4start_Click(object sender, EventArgs e)
        {  
            GameForm form4x4 = new GameForm(4,btn_4x4start);
            form4x4.onGameOver += myGameOver;
            form4x4.Show();
            btn_4x4start.Enabled = false;
        }
        private void btn_6x6start_Click(object sender, EventArgs e)
        {
            GameForm form6x6 = new GameForm(6,btn_6x6start);
            form6x6.onGameOver += myGameOver;
            form6x6.Show();
            btn_6x6start.Enabled = false;
        }
        private void btn_8x8start_Click(object sender, EventArgs e)
        {
            GameForm form8x8 = new GameForm(8,btn_8x8start);
            form8x8.onGameOver += myGameOver;
            form8x8.Show();
            btn_8x8start.Enabled = false;
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                if (scoreboardChanged)
                {
                    if (File.Exists(scorefilePath))
                    {
                        string oldfilename = scorefilePath.Remove(scorefilePath.Length - 3, 3) + "old";
                        if (File.Exists(oldfilename)) File.Delete(oldfilename);
                        File.Move(scorefilePath, oldfilename);
                    }
                    StreamWriter sw = new StreamWriter(scorefilePath);
                    foreach (playerValues elem in RankList)
                    {
                        sw.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", elem.playername, elem.steps.ToString(), elem.time.ToString(), elem.gametype.ToString()));
                    }
                    sw.Close();
                }
            }
        }
        private void exit_button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan kilépsz a játékból?", "Kérdés...", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                this.Close();
            }
        }
        private void login_button5_Click(object sender, EventArgs e)
        {
            if (login_button5.Text == "Bejelentkezés")
            {
                LogInForm a = new LogInForm();
                a.onLoggingOk += userLogged;
                a.ShowDialog();
                if(user_is_logged) login_button5.Text = "Kijelentkezés";
            }
            else 
            {
                user_is_logged = false;
                loggedUser = string.Empty;
                login_button5.Text = "Bejelentkezés";
                this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage1"];
            }
        }
        public void myGameOver(playerValues result)
        {
            if (!user_is_logged)
            {
                localnameinputform inputform = new localnameinputform();
                inputform.ShowDialog();
                scoreboardChanged = true;
                RankList.Add(new playerValues { playername = loc_username, steps = result.steps, time = result.time, gametype = result.gametype });
                localranklistfresh(result.gametype);
            } 
            else 
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("COM", "RW");
                data.Add("unev", loggedUser);
                data.Add("lepesek", result.steps.ToString());
                data.Add("ido", result.time.ToString());
                data.Add("tipus", result.gametype.ToString());
                string res = Pinger.send_com_post(data);
                if (res != "OK")
                {
                    MessageBox.Show("Nem sikerült a játékadatokat a szerverre elküldeni!!!","Hiba...");
                }
            }
        }
        public void userLogged(string user)
        {
            user_is_logged = true;
            loggedUser =user;
            this.tabControl1.SelectedTab = this.tabControl1.TabPages["tabPage2"];
        }
        private void localranklistfresh(int mtype) 
        {
            var query = from pv in RankList where pv.gametype == mtype orderby pv.steps, pv.time select pv;
            int no = 1;
            listBox1.Items.Clear();
            listBox1.Items.Add("\tNo.------Név------Lépés-------- Idő-");
            foreach (var item in query.Take(10))
            {
                listBox1.Items.Add(string.Format("\t{0,-2}-      {1,-12}\t{2,-3}\t{3:00}:{4:00}", no, item.playername, item.steps, item.time.Minutes, item.time.Seconds));
                no++;
            }
        }
        private void serverranklistrefresh()
        {
            isserver = Pinger.chk_server();
            if (isserver)
            {
                srvrlfh(listBox4x4, 4);
                srvrlfh(listBox6x6, 6);
                srvrlfh(listBox8x8, 8);
            }
        }
        private void srvrlfh(ListBox lstb,int GT)
        { 
            List<playerValues> SvRankList = new List<playerValues>();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("COM", "RQ");
            data.Add("GT", GT.ToString());
            string res = Pinger.send_com_post(data);
            if (res != "NemOK")
            {
                 res = res.TrimEnd('|');
                 string[] resrowspl = res.Split('|');
                 foreach (string elem in resrowspl)
                 {
                     string[] ud = elem.Split('ß');
                     SvRankList.Add(new playerValues { playername = ud[0], steps = int.Parse(ud[1]), time = TimeSpan.Parse(ud[2]), gametype = GT });
                 }
            }
            var query = from pv in SvRankList where pv.gametype == GT orderby pv.steps, pv.time select pv;
            int no = 1;
            lstb.Items.Clear();
            lstb.Items.Add("\tNo.------Név------Lépés-------- Idő-");
            foreach (var item in query.Take(10))
            {
                lstb.Items.Add(string.Format("\t{0,-2}-     {1,-12}\t{2,-3}\t{3:00}:{4:00}", no, item.playername, item.steps, item.time.Minutes, item.time.Seconds));
                no++;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int tabsize=4;
            if (!(sender as RadioButton).Checked) return;
            switch ((sender as RadioButton).Name)
            {
                case "radioButton1": tabsize = 4; groupBox1.Text = "Ranglista 4x4"; break;
                case "radioButton2": tabsize = 6; groupBox1.Text = "Ranglista 6x6"; break;
                case "radioButton3": tabsize = 8; groupBox1.Text = "Ranglista 8x8"; break;
            }
            localranklistfresh(tabsize);
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverranklistrefresh();
        }
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            serverranklistrefresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (music_is_on)
            {
                music_is_on = false;
                button1.BackgroundImage = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("SoundFF"), new Size(50,50));
                musicplayer.controls.stop();
            }
            else
            {
                music_is_on = true;
                button1.BackgroundImage = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("SoundON"), new Size(50,50));
                musicplayer.controls.play();
            }
        }
        private void pinfobutton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("COM", "LF");
            data.Add("unev", loggedUser);
            string res = Pinger.send_com_post(data);
            if (res != "OK")
            {
                MessageBox.Show("Nem sikerült a frissíteni a bejelentkezés állapotot", "Hiba...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
