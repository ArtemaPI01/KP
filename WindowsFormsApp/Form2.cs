using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Build();
        }
        private Dictionary<int, UserControl1> dynamicTextboxes = new Dictionary<int, UserControl1>();
        private void Build()
        {
            label1.Text = StaticClass.sur[StaticClass.index].Name;
            for (int i = 0; i < StaticClass.quest.Length;i++)
            {
                var pn = new UserControl1();
                pn.Build(StaticClass.quest[i], i+1);
                flowLayoutPanel1.Controls.Add(pn);
                dynamicTextboxes[i] = pn;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var th = new Thread(Back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Back(object obj){Application.Run(new Form1());}
        private void button2_Click(object sender, EventArgs e)
        {
            StaticClass.answers = new string[StaticClass.quest.Length];
            int x = 0;
            for (int i = 0; i < StaticClass.quest.Length; i++)
            {

                if (StaticClass.quest[i].Enter(dynamicTextboxes[i].GetAnswer))
                {
                    dynamicTextboxes[i].Respect();
                    if (x == 0)
                        StaticClass.answers[i] = dynamicTextboxes[i].GetAnswer;
                }
                else
                {
                    x = 1;
                    dynamicTextboxes[i].Error();
                }
            }
            if (x == 0)
            {
                Close();
                var th = new Thread(Next);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void Next(object obj){Application.Run(new Form3());}
    }
}