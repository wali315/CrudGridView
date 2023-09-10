namespace CrudGridView
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAge = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxEmployeeID = new TextBox();
            textBoxEmployeeName = new TextBox();
            textBoxCity = new TextBox();
            textBoxAge = new TextBox();
            textBoxContact = new TextBox();
            btnInsert = new Button();
            radioButtonMale = new RadioButton();
            radioButtonFeMale = new RadioButton();
            dateTimePickerJoiningDate = new DateTimePicker();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 44);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(178, 2);
            label1.Name = "label1";
            label1.Size = new Size(359, 37);
            label1.TabIndex = 0;
            label1.Text = "Crud In C#(Stored-Procedure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(61, 281);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 14;
            label2.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(61, 327);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 13;
            label3.Text = "Joining Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(61, 236);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 12;
            label4.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = Color.Red;
            lblAge.Location = new Point(61, 157);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(46, 25);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(61, 196);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(61, 115);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 9;
            label6.Text = "Employee Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(61, 74);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 8;
            label7.Text = "Employee Id";
            // 
            // textBoxEmployeeID
            // 
            textBoxEmployeeID.BackColor = SystemColors.ControlText;
            textBoxEmployeeID.BorderStyle = BorderStyle.None;
            textBoxEmployeeID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmployeeID.ForeColor = Color.Gray;
            textBoxEmployeeID.Location = new Point(237, 74);
            textBoxEmployeeID.Name = "textBoxEmployeeID";
            textBoxEmployeeID.Size = new Size(294, 18);
            textBoxEmployeeID.TabIndex = 15;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.BackColor = SystemColors.ControlText;
            textBoxEmployeeName.BorderStyle = BorderStyle.None;
            textBoxEmployeeName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmployeeName.ForeColor = Color.Gray;
            textBoxEmployeeName.Location = new Point(237, 115);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(294, 18);
            textBoxEmployeeName.TabIndex = 16;
            // 
            // textBoxCity
            // 
            textBoxCity.BackColor = SystemColors.ControlText;
            textBoxCity.BorderStyle = BorderStyle.None;
            textBoxCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCity.ForeColor = Color.Gray;
            textBoxCity.Location = new Point(237, 196);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(294, 18);
            textBoxCity.TabIndex = 17;
            // 
            // textBoxAge
            // 
            textBoxAge.BackColor = SystemColors.ControlText;
            textBoxAge.BorderStyle = BorderStyle.None;
            textBoxAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAge.ForeColor = Color.Gray;
            textBoxAge.Location = new Point(237, 157);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(294, 18);
            textBoxAge.TabIndex = 17;
            // 
            // textBoxContact
            // 
            textBoxContact.BackColor = SystemColors.ControlText;
            textBoxContact.BorderStyle = BorderStyle.None;
            textBoxContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContact.ForeColor = Color.Gray;
            textBoxContact.Location = new Point(237, 281);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(294, 18);
            textBoxContact.TabIndex = 18;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ControlText;
            btnInsert.FlatAppearance.BorderColor = Color.Red;
            btnInsert.FlatAppearance.BorderSize = 2;
            btnInsert.FlatAppearance.MouseDownBackColor = Color.Red;
            btnInsert.FlatAppearance.MouseOverBackColor = Color.Black;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.Red;
            btnInsert.Location = new Point(159, 383);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 33);
            btnInsert.TabIndex = 20;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonMale.ForeColor = Color.Red;
            radioButtonMale.Location = new Point(266, 241);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(60, 23);
            radioButtonMale.TabIndex = 21;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeMale
            // 
            radioButtonFeMale.AutoSize = true;
            radioButtonFeMale.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFeMale.ForeColor = Color.Red;
            radioButtonFeMale.Location = new Point(392, 241);
            radioButtonFeMale.Name = "radioButtonFeMale";
            radioButtonFeMale.Size = new Size(75, 23);
            radioButtonFeMale.TabIndex = 22;
            radioButtonFeMale.TabStop = true;
            radioButtonFeMale.Text = "Female";
            radioButtonFeMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerJoiningDate
            // 
            dateTimePickerJoiningDate.CalendarForeColor = Color.Gray;
            dateTimePickerJoiningDate.CalendarMonthBackground = Color.Gray;
            dateTimePickerJoiningDate.CalendarTitleBackColor = Color.Gray;
            dateTimePickerJoiningDate.CalendarTitleForeColor = Color.Gray;
            dateTimePickerJoiningDate.CalendarTrailingForeColor = Color.Gray;
            dateTimePickerJoiningDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            dateTimePickerJoiningDate.Format = DateTimePickerFormat.Short;
            dateTimePickerJoiningDate.Location = new Point(237, 326);
            dateTimePickerJoiningDate.Name = "dateTimePickerJoiningDate";
            dateTimePickerJoiningDate.Size = new Size(294, 25);
            dateTimePickerJoiningDate.TabIndex = 23;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlText;
            btnEdit.FlatAppearance.BorderColor = Color.Red;
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Red;
            btnEdit.Location = new Point(259, 383);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 33);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlText;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(359, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 33);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 427);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(691, 184);
            dataGridView1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.Location = new Point(237, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 1);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(237, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 1);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(237, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 1);
            panel4.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(237, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 1);
            panel5.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(237, 220);
            panel6.Name = "panel6";
            panel6.Size = new Size(294, 1);
            panel6.TabIndex = 31;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(237, 305);
            panel7.Name = "panel7";
            panel7.Size = new Size(294, 1);
            panel7.TabIndex = 32;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(237, 351);
            panel8.Name = "panel8";
            panel8.Size = new Size(294, 1);
            panel8.TabIndex = 33;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlText;
            btnSearch.FlatAppearance.BorderColor = Color.Red;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Red;
            btnSearch.Location = new Point(459, 383);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 33);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(697, 614);
            Controls.Add(btnSearch);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dateTimePickerJoiningDate);
            Controls.Add(radioButtonFeMale);
            Controls.Add(radioButtonMale);
            Controls.Add(btnInsert);
            Controls.Add(textBoxContact);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxEmployeeName);
            Controls.Add(textBoxEmployeeID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblAge);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "Form1";
            Padding = new Padding(3);
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAge;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxEmployeeID;
        private TextBox textBoxEmployeeName;
        private TextBox textBoxCity;
        private TextBox textBoxAge;
        private TextBox textBoxContact;
        private Button btnInsert;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFeMale;
        private DateTimePicker dateTimePickerJoiningDate;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Button btnSearch;
    }
}