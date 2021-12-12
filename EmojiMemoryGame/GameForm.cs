using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace EmojiMemoryGame
{
    public class playerValues
    {
        public string playername { set; get; }
        public int steps { set; get; }
        public TimeSpan time { set; get; }
        public int gametype { set; get; }
    }
    public class GameForm : Form
    {  
        public delegate void GameOver(playerValues ret);
        public GameOver onGameOver;

        private TableLayoutPanel tableLayoutPanel1;
        private Button firstClickedBTN, secondClickedBTN;
        private Image firstClickedBTNimage, secondClickedBTNimage;
        private Stopwatch stopWatch = new Stopwatch();
        private int  stepCounter, matchCounter;
        private Image[] imageArray;
        private TimeSpan timespan;
        private bool firstclick;
        private Timer GameTimer = new Timer();
        private Timer PictureFlippTimer = new Timer();
        private int rowcol;
        private Label timeLabel = new Label();
        private Label stepsLabel = new Label();
        private Label timeLabel_c = new Label();
        private Label stepsLabel_c = new Label();
        private Button sndr;
       

        public GameForm(int rowcol,Button sndr) 
        {
            
            this.sndr = sndr;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_Closing);
            this.PictureFlippTimer.Tick += new System.EventHandler(this.PictureFlippTimer_Tick);
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            this.Text = rowcol.ToString() + "X" + rowcol.ToString() + " játéktábla....";
            this.StartPosition = FormStartPosition.CenterParent;
            this.GameTimer.Interval = 998;
            this.PictureFlippTimer.Interval = 750;
            this.rowcol = rowcol;
            this.Size = new Size(435, 500);
            this.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = (System.Drawing.Icon)Properties.Resources.ResourceManager.GetObject("EMG.ico");
            this.timeLabel_c.AutoSize = true;
            this.timeLabel_c.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel_c.ForeColor = System.Drawing.Color.Azure;
            this.timeLabel_c.Location = new System.Drawing.Point(0, 431);
            this.timeLabel_c.Name = "timeLabel_c";
            this.timeLabel_c.Size = new System.Drawing.Size(101, 23);
            this.timeLabel_c.TabIndex = 5;
            this.timeLabel_c.Text = "Játék idő:";
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.timeLabel.Location = new System.Drawing.Point(107, 431);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(67, 23);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "";
            this.stepsLabel_c.AutoSize = true;
            this.stepsLabel_c.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepsLabel_c.ForeColor = System.Drawing.Color.Azure;
            this.stepsLabel_c.Location = new System.Drawing.Point(213, 431);
            this.stepsLabel_c.Name = "stepsLabel_c";
            this.stepsLabel_c.Size = new System.Drawing.Size(161, 23);
            this.stepsLabel_c.TabIndex = 7;
            this.stepsLabel_c.Text = "Lépések száma:";
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepsLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.stepsLabel.Location = new System.Drawing.Point(375, 431);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(68, 23);
            this.stepsLabel.TabIndex = 8;
            this.stepsLabel.Text = "";
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeLabel_c);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.stepsLabel_c);
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            fillImageArray(rowcol);
            setGameTable(rowcol);
            stepCounter = 0;
            matchCounter = 0;
            timeLabel.Text = "00:00";
            stepsLabel.Text = "0";
            firstclick = true;
        }
        private void GameForm_Closing(object sender, EventArgs e)
        {
            (sndr as Button).Enabled = true;
        }
        private void setGameTable(int rowcol)
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Height = 420;
            tableLayoutPanel1.Width = 420;
            tableLayoutPanel1.ColumnCount = rowcol;
            tableLayoutPanel1.RowCount = rowcol;
            tableLayoutPanel1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            for (int f = 1; f <= rowcol; f++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / rowcol));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowcol));
            }
            this.Controls.Add(tableLayoutPanel1);
            //
            //
            int rowcol2 = rowcol * rowcol;
            for (int f = 1; f <= rowcol2; f++)
            {
                tableLayoutPanel1.Controls.Add(new Button()
                {
                    Dock = DockStyle.Fill,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = imageArray[f - 1].Tag.ToString(),
                    Cursor = Cursors.Hand
                });
            }
            int arrayindex = 0;
            foreach (Button Pboxes in tableLayoutPanel1.Controls)
            {
                if (Pboxes is Button)
                {
                    Pboxes.Click += this.pictureButton_click;
                    Pboxes.FlatAppearance.BorderSize = 0;
                    Pboxes.Image = new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject("cover"), new Size(Pboxes.Size.Width, Pboxes.Size.Height));
                    Pboxes.BackgroundImage = new Bitmap(imageArray[arrayindex], new Size(Pboxes.Size.Width, Pboxes.Size.Height));
                    arrayindex++;
                }
            }
            tableLayoutPanel1.Refresh();
            tableLayoutPanel1.Visible = true;
        }
        private void fillImageArray(int tabsize)
        {
            HashSet<Image> imgset = new HashSet<Image>();
            for (int f = 1; f <= 32; f++)
            {
                imgset.Add(new Bitmap((Bitmap)Properties.Resources.ResourceManager.GetObject(f.ToString())));
            }
            int arrayLenght = tabsize * tabsize;
            imageArray = new Image[arrayLenght];
            Random rnd = new Random();
            int rndmax = 32;
            for (int f = 0; f <= arrayLenght / 2 - 1; f++)
            {
                int rndNum = rnd.Next(0, rndmax);
                rndmax--;
                Image mustsign = imgset.ElementAt(rndNum);
                imgset.Remove(mustsign);
                mustsign.Tag = f;
                imageArray[f] = mustsign;
                imageArray[f + (arrayLenght / 2)] = imageArray[f];
            }
            Image puffer;
            int rnd1, rnd2;
            for (int f = 0; f <= imageArray.Length; f++)
            {
                do
                {
                    rnd1 = rnd.Next(0, imageArray.Length - 1);
                    rnd2 = rnd.Next(0, imageArray.Length - 1);
                } while (rnd1 == rnd2);
                puffer = imageArray[rnd1];
                imageArray[rnd1] = imageArray[rnd2];
                imageArray[rnd2] = puffer;
            }
        }
        private void pictureButton_click(object sender, EventArgs e)
        {
            
            if (firstclick)
            {
                firstclick = false;
                GameTimer.Start();
                stopWatch.Start();
            }
            if (!GameTimer.Enabled && stepCounter == 0)
            {
                stopWatch.Start();
                GameTimer.Start();
            }
            if (firstClickedBTN != null && secondClickedBTN != null) return;

            var clickedBTN = (sender as Button);
            if (clickedBTN == firstClickedBTN) return;
            if (firstClickedBTN == null)
            {
                firstClickedBTNimage = clickedBTN.Image;
                firstClickedBTN = clickedBTN;
                clickedBTN.Image = null;
                return;
            }
            secondClickedBTNimage = clickedBTN.Image;
            secondClickedBTN = clickedBTN;
            clickedBTN.Image = null;
            stepCounter++;
            stepsLabel.Text = stepCounter.ToString();
            
            if (firstClickedBTN.Name == secondClickedBTN.Name)
            {
                matchCounter++;
                firstClickedBTN.Enabled = false;
                secondClickedBTN.Enabled = false;
                firstClickedBTN.Image = null;
                secondClickedBTN.Image = null;
                firstClickedBTN = null;
                secondClickedBTN = null;
            }
            else PictureFlippTimer.Start();
            if (matchCounter == (rowcol * rowcol / 2))
            {
                GameTimer.Stop();
                MessageBox.Show(this, "Eredményed: " + stepsLabel.Text + " lépés " + timeLabel.Text + " idővel!", "Vége a Játéknak!");
                playerValues ret = new playerValues { playername = "", steps = int.Parse(stepsLabel.Text), time = timespan, gametype = rowcol };
                onGameOver(ret);
                this.Close();
            }
        }
        private void PictureFlippTimer_Tick(object sender, EventArgs e)
        {
            PictureFlippTimer.Stop();
            firstClickedBTN.Image = firstClickedBTNimage; ;
            secondClickedBTN.Image = secondClickedBTNimage;
            firstClickedBTN = null;
            secondClickedBTN = null;
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timespan = stopWatch.Elapsed;
            timeLabel.Text = String.Format("{0:00}:{1:00}", timespan.Minutes, timespan.Seconds);
        }

    }
}
