using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Final_Project
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            Image backgroundImage = new Bitmap(@"C:\Users\jnugt\source\repos\OOD Final Project\Images\landingwallpaper.jpg");
            this.BackgroundImage = backgroundImage;
        }
        #region Landing Form - Event Handler's
        //Event Handler's for Button1(Fighter) and Button2(Sorcerer
        private void Button1_Hover(object sender, EventArgs e)
        {
            buttonFighter.BackColor = Color.SlateGray;
            buttonFighter.TabStop = false;
            buttonFighter.FlatStyle = FlatStyle.Flat;
            buttonFighter.FlatAppearance.BorderSize = 0;
        }
        private void Button1_Leave(object sender, EventArgs e)
        {
            buttonFighter.BackColor = Color.Black;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string tag = nameInputBox.Text;
            GameplayForm f2 = new GameplayForm(tag, 1);
            //Go to Game Form
            f2.ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string tag = nameInputBox.Text;
            GameplayForm f2 = new GameplayForm(tag, 2);
            //Go to Game Form
            f2.ShowDialog();
        }
        private void Button2_Hover(object sender, EventArgs e)
        {
            buttonSorcerer.BackColor = Color.SlateGray;
            buttonSorcerer.TabStop = false;
            buttonSorcerer.FlatStyle = FlatStyle.Flat;
            buttonSorcerer.FlatAppearance.BorderSize = 0;
        }
        private void Button2_Leave(object sender, EventArgs e)
        {
            buttonSorcerer.BackColor = Color.Black;
        }
        #endregion
    }
}
