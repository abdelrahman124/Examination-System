using lab_1_E_F.Models;
using ProjectExamination.Models;
using testd;

namespace ProjectExamination
{
    public partial class Form1 : Form
    {
        ExamnationSystemcontext context = new ExamnationSystemcontext();
        public string Uname { get; set; }
        public string U_password { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Uname = textBox1.Text;
            U_password = textBox2.Text;

            List<string> lname = context.logins.Select(e => e.Lname).ToList();
            List<string> lpassword = context.logins.Select(e => e.LPassword).ToList();


            bool isValid = false; // Flag to check if login is valid

            for (int i = 0; i < lname.Count; i++)
            {
                if (lname[i] == Uname && lpassword[i] == U_password)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                MessageBox.Show("Login Successfully");
                Form2 form2 = new Form2(Uname);
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid data");
            }





            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
