using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace _05final_object
{
	/// <summary>
	/// Form2 ��ժҪ˵����
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkOrange;
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(40, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 144);
			this.label1.TabIndex = 0;
			this.label1.Text = "��ܛ�w�lչĿ�Ğ�M��һЩ��Ҫ���^�`��Ķ��r���г�ʽ���Ñ����c�F�е�����ͬ�ܛ�w��ȸ����`���ͨ�^cfg.ini�O���Pbat���и��N��Ĳ�����������Ҫ���M���" +
				"�Ľ��h���gӭ�o���]��J-HZP@21CN.COM��HZPEMU@hotmail.com                 ��������δ���S�ɲ��Ì���ܛ�w�M�з����g" +
				"���ƽ⣬��t׷���䷨��؟�Σ�������������������HZPsoft 2006 Ver1.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(336, 269);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "�P춱�ܛ�w";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
