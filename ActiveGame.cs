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
            id = response.getArg(0);
        }

        public Message askForHint()
        {
            if (!string.IsNullOrEmpty(id)) //ensure the game is active
            {
                string message = "gethint:" + id;
                socket.send(message);

                Message response = socket.receive();
                if (response.getArg(0) == id)
                    return response;
            }
            return Message.EmptyMessage();
        }

        public Message sendGuess(string guess)
        {
            if (!string.IsNullOrEmpty(id)) //ensure the game is active
            {
                string message = "guess:" + id + "," + guess;
                socket.send(message);
                Message response = socket.receive();
                if (response.getArg(0) == id)
                    return response;
            }
            return Message.EmptyMessage();
        }

        public Message getLatestResponse()
        {
            return socket.getLatestResponse();
        }

        public void sendExit()
        {
            string message = "exit:" + id;
            socket.send(message);
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
