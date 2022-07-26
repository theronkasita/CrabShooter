using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Shooter_Game
{
    public partial class gameWorldForm : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver, gamePaused, isInteger;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int gamelevel = 1;
        int zombieSpeed = 1;
        public int num1, num2;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public gameWorldForm()
        {
            InitializeComponent();
            RestartGame();
            //this.BackColor = Color.Transparent;
            player.BackColor = Color.Transparent;
        }

        private void mainTimerEvents(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                gameTimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Score: " + score;
            levelLbl.Text = "Level: " + gamelevel;
            

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        DoExercise();
                    }
                }



                if (x is PictureBox && (string)x.Tag == "zombie")
                {                   

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }


                        if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if(j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                            ChangeLevel();
                        }
                    }
                }
            }

        }

        // initialize Game
        private void resetGame()
        {
            playerHealth = 100;
            speed = 10;
            ammo = 10;
            score = 0;
            gamelevel = 3;
            zombieSpeed = 1;            
            winnerPanel.Hide();
            zombiesList.Clear();
            exercisePanel.Hide();
        }

        private void DoExercise()
        {
            switch (gamelevel)
            {
                case 1:
                    randNumbers(10);
                    createExercise("+");
                    break;
                case 2:
                    randNumbers(20);
                    createExercise("+");
                    break;
                case 3:
                    randNumbers(30);
                    createExercise("-");
                    break;
                case 4:  
                    randNumbers(10);
                    createExercise("x");
                    break;
                case 5:
                    randNumbers(50);
                    createExercise("/");
                    break;
                default:
                    randNumbers(10);
                    createExercise("+");
                    break;

            }
            gamePaused = true;
            gameTimer.Stop();
            exercisePanel.Show();
            exercisePanel.BringToFront();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ShootBullet(facing);
                dificulty();

            }

            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

            if (gamePaused == true && gameOver == false)
            {
                String num = e.KeyCode.ToString().Remove(0, 1);
                isInteger = num.All(char.IsDigit);

                if(isInteger)
                {
                    answerTxt.Text = answerTxt.Text + num;
                }

                if (e.KeyCode == Keys.OemMinus)
                {
                    answerTxt.Text = answerTxt.Text + "-";
                }

                if (e.KeyCode == Keys.Enter)
                {
                    SubmitAnswer();
                }

                if (e.KeyCode == Keys.Back)
                {
                    if (answerTxt.Text.Length > 0)
                    {
                        answerTxt.Text = answerTxt.Text.Remove(answerTxt.Text.Length - 1);
                    }
                }
            }
            



        }

        private void ShootBullet(String direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            RestartGame();
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombie.BackColor = Color.Transparent;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();

        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }


            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;


            resetGame();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            gameTimer.Start();

        }


        private void SubmitAnswer()
        {
            double ans;
            if (answerTxt.Text.Length <= 0)
            {
                ans = (double).0;
            }
            else
            {
                ans = double.Parse(answerTxt.Text);
            }

            if (add(num1,num2,ans))
            {
                gamePaused = false;
                exercisePanel.Hide();
                gameTimer.Start();

                if (playerHealth > 80)
                {
                    playerHealth = 100;
                }
                else
                {
                    playerHealth += 20;
                }

                if (gamelevel == 1)
                {
                    ammo = 10;
                }
                else
                {
                    ammo = 5;
                }
            }
            else 
            if (sub(num1, num2, ans))
            {
                gamePaused = false;
                exercisePanel.Hide();
                gameTimer.Start();

                if (playerHealth > 80)
                {
                    playerHealth = 100;
                }
                else
                {
                    playerHealth += 20;
                }

                if (gamelevel == 3)
                {
                    ammo = 10;
                }
                else
                {
                    ammo = 5;
                }
            }
            else
            if (mal(num1, num2, ans))
            {
                gamePaused = false;
                exercisePanel.Hide();
                gameTimer.Start();

                if (playerHealth > 80)
                {
                    playerHealth = 100;
                }
                else
                {
                    playerHealth += 20;
                }

                if (gamelevel == 4)
                {
                    ammo = 10;
                }
                else
                {
                    ammo = 5;
                }
            }
            else
            if (div(num1, num2, ans))
            {
                gamePaused = false;
                exercisePanel.Hide();
                gameTimer.Start();

                if (playerHealth > 70)
                {
                    playerHealth = 100;
                }
                else
                {
                    playerHealth += 30;
                }
                if(gamelevel == 5)
                {
                    ammo = 10;
                }
                else
                {
                    ammo = 5;
                }
            }
            else
            {
                gamePaused = false;
                zombiesList.Clear();
                exercisePanel.Hide();
                gameTimer.Start();
                ammo = 5;
            }


        }

        public bool add(int x, int y, double z)
        {
            if ((x + y) == (int)z) { return true; }
            else { return false; }
            Console.WriteLine(x+" + "+y + " = "+z);
        }


        public bool sub(int x, int y, double z)
        {
            if (x > y)
            {
                if ((x - y) == (int)z)
                {
                    return true;
                } else { return false; }
            }
            else
            {
                if ((y - x) == (int)z)
                {
                    return true;
                }
                else { return false; }
            }

        }

        private void levelLbl_Click(object sender, EventArgs e)
        {

        }

        public bool mal(int x, int y, double z)
        {
            if ((x * y) == (int)z) { return true; }
            else { return false; }
        }


        public bool div(int x, int y, double z)
        {
            if (x > y)
            {
                if ((x / y) == (int)z)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                if ((y / x) == (int)z)
                {
                    return true;
                }
                else { return false; }
            }
        }

        public void randNumbers(int x)
        {
            num1 = new Random().Next(gamelevel, x);
            num2 = new Random().Next(new Random().Next(gamelevel,x), x);
        }

        private void createExercise(string sym)
        {
            if(num1 > num2)
            {
                problemTxt.Text = num1 + " " + sym + " " + num2 + " = ";
            } else
            {
                problemTxt.Text = num2 + " " + sym + " " + num1 + " = ";
            }

            answerTxt.Text = "";
        }

        private void ChangeLevel()
        {
            if (score >= 1 && score <= 49)
            {
                gamelevel = 1;
            }
            if (score >= 50 && score <= 99)
            {
                gamelevel = 2;
            }

            if (score >= 100 && score <= 149)
            {
                gamelevel = 3;
            }

            if (score >= 150 && score <= 199)
            {
                gamelevel = 4;
            }

            if (score >= 200 && score <= 299)
            {
                gamelevel = 5;
            }

            if (score >= 300)
            {
                winner();
            }
        }

        private void winner()
        {
            gameOver = true;
            gameTimer.Stop();
            winnerPanel.Show();
            winnerPanel.BringToFront();
        }

        private void dificulty()
        {
            if (gamelevel == 1)
            {
                // unlimitted Bullets
                ammo--;
                // change Crab Speed
                zombieSpeed = gamelevel;
            }
            else if (gamelevel == 2)
            {
                // unlimitted Bullets

                // change Crab Speed
                zombieSpeed = gamelevel;
            }
            else if (gamelevel == 5)
            {
                // unlimitted Bullets
                ammo--;
                // change Crab Speed
                zombieSpeed = 3;
            }
            else
            {  
                // change Crab Speed
                ammo--;
            }

            if (ammo < 1)
            {
                DropAmmo();
            }
        }

    }
}
