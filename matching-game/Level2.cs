using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matching_game
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }

        Menu sound = new Menu();
        Timer clickTimer = new Timer();
        Timer timer = new Timer { Interval = 1000 };
        Random rand = new Random();
        PictureBox firstGuess;
        bool allowClick = false;
        private int time = 120;


        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        //More resources added
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                  Properties.Resources.img9,
                  Properties.Resources.img8,
                  Properties.Resources.img3,
                  Properties.Resources.img4,
                  Properties.Resources.img5,
                  Properties.Resources.img6
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    sound.fail.Play();
                    MessageBox.Show("YOU LOSE! Out of time");
                    sound.fail.Stop();
                    sound.menusound.Play();
                    ResetImages();
                }

                var ssTime = TimeSpan.FromSeconds(time);
                lblTimer.Text = time.ToString() + " sec";
            };
        }

        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 120;
            timer.Start();
        }

        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.Level2Question;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rand.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;

            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
            sound.victory.Play();

            string[] win = { "Good Job!", "Well Done!", "Congratulations", "Bravo!", "Superb!", "Awesome!", "Remarkable!", "Epic!", "Brilliant!" };
            String quote = win[rand.Next(win.Length)];
            DialogResult TryAgain = MessageBox.Show(quote, "You finished the level with " + time.ToString() + " seconds left", MessageBoxButtons.RetryCancel);
            if (TryAgain == DialogResult.Retry)
            {
                ResetImages();
                sound.victory.Stop();
                sound.menusound.Play();
            }
            else if (TryAgain == DialogResult.Cancel)
            {
                Close();
            }

        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
        }

        private void Level2_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
