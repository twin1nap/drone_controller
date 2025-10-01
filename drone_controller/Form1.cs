using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tello_library;

namespace drone_controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start_connection();
        }

    static async Task start_connection()
        {
             var controller = new tello_controler();

            // Enter SDK mode
            await controller.SendCommandAsync("command");

            // Example: take off
            //await controller.SendCommandAsync("takeoff");
        }
    }
}
