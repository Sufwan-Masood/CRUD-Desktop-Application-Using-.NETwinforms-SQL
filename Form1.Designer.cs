namespace CRUD_WINFORM_APP
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7957F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.2043F));
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 3);
            tableLayoutPanel1.Location = new Point(390, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(692, 310);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Internee", "Cheif Officer", "Project Manager", "Software Engineer", "Data Scientist", "Product Manager", "Quality Assurance ", "Engineer", "Business ", "Analyst", "Systems", "Administrator", "Network ", "Engineer", "Database ", "Administrator", "UX/UI Designer", "Front-End Developer", "Back-End Developer", "DevOps Engineer", "IT ", "Support Specialist", "Cybersecurity Analyst", "Technical Writer", "Solutions", "Architect", "IT Consultant", "Mobile", "App Developer", "Cloud Engineer", "Kitchen Staff", "General Employee", "HR" });
            comboBox2.Location = new Point(270, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(377, 33);
            comboBox2.TabIndex = 4;
            comboBox2.Leave += comboBox2_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 265);
            label6.Name = "label6";
            label6.Size = new Size(103, 34);
            label6.TabIndex = 16;
            label6.Text = "Salary:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 212);
            label5.Name = "label5";
            label5.Size = new Size(186, 34);
            label5.TabIndex = 15;
            label5.Text = "Designation:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 161);
            label4.Name = "label4";
            label4.Size = new Size(80, 34);
            label4.TabIndex = 14;
            label4.Text = "Age:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 110);
            label3.Name = "label3";
            label3.Size = new Size(126, 34);
            label3.TabIndex = 13;
            label3.Text = "Gender:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 59);
            label2.Name = "label2";
            label2.Size = new Size(106, 34);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(270, 266);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(377, 33);
            textBox6.TabIndex = 5;
            textBox6.KeyPress += textBox6_KeyPress;
            textBox6.Leave += textBox6_Leave;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(270, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 33);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.Leave += textBox2_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 8);
            label1.Name = "label1";
            label1.Size = new Size(49, 34);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(270, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 33);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MALE", "FEMALE" });
            comboBox1.Location = new Point(270, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(377, 33);
            comboBox1.TabIndex = 2;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(270, 162);
            numericUpDown1.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(377, 33);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown1.Leave += numericUpDown1_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(294, 43);
            label7.TabIndex = 1;
            label7.Text = "OFFICE DATA";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 75);
            button1.Name = "button1";
            button1.Size = new Size(141, 36);
            button1.TabIndex = 2;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(62, 133);
            button2.Name = "button2";
            button2.Size = new Size(141, 36);
            button2.TabIndex = 3;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(62, 197);
            button3.Name = "button3";
            button3.Size = new Size(141, 36);
            button3.TabIndex = 4;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(62, 260);
            button4.Name = "button4";
            button4.Size = new Size(141, 36);
            button4.TabIndex = 5;
            button4.Text = "VIEW";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(62, 320);
            button5.Name = "button5";
            button5.Size = new Size(141, 36);
            button5.TabIndex = 6;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(62, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(1020, 248);
            dataGridView1.TabIndex = 7;
            dataGridView1.Visible = false;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 636);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox6;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
    }
}