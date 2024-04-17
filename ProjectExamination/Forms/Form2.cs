using lab_1_E_F.Models;
using ProjectExamination;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testd
{
    public partial class Form2 : Form
    {
        ExamnationSystemcontext context2 = new ExamnationSystemcontext();
        int logstudId;
        public Form2(string uname)
        {

            InitializeComponent();
            //var test = context2.logins.Where(e => e.StudentsId == ).Select(e => e.StudentsId).ToList();

            logstudId = context2.logins.FirstOrDefault(e => e.Lname== uname)
                                                          .StudentsId;


            List<int> ListSubId = context2.StudentSubject.Where(e => e.studentId == logstudId)
                .Select(e => e.subjectId).ToList();


            string[] edd = new string[ListSubId.Count];
            for (int i = 0; i < ListSubId.Count; i++)
            {
                edd[i] = context2.Subjects.Where(e => e.SubjectsId == ListSubId[i])
                                           .Select(e => e.Subname)
                                           .FirstOrDefault(); // Change from ToList() to FirstOrDefault()
            }

            var AllSubjects = context2.Subjects.Select(e => e.Subname).ToList();


            int[] edd2 = new int[ListSubId.Count];

            for (int i = 0; i < ListSubId.Count; i++)
            {
                edd2[i] = context2.StudentSubject.Where(e => e.subjectId == ListSubId[i])
                                           .Select(e => e.Grade)
                                           .FirstOrDefault(); // Change from ToList() to FirstOrDefault()
            }


            for (int i = 0; i < AllSubjects.Count; i++)
            {
                comboBox1.Items.Add(AllSubjects[i]);

            }


            User_lbl.Text = $"Hello {uname}\n Your Grade in The Subjects you examed is :  ";
            for (int i = 0; i < edd.Length; i++)
            {

                label1.Text += $"  \n {edd[i]} = {edd2[i]} \n  ";
                comboBox1.Items.Remove(edd[i]);
            }

            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                // Subscribe to the SelectedIndexChanged event
                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                comboBox1.SelectedIndex = 0;

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (comboBox1.Items.Count > 0)
            {
                Form3 form3 = new Form3(NameToForm3, GetSubjIdbyName, GetStudIdbySubjId);
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You Finsh All Exams");
            }

        }
        string NameToForm3;
        int GetSubjIdbyName;
        int GetStudIdbySubjId;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected item: " + comboBox1.SelectedItem.ToString());
            var valueNameFromComboBox = comboBox1.SelectedItem;
            NameToForm3 = valueNameFromComboBox as string;
            GetSubjIdbyName = context2.Subjects.Where(e => e.Subname == NameToForm3)
                                             .Select(e => e.SubjectsId).FirstOrDefault();
            //GetStudIdbySubjId = context2.StudentSubject.Where(e => e.subjectId == GetSubjIdbyName)
            GetStudIdbySubjId = logstudId;                             //.Select(e => e.studentId).FirstOrDefault();

        }

        private void User_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
