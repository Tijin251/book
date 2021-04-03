/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01.04.2021
 * Time: 9:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace hz
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			string[] hren = File.ReadAllLines("temp.txt");
			int i = 0;
			
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter("temp.txt")) {
				while (i < hren.Length) {
					sw.WriteLine(hren[i]);
					i++;
				}
				
				sw.WriteLine(textBox1.Text);
			}
			
	        Form2 f2 = new Form2();
//            String s = textBox1.Text;
//            f2.listBox1.Items.Add(s);
            f2.Show();
            this.Hide(); 
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
	}
}
