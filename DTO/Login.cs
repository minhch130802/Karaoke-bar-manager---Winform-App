using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Login
    {
        private bool _access;
        public bool access
        {
            get { return _access; }
            set { _access = value; }
        }

        public static bool _type;
        public bool type
        {
            get { return _type; }
            set { _type = value; }
        }

        public static String _name;
        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Login() { }

        public Login ( bool ac, bool ty, String name)
        {
            this.access = ac;
            this.type = ty;
            this.name = name;
        }
    }
}
