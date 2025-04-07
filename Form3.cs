using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sıberguvenlıkproje
{
    public partial class Form3 : Form
    {
        private int score = 0;  // Doğru cevap sayısı
        private int totalQuestions = 10; // Toplam soru sayısı
        private int pointPerQuestion = 10; // Her sorunun puanı
        private int totalScore = 0;
        public Form3()
        {
            InitializeComponent();

        }

        private void UpdateScore()
        {
            totalScore = score * pointPerQuestion; 
            double percentage = (double)totalScore / (totalQuestions * pointPerQuestion) * 100;

            string rank = "Çaylak Dedektif 🐣"; // Varsayılan değer ekleyelim

            if (percentage == 100)
            {
                rank = "Dedektif ";
                pictureBox28.Visible = true;
                label56.Text = "Tebrikler... Zekân, dikkatli gözlemlerin ve keskin mantığın sayesinde her soruyu doğru cevaplayarak üstün bir başarıya ulaştın. Aramıza hoş geldin, Dedektif!";
            }
            else if (percentage >= 71 && percentage <= 90)
            {
                rank = "Siber Güvenlik Amiri ";
                pictureBox27.Visible = true;
                label56.Text = "Ahh... Neredeyse! Soruları oldukça iyi cevapladın ama küçük bir hata yaptın dedektif adayı... Belki de bir ayrıntıyı kaçırdın ama pes etmek yok! Gerçek bir dedektif, her başarısızlığı bir ders olarak görür.";
            }
            else if (percentage >= 41 && percentage <= 70)
            {
                rank = "Polis Memuru ";
                pictureBox26.Visible = true;
                label56.Text = "Suçla mücadelede ön saftasın! Dedektiflik seviyesine ulaşamadın belki ama adaletin yılmaz bir savunucusu oldun! Görevin burada bitmiyor, şehrin sana ihtiyacı var!";
            }
            else if (percentage >= 0 && percentage <= 40)
            {
                rank = "Amatör Polis ";
                pictureBox25.Visible = true;
                label56.Text = "Sanırım ipuçları gözünden kaçtı ve maalesef dedektiflik hayalin suya düştü… Ama endişelenme, her büyük polis bir yerden başlar. Daha fazla çalışarak bir gün gerçek bir dedektif olabilirsin!";
            }

            label55.Text=($"Yüzde: {percentage:F1} Seviye: {rank}");

            

            UpdateBadge(totalScore);




        }


        private void UpdateBadge(int score)
        {

        }



        private void Form3_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabPage1.Text = "";
            tabPage2.Text = "";
            tabPage3.Text = "";
            tabPage4.Text = "";
            tabPage5.Text = "";
            tabPage6.Text = "";
            tabPage7.Text = "";
            tabPage8.Text = "";
            tabPage9.Text = "";
            tabPage10.Text = "";
            tabPage11.Text = "";
            tabPage12.Text = "";
            tabPage13.Text = "";
            tabPage14.Text = "";



            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;



            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                score += 1;
                UpdateScore();
            }

               
                checkBox2.Checked = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
               
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = false;
            checkBox6.Visible = false;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                score += 1;
                UpdateScore();
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = true;
            checkBox8.Visible = true;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                score += 1;
                UpdateScore();
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                score += 1;
                UpdateScore();
            }

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
        
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
          


        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage3;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                score += 1;
                UpdateScore();
            }

            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab = tabPage2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                score += 1;
                UpdateScore();
            }

            tabControl1.SelectedTab = tabPage5;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
           
            tabControl1.SelectedTab = tabPage5;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
          
            tabControl1.SelectedTab = tabPage5;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
         
            tabControl1.SelectedTab = tabPage5;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
           
            tabControl1.SelectedTab = tabPage6;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            
               if (checkBox22.Checked)
            {
                score += 1;
                UpdateScore();
            }

            tabControl1.SelectedTab = tabPage6;
           
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                score += 1;
                UpdateScore();
            }

            tabControl1.SelectedTab = tabPage7;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                score += 1;
                UpdateScore();
            }

            tabControl1.SelectedTab = tabPage8;

        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            tabControl1.SelectedTab = tabPage12;
            button6WasClicked = true; // Buton6'nın doğru olarak seçildiğini işaretle
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;

            score += 1;
            UpdateScore();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            int correctCount = 0;

            // Doğru checkboxları kontrol et
            if (checkBox1.Checked) correctCount++;
            if (checkBox4.Checked) correctCount++;
            if (checkBox6.Checked) correctCount++;
            if (checkBox7.Checked) correctCount++;
            if (checkBox9.Checked) correctCount++;
            if (checkBox11.Checked) correctCount++;
            if (checkBox22.Checked) correctCount++;
            if (checkBox24.Checked) correctCount++;
            if (checkBox32.Checked) correctCount++;

            // Eğer button6'ya doğru şekilde basılmışsa doğru cevaplara ekle
            if (button6WasClicked) correctCount++;

            // Progress barı güncelle (%100 = 10 doğru)
            progressBar1.Value = (int)((correctCount / 10.0) * 100);

        }

        private bool button6WasClicked = false;

       


        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            int correctCount = 0;

            // Doğru checkboxları kontrol et
            if (checkBox1.Checked) correctCount++;
            if (checkBox4.Checked) correctCount++;
            if (checkBox6.Checked) correctCount++;
            if (checkBox7.Checked) correctCount++;
            if (checkBox9.Checked) correctCount++;
            if (checkBox11.Checked) correctCount++;
            if (checkBox22.Checked) correctCount++;
            if (checkBox24.Checked) correctCount++;
            if (checkBox32.Checked) correctCount++;

            // Eğer button6'ya doğru şekilde basılmışsa doğru cevaplara ekle
            if (button6WasClicked) correctCount++;

            // Progress barı güncelle (%100 = 10 doğru)
            progressBar1.Value = (int)((correctCount / 10.0) * 100);

        }
      

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
            
        }


        private void ResetAllControls()
        {
            
        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

