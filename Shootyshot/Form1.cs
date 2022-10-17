using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shootyshot.Logic;
using static Shootyshot.Character;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace Shootyshot
{
    public partial class Form1 : Form
    {
        public Character userChar = new Character();
        public Ai ai = new Ai();



        private int AIAmmo = 0;
        private int UserAmmo = 0;
       
        public Form1()
        {
            InitializeComponent();
            txtPAmmo.Text = userChar.ammo.ToString();
            txtaiAmmo.Text = AIAmmo.ToString();
        }
       
 
        private void Form1_Load(object sender, EventArgs e)
        {
            btnShot.Enabled = false;
            btnShotgun.Enabled = false;
            
        }
        private void btnShot_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Shoot;
            GameView.Items.Add("Player tried just using " + Actions.Shoot.ToString());
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(aiAction, userAction);
            if (userChar.ammo <= 1)
            {
             
                btnShot.Enabled = false;
                userChar.ammo--;
            }
            txtPAmmo.Text = userChar.ammo.ToString();
            GameView.Items.Add("Ai just " + aiAction.ToString());


            EndGame(winner);
        }
  

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Block;
            GameView.Items.Add("Player tried just using " + Actions.Block.ToString());
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(aiAction, userAction);
            GameView.Items.Add("Ai just " + aiAction.ToString());
            EndGame(winner);
        }




        private void textBoxPlayerAction_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void GameView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void GameViewLive()
        {
            if (GameView.Items.Count > 12)
                GameView.Items.Clear();
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            if (userChar.ammo >= 0)
            {
                btnShot.Enabled = true;
            }
            if(userChar.ammo >= 2)
            {
                btnShotgun.Enabled = true;
            }
            Actions userAction = userChar.Reload();     
            GameView.Items.Add("Player just " + Actions.Reload.ToString());
            Actions aiAction = ai.AiActions ();
            GameView.Items.Add("Ai just " + aiAction.ToString());
            Winner winner = Logic.OngoingActions(aiAction, userAction);
            EndGame(winner);
            txtPAmmo.Text = userChar.ammo.ToString();
            txtaiAmmo.Text = ai.AIAmmo.ToString();
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\kunge\GITHUB repos\tg1\plugg\Shootyshot\pic1.png");
        }

        private void btnShotgun_Click_1(object sender, EventArgs e)
        {
            Actions aiAction = ai.AiActions();
            Actions userAction = Actions.Shotgun;
            GameView.Items.Add("Ai just " + aiAction.ToString());
            GameView.Items.Add("Player just using " + Actions.Shotgun.ToString());
            Winner winner = Logic.OngoingActions(aiAction, userAction);
            EndGame(winner);

        }

        public void ResetGame()
        {
            userChar = new Character();
            ai = new Ai();
            btnShotgun.Enabled = false;
            btnShot.Enabled = false;
            MessageBox.Show("New round!");
        }


        int aiscore = 0;
        int userscore = 0;

        public void EndGame(Winner winner)
        {
            if (winner == Winner.Player)
            {
                userscore++;
                ResetGame();
            }
            else if (winner == Winner.Ai)
            {
                aiscore++;
                ResetGame();    
            }
            CheckTrueWinner(userscore, aiscore);
        }
        public void CheckTrueWinner(int userscore, int aiscore)
        {
            if (userscore == 2)
            {
                MessageBox.Show("YOU HAVE WON ALL THREE ROUNDS");
            }
            else if (aiscore == 2)
            {
                MessageBox.Show("YOU HAVE LOST ALL THREE ROUNDS LOSER");
            }
        }

        private void txtPAmmo_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restarted!");
            GameView.Items.Clear();
            userChar.ammo = 0;
            ai.AIAmmo = 0;
            aiscore = 0;
            userscore = 0;
            ResetGame();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\kunge\GITHUB repos\tg1\plugg\Shootyshot\refrence\pic2.png");

        }

        public void Restart()
        {
            ResetGame();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\kunge\GITHUB repos\tg1\plugg\Shootyshot\pic1.png");

        }

        private void textBoxAmmoComputer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
