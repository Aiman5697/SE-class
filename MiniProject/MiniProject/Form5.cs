using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form5 : Form
    {

        Student student = new Student();
        List<Student> students = new List<Student>();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            students = student.initList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageText = "Found:\n\n";
            try
            {
                if (textBox1.Text.All(char.IsWhiteSpace))
                {
                    Exception ex = new Exception();
                    throw ex;
                }

                List<string> names = new List<string>(); 
                
                students.ForEach(x =>
                {
                    bool found = x.Name.Contains(textBox1.Text);

                    names.Add(x.Name);

                    if (found)
                    {
                        string newText = String.Format("Matric No: {0} Name: {1} \n", x.MatricNo, x.Name);
                        messageText = messageText + newText;
                    }
                });

                IEnumerable<string> str = names;

                bool result = str.Any(x => x.Contains(textBox1.Text));
                
                if(!result)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                MessageBox.Show(messageText);
            }
            catch
            {
                MessageBox.Show("Invalid input.");
            }
        }

    }
}
