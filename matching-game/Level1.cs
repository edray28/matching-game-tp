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
    public partial class Level1 : Form
    {
      
        public Level1()
        {
            InitializeComponent();
        }

        //menu object for sounds
        Menu sound = new Menu();

        //timer for Click and countdown
        Timer clickTimer = new Timer();
        Timer timer = new Timer { Interval = 1000 };

        //random variable for randomizing match in pictureboxes and quotes
        Random rand = new Random();

        //first click of image
        PictureBox firstGuess;

        //Allow click button after pressing start
        bool allowClick = false;

        //time var for countdown lvl1
        private int time = 60;

        //PictureBoxes stores object arrays 
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        //iterate and return new images objects pictureBoxes from Resources in solution folder
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                  Properties.Resources.img1,
                  Properties.Resources.img2,
                  Properties.Resources.img8
                };
            }
        }

        //start timer after being called in the startGame function
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
                //realtime seconds
                var ssTime = TimeSpan.FromSeconds(time);
                lblTimer.Text = time.ToString() + " sec";
            };
        }

        //reset images after timer, level is finished and called after pick wrong match 
        public void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }

        //Hide images in pictureboxes by iterating replacing all resource with another resource (Level1Question)
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.Level1Question;
            }
        }

        //Sets image in picturebox randomly function  
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

        //Iterate the getfreeslots each image on images ineumerable
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

        //Match image by pairs and checks images left
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
            clickTimer.Stop();
            timer.Stop();
            sound.victory.Play();

            //Win texts
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

        //Start game function in button that sets images, timer and click 
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

        private void Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
