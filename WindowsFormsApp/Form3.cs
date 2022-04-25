using System;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Build();
        }
        private void Build()
        {
            if (StaticClass.cheak)
                Survey.Save(StaticClass.sur[StaticClass.index]);
            label1.Text += StaticClass.sur[StaticClass.index].Name + "\"";
            for (int i = 0; i < StaticClass.answers.Length; ++i)
                dataGridView1.Rows.Add(i+1, StaticClass.answers[i]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var th = new Thread(Back);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Back(object obj){Application.Run(new Form1());}
    }
}