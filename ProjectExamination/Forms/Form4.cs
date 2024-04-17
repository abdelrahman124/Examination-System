using lab_1_E_F.Models;
using Microsoft.EntityFrameworkCore;
using ProjectExamination.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using testd;

namespace ProjectExamination.Forms
{
    public partial class Form4 : Form
    {
        ExamnationSystemcontext context4 = new ExamnationSystemcontext();
        int _gradein;
        int _studeIdin;
        int _SubIdin;
        string StudentName;

       
        public Form4(int _grade, int _studentId, int _sub, string _NameOfSubject)
        {

            _gradein = _grade;
            _studeIdin = _studentId;
            _SubIdin = _sub;
           



            InitializeComponent();
            label1.Text = _gradein.ToString();

             StudentName = context4.Students.Where(s => s.StudentsId == _studentId).Select(l => l.StudenName)
                                                     .FirstOrDefault();
            label4.Text = StudentName;
            label2.Text = _NameOfSubject;
            



        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StudentSubject newRecord = new StudentSubject
            {
                // Set properties of the entity
                subjectId = _SubIdin,
                studentId = _studeIdin,
                Grade = _gradein
            };

            context4.StudentSubject.Add(newRecord);

            // Submit the changes to the database
            context4.SaveChanges();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string logName = context4.logins.Where(e => e.StudentsId == _studeIdin).Select(e => e.Lname).FirstOrDefault();

            Form2 form2 = new Form2(logName);
            form2.Show();
            this.Hide();

        }
    }
}
