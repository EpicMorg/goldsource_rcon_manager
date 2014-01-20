using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace goldsource_rcon_manager {
    internal class RCON {

        public byte[] prepareCommand(string command) {
            byte[] bufferTemp = Encoding.ASCII.GetBytes(command);
            byte[] bufferSend = new byte[bufferTemp.Length + 4];

            //intial 5 characters as per standard
            bufferSend[0] = byte.Parse("255");
            bufferSend[1] = byte.Parse("255");
            bufferSend[2] = byte.Parse("255");
            bufferSend[3] = byte.Parse("255");

            //copying bytes from challenge rcon to send buffer
            int j = 4;

            for (int i = 0; i < bufferTemp.Length; i++) {
                bufferSend[j++] = bufferTemp[i];
            }
            return bufferSend;
        }

        public string sendRCON(string serverIp, int serverPort, string rconPassword, string rconCommand) {
            UdpClient client = new UdpClient();
            client.Connect(serverIp, serverPort);

            //sending challenge command to server 
            string getChallenge = "challenge rcon\n";
            byte[] bufferSend = this.prepareCommand(getChallenge);

            //send challenge command and get response
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            client.Send(bufferSend, bufferSend.Length);
            byte[] bufferRec = client.Receive(ref RemoteIpEndPoint);

            //retrive number from challenge response 
            string challenge_rcon = Encoding.ASCII.GetString(bufferRec);
            challenge_rcon = string.Join(null, Regex.Split(challenge_rcon, "[^\\d]"));

            //preparing rcon command to send
            string command = "rcon \"" + challenge_rcon + "\" " + rconPassword + " " + rconCommand + "\n";
            bufferSend = this.prepareCommand(command);

            client.Send(bufferSend, bufferSend.Length);
            bufferRec = client.Receive(ref RemoteIpEndPoint);
            return Encoding.ASCII.GetString(bufferRec);
        }

    }
}
