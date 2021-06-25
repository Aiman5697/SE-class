using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace MiniProject
{
    public class Student
    {
        public string id;
        public int matric;
        public string name;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public int MatricNo
        {
            get { return matric; }
            set { matric = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Student> initList()
        {
            List<Student> list = new List<Student>();
            List<string> dataLines = new db().Read.ToList();

            foreach(string x in dataLines)
            {
                string last = dataLines.Last();

                if (x.Equals(last))     //ignore last index element
                {
                    break;
                }

                string[] packs = x.Split(',');
                Student student = new Student();
                student.ID = packs[0];
                student.MatricNo = int.Parse(packs[1]);
                student.Name = packs[2];
                list.Add(student);
            };

            return list;
        }
    }

    public class db
    {
        public string[] Read
        {
            get
            {
                StreamReader sr = new StreamReader(@"db.txt");
                string olddata = sr.ReadToEnd();
                string[] oldDataLines = Regex.Split(olddata,Environment.NewLine);
                sr.Close();
                return oldDataLines;
            }
        }
    }
}
