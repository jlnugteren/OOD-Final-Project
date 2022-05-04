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
    public partial class GameplayForm : Form
    {
        public bool attackclick = false;
        public bool healclick = false;

        //Gameplay form Constructor
        public GameplayForm(string gamertag, int charclass)
        {
            InitializeComponent();
            playerNameBox.Text += gamertag;

            //Starts Battle sequence
            this.SetupBattle(gamertag, charclass);
        }
        //Main Battle Setup Method
        public void SetupBattle(string tag, int charclass)
        {
            //Creating Character Special Class
            if (charclass == 1)
            {
                //Creation of user
                FighterClass gamerFighter = new FighterClass();
                gamerFighter.Username = tag;
                gameplayDialogueBox.Text += "*****Fighter " + gamerFighter.Username + " has joined the fight!*****\r\n";
                //Join the Fight
                PlayBattle(gamerFighter);
            }
            else if(charclass == 2)
            {
                //Creation of User
                SorcererClass gamerSorcerer = new SorcererClass();
                gamerSorcerer.Username = tag;
                gameplayDialogueBox.Text += "*****Sorcerer " + gamerSorcerer.Username + " has joined the fight!*****\r\n";
                //Join the Fight
                PlayBattle(gamerSorcerer);
            }
            else
            {
                MessageBox.Show("Could not determine Player Class");
            }
            return;
        }
        #region Main Battle Sequence
        public async void PlayBattle(Player player)
        {
            //Event Listener's for the buttons
            healButton.Click += new System.EventHandler(HealButton_Click);
            attackButton.Click += new System.EventHandler(AttackButton_Click);

            Random randomnumber = new Random();
            int nextfoe = 0;
            gameplayDialogueBox.Text += "****Let The Battle's Begin****\r\n";
            //Game loop for continous play of 4 rounds.
            for (int i = 0; i < 4; i++)
            {
                //Generate the Random Foe
                attackclick = false;
                healclick = false;
                nextfoe = randomnumber.Next()%3;
                Foe currentfoe = RandomFoe(nextfoe);

                //Intializes Stat Blocks
                UpdateBoxes(player, currentfoe);

                //While player is alive and currentfoe is alive
                while (player.Health > 0)
                {
                    //Random Values
                    int foevalue = currentfoe.FoeAttack();
                    int playervalue = player.PlayerAttack();

                    //Making sure Player and Foe do something
                    if (foevalue == 0)
                    {
                        foevalue++;
                    }
                    if (playervalue == 0)
                    {
                        playervalue++;
                    }

                    //foe Attack Sequence
                    string s = currentfoe.GetType().Name;
                    gameplayDialogueBox.Text += " - " + s + " Attacked for " + foevalue + " damage\r\n";
                    foeNameBox.Text = s;
                    player.Health -= foevalue;

                    if (player.Health <= 0)
                    {
                        gameplayDialogueBox.Text = "You Were Defeated!";
                        UpdateBoxes(player, currentfoe);
                        UpdateCursor();
                        return;
                    }

                    //Re-Initializes Stat Blocks
                    UpdateBoxes(player, currentfoe);
                    UpdateCursor();
                    

                    //Waiting for player Input
                    while (attackclick == false && healclick == false)
                    {                        
                        await Task.Delay(10);
                    }
                    //Checking if button was clicked.
                    if (attackclick == true)
                    {
                        gameplayDialogueBox.Text += " - Player Attacked for " + playervalue + " damage\r\n";
                        currentfoe.Health -= playervalue;
                        attackclick = false;
                        UpdateBoxes(player, currentfoe);
                    }
                    else if (healclick == true)
                    {
                        gameplayDialogueBox.Text += player.PlayerHeal();
                        healclick = false;
                        UpdateBoxes(player, currentfoe);                        
                    }
                    else
                    {
                        gameplayDialogueBox.Text += "Nothing Happened\r\n";
                    }
                    UpdateCursor();
                    if (currentfoe.Health <=0)
                    {
                        break;
                    }
                }
                if (player.Health <= 0)
                {
                    gameplayDialogueBox.Text = "You Were Defeated!";
                    return;
                }
                else
                {
                    gameplayDialogueBox.Text += " - " + currentfoe.GetType().Name + "Defeated!\r\n";
                }
                //Foe cleanup
                currentfoe = null;
            }
            //Congratulations Screen
            gameplayDialogueBox.Text = "\r\n\r\n\r\n\r\n********************************************************\r\n" +
                "************ Congratulations You Won! ************\r\n" +
                "********************************************************\r\n";
            return;
        }

        //returns a random foe for the player to fight next.
        public Foe RandomFoe(int i)
        {
            if (i == 0)
            {
                return new Goblin();
            }
            else if (i == 1)
            {
                return new Wolf();
            }
            else if (i == 2)
            {
                return new Vampire();
            }
            else
            {
                return null;
            }
        }
        //Sets it so the Attack is initiated
        public void AttackButton_Click(Object sender, EventArgs e)
        {
            attackclick = true;   
        }
        //Sets it so the Heal is initiated
        public void HealButton_Click(Object sender, EventArgs e)
        {
            healclick = true;
        }
        //Updates the Stat boxes for player and foe
        public void UpdateBoxes(Player p, Foe f)
        {
            playerStatsBox.Text = p.UpdateStats();
            foeStatsBox.Text = f.UpdateStats();
        }
        //Makes it so the gameplay box scrolls with added text
        public void UpdateCursor()
        {
            gameplayDialogueBox.SelectionStart = gameplayDialogueBox.Text.Length;
            gameplayDialogueBox.ScrollToCaret();
        }
        #endregion
    }
}
