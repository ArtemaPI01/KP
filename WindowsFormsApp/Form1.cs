using System;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Build();
        }
        private void Build(){comboBox1.DataSource = StaticClass.sur;}
        private void button1_Click(object sender, EventArgs e){Close();}
        private void button2_Click(object sender, EventArgs e)
        {
            StaticClass.index = comboBox1.SelectedIndex;
            StaticClass.quest = Question.ChoiceSurvey(StaticClass.sur[comboBox1.SelectedIndex]);
            StaticClass.cheak = checkBox1.Checked;
            Close();
            var th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj){Application.Run(new Form2());}
    }
}