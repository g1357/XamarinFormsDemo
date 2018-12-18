using System;
using System.Collections.Generic;
using System.Text;
using XFDemo01.Helpers;

namespace XFDemo01
{
    public class MyData : Observable
    {
        public string MyName { get; set; }

        private string myLastname = "Моя Фамилия";
        public string MyLastname {
            get { return myLastname; }
            set { Set(ref myLastname, value); }
        }
    }
}
