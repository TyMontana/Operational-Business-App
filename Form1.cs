using IT481_Unit3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit3
{
	public partial class Form1 : Form
	{ 
		DB database;
		private string user;
		private string password;
		private string server;
		private string databaseName;
		public Form1()
		{
			InitializeComponent();
			textBox3.Text = "DESKTOP-MU6NSQU\\SQLEXPRESS";
			textBox4.Text = "Northwind";
			btn_Connect.Click += new EventHandler(button1_Click);
			btn_CustomerCount.Click += new EventHandler(button2_Click);
			btn_CustomerDetails.Click += new EventHandler(button3_Click);
			btn_OrderCount.Click += new EventHandler(button4_Click);
			btn_OrderDetails.Click += new EventHandler(button5_Click);
			btn_EmployeeCount.Click += new EventHandler(button6_Click);
			btn_EmployeeDetails.Click += new EventHandler(button7_Click);
		}
			private void button1_Click(object sender, EventArgs e)
		{
			bool isValid = true;
			user = textBox1.Text;
			password = textBox2.Text;
			server = textBox3.Text;
			databaseName = textBox4.Text;

			if (user.Length == 0 || password.Length == 0 ||
			  server.Length == 0 || databaseName.Length == 0)
			{
				isValid = false;
				MessageBox.Show("You must enter user name, password, server, and database values");
			}
			else if (password.Length < 12)
			{
				isValid = false;
				MessageBox.Show("Password length must be 12 characters or more");
			}
			else
			{
				if (password.All(char.IsLetterOrDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)))
				{
					isValid = false;
					MessageBox.Show("You must enter alphanumeric and special characters for the password");
				}
			}
			if (isValid)
			{
				 database = new DB("Server = DESKTOP - MU6NSQU\\SQLEXPRESS;" +
							  "Trusted_Connection=true;" +	  
							  "Database= " + databaseName + ";" +
							  "User ID = " + user + ";" +
							  "Password = " + password + ";");
				MessageBox.Show("Connection information sent");
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string count = database.getCustomerCount();
			MessageBox.Show(count, "Customer count");
			
		}
		private void button3_Click(object sender, EventArgs e)
		{
			string customerid = database.getCustomerID();
			MessageBox.Show(customerid, "CustomerID");
			string names = database.getCompanyNames();
			MessageBox.Show(names, "CompanyName");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string count = database.getOrderCount();
			MessageBox.Show(count, "Order count");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string count = database.getEmployeeCount();
			MessageBox.Show(count, "Employee count");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string names = database.getEmployeeLastName();
			MessageBox.Show(names, "EmployeeName");
		}
		private void button5_Click(object sender, EventArgs e)
		{
			string orderid = database.getOrder();
			MessageBox.Show(orderid, "OrderID");
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
		private void label5_Click(object sender, EventArgs e)
		{

		}
		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
