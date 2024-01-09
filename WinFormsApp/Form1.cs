namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            long count = await Task.Run(() =>
            {
                long sum = 0;
                for (long i = 0; i < 10000000000; i++)
                {
                    sum += i;
                }
                return sum;
            });

            MessageBox.Show(count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
