using System;
using System.Collections.Generic;
using System.Text;

namespace Cameron_Edwards_Wordguess
{
    public static class MessageParser
    {
        public static Message parse(string input)
        {
            Message ret = new Message();

            string[] colonSplit = input.Split(':');
            if (colonSplit.Length == 1)
                return Message.EmptyMessage(); //no colon in message
            ret.setType(colonSplit[0]);

            string[] commaSplit = colonSplit[1].Split(',');
            foreach (string s in commaSplit)
                ret.addArg(s);

            return ret;
        }
    }
}
