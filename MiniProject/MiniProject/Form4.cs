using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniProject
{
    public partial class Form4 : Form
    {

        Student student = new Student();
        List<Student> students = new List<Student>();

        public Form4()
        {
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            students = student.initList();
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            try
            {
                string code = textBox1.Text.Substring(0, 3);
                int numid = int.Parse(textBox1.Text.Substring(3));

                if(code != "MCT" || textBox1.Text.Contains(" "))
                {
                    Exception ex = new Exception();
                    throw ex;
                }

                try
                {
                    Student removeStudent = students.Where(x => x.ID == textBox1.Text).Single();

                    students.RemoveAll(x => x.ID == removeStudent.ID);

                    File.WriteAllText(@"db.txt", String.Empty);
                    students.ForEach(x =>
                    {
                        string createText = x.ID + "," + x.MatricNo + "," + x.Name + Environment.NewLine;
                        File.AppendAllText(@"db.txt", createText);
                    });

                    MessageBox.Show("Successfully deleted user with ID " + textBox1.Text);
                    textBox1.Clear();
                }
                catch
                {
                    MessageBox.Show("No student is found.");
                }
                
            }
            catch
            {
                MessageBox.Show("Invalid input.");
            }

        }

        
    }
}
