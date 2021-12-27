using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Student
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (value.Trim().Length > 2)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Yeni ad sec");
                }
            }
        }
        public string surname { get; set; }
        public string fullname { get { return name + " " + surname; } }
        private string _email;
        public string email
        {
            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;

                }
                catch (Exception e)
                {

                    throw e;
                }

            }
        }


    }
}
