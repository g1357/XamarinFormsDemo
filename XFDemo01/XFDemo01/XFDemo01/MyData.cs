using System;
using System.Collections.Generic;
using System.Text;
namespace XFDemo01
{
    public class MyData
    {
        public string MyName { get; set; }

        private string myLastname = "Моя Фамилия";
        public string MyLastname {
            get
            {
                return myLastname;
            }
            set
            {
                myLastname = value;
                
            }
        }
    }
}
