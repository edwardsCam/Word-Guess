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

        public static Message EmptyMessage()
        {
            return new Message();
        }

        public void addArg(string a)
        {
            args.Add(a);
        }

        public void setType(string t)
        {
            type = t;
        }

        public string getType()
        {
            return type;
        }

        public string getArg(int i)
        {
            if (i < 0 || i >= args.Count)
                return string.Empty;
            return args[i];
        }

        public bool isType(string type)
        {
            return getType() == type;
        }
    }
}
