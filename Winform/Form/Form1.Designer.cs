namespace Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentNameRadio = new System.Windows.Forms.RadioButton();
            this.idRadio = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.studentSearchInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.studentViewList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._studentClass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.studentAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nameRadio = new System.Windows.Forms.RadioButton();
            this.floorRadio = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteClassBtn = new System.Windows.Forms.Button();
            this.fixClassBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.classDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classCapitity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassViewList = new System.Windows.Forms.DataGridView();
            this.sdtClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCapicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classSearchInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.classStd = new System.Windows.Forms.TabControl();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewList)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassViewList)).BeginInit();
            this.classStd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.studentNameRadio);
            this.tabPage2.Controls.Add(this.idRadio);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.studentSearchInput);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.studentViewList);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sinh Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // studentNameRadio
            // 
            this.studentNameRadio.AutoSize = true;
            this.studentNameRadio.Location = new System.Drawing.Point(437, 13);
            this.studentNameRadio.Name = "studentNameRadio";
            this.studentNameRadio.Size = new System.Drawing.Size(61, 17);
            this.studentNameRadio.TabIndex = 13;
            this.studentNameRadio.Text = "Tên SV";
            this.studentNameRadio.UseVisualStyleBackColor = true;
            // 
            // idRadio
            // 
            this.idRadio.AutoSize = true;
            this.idRadio.Checked = true;
            this.idRadio.Location = new System.Drawing.Point(354, 13);
            this.idRadio.Name = "idRadio";
            this.idRadio.Size = new System.Drawing.Size(36, 17);
            this.idRadio.TabIndex = 14;
            this.idRadio.TabStop = true;
            this.idRadio.Text = "ID";
            this.idRadio.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(696, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Tìm Kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.studentSearchEvent);
            // 
            // studentSearchInput
            // 
            this.studentSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentSearchInput.Location = new System.Drawing.Point(553, 12);
            this.studentSearchInput.Name = "studentSearchInput";
            this.studentSearchInput.Size = new System.Drawing.Size(137, 20);
            this.studentSearchInput.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tìm Theo";
            // 
            // studentViewList
            // 
            this.studentViewList.AllowUserToAddRows = false;
            this.studentViewList.AllowUserToDeleteRows = false;
            this.studentViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.StudentClass});
            this.studentViewList.Location = new System.Drawing.Point(243, 42);
            this.studentViewList.Name = "studentViewList";
            this.studentViewList.ReadOnly = true;
            this.studentViewList.Size = new System.Drawing.Size(536, 347);
            this.studentViewList.TabIndex = 9;
            this.studentViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellStudentDetailEvent);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sinh Viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tuổi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // StudentClass
            // 
            this.StudentClass.DataPropertyName = "StudentClass";
            this.StudentClass.FillWeight = 50F;
            this.StudentClass.HeaderText = "Lớp";
            this.StudentClass.Name = "StudentClass";
            this.StudentClass.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this._studentClass);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.studentAge);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.studentGender);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.studentId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.studentName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 385);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(114, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteStudentBtn);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(16, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateStudentBtn);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(16, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddStudentBtn);
            // 
            // _studentClass
            // 
            this._studentClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._studentClass.Location = new System.Drawing.Point(114, 220);
            this._studentClass.Name = "_studentClass";
            this._studentClass.Size = new System.Drawing.Size(111, 20);
            this._studentClass.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lớp";
            // 
            // studentAge
            // 
            this.studentAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentAge.Location = new System.Drawing.Point(114, 178);
            this.studentAge.Name = "studentAge";
            this.studentAge.Size = new System.Drawing.Size(111, 20);
            this.studentAge.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tuổi";
            // 
            // studentGender
            // 
            this.studentGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGender.Location = new System.Drawing.Point(114, 135);
            this.studentGender.Name = "studentGender";
            this.studentGender.Size = new System.Drawing.Size(111, 20);
            this.studentGender.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giới Tính";
            // 
            // studentId
            // 
            this.studentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentId.Location = new System.Drawing.Point(114, 86);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(111, 20);
            this.studentId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID Sinh Viên";
            // 
            // studentName
            // 
            this.studentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentName.Location = new System.Drawing.Point(114, 42);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(111, 20);
            this.studentName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên Sinh Viên";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nameRadio);
            this.tabPage1.Controls.Add(this.floorRadio);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ClassViewList);
            this.tabPage1.Controls.Add(this.classSearchInput);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lớp Học";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nameRadio
            // 
            this.nameRadio.AutoSize = true;
            this.nameRadio.Checked = true;
            this.nameRadio.Location = new System.Drawing.Point(433, 10);
            this.nameRadio.Name = "nameRadio";
            this.nameRadio.Size = new System.Drawing.Size(65, 17);
            this.nameRadio.TabIndex = 9;
            this.nameRadio.TabStop = true;
            this.nameRadio.Text = "Tên Lớp";
            this.nameRadio.UseVisualStyleBackColor = true;
            // 
            // floorRadio
            // 
            this.floorRadio.AutoSize = true;
            this.floorRadio.Location = new System.Drawing.Point(350, 10);
            this.floorRadio.Name = "floorRadio";
            this.floorRadio.Size = new System.Drawing.Size(47, 17);
            this.floorRadio.TabIndex = 9;
            this.floorRadio.Text = "Vị trí";
            this.floorRadio.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(692, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.classSearchEvent);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.deleteClassBtn);
            this.panel1.Controls.Add(this.fixClassBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.classDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.classCapitity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.classFloor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.className);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 385);
            this.panel1.TabIndex = 7;
            // 
            // deleteClassBtn
            // 
            this.deleteClassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteClassBtn.Location = new System.Drawing.Point(114, 246);
            this.deleteClassBtn.Name = "deleteClassBtn";
            this.deleteClassBtn.Size = new System.Drawing.Size(75, 51);
            this.deleteClassBtn.TabIndex = 14;
            this.deleteClassBtn.Text = "Xóa";
            this.deleteClassBtn.UseVisualStyleBackColor = true;
            this.deleteClassBtn.Click += new System.EventHandler(this.deleteClass);
            // 
            // fixClassBtn
            // 
            this.fixClassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fixClassBtn.Location = new System.Drawing.Point(16, 322);
            this.fixClassBtn.Name = "fixClassBtn";
            this.fixClassBtn.Size = new System.Drawing.Size(75, 51);
            this.fixClassBtn.TabIndex = 14;
            this.fixClassBtn.Text = "Sửa";
            this.fixClassBtn.UseVisualStyleBackColor = true;
            this.fixClassBtn.Click += new System.EventHandler(this.updateClassBtn);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(16, 246);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 51);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button_add);
            // 
            // classDescription
            // 
            this.classDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classDescription.Location = new System.Drawing.Point(109, 178);
            this.classDescription.Name = "classDescription";
            this.classDescription.Size = new System.Drawing.Size(124, 20);
            this.classDescription.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mô tả";
            // 
            // classCapitity
            // 
            this.classCapitity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classCapitity.Location = new System.Drawing.Point(109, 135);
            this.classCapitity.Name = "classCapitity";
            this.classCapitity.Size = new System.Drawing.Size(124, 20);
            this.classCapitity.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sức chứa";
            // 
            // classFloor
            // 
            this.classFloor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classFloor.Location = new System.Drawing.Point(109, 86);
            this.classFloor.Name = "classFloor";
            this.classFloor.Size = new System.Drawing.Size(124, 20);
            this.classFloor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vị trí tầng";
            // 
            // className
            // 
            this.className.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.className.Location = new System.Drawing.Point(109, 41);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(124, 20);
            this.className.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Lớp";
            // 
            // ClassViewList
            // 
            this.ClassViewList.AllowUserToAddRows = false;
            this.ClassViewList.AllowUserToDeleteRows = false;
            this.ClassViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdtClass,
            this.floor,
            this.maxCapicity,
            this.description});
            this.ClassViewList.Location = new System.Drawing.Point(244, 41);
            this.ClassViewList.Name = "ClassViewList";
            this.ClassViewList.ReadOnly = true;
            this.ClassViewList.Size = new System.Drawing.Size(531, 348);
            this.ClassViewList.TabIndex = 6;
            this.ClassViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClassEventClick);
            // 
            // sdtClass
            // 
            this.sdtClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdtClass.DataPropertyName = "name";
            this.sdtClass.HeaderText = "Tên Lớp";
            this.sdtClass.Name = "sdtClass";
            this.sdtClass.ReadOnly = true;
            // 
            // floor
            // 
            this.floor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floor.DataPropertyName = "floor";
            this.floor.HeaderText = "Vị trí Tầng";
            this.floor.Name = "floor";
            this.floor.ReadOnly = true;
            // 
            // maxCapicity
            // 
            this.maxCapicity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxCapicity.DataPropertyName = "MaxCapicity";
            this.maxCapicity.HeaderText = "Sức Chứa";
            this.maxCapicity.Name = "maxCapicity";
            this.maxCapicity.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "Ddescription";
            this.description.HeaderText = "Mô tả";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // classSearchInput
            // 
            this.classSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classSearchInput.Location = new System.Drawing.Point(549, 9);
            this.classSearchInput.Name = "classSearchInput";
            this.classSearchInput.Size = new System.Drawing.Size(137, 20);
            this.classSearchInput.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tìm Theo";
            // 
            // classStd
            // 
            this.classStd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classStd.Controls.Add(this.tabPage1);
            this.classStd.Controls.Add(this.tabPage2);
            this.classStd.Location = new System.Drawing.Point(0, 0);
            this.classStd.Name = "classStd";
            this.classStd.SelectedIndex = 0;
            this.classStd.Size = new System.Drawing.Size(783, 411);
            this.classStd.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(114, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 51);
            this.button6.TabIndex = 14;
            this.button6.Text = "Tải lại";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.refreshListEvent);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.Location = new System.Drawing.Point(114, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 51);
            this.button7.TabIndex = 14;
            this.button7.Text = "Tải lại";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.refreshListEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 407);
            this.Controls.Add(this.classStd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassViewList)).EndInit();
            this.classStd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView studentViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox _studentClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox studentAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton nameRadio;
        private System.Windows.Forms.RadioButton floorRadio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteClassBtn;
        private System.Windows.Forms.Button fixClassBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox classDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classCapitity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClassViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCapicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.TextBox classSearchInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl classStd;
        private System.Windows.Forms.RadioButton studentNameRadio;
        private System.Windows.Forms.RadioButton idRadio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox studentSearchInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

