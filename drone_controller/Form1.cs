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
        tello_controler controler = new tello_controler();
        public Form1()
        {
            InitializeComponent();
            start_connection(controler);
        }

    static async Task start_connection(tello_controler controler)
    {
            

            // Enter SDK mode
            await controler.SendCommandAsync("command");
            await controler.SendCommandAsync("battery?");

        }

        //private async Task Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.W)
        //    {
        //        await controler.SendCommandAsync("foward 20");
        //    }
        //    else if (e.KeyCode == Keys.S)
        //    {
        //        await controler.SendCommandAsync("back 20");
        //    }

        //}

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                await controler.SendCommandAsync("forward 50");
            }
            else if (e.KeyCode == Keys.S)
            {
                await controler.SendCommandAsync("back 50");
            }
            else if (e.KeyCode == Keys.A)
            {
                await controler.SendCommandAsync("left 50");
            }
            else if (e.KeyCode == Keys.D)
            {
                await controler.SendCommandAsync("right 50");
            }
            else if (e.KeyCode == Keys.Up)
            {
                await controler.SendCommandAsync("flip f");
            }
            else if (e.KeyCode == Keys.T)
            {
                await controler.SendCommandAsync("flip b");
            }
        }

        private async void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString().Contains("cw"))
            {
                await controler.SendCommandAsync($"{btn.Tag} {num_angle.Value}");
            }
            else
            {
                await controler.SendCommandAsync($"{btn.Tag} {num_distance.Value}");

            }


        }

        bool fly = false;
        private async void button9_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(await controler.SendCommandAsync("time?"));
            //int time = int.Parse((await controler.SendCommandAsync("time?")).Replace("s", ""));
            if (fly == true) //als het langer vliegt dan 0 seconden
            { 
                await controler.SendCommandAsync($"land");
                fly = false;
            }
            else
            {
                await controler.SendCommandAsync($"takeoff");
                fly = true;
            }
            
        }

        private async void trackBar_speed_Scroll(object sender, EventArgs e)
        {
            lbl_speed.Text = trackBar_speed.Value.ToString();
            await controler.SendCommandAsync($"speed {trackBar_speed.Value}");

        }
    }
}
