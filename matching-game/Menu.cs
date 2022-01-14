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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            Level1 lvl1 = new Level1();
            lvl1.ShowDialog();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            Level2 lvl2 = new Level2();
            lvl2.ShowDialog();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            Level3 lvl3 = new Level3();
            lvl3.ShowDialog();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.ShowDialog();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.ShowDialog();
        }

        
    }
}
