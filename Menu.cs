using Autolocker.Properties;
using System;
using System.Drawing;
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

        // Variable stores currently selected agent - Jett is default
        string agentName = "Jett";
        bool found = false;
        string randomBind = "F7";
        string activeBind = "F8";
        string map = null;

        public void KeypressListener()
        {
            while (true)
            {
                // Minimum CPU usage
                Thread.Sleep(50);
                // Loop through all possible F keys
                for (int i = 112; i < 124; i++)
                {
                    int keyState = GetAsyncKeyState(i);

                    if (keyState != 0)
                    {
                        if(Enum.GetName(typeof(Keys), i) == randomBind)
                        {
                            if (checkBoxRandomAgent.Checked) checkBoxRandomAgent.Invoke(new UncheckRandomDelegate(UncheckRandom));
                            else if (!checkBoxRandomAgent.Checked) checkBoxRandomAgent.Invoke(new CheckRandomDelegate(CheckRandom));
                            Thread.Sleep(200);
                        }
                        if (Enum.GetName(typeof(Keys), i) == activeBind)
                        {
                            if (checkBoxActive.Checked) checkBoxActive.Invoke(new UncheckActiveDelegate(UncheckActive));
                            else if (!checkBoxActive.Checked) checkBoxActive.Invoke(new CheckActiveDelegate(CheckActive));
                            Thread.Sleep(200);
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

        public void SearchMap()
        {
            map = null;
            int matched = 0;
            while (checkBoxActive.Checked && map == null)
            {
                Thread.Sleep(50);

                int XOffset = 105;
                int YOffset = 104;

                // Loads current screen into bitmap
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Bitmap fullscreen = new Bitmap(bounds.Width, bounds.Height);

                using (Graphics graphics = Graphics.FromImage(fullscreen))
                {
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                // Load maps
                Image a = Properties.Resources.ascent;
                Bitmap ascent = new Bitmap(a);

                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (ascent.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "ascent";
                    a.Dispose();
                    ascent.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image b = Properties.Resources.bind;
                Bitmap bind = new Bitmap(b);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (bind.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "bind";
                    b.Dispose();
                    bind.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image br = Properties.Resources.breeze;
                Bitmap breeze = new Bitmap(br);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (breeze.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "breeze";
                    br.Dispose();
                    breeze.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image f = Properties.Resources.fracture;
                Bitmap fracture = new Bitmap(f);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (fracture.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "fracture";
                    f.Dispose();
                    fracture.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image h = Properties.Resources.haven;
                Bitmap haven = new Bitmap(h);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (haven.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "haven";
                    h.Dispose();
                    haven.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image i = Properties.Resources.icebox;
                Bitmap icebox = new Bitmap(i);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (icebox.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "icebox";
                    i.Dispose();
                    icebox.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image l = Properties.Resources.lotus;
                Bitmap lotus = new Bitmap(l);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (lotus.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "lotus";
                    l.Dispose();
                    lotus.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image p = Properties.Resources.pearl;
                Bitmap pearl = new Bitmap(p);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (pearl.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }

                if (matched >= 500)
                {
                    map = "pearl";
                    p.Dispose();
                    pearl.Dispose();
                    fullscreen.Dispose();
                    break;
                }

                Image s = Properties.Resources.split;
                Bitmap split = new Bitmap(s);

                matched = 0;
                for (int x = 0; x < 80; x++)
                {
                    for (int y = 0; y < 11; y++)
                    {
                        if (split.GetPixel(x, y) == fullscreen.GetPixel(x + XOffset, y + YOffset)) matched++;
                    }
                }
                
                if (matched >= 500)
                {
                    map = "split";
                    s.Dispose();
                    split.Dispose();
                    fullscreen.Dispose();
                    break;
                }
            }
        }
        public void SearchAgentTop()
        {
            // Keeps searching until the program is turned off (active checkmark removed)
            while (checkBoxActive.Checked && !found)
            {
                Thread.Sleep(50);
                if (checkBoxUseConfig.Checked)
                {
                    while (map == null && checkBoxUseConfig.Checked)
                    {
                        Thread.Sleep(50);
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
                }
                agentName = agentName.ToLower();
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
                // Free all resources used
                agent.Dispose();
                fullscreen.Dispose();
                a.Dispose();

                if (checkBoxRandomAgent.Checked)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 20);
                    string[] agents = { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Fade", "Gekko", "Harbor", "Jett", "KAYO", "Killjoy", "Omen", "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };

                    agentName = agents[randomNumber];
                }
            }
        }

        public void SearchAgentBottom()
        {
            // Keeps searching until the program is turned off (active checkmark removed)
            while (checkBoxActive.Checked && !found)
            {
                Thread.Sleep(50);
                if (checkBoxUseConfig.Checked)
                {
                    while (map == null && checkBoxUseConfig.Checked)
                    {
                        Thread.Sleep(50);
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
                }
                agentName = agentName.ToLower();
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
                // Free all resources used
                agent.Dispose();
                fullscreen.Dispose();
                a.Dispose();

                if (checkBoxRandomAgent.Checked)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 20);
                    string[] agents = { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Fade", "Gekko", "Harbor", "Jett", "KAYO", "Killjoy", "Omen", "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };

                    agentName = agents[randomNumber];
                }
            }
        }

        private void CheckBoxRandomAgent_CheckedChanged(object sender, EventArgs e)
        {
            // If random agent is activated, set random agent
            if (checkBoxRandomAgent.Checked)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, 20);
                string[] agents = { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Fade", "Gekko", "Harbor", "Jett", "KAYO", "Killjoy", "Omen", "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };

                agentName = agents[randomNumber];
                selectedAgentLabel.Text = "Selected agent: RANDOM";
            }
        }

        private void CheckBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            Thread searchMapThread = new Thread(new ThreadStart(SearchMap))
            {
                IsBackground = true
            };
            searchMapThread.Start();

            if (checkBoxActive.Checked)
            {
                // If random agent is activated, set random agent
                if (checkBoxRandomAgent.Checked)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 20);
                    string[] agents = { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Fade", "Gekko", "Harbor", "Jett", "KAYO", "Killjoy", "Omen", "Phoenix", "Raze", "Reyna", "Sage", "Skye", "Sova", "Viper", "Yoru" };

                    agentName = agents[randomNumber];
                    selectedAgentLabel.Text = "Selected agent: RANDOM";
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

        private void SetConfigAgent(string map)
        {
            if (map == "ascent")
            {
                if (ascentConfigDropdown.SelectedItem == null) return;
                agentName = ascentConfigDropdown.SelectedItem.ToString();
            }
            else if (map == "bind")
            {
                if (bindConfigDropdown.SelectedItem == null)
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
                IsBackground=true
            };
            setRandomButtonTextThread.Start();
        }

        private void SetRandomKeybindText()
        {
            bool pressed = false;
            while (!pressed)
            {
                // Minimum CPU usage
                Thread.Sleep(50);
                for (int i = 112; i < 124; i++)
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
                Thread.Sleep(50);
                // Loop through all possible F keys
                for (int i = 112; i < 124; i++)
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
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}
