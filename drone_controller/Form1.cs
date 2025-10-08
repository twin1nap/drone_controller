using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tello_library;

namespace drone_controller
{
    public partial class drone_controller : Form
    {
        tello_controler controler = new tello_controler();
        public drone_controller()
        {
            InitializeComponent();
            start_connection(controler);
        }


        static async Task start_connection(tello_controler controler)
        {

            // Enter SDK mode
            await controler.SendCommandAsync("command"); //add connection check
            await controler.SendCommandAsync("battery?");

        }


        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TabPage selected_tab = tabControl.SelectedTab;
            Button btn = null;
            // tabControl.SelectedTab
            if (e.KeyCode == Keys.W)
            {
                //await controler.SendCommandAsync("forward 50");
                btn = selected_tab.Controls["button_forward"] as Button;
                //button_Click(selected_tab.Controls["button_forward"], EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.S)
            {
                btn = selected_tab.Controls["button_back"] as Button;
            }
            else if (e.KeyCode == Keys.A)
            {
                btn = selected_tab.Controls["button_left"] as Button;
            }
            else if (e.KeyCode == Keys.D)
            {
                btn = selected_tab.Controls["button_right"] as Button;
            }
            else if (e.KeyCode == Keys.Up)
            {
                btn = selected_tab.Controls["button_up"] as Button;
            }
            else if (e.KeyCode == Keys.Down)
            {
                btn = selected_tab.Controls["button_down"] as Button;
            }
            else if (e.KeyCode == Keys.Left)
            {
                btn = selected_tab.Controls["button_left"] as Button;
            }
            else if (e.KeyCode == Keys.Right)
            {
                btn = selected_tab.Controls["button_right"] as Button;
            }
            else if (e.KeyCode == Keys.Space)
            {
                btn = selected_tab.Controls["button_fly_land"] as Button;
            }
            

            //else
            //{
            //    MessageBox.Show("no button assigned to that key", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if (btn != null)
            {
                btn.PerformClick();
            }
            //else
            //{
            //    MessageBox.Show("no button found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            // so if you use arrow keys or space it doesnt do other stuff
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Space
                )
            {
                e.Handled = true;
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
        private async void button_fly_land_Click(object sender, EventArgs e)
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
            await controler.SendCommandAsync($"speed {trackBar_speed.Value}" );

        }

        private void BtnOpenFlightPath_Click(object sender, EventArgs e)
        {
            if (openFlightPathDialog.ShowDialog() == DialogResult.OK)
            {
                string path;
                path = openFlightPathDialog.FileName;
                string[] lines = File.ReadAllLines(path);
                //foreach (string line in lines)
                //{
                //    richTextBox1.Lines.Append(line);
                //}
                RtbFlightPath.Lines = lines;
                
            }
        }

        private void BtnSaveFlightPath_Click(object sender, EventArgs e)
        {
            if (saveFlightPathDialog.ShowDialog() ==DialogResult.OK)
            {
                string path;
                path = saveFlightPathDialog.FileName;
                File.WriteAllText(path, RtbFlightPath.Text);
            }
        }

        private async void BtnRunFlightPath_Click(object sender, EventArgs e)
        {
            foreach (string line in RtbFlightPath.Lines)
            {
                await controler.SendCommandAsync(line);
            }
        }
    }
}
