namespace PrintingSlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = ssemester.Text;
            dataGridView1.Rows[n].Cells[1].Value = sname.Text;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graph = e.Graphics;
            Font myfont = new Font("Arial", 7, FontStyle.Bold);
            string hell = "____________________________________________________________________________________________________________";
            int my_x = 0;
            int my_y = 0;
            int my_newline = 0;
            StringFormat formt3 = new StringFormat();
            SolidBrush colr = new SolidBrush(Color.Black);
            StringFormat formt0 = new StringFormat();
            formt0.LineAlignment = StringAlignment.Center;
            formt0.Alignment = StringAlignment.Center;
            formt3 = new StringFormat(StringFormatFlags.DirectionVertical);
            //graph.Drawstring()
            //printing
            //heading
            graph.DrawString("Gulshan Medical Store".ToUpper(), new Font("Arial", 13, FontStyle.Bold), colr, 20, my_y + 10);
            //adress
            graph.DrawString("Gulshan Medical Store(shop No 23-B),Near evershine Appartments,", new Font("Arial", 5, FontStyle.Regular), colr, 35, my_y + 33);
            graph.DrawString("Block-10 Gulshan-e-Iqbal,Karachi", new Font("Arial", 5, FontStyle.Regular), colr, 75, my_y + 42);
            //contact details
            graph.DrawString("ContactNo# 03022650101 ,03150214696", new Font("Arial", 5, FontStyle.Bold), colr, 65, my_y + 55);
            //line___________________________
            graph.DrawString(hell, new Font("Arial", 8, FontStyle.Regular), colr, my_x, my_y + 58);
            //invoice no addtxtinvoice
            //query
            string invoicedate = DateTime.Now.ToString();

            //query
            graph.DrawString("Invoice No:", new Font("Arial", 7, FontStyle.Bold), colr, 10, my_y + 73);
            graph.DrawString("No", new Font("Arial", 7, FontStyle.Bold), colr, 70, my_y + 73);
            //invoice Date
            graph.DrawString("Invoice Date:", new Font("Arial", 7, FontStyle.Bold), colr, 120, my_y + 73);

            graph.DrawString(invoicedate, new Font("Arial", 7, FontStyle.Bold), colr, 185, my_y + 73);
            //line___________________________
            graph.DrawString(hell, new Font("Arial", 8, FontStyle.Bold), colr, my_x, my_y + 76);
            //heading of grid
            graph.DrawString("Name", new Font("Arial", 7, FontStyle.Bold), colr, 10, my_y + 92);
            graph.DrawString("Semester", new Font("Arial", 7, FontStyle.Bold), colr, 210, my_y + 92);

            graph.DrawString(hell, new Font("Arial", 8, FontStyle.Bold), colr, my_x, my_y + 100);


            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                //string items = (i + 1) + "-" + dataGridView1.Rows[i].Cells[].Value.ToString();
                string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string sem = dataGridView1.Rows[i].Cells[1].Value.ToString();
                graph.DrawString(name, myfont, colr, 10, my_y + 120);
                graph.DrawString(sem, myfont, colr, 210, my_y + 120);
                my_y = my_y + 20;
                int afteruse = my_y;


            }
            int another_y = int.Parse(dataGridView1.Rows.Count.ToString()) * 18;

            ////line___________________________
            graph.DrawString("_________________________________________________________________________________________________", new Font("Arial", 4, FontStyle.Regular), colr, my_x, 110 + another_y);

            //string subtotal = "Total:" + txtsubtotal.Text;
            string subtotal = "Total:" ;

            graph.DrawString(subtotal, new Font("Arial", 7, FontStyle.Bold), colr, 190, 120 + another_y);
            string Paid = "Paid:" ;
            graph.DrawString(Paid, new Font("Arial", 7, FontStyle.Bold), colr, 190, 140 + another_y);
            string Balance = "Balance:" ;
            graph.DrawString(Balance, new Font(Balance, 7, FontStyle.Bold), colr, 190, 160 + another_y);
            graph.DrawString("_________________________________________________________________________________________________________________", new Font("Arial", 8, FontStyle.Regular), colr, my_x, 175 + another_y);
            graph.DrawString("*******************************************************************************************************************", new Font("Arial", 8, FontStyle.Regular), colr, my_x, 185 + another_y);
            graph.DrawString("No Return No Exchange and No Refund", new Font("Arial", 8, FontStyle.Regular), colr, my_x + 150, 200 + another_y, formt0);

        }

        private void Print_Click(object sender, EventArgs e)
        {
            //printing
            printPreviewDialog1.Document = printDocument1;
            //papersize


            int d1 = dataGridView1.Rows.Count;
            if (d1 > 0 && d1 <= 5)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 300);
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
            else if (d1 >= 5 && d1 <= 10)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 500);
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
            else if (d1 >= 10 && d1 <= 20)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 750);
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
            else if (d1 >= 20 && d1 <= 30)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 850);
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
            else if (d1 >= 30 && d1 <= 40)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 1000);
                printPreviewDialog1.ShowDialog();
                printDocument1.Print();
            }
        }
    }
}