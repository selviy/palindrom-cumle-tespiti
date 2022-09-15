namespace WinFormsApp6
{
    public partial class Form1 : Form
    {//palindrom
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "kontrol et";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle;
            cumle = richTextBox1.Text;
            cumle=cumle.ToLower();
            int uzunluk, sayici = 0;
            uzunluk = cumle.Length;
            List<char> palindrom = new List<char>();
            List<char> terspalindrom = new List<char>();
            
            int ls = 0;//liste sayacý
            for (int i = 0; i < uzunluk; i++)
            {
                if (cumle[i] != ' ')
                {
                    palindrom.Add(cumle[i]);
                    ls++;
                }
            }
            for (int i = 0; i < uzunluk; i++)//int i=uzunluk-1; i>=0; i-- 
            {
                if (cumle[uzunluk - 1 - i] != ' ')//i
                {
                    terspalindrom.Add(cumle[uzunluk - 1 - i]);//i
                }
            }
            for (int i = uzunluk - 1; i >= 0; i--) 
            {
                if (cumle[i] != ' ')
                {
                    terspalindrom.Add(cumle[i]);
                }
            }
            for (int i = 0; i < ls; i++)
            {
                if (palindrom[i] == terspalindrom[i])
                    sayici++;
                else
                    break;
            }
            //ls = palindrom.Count; ls kullanmak yerine palindrom.Count kullanýlabilir.
            if (sayici == ls)
                label1.Text = "palindrom";
            else
                label1.Text = "palindrom deðil";

        }
    }
}