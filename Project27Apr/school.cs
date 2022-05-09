using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project27Apr
{
    public class School
    {
        public School(string sname, string tname, string sub)
        {
            this.Name = sname;
            this.Teacher = tname;
            this.Subject = sub;
            //ITTeam = new ITTeam();            
        }

        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Subject { get; set; }


        public void GetStudentDetails()
        {
            Console.WriteLine(this.Name + "    " + this.Teacher + "  " + this.Subject);
        }
    }
}
