using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sıberguvenlıkproje
{
    public partial class Form1: Form
    {
        private string[] mesajlar = { "Kimlik Avı (Phishing)\r\nKimlik avı, kötü niyetli kişilerin, meşru bir kaynaktan geliyormuş gibi görünen sahte e-postalar veya mesajlar yoluyla kişisel bilgileri veya finansal verileri ele geçirme girişimidir. Bu tür oltalama (phishing) saldırıları genellikle banka bilgilerini, kullanıcı adlarını ve şifreleri çalmak için kullanılır. Örneğin, bir bankadan geliyormuş gibi görünen ve hesap bilgilerinizi güncellemenizi isteyen bir e-posta alabilirsiniz. Söz konusu e-posta sizi sahte bir web sitesine yönlendirebilir ve burada girdiğiniz bilgiler dolandırıcıların eline geçer.", "Güvenlik Duvarı (Firewall)\r\nGüvenlik duvarı, bir ağın içindeki ve dışındaki trafiği izleyip kontrol eden, yetkisiz erişimleri engelleyen bir güvenlik sistemi veya yazılımıdır. Ağ trafiğini filtrelemek ve iç ağları dış tehditlerden korumak için kullanılır. Örnek vermek gerekirse, evdeki veya iş yerindeki bilgisayarınıza veya ağınıza gelen istenmeyen trafiği bloke eden bir güvenlik duvarı yazılımı ile yetkisiz erişimleri engelleyerek verilerinizi koruyabilirsiniz.", "Antivirüs Yazılımı\r\nAntivirüs yazılımı, kötü amaçlı yazılımları (virüsler, truva atları, solucanlar) tespit etmek, engellemek ve temizlemek için kullanılan programlardır. Yazılımlar, sisteminizi tarayarak zararlı yazılımları bulur ve onları etkisiz hale getirir. Bilgisayarınıza yüklediğiniz bir antivirüs programı, düzenli olarak sisteminizi tarar ve potansiyel tehditleri tespit ederek sizi uyarır", "Şifreleme (Encryption)\r\nŞifreleme, verilerin yetkisiz erişimden korunması için okunamaz hale getirilmesi işlemidir. Veriler yalnızca yetkili kullanıcılar tarafından özel bir anahtar veya şifre ile çözülebilir. Örneğin, bankacılık işlemleriniz sırasında gönderilen veriler şifrelenebilir ve sadece alıcı taraf verileri çözebilir", "Güçlü Şifre (Strong Password)\r\nGüçlü şifreler, büyük harf, küçük harf, rakam ve semboller içeren, tahmin edilmesi zor şifrelerdir. Parolalar, hesap güvenliğini artırır ve saldırganların şifrelerinizi tahmin etmesini zorlaştırır. “P@ssw0rd!” gibi bir şifre, sadece “123456” gibi basit bir şifreye göre daha güvenli olabilir.", "Şifrelerini kimseyle paylaşma!", "İki adımlı doğrulama kullan!" };

        private int index = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage2;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            tabControl1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabPage1.Text = "";
            tabPage2.Text = "";
            button6.Visible = false;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
         
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = mesajlar[index];
            index++;

            if (index >= mesajlar.Length)
            {
                index = 0;
                button5.Hide();
                button6.Visible = true;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
