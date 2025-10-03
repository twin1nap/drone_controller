using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tello_library
{
    public class tello_controler
    {
        // the udp is the object that is bassically the connection
        public UdpClient UDP = new UdpClient(8889);
        //the endpoint where commands need to go
        public IPEndPoint drone_endpoint = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);

        //string command = "command"; // Tello needs this first to enter SDK mode

        // Send a command to the drone and get the response
        public async Task<string> SendCommandAsync(string command)
        {
            // The command we want to send (text string)
            byte[] commandBytes = Encoding.UTF8.GetBytes(command);

            await UDP.SendAsync(commandBytes, commandBytes.Length, drone_endpoint);
            Console.WriteLine($"Sent: {command}");

            // Wait for the drone's response
            var response = await UDP.ReceiveAsync();
            string reply = Encoding.UTF8.GetString(response.Buffer);
            Console.WriteLine($"Received: {reply}");
            return reply;

        }
    }
}
