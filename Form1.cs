using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirdd
{
    public partial class Form1 : Form 
    {
        float backgroundSpeed = 10f;//arkaplan ilerleme hızı
        float gravity = 7;//yerçekimi kuvveti
        int score = 0;//skor değerini saklar
        
        public Form1()//form sınıfının yapıcı metodu
        {
            InitializeComponent();//form bileşenlerini başlatır
        }

        private void Form1_Load(object sender, EventArgs e)//form yüklenince çalışır
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerEvent(object sender, EventArgs e)//zamanlayıcı başlatan metod
        {
           flyingBird.Top += (int)gravity;//kuşun yukarı yönlü hareketini sağlar
            pipeDown.Left -= (int)backgroundSpeed;//borunun sola doğru hareketini sağlar
            pipeUp.Left -= (int)backgroundSpeed;//borunun sola doğru hareketini sağlar

            scoreText.Text = "Score: " +score;// score yazısı yanına skor verisini gir
            scoreText_menu.Text = "Score: " + score;//menüde son skoru yaz



            if (pipeDown.Left < -80)//alt boru nesnesinin ekran sınırları dışına çıkması durumunu kontrol eder
            {
                pipeDown.Left = 460;//yeniden oluşturulan nesnenin konumu
                score++;
            }


            if (pipeUp.Left < -70)//üst boru nesnesinin ekran sınırları dışına çıkması durumunu kontrol eder
            {
                pipeUp.Left = 360;//yeniden oluşturulan nesnenin konumu
                score++;
            }

           

            Control[] obstacles = { pipeDown, pipeUp, topGround, Ground };//kontrol edilecek engellerin dizisi

            foreach(var obstacle in obstacles)//engelleri sırayla obstacleye ekle
            {
                if (flyingBird.Bounds.IntersectsWith(obstacle.Bounds))//kuşun kenarları engellerin kenarlarına değiyor mu
                {

                    gameOver();//değiyorsa oyunu bitir
                    game_menu.Show();// menüyü göster
                }


            }

            if (score > 10 ) {//skor 10'dan büyük ise
                backgroundSpeed += 0.01f;//backgroundSpeed değerini 0.01 değerinde arttır


                    }

            if (score > 20)//skor 20'dan büyük ise
            {
                backgroundSpeed += 0.04f;//backgroundSpeed değerini 0.04 değerinde arttır


            }

            if (score > 30)//skor 30'dan büyük ise
            {
                backgroundSpeed += 0.06f;//backgroundSpeed değerini 0.06 değerinde arttır


            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)//enter veya space tıklayınca çalışacak metod
        {
            if (e.KeyCode == Keys.Space || e.KeyCode== Keys.Enter)//enter veya space tuşuna basılınca kuşun yükselme oranı
                gravity = -7;
           
        }


        private void GameKeyUp(object sender, KeyEventArgs e)//tuşlara basılmazsa çalışacak metod
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)//eğer space ya da enter tuşuna basılırsa yerçekimi kuvvetini tekrar devreye al
                gravity = 7;
            if (e.KeyCode == Keys.E)// eğer e ye basarsa oyundan çık
                Application.Exit();
            if (e.KeyCode == Keys.R)//eğer r ye basarsa tekrar başla
                Application.Restart();
        }
        private void gameOver()//oyun bitme durumunda çalışacak metod
        {

            timer.Stop();//zamanlayıcıyı durdur
            scoreText.Text += " GAME OVERR";// score yanına "game over" yaz
            game_menu.Show();//menüyü göster
        }
        
        //tanımlanmış objeler için metodlar
        private void pipeDown_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pipeUp_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)//exitButton_Click butonu için metod
        {
            Application.Exit();// basılırsa oyundan çık
        }

        private void restart_Click(object sender, EventArgs e)//restart_Click butonu için metod
        {

            Application.Restart();// basılırsa oyunu tekrarla


        }
        // çeşitli obje ve olay için metodlar
        private void game_menu_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void scoreText_menu_Click(object sender, EventArgs e)
        {

        }
    }
    }

