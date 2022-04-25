using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(){InitializeComponent();}
        public string GetAnswer{get{return textBox2.Text+comboBox1.Text;}}
        public void Respect(){textBox2.BackColor = Color.White;}
        public void Error(){textBox2.BackColor = Color.Tomato;}
        public void Build(Question quest, int id)
        {
            textBox1.Text = id + ") " + quest.Text;
            if(quest.Type == 0 || quest.Type == 2)
            {
                textBox2.Enabled = true;
                textBox2.Visible = true;
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox1.Visible = true;
                comboBox1.DataSource = quest.OnlyOptions();
            }
        }
    }
}