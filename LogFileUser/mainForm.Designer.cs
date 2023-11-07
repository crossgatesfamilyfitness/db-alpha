namespace LogFileUser
{
    partial class mainForm
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
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbInsert = new RadioButton();
            rbModify = new RadioButton();
            cmbTables = new ComboBox();
            button2 = new Button();
            dgv_potential = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_potential).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(546, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(cmbTables);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 140);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 10);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Tables:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 11);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 4;
            label1.Text = "Back To Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(421, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInsert);
            groupBox1.Controls.Add(rbModify);
            groupBox1.Location = new Point(211, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operation";
            // 
            // rbInsert
            // 
            rbInsert.AutoSize = true;
            rbInsert.Location = new Point(23, 48);
            rbInsert.Name = "rbInsert";
            rbInsert.Size = new Size(54, 19);
            rbInsert.TabIndex = 1;
            rbInsert.TabStop = true;
            rbInsert.Text = "Insert";
            rbInsert.UseVisualStyleBackColor = true;
            // 
            // rbModify
            // 
            rbModify.AutoSize = true;
            rbModify.Location = new Point(23, 22);
            rbModify.Name = "rbModify";
            rbModify.Size = new Size(63, 19);
            rbModify.TabIndex = 0;
            rbModify.TabStop = true;
            rbModify.Text = "Modify";
            rbModify.UseVisualStyleBackColor = true;
            // 
            // cmbTables
            // 
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(7, 29);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(198, 23);
            cmbTables.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(13, 154);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 2;
            button2.Text = "Clean Checkin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgv_potential
            // 
            dgv_potential.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_potential.Location = new Point(123, 160);
            dgv_potential.Name = "dgv_potential";
            dgv_potential.RowTemplate.Height = 25;
            dgv_potential.Size = new Size(672, 375);
            dgv_potential.TabIndex = 3;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 547);
            Controls.Add(dgv_potential);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "--->";
            Load += mainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_potential).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton rbInsert;
        private RadioButton rbModify;
        private ComboBox cmbTables;
        private Button button2;
        private DataGridView dgv_potential;
    }
}