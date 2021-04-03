/*
 * Created by SharpDevelop.
 * User: User
 * Date: 01.04.2021
 * Time: 10:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace hz
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		string[] hren;
		
		string itemToDelete = "";
		
		public Form2()
		{
			InitializeComponent();
			
			int i = 0;
			
			hren = File.ReadAllLines("temp.txt");
			
			while (i < hren.Length) {
				listBox1.Items.Add(hren[i]);
				i++;
			}
			
		}
		public void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			itemToDelete = Convert.ToString(listBox1.SelectedItem);
		}
		
		void Form2FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
			string[] hren2 = File.ReadAllLines("temp.txt");
			
			int i = 0;
			
			while (i < hren.Length) {
				if (hren2[i] == itemToDelete) {
					hren2[i] = "";
				}
				i++;
			}
			
			i = 0;
			
			using (System.IO.StreamWriter sw = new System.IO.StreamWriter("temp.txt")) {
				while (i < hren2.Length) {
					if (hren2[i] != "") {
						sw.WriteLine(hren2[i]);
					}
					i++;
				}
			}
		}
		
	}
}
