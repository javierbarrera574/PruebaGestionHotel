namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;

            Control[] controls = this.Controls.Find(labelName, true);
            if (controls.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;


            Control[] controls = this.Controls.Find(labelName, true);
            if (controls.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.Orange;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;


            Control[] controls = this.Controls.Find(labelName, true);
            if (controls.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.Black;
            }
        }
    }
}