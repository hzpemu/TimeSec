using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace _05final_object
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		long alltime=0;		
		string nowtime="";
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		string pcid="";
		string run2="";
		string run3="";
		string run4="";
		string run5="";
		string run6="";
		string starton="";
		string dida="";
		string hmse="";
		string year="";
		string moth="";
		string dayy="";
		string hour="";
		string mite="";
		string djsj="";
        
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;		

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(104, 56);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(88, 21);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(184, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "�_ʼ";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(176, 152);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(32, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(16, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(72, 144);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�x��ģʽ";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(8, 88);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 32);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "��Ӌ";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(8, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 40);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "���r";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "��Ӌ�r�g��";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Location = new System.Drawing.Point(104, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(184, 48);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "��Ӌ�r���x��";
			// 
			// radioButton4
			// 
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(112, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(32, 16);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "��";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(16, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(32, 16);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.Text = "�r";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 8);
			this.label2.TabIndex = 6;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(200, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(24, 21);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(248, 56);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(24, 21);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(224, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "�r";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(272, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "��";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "�P춱�ܛ�w";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(104, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(224, 24);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "�����΄�������Ƿ��Ԅ��P�]����ʽ";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(104, 16);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(16, 16);
			this.checkBox2.TabIndex = 12;
			this.checkBox2.Text = "checkBox2";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(120, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(208, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "�_������ʽ�r�Ԅ��_ʼ�\��";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 32);
			this.button2.TabIndex = 14;
			this.button2.Text = "��������O��";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(328, 241);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "�r�g����С�ؕ�";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.radioButton1.Checked==true)
			{
				this.dateTimePicker1.Enabled=true;
					this.textBox1.Enabled=false;
				this.textBox2.Enabled=true;
				this.textBox3.Enabled=true;
			}
			else if(this.radioButton2.Checked==true)
			{
					this.dateTimePicker1.Enabled=false;
				this.textBox1.Enabled=true;
				this.textBox2.Enabled=false;
				this.textBox3.Enabled=false;
			}
		}

		void click()
		{
			try{this.textBox2.Text=int.Parse(this.textBox2.Text).ToString();}
			catch{}
			if(this.textBox3.Text.Length==1){this.textBox3.Text="0"+this.textBox3.Text;}
			if(this.radioButton1.Checked==true)
			{
				try
				{					
					//					this.label2.Text=this.dateTimePicker1.Value.ToString().Substring(0,10);//-
					//					this.label2.Text=this.label2.Text+"___"+System.DateTime.Now.ToString().Substring(0,16);
					this.timer1.Interval=500;
					this.timer1.Start();
					//this.timer1.			
					//					Process ps=new Process();
					//					ps.StartInfo.FileName=this.name2url;
					//					this.label1.Text =this.name2url;
					//					ps.Start();
				}
				catch
				{
					//this.label1.Text =this.name1url;
				}	
                                
			}
			else if(this.radioButton2.Checked==true)
			{
				try
				{
					if(this.radioButton3.Checked==true)
					{
						this.alltime=long.Parse(this.textBox1.Text)*60;
					}
					else if(this.radioButton4.Checked==true)
					{
						this.alltime=long.Parse(this.textBox1.Text);                    
					}					
					this.nowtime=System.DateTime.Now.Minute.ToString();		
					this.timer2.Interval=10000;
					this.timer2.Start();
				}
				catch{}
			}
			this.button1.Enabled=false;
			this.groupBox1.Enabled=false;
			this.groupBox2.Enabled=false;
			this.dateTimePicker1.Enabled=false;
			this.textBox2.Enabled=false;
			this.textBox3.Enabled=false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		click();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
//			this.label2.Text=this.dateTimePicker1.Value.ToString().Substring(0,10)+" "+this.textBox2.Text+":"+this.textBox3.Text+"==="+System.DateTime.Now.ToString().Substring(0,16);
//			if(this.dateTimePicker1.Value.ToString().Substring(0,10)+" "+this.textBox2.Text+":"+this.textBox3.Text==System.DateTime.Now.ToString().Substring(0,16))
//			{
//				this.timer1.Stop();
//				this.closeall();
//			}
//			else if(this.dateTimePicker1.Value.ToString().Substring(0,10)+" "+this.textBox2.Text+":"+this.textBox3.Text==System.DateTime.Now.ToString().Substring(0,15))
//			{
//				this.timer1.Stop();
//				this.closeall();
//			}
			this.label2.Text=this.dateTimePicker1.Value.Date.ToString()+"==="+System.DateTime.Now.Date.ToString();
            if(this.dateTimePicker1.Value.Date==System.DateTime.Now.Date)
			{
                this.label2.Text=this.label2.Text+"---";
				try
				{
					if(int.Parse(System.DateTime.Now.Hour.ToString()).ToString()==int.Parse(this.textBox2.Text).ToString())
					{
						this.label2.Text=this.label2.Text+"///"+System.DateTime.Now.Hour.ToString()+"||"+this.textBox2.Text;
						if(int.Parse(System.DateTime.Now.Minute.ToString()).ToString()==int.Parse(this.textBox3.Text).ToString())
						{
							this.label2.Text=this.label2.Text+"ok";
							this.timer1.Stop();
							this.closeall();
						}
						else{this.label2.Text=this.label2.Text+"no"+System.DateTime.Now.Minute.ToString()+"||"+this.textBox3.Text;}
					}
					else
					{
						this.label2.Text=this.label2.Text+"///"+System.DateTime.Now.Hour.ToString()+"||"+this.textBox2.Text;
					}
				}
				catch
				{
					this.timer1.Stop();
					MessageBox.Show("ݔ��ָ����С�r���犲����_��Ո�z��K�����������\�б���ʽ��","�oЧ����");
				}
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			this.label2.Text=this.alltime.ToString();
			
//			if(this.radioButton3.Checked==true)
//			{
//				if(this.nowtime.Substring(0,13)!=System.DateTime.Now.ToString().Substring(0,13))
//				{this.nowtime=System.DateTime.Now.ToString().Substring(0,16);this.alltime--;}
//			}
//			else if(this.radioButton4.Checked==true)
//			{
//				if(this.nowtime!=System.DateTime.Now.ToString().Substring(0,16))
//				{this.nowtime=System.DateTime.Now.ToString().Substring(0,16);this.alltime--;}			
//			}
			if(this.nowtime!=System.DateTime.Now.Minute.ToString())
			{
				this.nowtime=System.DateTime.Now.Minute.ToString();		
				this.alltime--;
			}
			if(this.alltime==0)
			{
				this.timer2.Stop();
                this.closeall();				
				//this.label2.Text="afgafgasdfg";				
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.textBox2.Text=System.DateTime.Now.Hour.ToString();
			this.textBox3.Text=System.DateTime.Now.Minute.ToString();

			try
			{
				string check;
				FileStream input=new FileStream(Directory.GetCurrentDirectory()+"\\"+"cfg.ini",FileMode.Open,FileAccess.Read);
				System.Text.Encoding en=System.Text.Encoding.Default;
				//				System.Text.Encoding en=System.Text.Encoding.GetEncoding("gb2312");
				StreamReader sr=new StreamReader(input,en);
				check=sr.ReadToEnd();
				int cpcid=check.IndexOf("run1=",0);
				int crun2=check.IndexOf("run2=",0);
				int crun3=check.IndexOf("run3=",0);
				int crun4=check.IndexOf("run4=",0);
				int crun5=check.IndexOf("run5=",0);
				int crun6=check.IndexOf("run6=",0);
				int starton=check.IndexOf("star=",0);
				int dida=check.IndexOf("dida=",0);
				int hmse=check.IndexOf("hmse=",0);
				int year=check.IndexOf("year=",0);
				int moth=check.IndexOf("moth=",0);
				int dayy=check.IndexOf("dayy=",0);
				int hour=check.IndexOf("hour=",0);
				int mite=check.IndexOf("mite=",0);
				int djsj=check.IndexOf("djsj=",0);
				
				try
				{
					if(check.Substring(cpcid+5,check.IndexOf(";",cpcid)-(cpcid+5)).Length<1){MessageBox.Show("run1���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.pcid=check.Substring(cpcid+5,check.IndexOf(";",cpcid)-(cpcid+5));}
				}
				catch{}	
				try
				{
					if(check.Substring(crun2+5,check.IndexOf(";",crun2)-(crun2+5)).Length<1){MessageBox.Show("run2���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.run2=check.Substring(crun2+5,check.IndexOf(";",crun2)-(crun2+5));}
				}
				catch{}
				try
				{
					if(check.Substring(crun3+5,check.IndexOf(";",crun3)-(crun3+5)).Length<1){MessageBox.Show("run3���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.run3=check.Substring(crun3+5,check.IndexOf(";",crun3)-(crun3+5));}
				}
				catch{}
				try
				{
					if(check.Substring(crun4+5,check.IndexOf(";",crun4)-(crun4+5)).Length<1){MessageBox.Show("run4���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.run4=check.Substring(crun4+5,check.IndexOf(";",crun4)-(crun4+5));}
				}
				catch{}
				try
				{
					if(check.Substring(crun5+5,check.IndexOf(";",crun5)-(crun5+5)).Length<1){MessageBox.Show("run5���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.run5=check.Substring(crun5+5,check.IndexOf(";",crun5)-(crun5+5));}
				}
				catch{}
				try
				{
					if(check.Substring(crun6+5,check.IndexOf(";",crun6)-(crun6+5)).Length<1){MessageBox.Show("run6���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.run6=check.Substring(crun6+5,check.IndexOf(";",crun6)-(crun6+5));}
				}
				catch{}
				try
				{
					if(check.Substring(starton+5,check.IndexOf(";",starton)-(starton+5)).Length<1){MessageBox.Show("star���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.starton=check.Substring(starton+5,check.IndexOf(";",starton)-(starton+5));}
				}
				catch{}
				try
				{
					if(check.Substring(dida+5,check.IndexOf(";",dida)-(dida+5)).Length<1){MessageBox.Show("dida���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.dida=check.Substring(dida+5,check.IndexOf(";",dida)-(dida+5));}
				}
				catch{}
				try
				{
					if(check.Substring(hmse+5,check.IndexOf(";",hmse)-(hmse+5)).Length<1){MessageBox.Show("hmse���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.hmse=check.Substring(hmse+5,check.IndexOf(";",hmse)-(hmse+5));}					
				}
				catch{}
				try
				{
					if(check.Substring(year+5,check.IndexOf(";",year)-(year+5)).Length<1){MessageBox.Show("year���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.year=check.Substring(year+5,check.IndexOf(";",year)-(year+5));}
				}
				catch{}
				try
				{
					if(check.Substring(moth+5,check.IndexOf(";",moth)-(moth+5)).Length<1){MessageBox.Show("moth���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.moth=check.Substring(moth+5,check.IndexOf(";",moth)-(moth+5));}
				}
				catch{}
				try
				{
					if(check.Substring(dayy+5,check.IndexOf(";",dayy)-(dayy+5)).Length<1){MessageBox.Show("dayy���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.dayy=check.Substring(dayy+5,check.IndexOf(";",dayy)-(dayy+5));}
				}
				catch{}
				try
				{
					if(check.Substring(hour+5,check.IndexOf(";",hour)-(hour+5)).Length<1){MessageBox.Show("hour���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.hour=check.Substring(hour+5,check.IndexOf(";",hour)-(hour+5));}
				}
				catch{}
				try
				{
					if(check.Substring(mite+5,check.IndexOf(";",mite)-(mite+5)).Length<1){MessageBox.Show("mite���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.mite=check.Substring(mite+5,check.IndexOf(";",mite)-(mite+5));}
				}
				catch{}
				try
				{
					string dt =this.year+"��"+this.moth+"��"+this.dayy+"��" + "00:00:00";
					this.dateTimePicker1.Value = DateTime.Parse(dt);
					this.textBox2.Text=this.hour;
					this.textBox3.Text=this.mite;					
				}
				catch{}
				try
				{
					if(check.Substring(djsj+5,check.IndexOf(";",djsj)-(djsj+5)).Length<1){MessageBox.Show("djsj���в����_��·�����ʽ�����_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");}
					else{this.djsj=check.Substring(djsj+5,check.IndexOf(";",djsj)-(djsj+5));}					
				}
				catch{}
			}
			catch
			{
				MessageBox.Show("�o�����_�B�ӣ��_�J�Ƿ���ЙnĿ��к���cfg.ini���_�J�Ƿ�ԓ�B����Ч�����_cfg.ini�鿴�Ƿ���Ч��","�oЧ����");
				//				MessageBox.Show("�޷������ӣ�ȷ���Ƿ�ִ���ļ�Ŀ¼�к���cfg.ini��ȷ���Ƿ��������Ч����cfg.ini�鿴�Ƿ���Ч��","��Ч����");
				//				try
				//				{
				
			}
			if(this.dida=="0")
			{
				this.radioButton1.Select();
			}
			else if(this.dida=="1")
			{
				this.radioButton2.Select();
				if(this.hmse=="0")
				{this.radioButton3.Select();}
				else if(this.hmse=="1")
				{this.radioButton4.Select();}
				this.textBox1.Text=this.djsj;
			}

			if(this.starton=="true")
			{
				this.checkBox2.Checked=true;
				this.click();
			}	
			
		}
		void closeall()
		{			
			try
			{			
				Process ps=new Process();
				ps.StartInfo.FileName=this.pcid;
				//this.label2.Text =this.pcid;
				ps.Start();
			}
			catch{}

			try
			{			
				Process ps2=new Process();
				ps2.StartInfo.FileName=this.run2;
				ps2.Start();
			}
			catch{}

			try
			{
				Process ps3=new Process();
				ps3.StartInfo.FileName=this.run3;
				ps3.Start();
			}
			catch{}
			try
			{
				Process ps4=new Process();
				ps4.StartInfo.FileName=this.run4;
				ps4.Start();
			}
			catch{}
			try
			{
				Process ps5=new Process();
				ps5.StartInfo.FileName=this.run5;
				ps5.Start();
			}
			catch{}
			try
			{
				Process ps6=new Process();
				ps6.StartInfo.FileName=this.run6;
				ps6.Start();	
			}
			catch{}
			if(this.checkBox1.Checked==true)
			{this.Close();}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Form2 a=new Form2();
			a.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		
		}
		
	}
}
