using RestSharp;
using static System.Windows.Forms.Design.AxImporter;

namespace RestClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/");
            var result = await client.GetAsync<Posts[]>(new RestRequest("posts"));
            dataGridView1.DataSource = result;
        }
    }

    class Posts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}