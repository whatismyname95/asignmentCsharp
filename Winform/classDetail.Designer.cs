namespace Winform
{
    partial class classDetail
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
            this.classUpdateDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classUpdateCapitity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classUpdateFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classUpdateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fixClassBtn = new System.Windows.Forms.Button();
            this.originClassName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classUpdateDescription
            // 
            this.classUpdateDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classUpdateDescription.Location = new System.Drawing.Point(138, 175);
            this.classUpdateDescription.Name = "classUpdateDescription";
            this.classUpdateDescription.Size = new System.Drawing.Size(200, 20);
            this.classUpdateDescription.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mô tả";
            // 
            // classUpdateCapitity
            // 
            this.classUpdateCapitity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classUpdateCapitity.Location = new System.Drawing.Point(138, 132);
            this.classUpdateCapitity.Name = "classUpdateCapitity";
            this.classUpdateCapitity.Size = new System.Drawing.Size(200, 20);
            this.classUpdateCapitity.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sức chứa";
            // 
            // classUpdateFloor
            // 
            this.classUpdateFloor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classUpdateFloor.Location = new System.Drawing.Point(138, 83);
            this.classUpdateFloor.Name = "classUpdateFloor";
            this.classUpdateFloor.Size = new System.Drawing.Size(200, 20);
            this.classUpdateFloor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Vị trí tầng";
            // 
            // classUpdateName
            // 
            this.classUpdateName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classUpdateName.Location = new System.Drawing.Point(138, 38);
            this.classUpdateName.Name = "classUpdateName";
            this.classUpdateName.Size = new System.Drawing.Size(200, 20);
            this.classUpdateName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Lớp";
            // 
            // fixClassBtn
            // 
            this.fixClassBtn.Location = new System.Drawing.Point(202, 246);
            this.fixClassBtn.Name = "fixClassBtn";
            this.fixClassBtn.Size = new System.Drawing.Size(75, 51);
            this.fixClassBtn.TabIndex = 22;
            this.fixClassBtn.Text = "Sửa";
            this.fixClassBtn.UseVisualStyleBackColor = true;
            this.fixClassBtn.Click += new System.EventHandler(this.UpdateClassBtn1);
            // 
            // originClassName
            // 
            this.originClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originClassName.Location = new System.Drawing.Point(357, 12);
            this.originClassName.Name = "originClassName";
            this.originClassName.ReadOnly = true;
            this.originClassName.Size = new System.Drawing.Size(108, 20);
            this.originClassName.TabIndex = 15;
            // 
            // classDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.fixClassBtn);
            this.Controls.Add(this.classUpdateDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classUpdateCapitity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classUpdateFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.originClassName);
            this.Controls.Add(this.classUpdateName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "classDetail";
            this.Text = "classDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classUpdateDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classUpdateCapitity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classUpdateFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fixClassBtn;
        private System.Windows.Forms.TextBox originClassName;
    }
}