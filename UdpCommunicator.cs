using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

/*
 * UdpCommunicator acts as both sender and receiver on a specific port
 * */

namespace Cameron_Edwards_Wordguess
{
    public class UdpCommunicator
    {
        private UdpClient client;
        private IPEndPoint server;
        private List<Message> sentMsgs, receivedMsgs;

        public UdpCommunicator()
        {
            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
            client = new UdpClient(localEP);
            sentMsgs = new List<Message>();
            receivedMsgs = new List<Message>();
        }

        public void addEndPoint(IPEndPoint p)
        {
            server = p;
        }

        public void send(string message)
        {
            if (server != null)
            {
                byte[] sendBuffer = Encoding.Unicode.GetBytes(message);
                int result = client.Send(sendBuffer, sendBuffer.Length, server);
                sentMsgs.Add(MessageParser.parse(message));
            }
        }

        public Message receive()
        {
            try
            {
                byte[] receiveBuffer = client.Receive(ref server);
                string response = Encoding.Unicode.GetString(receiveBuffer);
                Message msg = MessageParser.parse(response);
                receivedMsgs.Add(msg);
                return msg;
            }
            catch (Exception)
            {
                return Message.EmptyMessage();
            }
        }

        public Message getLatestResponse()
        {
            if (receivedMsgs.Count > 0)
                return receivedMsgs[receivedMsgs.Count - 1];
            return Message.EmptyMessage();
        }
    }
}
