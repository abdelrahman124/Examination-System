using lab_1_E_F.Models;
using Microsoft.EntityFrameworkCore;
using ProjectExamination.Forms;
using ProjectExamination.Migrations;
using ProjectExamination.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace testd
{
    public partial class Form3 : Form
    {
        ExamnationSystemcontext contect3 = new ExamnationSystemcontext();
        int subId;
        int studId;
        string nameSubject;
        int finalGrade = 0;
        List<int> modelans = new List<int>();

        public Form3(string _NameToForm3ByFrom2, int _subIdByName, int _studIdBysub)
        {

            InitializeComponent();

            subId = _subIdByName;
            nameSubject = _NameToForm3ByFrom2;
            studId = _studIdBysub;

            label12.Text = _NameToForm3ByFrom2;
            label11.Text = (string)contect3.Exams.Where(e => e.Subjectid == _subIdByName).Select(e => e.QuestionNum).FirstOrDefault().ToString();

            int examid = contect3.Exams.Where(s => s.Subjectid == _subIdByName)
                                              .Select(e => e.Examsid).FirstOrDefault();



            
                  var AllQuestions2 = (from row in contect3.Questions
                              select new
                              {
                                  Column1QBODY = row.Qbody,
                                  Column2ModelAnser = row.Model_Answer,
                                  Column3Mark = row.Mark,
                                  Column4QuestionsId = row.QuestionsId,
                                  Column5Examsid = row.Examsid

                              }).Where(e => e.Column5Examsid == examid).OrderBy(w => Guid.NewGuid()).ToList();


            for (int i = 0; i < 5; i++)
            {

                modelans.Add(AllQuestions2[i].Column2ModelAnser);
            }

            //= contect3.Questions.Where(w => w.Examsid == examid)
            //                      .OrderBy(w => Guid.NewGuid()).Select(e => e.Qbody).ToList();



            //var AllQuestions = contect3.Questions.Where(w => w.Examsid == examid)
            //                      .OrderBy(w => Guid.NewGuid()).ToList();

            //var AllQuestionsDataguideWithGuide = AllQuestionsDataguideWithGuide.Select(e => e.Qbody).ToList();



            Q1.Text = AllQuestions2[0].Column1QBODY;
            Q2.Text = AllQuestions2[1].Column1QBODY;
            Q3.Text = AllQuestions2[2].Column1QBODY;
            Q4.Text = AllQuestions2[3].Column1QBODY;
            Q5.Text = AllQuestions2[4].Column1QBODY;

            //List<int> modelAnswer = AllQuestionsDataguideWithGuide.Select(e => e.Model_Answer).ToList();



        }


        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region dd


            List<int> userAnswerList = new List<int>();

            #region for  group box 1 
            if (radioButton1.Checked)
            {
                // Code to handle when radioButton1 is selected
                userAnswerList.Add(1);
            }
            else if (radioButton2.Checked)
            {
                // Code to handle when radioButton2 is selected
                userAnswerList.Add(0);
            }
            #endregion

            #region for  group box  2
            if (radioButton3.Checked)
            {
                // Code to handle when radioButton1 is selected
                userAnswerList.Add(1);
            }
            else if (radioButton4.Checked)
            {
                // Code to handle when radioButton2 is selected
                userAnswerList.Add(0);

            }
            #endregion

            #region for  group box 3
            if (radioButton5.Checked)
            {
                // Code to handle when radioButton1 is selected
                userAnswerList.Add(1);
            }
            else if (radioButton6.Checked)
            {
                // Code to handle when radioButton2 is selected
                userAnswerList.Add(0);

            }
            #endregion

            #region for  group box 4
            if (radioButton7.Checked)
            {
                // Code to handle when radioButton1 is selected
                userAnswerList.Add(1);
            }
            else if (radioButton8.Checked)
            {
                // Code to handle when radioButton2 is selected
                userAnswerList.Add(0);

            }
            #endregion

            #region for  group box 5

            if (radioButton9.Checked)
            {
                // Code to handle when radioButton1 is selected
                userAnswerList.Add(1);
            }
            else if (radioButton10.Checked)
            {
                // Code to handle when radioButton2 is selected
                userAnswerList.Add(0);

            }
            #endregion

            if(userAnswerList.Count  ==  5) 
            {


                for (int i = 0; i < userAnswerList.Count; i++)
                {

                    if (userAnswerList[i] == modelans[i])
                    {
                        finalGrade += 10;
                    }
                }
                #endregion
                Form4 form4 = new Form4(finalGrade, studId, subId, nameSubject);
                form4.Show();
                this.Hide();
            }

          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
