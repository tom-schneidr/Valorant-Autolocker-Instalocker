using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Autolocker
{
    partial class Menu
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
                "Astra","Breach","Brimstone","Chamber","Cypher","Fade","Gekko","Harbor","Jett","KAYO","Killjoy","Neon","Omen","Phoenix","Raze","Reyna","Sage","Skye","Sova","Viper","Yoru"
            });
            this.comboBox1.Location = new System.Drawing.Point(138, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(168, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "active";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            //
            // checkBox2
            //
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(168, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "random agent";
            this.checkBox2.UseVisualStyleBackColor = true;


            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Name = "Menu";
            this.Text = "Autolocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;

        // Define a variable to store the selected item
        string agentName;

        // Define a delegate to get the selected item on the UI thread
        delegate void GetSelectedItemDelegate();

        // Method to get the selected item on the UI thread
        private void GetSelectedItem()
        {
            agentName = this.comboBox1.SelectedItem.ToString().ToLower();
        }

        public void searchAgent()
        {
            while (checkBox1.Checked)
            {

                if (this.checkBox2.Checked)
                {
                    Random rand = new Random();
                    int randomNumber = rand.Next(0, 20);

                    agentName = this.comboBox1.Items[randomNumber].ToString().ToLower();
                }
                else
                {
                    this.comboBox1.Invoke(new GetSelectedItemDelegate(GetSelectedItem));
                }

                Image a = Properties.Resources.ResourceManager.GetObject(agentName) as Image;
                Bitmap agent = new Bitmap(a);

                // Get the bounds of the primary screen
                Rectangle bounds = Screen.PrimaryScreen.Bounds;

                // Create a Bitmap object to hold the screenshot
                Bitmap fullscreen = new Bitmap(bounds.Width, bounds.Height);

                // Create a Graphics object from the bitmap
                using (Graphics graphics = Graphics.FromImage(fullscreen))
                {
                    // Copy the screen to the bitmap
                    graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                int XOffset = 500;
                int YOffset = 885;

                int fullX = 0;
                int fullY = 0;
                for (int i = 0; i < 21; i++)
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

                    Console.WriteLine(matched);

                    if (matched >= 500)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            // Click the position
                            Cursor.Position = new Point(fullX - 40, fullY - 40);
                            Thread.Sleep(100);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            Thread.Sleep(100);
                            Cursor.Position = new Point(960, 810);
                            Thread.Sleep(100);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }
                        break;
                    }

                    if (i != 10) XOffset += 84;
                    else if (i == 10)
                    {
                        XOffset = 500;
                        YOffset += 84;
                    }
                }

                agent.Dispose();
                fullscreen.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Thread searchThread = new Thread(new ThreadStart(searchAgent));
                searchThread.IsBackground = true;
                searchThread.Start();
            }
        }
    }
}

