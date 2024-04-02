namespace CsharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       







        #region UI Event Handlers		textbox2	""	string

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = textBox1.Text;

            //debugOutput("Rest Client Created");

            //string textbox2=string.Empty;

            textBox2.Text = rClient.makeRequest();

            //debugOutput(textbox2);

        }

        #endregion








































        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
