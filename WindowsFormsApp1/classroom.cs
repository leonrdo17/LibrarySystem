using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class classroom
    {
        public string _block;
        public string _typeofclass;
        public string _classname; 

        public string Block
        {
            get
            {
                return _block;
            }
            set
            {
                _block = value;
            }
        }

        public string Typeofclass
        {
            get
            {
                return _typeofclass;
            }
            set
            {
                _typeofclass = value;
            }
        }
        public string Classname
        {
            get
            {
                return _classname;
            }
            set
            {
                _classname = value;
            }
        }
        public classroom(string block, string typeofclass, string classname)
        {
            _block = block;
            _typeofclass = typeofclass;
            _classname = classname;
        }
    }
}
