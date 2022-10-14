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
       public Character userChar;
       public Ai ai = new Ai();



        private int AIAmmo = 0;
        private int UserAmmo = 0;
       
        public Form1()
        {
            InitializeComponent();
            txtPAmmo.Text = UserAmmo.ToString();
            textBoxAmmoComputer.Text = AIAmmo.ToString();
        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Shoot;
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(userAction, aiAction);
            Endgame(winner);
        }
       

 
        private void Form1_Load(object sender, EventArgs e)
        {
            // Disables shoot and shotgun

        }

        public void round()
        {
            txtPAmmo.Text = UserAmmo.ToString();
            txtPAction.Text = CurrentAction.ToString();


        }

        

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Block;
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(userAction, aiAction);
            Endgame(winner);
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            // MessageBox.Box("You have dumpstered shitter");
            userChar.Reload();
        }

       

        private void textBoxPlayerAction_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void GameView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Actions userAction = Actions.Reload;
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(userAction, aiAction);
            Endgame(winner);

            

        }
        
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnShotgun_Click_1(object sender, EventArgs e)
        {
            Actions userAction = Actions.Shotgun;
            Actions aiAction = ai.AiActions();
            Winner winner = Logic.OngoingActions(userAction, aiAction);
            Endgame(winner);
        }

        private void txtPAmmo_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
