namespace DateCalculator
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
            panel1 = new Panel();
            label5 = new Label();
            labelResult = new Label();
            labelComment = new Label();
            panel2 = new Panel();
            labelLog = new Label();
            label4 = new Label();
            tabPageAddSub = new TabPage();
            numericUpDownMonth = new NumericUpDown();
            numericUpDownYear = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSub = new Button();
            buttonAdd = new Button();
            numericUpDownDay = new NumericUpDown();
            dateTimePickerAddSub = new DateTimePicker();
            tabPageDiffTime = new TabPage();
            buttonRotate = new Button();
            buttonTimeDiff = new Button();
            textBoxTime2 = new TextBox();
            textBoxTime1 = new TextBox();
            tabPageDiffDate = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            buttonDiff = new Button();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPageAddSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDay).BeginInit();
            tabPageDiffTime.SuspendLayout();
            tabPageDiffDate.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(labelResult);
            panel1.Location = new Point(12, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 81);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Eredmény:";
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelResult.Location = new Point(3, 25);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(262, 54);
            labelResult.TabIndex = 0;
            labelResult.Text = "                        ";
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 238);
            labelComment.Location = new Point(16, 321);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(90, 17);
            labelComment.TabIndex = 3;
            labelComment.Text = "Napon átívelő!";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelLog);
            panel2.Location = new Point(292, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 396);
            panel2.TabIndex = 5;
            // 
            // labelLog
            // 
            labelLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLog.Location = new Point(3, 0);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(444, 394);
            labelLog.TabIndex = 0;
            labelLog.Text = "                         ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 12);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "History";
            // 
            // tabPageAddSub
            // 
            tabPageAddSub.Controls.Add(numericUpDownMonth);
            tabPageAddSub.Controls.Add(numericUpDownYear);
            tabPageAddSub.Controls.Add(label3);
            tabPageAddSub.Controls.Add(label2);
            tabPageAddSub.Controls.Add(label1);
            tabPageAddSub.Controls.Add(buttonSub);
            tabPageAddSub.Controls.Add(buttonAdd);
            tabPageAddSub.Controls.Add(numericUpDownDay);
            tabPageAddSub.Controls.Add(dateTimePickerAddSub);
            tabPageAddSub.Location = new Point(4, 24);
            tabPageAddSub.Name = "tabPageAddSub";
            tabPageAddSub.Padding = new Padding(3);
            tabPageAddSub.Size = new Size(266, 191);
            tabPageAddSub.TabIndex = 1;
            tabPageAddSub.Text = "Date Add/Sub";
            tabPageAddSub.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMonth
            // 
            numericUpDownMonth.Location = new Point(87, 50);
            numericUpDownMonth.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numericUpDownMonth.Name = "numericUpDownMonth";
            numericUpDownMonth.Size = new Size(61, 23);
            numericUpDownMonth.TabIndex = 8;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(6, 50);
            numericUpDownYear.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(75, 23);
            numericUpDownYear.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 32);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Hónap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 5;
            label2.Text = "Év";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 32);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Nap";
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(6, 121);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(124, 35);
            buttonSub.TabIndex = 3;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 79);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 36);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // numericUpDownDay
            // 
            numericUpDownDay.Location = new Point(154, 50);
            numericUpDownDay.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownDay.Name = "numericUpDownDay";
            numericUpDownDay.Size = new Size(61, 23);
            numericUpDownDay.TabIndex = 1;
            numericUpDownDay.ValueChanged += numericUpDownDay_ValueChanged;
            // 
            // dateTimePickerAddSub
            // 
            dateTimePickerAddSub.Location = new Point(6, 6);
            dateTimePickerAddSub.Name = "dateTimePickerAddSub";
            dateTimePickerAddSub.Size = new Size(200, 23);
            dateTimePickerAddSub.TabIndex = 0;
            // 
            // tabPageDiffTime
            // 
            tabPageDiffTime.Controls.Add(buttonRotate);
            tabPageDiffTime.Controls.Add(buttonTimeDiff);
            tabPageDiffTime.Controls.Add(textBoxTime2);
            tabPageDiffTime.Controls.Add(textBoxTime1);
            tabPageDiffTime.Location = new Point(4, 24);
            tabPageDiffTime.Name = "tabPageDiffTime";
            tabPageDiffTime.Padding = new Padding(3);
            tabPageDiffTime.Size = new Size(266, 191);
            tabPageDiffTime.TabIndex = 2;
            tabPageDiffTime.Text = "Time Diff";
            tabPageDiffTime.UseVisualStyleBackColor = true;
            // 
            // buttonRotate
            // 
            buttonRotate.Image = (Image)resources.GetObject("buttonRotate.Image");
            buttonRotate.Location = new Point(112, 6);
            buttonRotate.Name = "buttonRotate";
            buttonRotate.Size = new Size(35, 35);
            buttonRotate.TabIndex = 3;
            buttonRotate.UseVisualStyleBackColor = true;
            buttonRotate.Click += buttonRotate_Click;
            // 
            // buttonTimeDiff
            // 
            buttonTimeDiff.Location = new Point(6, 64);
            buttonTimeDiff.Name = "buttonTimeDiff";
            buttonTimeDiff.Size = new Size(100, 36);
            buttonTimeDiff.TabIndex = 2;
            buttonTimeDiff.Text = "Time Diff";
            buttonTimeDiff.UseVisualStyleBackColor = true;
            buttonTimeDiff.Click += buttonTimeDiff_Click;
            // 
            // textBoxTime2
            // 
            textBoxTime2.Location = new Point(6, 35);
            textBoxTime2.Name = "textBoxTime2";
            textBoxTime2.Size = new Size(100, 23);
            textBoxTime2.TabIndex = 1;
            textBoxTime2.Leave += textBoxTime2_Leave;
            // 
            // textBoxTime1
            // 
            textBoxTime1.Location = new Point(6, 6);
            textBoxTime1.Name = "textBoxTime1";
            textBoxTime1.Size = new Size(100, 23);
            textBoxTime1.TabIndex = 0;
            textBoxTime1.TextChanged += textBoxTime1_TextChanged;
            textBoxTime1.Leave += textBoxTime1_Leave;
            textBoxTime1.MouseLeave += textBoxTime1_MouseLeave;
            // 
            // tabPageDiffDate
            // 
            tabPageDiffDate.Controls.Add(dateTimePicker1);
            tabPageDiffDate.Controls.Add(dateTimePicker2);
            tabPageDiffDate.Controls.Add(buttonDiff);
            tabPageDiffDate.Location = new Point(4, 24);
            tabPageDiffDate.Name = "tabPageDiffDate";
            tabPageDiffDate.Padding = new Padding(3);
            tabPageDiffDate.Size = new Size(266, 191);
            tabPageDiffDate.TabIndex = 0;
            tabPageDiffDate.Text = "Date Diff";
            tabPageDiffDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(6, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // buttonDiff
            // 
            buttonDiff.Location = new Point(6, 64);
            buttonDiff.Name = "buttonDiff";
            buttonDiff.Size = new Size(100, 36);
            buttonDiff.TabIndex = 2;
            buttonDiff.Text = "Diff";
            buttonDiff.UseVisualStyleBackColor = true;
            buttonDiff.Click += buttonDiff_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDiffDate);
            tabControl1.Controls.Add(tabPageDiffTime);
            tabControl1.Controls.Add(tabPageAddSub);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(274, 219);
            tabControl1.TabIndex = 4;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 438);
            Controls.Add(labelComment);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Dátum Kalkulátor";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabPageAddSub.ResumeLayout(false);
            tabPageAddSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDay).EndInit();
            tabPageDiffTime.ResumeLayout(false);
            tabPageDiffTime.PerformLayout();
            tabPageDiffDate.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelResult;
        private Panel panel2;
        private Label labelLog;
        private Label label4;
        private Label label5;
        private TabPage tabPageAddSub;
        private NumericUpDown numericUpDownMonth;
        private NumericUpDown numericUpDownYear;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSub;
        private Button buttonAdd;
        private NumericUpDown numericUpDownDay;
        private DateTimePicker dateTimePickerAddSub;
        private TabPage tabPageDiffTime;
        private Button buttonTimeDiff;
        private TextBox textBoxTime2;
        private TextBox textBoxTime1;
        private TabPage tabPageDiffDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonDiff;
        private TabControl tabControl1;
        private Label labelComment;
        private Button buttonRotate;
    }
}
