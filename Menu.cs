using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Autolocker
{
    public partial class Menu : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Menu()
        {
            InitializeComponent();
            // Set Astra as the default value when opening the app
            comboBoxAgents.SelectedItem = "Astra";
        }

        // Variable stores currently selected agent
        string agentName;

        bool found = false;

        delegate void GetSelectedItemDelegate();

        private void GetSelectedItem()
        {
            agentName = this.comboBoxAgents.SelectedItem.ToString().ToLower();
        }

        delegate void UncheckActiveDelegate();
        private void UncheckActive()
        {
            checkBoxActive.Checked = false;
        }

        public void SearchAgentTop()
        {
            // Keeps searching until the program is turned off (active checkmark removed)
            while (checkBoxActive.Checked && !found)
            {
                // Set the selected agent if random pick isnt activated
                if (!this.checkBoxRandomAgent.Checked)
                {
                    this.comboBoxAgents.Invoke(new GetSelectedItemDelegate(GetSelectedItem));
                }

                // Loads currently selected agent icon into bitmap
                Image a = Properties.Resources.ResourceManager.GetObject(agentName) as Image;
                Bitmap agent = new Bitmap(a);

                // Loads current screen into bitmap
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Bitmap fullscreen = new Bitmap(bounds.Width, bounds.Height);

                using (Graphics graphics = Graphics.FromImage(fullscreen))
                {
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                // Starting coordinates, dependant on resolution (Resolution: 1920x1080) - Other resolutions arent supported
                int XOffset = 500;
                int YOffset = 885;

                int fullX = 0;
                int fullY = 0;
                for (int i = 0; i < 11; i++)
                {
                    int matched = 0;
                    for (int x = 0; x < 80; x++)
                    {
                        for (int y = 0; y < 80; y++)
                        {
                            fullX = x + XOffset;
                            fullY = y + YOffset;

                            Color fullscreenPixel = fullscreen.GetPixel(fullX, fullY);
                            Color agentPixel = agent.GetPixel(x, y);

                            if (fullscreenPixel == agentPixel)
                            {
                                matched++;
                            }
                        }
                    }

                    // Checked location matches agent icon(only about 10 % match required)
                    if (matched >= 500)
                    {
                        found = true;
                        this.checkBoxActive.Invoke(new UncheckActiveDelegate(UncheckActive));

                        // Selection repeated for 5 seconds to make sure an agent is selected
                        TimeSpan endtime = DateTime.Now.AddSeconds(5).TimeOfDay;
                        while (DateTime.Now.TimeOfDay <= endtime)
                        {
                            Cursor.Position = new Point(fullX - 40, fullY - 40);
                            Thread.Sleep(20);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            Cursor.Position = new Point(960, 810);
                            Thread.Sleep(20);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        break;
                    }

                    // Offset change, dependant on resolution (Resolution: 1920x1080) - Other resolutions arent supported
                    XOffset += 84;
                }
                agent.Dispose();
                fullscreen.Dispose();
            }
        }

        public void SearchAgentBottom()
        {
            // Keeps searching until the program is turned off (active checkmark removed)
            while (checkBoxActive.Checked && !found)
            {
                // Set the selected agent if random pick isnt activated
                if (!this.checkBoxRandomAgent.Checked)
                {
                    this.comboBoxAgents.Invoke(new GetSelectedItemDelegate(GetSelectedItem));
                }

                // Loads currently selected agent icon into bitmap
                Image a = Properties.Resources.ResourceManager.GetObject(agentName) as Image;
                Bitmap agent = new Bitmap(a);

                // Loads current screen into bitmap
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Bitmap fullscreen = new Bitmap(bounds.Width, bounds.Height);

                using (Graphics graphics = Graphics.FromImage(fullscreen))
                {
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                // Starting coordinates, dependant on resolution (Resolution: 1920x1080) - Other resolutions arent supported
                int XOffset = 500;
                int YOffset = 969;

                int fullX = 0;
                int fullY = 0;
                for (int i = 0; i < 11; i++)
                {
                    int matched = 0;
                    for (int x = 0; x < 80; x++)
                    {
                        for (int y = 0; y < 80; y++)
                        {
                            fullX = x + XOffset;
                            fullY = y + YOffset;

                            Color fullscreenPixel = fullscreen.GetPixel(fullX, fullY);
                            Color agentPixel = agent.GetPixel(x, y);

                            if (fullscreenPixel == agentPixel)
                            {
                                matched++;
                            }
                        }
                    }

                    // Checked location matches agent icon(only about 10 % match required)
                    if (matched >= 500)
                    {
                        found = true;
                        this.checkBoxActive.Invoke(new UncheckActiveDelegate(UncheckActive));

                        // Selection repeated for 5 seconds to make sure an agent is selected
                        TimeSpan endtime = DateTime.Now.AddSeconds(5).TimeOfDay;
                        while (DateTime.Now.TimeOfDay <= endtime)
                        {
                            Cursor.Position = new Point(fullX - 40, fullY - 40);
                            Thread.Sleep(20);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            Cursor.Position = new Point(960, 810);
                            Thread.Sleep(20);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        break;
                    }

                    // Offset change, dependant on resolution (Resolution: 1920x1080) - Other resolutions arent supported
                    XOffset += 84;
                }
                agent.Dispose();
                fullscreen.Dispose();
            }
        }

        private void CheckBoxRandomAgent_CheckedChanged(object sender, EventArgs e)
        {
            // If random agent is activated, set random agent
            if (checkBoxRandomAgent.Checked)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, 20);

                agentName = this.comboBoxAgents.Items[randomNumber].ToString().ToLower();
            }
        }

        private void CheckBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                // If random agent is activated, set random agent
                if (checkBoxRandomAgent.Checked)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 20);

                    agentName = this.comboBoxAgents.Items[randomNumber].ToString().ToLower();
                }

                found = false;
                Thread searchThreadTop = new Thread(new ThreadStart(SearchAgentTop))
                {
                    IsBackground = true
                };
                Thread searchThreadBottom = new Thread(new ThreadStart(SearchAgentBottom))
                {
                    IsBackground = true
                };
                searchThreadTop.Start();
                searchThreadBottom.Start();
            }
        }
    }
}
