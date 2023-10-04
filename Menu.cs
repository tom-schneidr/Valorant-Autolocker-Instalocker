using Autolocker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Autolocker
{
    public partial class Menu : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public Menu()
        {
            InitializeComponent();
            LoadConfig();
            Thread keypressListenerThread = new Thread(new ThreadStart(KeypressListener))
            {
                IsBackground = true
            };
            keypressListenerThread.Start();
        }

        // Variables YAY
        readonly string[] allAgents = { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Deadlock", "Fade", "Gekko", "Harbor", "Jett", "KAYO", "Killjoy", "Omen", "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };
        string agentName = "Jett";
        string randomBind = "F7";
        string activeBind = "F8";
        string map = null;
        Image background;

        public void KeypressListener()
        {
            while (true)
            {
                // Minimum CPU usage
                Thread.Sleep(100);
                // Loop through all possible keys
                for (int i = 0; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);

                    // Check if a set keybind is being pressed, trigger event if detected
                    if (keyState != 0)
                    {
                        if (Enum.GetName(typeof(Keys), i) == randomBind)
                        {
                            if (checkBoxRandomAgent.Checked) checkBoxRandomAgent.Invoke(new UncheckRandomDelegate(UncheckRandom));
                            else if (!checkBoxRandomAgent.Checked) checkBoxRandomAgent.Invoke(new CheckRandomDelegate(CheckRandom));
                        }
                        if (Enum.GetName(typeof(Keys), i) == activeBind)
                        {
                            if (checkBoxActive.Checked) checkBoxActive.Invoke(new UncheckActiveDelegate(UncheckActive));
                            else if (!checkBoxActive.Checked) checkBoxActive.Invoke(new CheckActiveDelegate(CheckActive));
                        }
                    }
                }
            }
        }

        private delegate void UncheckActiveDelegate();
        private void UncheckActive()
        {
            checkBoxActive.Checked = false;
        }

        private delegate void CheckActiveDelegate();
        private void CheckActive()
        {
            checkBoxActive.Checked = true;
        }


        private delegate void UncheckRandomDelegate();
        private void UncheckRandom()
        {
            checkBoxRandomAgent.Checked = false;
        }

        private delegate void CheckRandomDelegate();
        private void CheckRandom()
        {
            checkBoxRandomAgent.Checked = true;
        }

        private void SelectRandomAgent()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, allAgents.Length - 1);
            agentName = allAgents[randomNumber];
            selectedAgentLabel.Text = "Selected agent: RANDOM";
        }

        public void SearchMap()
        {
            map = null;
            int RGB_TOLERANCE = 10;
            double REQUIRED_ACCURACY = 0.7;

            // Variables for the images
            Bitmap fullscreen;
            Graphics graphics;

            // Map
            Image m;
            Bitmap bitMap;

            while (checkBoxActive.Checked && checkBoxUseConfig.Checked && map == null)
            {
                Thread.Sleep(50);

                int XOffset = 105;
                int YOffset = 104;
                double MAPPIXELS = 80 * 11;


                fullscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

                using (graphics = Graphics.FromImage(fullscreen))
                {
                    // Copy the screen contents to the fullscreen Bitmap
                    graphics.CopyFromScreen(
                        Screen.PrimaryScreen.Bounds.X,
                        Screen.PrimaryScreen.Bounds.Y,
                        0,
                        0,
                        Screen.PrimaryScreen.Bounds.Size,
                        CopyPixelOperation.SourceCopy
                    );
                }

                // Check maps
                m = Resources.ascent;
                bitMap = new Bitmap(m);
                int matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "ascent";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.bind;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "bind";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.breeze;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "breeze";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.fracture;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "fracture";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.haven;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "haven";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.icebox;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "icebox";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.lotus;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "lotus";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.pearl;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "pearl";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.split;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        Color mapPixel = bitMap.GetPixel(x, y);
                        Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                        int r = mapPixel.R - fullPixel.R;
                        int g = mapPixel.G - fullPixel.G;
                        int b = mapPixel.B - fullPixel.B;

                        if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                    }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                    map = "split";
                    m.Dispose();
                    bitMap.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                m = Resources.sunset;
                bitMap = new Bitmap(m);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                  for (int y = 0; y < 11; y++)
                  {
                    Color mapPixel = bitMap.GetPixel(x, y);
                    Color fullPixel = fullscreen.GetPixel(x + XOffset, y + YOffset);
                    int r = mapPixel.R - fullPixel.R;
                    int g = mapPixel.G - fullPixel.G;
                    int b = mapPixel.B - fullPixel.B;

                    if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                  }
                }

                if (matched / MAPPIXELS >= REQUIRED_ACCURACY)
                {
                  map = "sunset";
                  m.Dispose();
                  bitMap.Dispose();
                  fullscreen.Dispose();
                  break;
                }

                m.Dispose();
                bitMap.Dispose();
                fullscreen.Dispose();
            }
        }
        public void SearchAgent(int row)
        {
            int RGB_TOLERANCE = 10;
            double REQUIRED_ACCURACY = 0.6;
            double AGENTPIXELS = 80 * 80;
            // Keeps searching until the program is turned off (active checkmark removed)
            while (checkBoxActive.Checked)
            {
                Thread.Sleep(50);
                if (checkBoxUseConfig.Checked)
                {
                    while (map == null && checkBoxUseConfig.Checked && checkBoxActive.Checked)
                    {
                        Thread.Sleep(10);
                    }
                    if (map == "ascent") ascentConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "bind") bindConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "breeze") breezeConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "fracture") fractureConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "haven") havenConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "icebox") iceboxConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "lotus") lotusConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "pearl") pearlConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "split") splitConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    else if (map == "sunset") splitConfigDropdown.Invoke((Action)(() => SetConfigAgent(map)));
                    map = null;
                }
                agentName = agentName.ToLower();
                // Loads currently selected agent icon into bitmap
                Image a = Resources.ResourceManager.GetObject(agentName) as Image;
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
                int YOffset = 885 + (row * 84);

                int fullX = 0;
                int fullY = 0;

                int test = 0;
                for (int i = 0; i < 11; i++)
                {
                    int matched = 0;
                    for (int x = 0; x < 80; x++)
                    {
                        for (int y = 0; y < 80; y++)
                        {
                            fullX = x + XOffset;
                            fullY = y + YOffset;
                            Color agentPixel = agent.GetPixel(x, y);
                            Color fullPixel = fullscreen.GetPixel(fullX, fullY);
                            if (agentPixel == fullPixel) test++;
                            int r = agentPixel.R - fullPixel.R;
                            int g = agentPixel.G - fullPixel.G;
                            int b = agentPixel.B - fullPixel.B;

                            if ((r * r + g * g + b * b) / 3 <= RGB_TOLERANCE * RGB_TOLERANCE) matched++;
                        }
                    }

                    if ((matched / AGENTPIXELS) >= REQUIRED_ACCURACY)
                    {
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
                // Free all resources used
                agent.Dispose();
                fullscreen.Dispose();
                a.Dispose();

                if (checkBoxRandomAgent.Checked)
                {
                    checkBoxRandomAgent.Invoke((Action)(() => SelectRandomAgent()));
                }
            }
        }

        private void CheckBoxRandomAgent_CheckedChanged(object sender, EventArgs e)
        {
            // If random agent is activated, set random agent
            if (checkBoxRandomAgent.Checked)
            {
                checkBoxRandomAgent.Invoke((Action)(() => SelectRandomAgent()));
            }
            else
            {
                agentName = "Jett";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void CheckBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActive.Checked)
            {
                if (checkBoxUseConfig.Checked)
                {
                    Thread searchMapThread = new Thread(new ThreadStart(SearchMap))
                    {
                        IsBackground = true
                    };
                    searchMapThread.Start();
                }
                // If random agent is activated, set random agent
                if (checkBoxRandomAgent.Checked)
                {
                    checkBoxRandomAgent.Invoke((Action)(() => SelectRandomAgent()));
                }

                Thread searchThreadTop = new Thread(() => SearchAgent(0))
                {
                    IsBackground = true
                };
                Thread searchThreadBottom = new Thread(() => SearchAgent(1))
                {
                    IsBackground = true
                };
                searchThreadTop.Start();
                searchThreadBottom.Start();
            }
        }

        private void SetConfigAgent(string map)
        {
            if (map == "ascent")
            {
                if (ascentConfigDropdown.SelectedItem == null) return;
                agentName = ascentConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "bind")
            {
                if (bindConfigDropdown.SelectedItem == null) return;
                agentName = bindConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "breeze")
            {
                if (breezeConfigDropdown.SelectedItem == null) return;
                agentName = breezeConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "fracture")
            {

                if (fractureConfigDropdown.SelectedItem == null) return;
                agentName = fractureConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "haven")
            {
                if (havenConfigDropdown.SelectedItem == null) return;
                agentName = havenConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "icebox")
            {
                if (iceboxConfigDropdown.SelectedItem == null) return;
                agentName = iceboxConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "lotus")
            {
                if (lotusConfigDropdown.SelectedItem == null) return;
                agentName = lotusConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "pearl")
            {
                if (pearlConfigDropdown.SelectedItem == null) return;
                agentName = pearlConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "split")
            {
                if (splitConfigDropdown.SelectedItem == null) return;
                agentName = splitConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "sunset")
            {
              if (sunsetConfigDropdown.SelectedItem == null) return;
              agentName = sunsetConfigDropdown.SelectedItem.ToString();
            }

            selectedAgentLabel.Text = "Selected agent: " + agentName;
        }

        private void SetRandomKeybind(string bind)
        {
            randomKeybindButton.Text = "[" + bind + "]";
            randomBind = bind;
        }

        private void RandomKeybindButton_Click(object sender, EventArgs e)
        {
            randomKeybindButton.Text = "[...]";
            Thread setRandomButtonTextThread = new Thread(new ThreadStart(SetRandomKeybindText))
            {
                IsBackground = true
            };
            setRandomButtonTextThread.Start();
        }

        private void SetRandomKeybindText()
        {
            bool pressed = false;
            while (!pressed)
            {
                // Minimum CPU usage
                Thread.Sleep(100);
                for (int i = 0; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState != 0)
                    {
                        randomKeybindButton.Invoke((Action)(() => SetRandomKeybind(Enum.GetName(typeof(Keys), i))));
                        pressed = true;
                        break;
                    }
                }
            }
        }

        private void ActiveKeybindButton_Click(object sender, EventArgs e)
        {
            activeKeybindButton.Text = "[...]";
            Thread setActiveButtonTextThread = new Thread(new ThreadStart(SetActiveKeybindText))
            {
                IsBackground = true
            };
            setActiveButtonTextThread.Start();
        }

        private void SetActiveKeybindText()
        {
            bool pressed = false;
            while (!pressed)
            {
                // Minimum CPU usage
                Thread.Sleep(100);
                // Loop through all possible F keys
                for (int i = 0; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState != 0)
                    {
                        activeKeybindButton.Invoke((Action)(() => SetActiveKeybind(Enum.GetName(typeof(Keys), i))));
                        pressed = true;
                        break;
                    }
                }
            }
        }

        private void SetActiveKeybind(string bind)
        {
            activeKeybindButton.Text = "[" + bind + "]";
            activeBind = bind;
        }

        private void SelectAstraButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Astra";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectBreachButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Breach";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectBrimstoneButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Brimstone";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectChamberButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Chamber";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectCypherButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Cypher";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectDeadlockButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Deadlock";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectFadeButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Fade";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectGekkoButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Gekko";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectHarborButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Harbor";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectJettButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Jett";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectKayoButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Kayo";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectKilljoyButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Killjoy";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectNeonButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Neon";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectOmenButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Omen";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectPhoenixButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Phoenix";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectRazeButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Raze";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectReynaButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Reyna";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectSageButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Sage";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectSkyeButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Skye";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectSovaButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Sova";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectViperButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Viper";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SelectYoruButton_Click(object sender, EventArgs e)
        {
            if (!checkBoxRandomAgent.Checked)
            {
                agentName = "Yoru";
                selectedAgentLabel.Text = "Selected agent: " + agentName;
            }
        }

        private void SaveConfig()
        {
            if (ascentConfigDropdown.SelectedItem != null)
                Settings.Default.configAscent = ascentConfigDropdown.SelectedItem.ToString();
            if (bindConfigDropdown.SelectedItem != null)
                Settings.Default.configBind = bindConfigDropdown.SelectedItem.ToString();
            if (breezeConfigDropdown.SelectedItem != null)
                Settings.Default.configBreeze = breezeConfigDropdown.SelectedItem.ToString();
            if (fractureConfigDropdown.SelectedItem != null)
                Settings.Default.configFracture = fractureConfigDropdown.SelectedItem.ToString();
            if (havenConfigDropdown.SelectedItem != null)
                Settings.Default.configHaven = havenConfigDropdown.SelectedItem.ToString();
            if (iceboxConfigDropdown.SelectedItem != null)
                Settings.Default.configIcebox = iceboxConfigDropdown.SelectedItem.ToString();
            if (lotusConfigDropdown.SelectedItem != null)
                Settings.Default.configLotus = lotusConfigDropdown.SelectedItem.ToString();
            if (pearlConfigDropdown.SelectedItem != null)
                Settings.Default.configPearl = pearlConfigDropdown.SelectedItem.ToString();
            if (splitConfigDropdown.SelectedItem != null)
                Settings.Default.configSplit = splitConfigDropdown.SelectedItem.ToString();
            if (randomBind != null)
                Settings.Default.randomKeybind = randomBind;
            if (activeBind != null)
                Settings.Default.activeKeybind = activeBind;
            Settings.Default.Save();
        }

        private void LoadConfig()
        {
            ascentConfigDropdown.SelectedItem = Settings.Default.configAscent;
            bindConfigDropdown.SelectedItem = Settings.Default.configBind;
            breezeConfigDropdown.SelectedItem = Settings.Default.configBreeze;
            fractureConfigDropdown.SelectedItem = Settings.Default.configFracture;
            havenConfigDropdown.SelectedItem = Settings.Default.configHaven;
            iceboxConfigDropdown.SelectedItem = Settings.Default.configIcebox;
            lotusConfigDropdown.SelectedItem = Settings.Default.configLotus;
            pearlConfigDropdown.SelectedItem = Settings.Default.configPearl;
            splitConfigDropdown.SelectedItem = Settings.Default.configSplit;

            if (Settings.Default.randomKeybind != "")
                randomBind = Settings.Default.randomKeybind;
            randomKeybindButton.Text = "[" + randomBind + "]";
            if (Settings.Default.activeKeybind != "")
                activeBind = Settings.Default.activeKeybind;
            activeKeybindButton.Text = "[" + activeBind + "]";

            if (Settings.Default.backgroundImagePath != "")
            {
                background = Image.FromFile(Settings.Default.backgroundImagePath);
                agentPage.BackgroundImage = background;
                configPage.BackgroundImage = background;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void CheckBoxUseConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseConfig.Checked)
            {
                if (checkBoxActive.Checked)
                {
                    Thread searchMapThread = new Thread(new ThreadStart(SearchMap))
                    {
                        IsBackground = true
                    };
                    searchMapThread.Start();
                }
            }
        }

        private void ButtonBackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string targetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "CustomBackgroundImage.jpg");

                if (File.Exists(targetPath))
                {
                    string tmpPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "tmp.jpg");
                    if (File.Exists(tmpPath)) File.Delete(tmpPath);
                    File.Copy(openFileDialog.FileName, tmpPath, true);
                    background?.Dispose();
                    background = Image.FromFile(tmpPath);
                    agentPage.BackgroundImage = background;
                    configPage.BackgroundImage = background;
                    File.Delete(targetPath);

                    File.Copy(tmpPath, targetPath, true);
                    background.Dispose();
                    background = Image.FromFile(targetPath);
                    agentPage.BackgroundImage = background;
                    configPage.BackgroundImage = background;

                    File.Delete(tmpPath);
                }
                else
                {
                    File.Copy(openFileDialog.FileName, targetPath, true);
                    background = Image.FromFile(targetPath);
                    agentPage.BackgroundImage = background;
                    configPage.BackgroundImage = background;
                }
                Settings.Default.backgroundImagePath = targetPath;
                Settings.Default.Save();
            }
        }

        private void ButtonRemoveBackgroundImage_Click(object sender, EventArgs e)
        {
            if (background != null)
            {
                background.Dispose();
                agentPage.BackgroundImage = null;
                configPage.BackgroundImage = null;
                Settings.Default.backgroundImagePath = "";
            }
        }
  }
}
