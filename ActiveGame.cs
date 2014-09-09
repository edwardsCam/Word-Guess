using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace Cameron_Edwards_Wordguess
{
    public class ActiveGame
    {
        private UdpCommunicator socket;
        private string id;

        public ActiveGame(string serv_ip, string serv_port)
        {
            socket = new UdpCommunicator();

            IPAddress addr = EndPointParser.ParseAddress(serv_ip);
            int port = EndPointParser.ParsePort(serv_port);
            IPEndPoint server = new IPEndPoint(addr, port);
            socket.addEndPoint(server);

            startGame();
        }

        private void startGame()
        {
            socket.send(startString());
            Message response = socket.receive();
            if (response != null)
                id = response.getArg(0);
        }

        public Message askForHint()
        {
            if (id != null)
            {
                string message = "gethint:" + id;
                socket.send(message);

                Message response = socket.receive();
                if (response.getArg(0) == id)
                    return response;
            }
            return null;
        }

        public Message sendGuess(string guess)
        {
            if (id != null)
            {
                string message = "guess:" + id + "," + guess;
                socket.send(message);
                Message response = socket.receive();
                if (response != null && response.getArg(0) == id)
                    return response;
            }
            return null;
        }

        public Message getLatestResponse()
        {
            return socket.getLatestResponse();
        }

        public static string startString()
        {
            string anum = "A01982846";
            string first = "Cameron";
            string last = "Edwards";
            return "newgame:" + anum + "," + last + "," + first;
        }
    }
}
