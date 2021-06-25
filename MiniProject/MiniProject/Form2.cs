using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form2 : Form
    {
        
        Student student = new Student();
        List<Student> students = new List<Student>();
        int numid = 0;

        public bool IsEmpty<T>(List<T> list)
        {
            if (list == null)
            {
                return true;
            }

            return !list.Any();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            students = student.initList();

            bool isEmpty = IsEmpty(students);

            if(!isEmpty)
            {
                Student latest = students.Last();
                numid = int.Parse(latest.ID.Substring(3));
            }

            textBox1.Text = "MCT" + ++numid;
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
            if(string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter the value.");
                return;
            }

            try
            {
                student.ID = textBox1.Text;
                student.MatricNo = int.Parse(textBox2.Text);
                student.Name = textBox3.Text;

                students.Add(student);
                
                string createText = student.ID + "," + student.MatricNo + "," + student.Name + Environment.NewLine;
                File.AppendAllText(@"db.txt", createText);                

                MessageBox.Show("Successfully added user " + student.Name + " with ID " + student.ID);
                textBox1.Text = "MCT" + ++numid;

            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }

            
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;

        }

        
    }
}
