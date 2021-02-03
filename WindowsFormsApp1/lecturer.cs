using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class lecturer
    {
        public string _name;
        public string _idnumber;
        public string _password;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Idnumber
        {
            get
            {
                return _idnumber;
            }
            set
            {
                _idnumber = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public lecturer(string name, string idnumber, string password)
        {
            _name = name;
            _idnumber = idnumber;
            _password = password;
        }
    }
}
