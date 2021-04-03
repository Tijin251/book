/*
 * Created by SharpDevelop.
 * User: Porter
 * Date: 29.03.2021
 * Time: 22:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace hz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
	      Form2 hz2 = new Form2(); 
            
            hz2.ShowDialog();
		}
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = "Свое начало МУ «ЦБС г. Белово» берет с открытия в 1941 г. городской библиотеки № 1, штат которой составлял 3 человека. В настоящее время в ЦБС трудятся 60 библиотечных работников. С 2002 года МУ «ЦБС г. Белово» является юридическим лицом. В 2005 году к ней присоединено муниципальное учреждение «Централизованная детская библиотечная система г. Белово». МУ «ЦБС г. Белово» включает в себя Центральную городскую библиотеку, Центральную детскую библиотеку и 12 библиотек - структурных подразделений. В ЦБС функционируют специализированные библиотеки: Библиотека - Центр по проблемам детства и юношества, Библиотека – центр современного чтения, Библиотека семейного чтения «Инская», Библиотека- информационный Центр по вопросам культуры. Одна библиотека именная – Библиотека «Новогородская» им. А.И. Курицына.";
			
			textBox1.TextAlign = HorizontalAlignment.Center;
		}
		void Button4Click(object sender, EventArgs e)
		{
			textBox1.Text = "Учредитель: Управление культуры Администрации Беловского городского округа Юридический адрес:652600 Кемеровская область - Кузбасс, г. Белово, ул. Ленина, 15. Руководитель:Начальник управления - Широкова Ольга Александровна. Телефоны: Приёмная: (38452) 2-40-20. Заместители: (38452) 2-44-82. Методический отдел: (38452) 2-38-57. Ссылки:e-mail: kgbelovo@mail.ru. сайт: http://uk-belovo.kmr.muzkult.ru. Юридический и фактический адрес МУ ЦБС г. Белово: 652600, Кемеровская область - Кузбасс, г. Белово, ул. Юности, 20, помещение 26. Контактные телефоны: (38452) 2-19-72 (директор); 2-64-03 (инновационно-методический  отдел, отдел комплектования и обработки литературы); 2-60-42 (информационно-библиографический отдел, отдел обслуживания, центр правовой информации). Адрес сайта: http://belovo-lib.kmr.muzkult.ru/about/. E-mail: belovo.cgb@mail.ru. Режим работы: Понедельник – пятница 10.00 - 19.00, Воскресенье 10.00 - 16.00, Суббота – выходной день, Последний четверг месяца – санитарный день";
			
			textBox1.TextAlign = HorizontalAlignment.Center;
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form1 hz = new Form1(); 
            
            hz.ShowDialog(); 
		}
	}
}
