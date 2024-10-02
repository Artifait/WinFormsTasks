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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            View = new DataGridView();
            QueryInputer = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)View).BeginInit();
            SuspendLayout();
            // 
            // View
            // 
            View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            View.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            View.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Black;
            dataGridViewCellStyle8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            View.DefaultCellStyle = dataGridViewCellStyle8;
            View.Location = new Point(12, 51);
            View.Name = "View";
            View.Size = new Size(782, 500);
            View.TabIndex = 0;
            // 
            // QueryInputer
            // 
            QueryInputer.Location = new Point(12, 12);
            QueryInputer.Name = "QueryInputer";
            QueryInputer.Size = new Size(546, 33);
            QueryInputer.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(564, 12);
            button1.Name = "button1";
            button1.Size = new Size(108, 33);
            button1.TabIndex = 2;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(678, 12);
            button2.Name = "button2";
            button2.Size = new Size(116, 33);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(806, 563);
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
    }
}
