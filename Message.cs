using System;
using System.Collections.Generic;
using System.Text;

namespace Cameron_Edwards_Wordguess
{
    public class Message
    {
        private string type;
        private List<string> args;

        public Message()
        {
            type = string.Empty;
            args = new List<string>();
        }

        public void setType(string t)
        {
            type = t;
        }

        public void addArg(string a)
        {
            args.Add(a);
        }

        public string getType()
        {
            return type;
        }

        public string getArg(int i)
        {
            return args[i];
        }
    }
}
