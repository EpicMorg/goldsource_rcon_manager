using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace goldsource_rcon_manager {
    internal class Rcon {

        public byte[] PrepareCommand(string command) {
            var bufferTemp = Encoding.ASCII.GetBytes(command);
            var bufferSend = new byte[bufferTemp.Length + 4];

            //intial 5 characters as per standard  
            for (var i = 0; i < 4; i++) 
                bufferSend[i] = 255; 
            //copying bytes from challenge rcon to send buffer
            Array.Copy(bufferTemp,0,bufferSend,4,bufferTemp.Length); 
            return bufferSend;
        }

        public string SendRcon(string serverIp, int serverPort, string rconPassword, string rconCommand) {
            var client = new UdpClient();
            client.Connect(serverIp, serverPort);

            //sending challenge command to server 
            const string getChallenge = "challenge rcon\n";
            var bufferSend = this.PrepareCommand(getChallenge);

            //send challenge command and get response
            var remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            client.Send(bufferSend, bufferSend.Length);
            var bufferRec = client.Receive(ref remoteIpEndPoint);

            //retrive number from challenge response 
            var challengeRcon = Encoding.ASCII.GetString(bufferRec);
            challengeRcon = string.Join(null, Regex.Split(challengeRcon, "[^\\d]"));

            //preparing rcon command to send
            var command = "rcon \"" + challengeRcon + "\" " + rconPassword + " " + rconCommand + "\n";
            bufferSend = this.PrepareCommand(command);

            client.Send(bufferSend, bufferSend.Length);
            var sb = new StringBuilder();
            var messageresponse = client.Receive(ref remoteIpEndPoint);
            var offset = 5;
            bool next = false;
            while (messageresponse!=null) {
                var msrl = messageresponse.Length;
                var endoffset = 0;
                if (msrl > 1
                    && messageresponse[msrl - 1] == 0
                    && messageresponse[msrl - 2] == 0) {
                    endoffset = 2;
                    next = false;
                }
                else {
                    next = true; 
                }
                sb.Append(Encoding.ASCII.GetString(messageresponse, offset, msrl - offset - endoffset));
                messageresponse = next?client.Receive(ref remoteIpEndPoint):null;
                
            }
           
            // bufferRec = client.Receive(ref remoteIpEndPoint);
            // return Encoding.ASCII.GetString(bufferRec);
            return sb.ToString();
        }

    }
}
