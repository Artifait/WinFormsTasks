namespace WinFormsTasks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            View = new DataGridView();
            QueryInputer = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Provieders = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)View).BeginInit();
            SuspendLayout();
            // 
            // View
            // 
            View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            View.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            View.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            View.DefaultCellStyle = dataGridViewCellStyle2;
            View.Location = new Point(12, 98);
            View.Name = "View";
            View.Size = new Size(1219, 453);
            View.TabIndex = 0;
            // 
            // QueryInputer
            // 
            QueryInputer.Location = new Point(237, 12);
            QueryInputer.Multiline = true;
            QueryInputer.Name = "QueryInputer";
            QueryInputer.Size = new Size(872, 73);
            QueryInputer.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1115, 12);
            button1.Name = "button1";
            button1.Size = new Size(116, 33);
            button1.TabIndex = 2;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1115, 51);
            button2.Name = "button2";
            button2.Size = new Size(116, 33);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Provieders
            // 
            Provieders.BackColor = Color.Black;
            Provieders.DropDownStyle = ComboBoxStyle.DropDownList;
            Provieders.ForeColor = Color.White;
            Provieders.FormattingEnabled = true;
            Provieders.Location = new Point(12, 11);
            Provieders.Name = "Provieders";
            Provieders.Size = new Size(219, 34);
            Provieders.TabIndex = 4;
            Provieders.SelectedIndexChanged += Providers_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Black;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(219, 34);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1243, 563);
            Controls.Add(comboBox2);
            Controls.Add(Provieders);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(QueryInputer);
            Controls.Add(View);
            Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView View;
        private TextBox QueryInputer;
        private Button button1;
        private Button button2;
        private ComboBox Provieders;
        private ComboBox comboBox2;
    }
}
