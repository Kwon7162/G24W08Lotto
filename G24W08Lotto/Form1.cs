namespace G24W08Lotto
{
    public partial class Form1 : Form
    {
        private const int LottoCount = 6;
        private const int MaxNumber = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnGenerate(object sender, EventArgs e)
        {

            HashSet<int> numSet = new HashSet<int>();
            Random r = new Random();

            while (numSet.Count < LottoCount)
            {
                numSet.Add(r.Next(1, MaxNumber + 1));
            }

            int[] num = numSet.ToArray();
            Array.Sort(num);

            Num1.Text = num[0].ToString();
            Num2.Text = num[1].ToString();
            Num3.Text = num[2].ToString();
            Num4.Text = num[3].ToString();
            Num5.Text = num[4].ToString();
            Num6.Text = num[5].ToString();
        }
    }
}
