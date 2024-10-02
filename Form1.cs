namespace WinFormsTasks
{
    public partial class Form1 : Form
    {
        PointDB db = null;

        public Form1()
        {
            InitializeComponent();
            db = new("Stationery");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = db.ExecuteQuery(QueryInputer.Text);
            View.DataSource = ds.Tables["MappedTable"]; // Отображаем конкретную таблицу по её названию
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.UpdateDB();
        }
    }
}
