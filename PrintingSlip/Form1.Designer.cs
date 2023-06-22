namespace PrintingSlip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            name = new Label();
            enter = new Button();
            dataGridView1 = new DataGridView();
            names = new DataGridViewTextBoxColumn();
            semester = new DataGridViewTextBoxColumn();
            sname = new TextBox();
            ssemester = new TextBox();
            ssem = new Label();
            Print = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 74);
            name.Name = "name";
            name.Size = new Size(59, 25);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // enter
            // 
            enter.Location = new Point(270, 77);
            enter.Name = "enter";
            enter.Size = new Size(112, 34);
            enter.TabIndex = 1;
            enter.Text = "Enter";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { names, semester });
            dataGridView1.Location = new Point(8, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 2;
            // 
            // names
            // 
            names.HeaderText = "name";
            names.MinimumWidth = 8;
            names.Name = "names";
            names.Width = 150;
            // 
            // semester
            // 
            semester.HeaderText = "semester";
            semester.MinimumWidth = 8;
            semester.Name = "semester";
            semester.Width = 150;
            // 
            // sname
            // 
            sname.Location = new Point(77, 77);
            sname.Name = "sname";
            sname.Size = new Size(150, 31);
            sname.TabIndex = 3;
            // 
            // ssemester
            // 
            ssemester.Location = new Point(103, 40);
            ssemester.Name = "ssemester";
            ssemester.Size = new Size(150, 31);
            ssemester.TabIndex = 5;
            // 
            // ssem
            // 
            ssem.AutoSize = true;
            ssem.Location = new Point(12, 37);
            ssem.Name = "ssem";
            ssem.Size = new Size(85, 25);
            ssem.TabIndex = 4;
            ssem.Text = "Semester";
            // 
            // Print
            // 
            Print.Location = new Point(391, 305);
            Print.Name = "Print";
            Print.Size = new Size(112, 34);
            Print.TabIndex = 6;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Print);
            Controls.Add(ssemester);
            Controls.Add(ssem);
            Controls.Add(sname);
            Controls.Add(dataGridView1);
            Controls.Add(enter);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Button enter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn names;
        private DataGridViewTextBoxColumn semester;
        private TextBox sname;
        private TextBox ssemester;
        private Label ssem;
        private Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}