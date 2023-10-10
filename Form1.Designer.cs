namespace IT481_Unit3
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
			this.btn_Connect = new System.Windows.Forms.Button();
			this.btn_CustomerCount = new System.Windows.Forms.Button();
			this.btn_CustomerDetails = new System.Windows.Forms.Button();
			this.btn_OrderCount = new System.Windows.Forms.Button();
			this.btn_OrderDetails = new System.Windows.Forms.Button();
			this.btn_EmployeeCount = new System.Windows.Forms.Button();
			this.btn_EmployeeDetails = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Connect
			// 
			this.btn_Connect.Location = new System.Drawing.Point(324, 146);
			this.btn_Connect.Name = "btn_Connect";
			this.btn_Connect.Size = new System.Drawing.Size(144, 23);
			this.btn_Connect.TabIndex = 0;
			this.btn_Connect.Text = "Connect DB";
			this.btn_Connect.UseVisualStyleBackColor = true;
			this.btn_Connect.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_CustomerCount
			// 
			this.btn_CustomerCount.Location = new System.Drawing.Point(324, 192);
			this.btn_CustomerCount.Name = "btn_CustomerCount";
			this.btn_CustomerCount.Size = new System.Drawing.Size(144, 23);
			this.btn_CustomerCount.TabIndex = 1;
			this.btn_CustomerCount.Text = "Get Customer Count";
			this.btn_CustomerCount.UseVisualStyleBackColor = true;
			this.btn_CustomerCount.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_CustomerDetails
			// 
			this.btn_CustomerDetails.Location = new System.Drawing.Point(324, 242);
			this.btn_CustomerDetails.Name = "btn_CustomerDetails";
			this.btn_CustomerDetails.Size = new System.Drawing.Size(144, 23);
			this.btn_CustomerDetails.TabIndex = 2;
			this.btn_CustomerDetails.Text = "Get Customer Details";
			this.btn_CustomerDetails.UseVisualStyleBackColor = true;
			this.btn_CustomerDetails.Click += new System.EventHandler(this.button3_Click);
			// 
			// btn_OrderCount
			// 
			this.btn_OrderCount.Location = new System.Drawing.Point(324, 291);
			this.btn_OrderCount.Name = "btn_OrderCount";
			this.btn_OrderCount.Size = new System.Drawing.Size(144, 23);
			this.btn_OrderCount.TabIndex = 3;
			this.btn_OrderCount.Text = "Get Order Count";
			this.btn_OrderCount.UseVisualStyleBackColor = true;
			this.btn_OrderCount.Click += new System.EventHandler(this.button4_Click);
			// 
			// btn_OrderDetails
			// 
			this.btn_OrderDetails.Location = new System.Drawing.Point(324, 337);
			this.btn_OrderDetails.Name = "btn_OrderDetails";
			this.btn_OrderDetails.Size = new System.Drawing.Size(144, 23);
			this.btn_OrderDetails.TabIndex = 4;
			this.btn_OrderDetails.Text = "Get Order Ship Names";
			this.btn_OrderDetails.UseVisualStyleBackColor = true;
			this.btn_OrderDetails.Click += new System.EventHandler(this.button5_Click);
			// 
			// btn_EmployeeCount
			// 
			this.btn_EmployeeCount.Location = new System.Drawing.Point(621, 192);
			this.btn_EmployeeCount.Name = "btn_EmployeeCount";
			this.btn_EmployeeCount.Size = new System.Drawing.Size(144, 23);
			this.btn_EmployeeCount.TabIndex = 5;
			this.btn_EmployeeCount.Text = "Get Employee Count";
			this.btn_EmployeeCount.UseVisualStyleBackColor = true;
			this.btn_EmployeeCount.Click += new System.EventHandler(this.button6_Click);
			// 
			// btn_EmployeeDetails
			// 
			this.btn_EmployeeDetails.Location = new System.Drawing.Point(621, 239);
			this.btn_EmployeeDetails.Name = "btn_EmployeeDetails";
			this.btn_EmployeeDetails.Size = new System.Drawing.Size(144, 23);
			this.btn_EmployeeDetails.TabIndex = 6;
			this.btn_EmployeeDetails.Text = "Get Employee Names";
			this.btn_EmployeeDetails.UseVisualStyleBackColor = true;
			this.btn_EmployeeDetails.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(213, 156);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Connect";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Count Customer";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(213, 252);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Get Customers";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(213, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Order Count";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(213, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Order Ship Names";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(510, 202);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Employee Count";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(510, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Get Employee Names";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(213, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "User";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(213, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Password";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(213, 77);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "Server";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(213, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 13);
			this.label11.TabIndex = 17;
			this.label11.Text = "Database";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(324, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 20);
			this.textBox1.TabIndex = 18;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(324, 43);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 20);
			this.textBox2.TabIndex = 19;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(324, 70);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(144, 20);
			this.textBox3.TabIndex = 20;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(324, 108);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(144, 20);
			this.textBox4.TabIndex = 21;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_EmployeeDetails);
			this.Controls.Add(this.btn_EmployeeCount);
			this.Controls.Add(this.btn_OrderDetails);
			this.Controls.Add(this.btn_OrderCount);
			this.Controls.Add(this.btn_CustomerDetails);
			this.Controls.Add(this.btn_CustomerCount);
			this.Controls.Add(this.btn_Connect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Connect;
		private System.Windows.Forms.Button btn_CustomerCount;
		private System.Windows.Forms.Button btn_CustomerDetails;
		private System.Windows.Forms.Button btn_OrderCount;
		private System.Windows.Forms.Button btn_OrderDetails;
		private System.Windows.Forms.Button btn_EmployeeCount;
		private System.Windows.Forms.Button btn_EmployeeDetails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}

