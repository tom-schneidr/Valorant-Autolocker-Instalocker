using System.Windows.Forms;

namespace Autolocker
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomAgent = new System.Windows.Forms.CheckBox();
            this.randomKeybindButton = new System.Windows.Forms.Button();
            this.activeKeybindButton = new System.Windows.Forms.Button();
            this.selectAstraButton = new System.Windows.Forms.Button();
            this.selectBreachButton = new System.Windows.Forms.Button();
            this.selectChamberButton = new System.Windows.Forms.Button();
            this.selectCypherButton = new System.Windows.Forms.Button();
            this.selectBrimstoneButton = new System.Windows.Forms.Button();
            this.selectHarborButton = new System.Windows.Forms.Button();
            this.selectGekkoButton = new System.Windows.Forms.Button();
            this.selectFadeButton = new System.Windows.Forms.Button();
            this.selectOmenButton = new System.Windows.Forms.Button();
            this.selectNeonButton = new System.Windows.Forms.Button();
            this.selectKilljoyButton = new System.Windows.Forms.Button();
            this.selectKayoButton = new System.Windows.Forms.Button();
            this.selectJettButton = new System.Windows.Forms.Button();
            this.selectSageButton = new System.Windows.Forms.Button();
            this.selectReynaButton = new System.Windows.Forms.Button();
            this.selectRazeButton = new System.Windows.Forms.Button();
            this.selectPhoenixButton = new System.Windows.Forms.Button();
            this.selectViperButton = new System.Windows.Forms.Button();
            this.selectSovaButton = new System.Windows.Forms.Button();
            this.selectSkyeButton = new System.Windows.Forms.Button();
            this.selectYoruButton = new System.Windows.Forms.Button();
            this.selectedAgentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(488, 372);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(98, 31);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.CheckBoxActive_CheckedChanged);
            // 
            // checkBoxRandomAgent
            // 
            this.checkBoxRandomAgent.AutoSize = true;
            this.checkBoxRandomAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRandomAgent.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRandomAgent.Location = new System.Drawing.Point(488, 320);
            this.checkBoxRandomAgent.Name = "checkBoxRandomAgent";
            this.checkBoxRandomAgent.Size = new System.Drawing.Size(118, 31);
            this.checkBoxRandomAgent.TabIndex = 1;
            this.checkBoxRandomAgent.Text = "random";
            this.checkBoxRandomAgent.UseVisualStyleBackColor = true;
            this.checkBoxRandomAgent.CheckedChanged += new System.EventHandler(this.CheckBoxRandomAgent_CheckedChanged);
            // 
            // randomKeybindButton
            // 
            this.randomKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.randomKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomKeybindButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomKeybindButton.Location = new System.Drawing.Point(612, 316);
            this.randomKeybindButton.Name = "randomKeybindButton";
            this.randomKeybindButton.Size = new System.Drawing.Size(70, 40);
            this.randomKeybindButton.TabIndex = 2;
            this.randomKeybindButton.Text = "[F7]";
            this.randomKeybindButton.UseVisualStyleBackColor = false;
            this.randomKeybindButton.Click += new System.EventHandler(this.RandomKeybindButton_Click);
            // 
            // activeKeybindButton
            // 
            this.activeKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.activeKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeKeybindButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeKeybindButton.Location = new System.Drawing.Point(612, 368);
            this.activeKeybindButton.Name = "activeKeybindButton";
            this.activeKeybindButton.Size = new System.Drawing.Size(70, 40);
            this.activeKeybindButton.TabIndex = 3;
            this.activeKeybindButton.Text = "[F8]";
            this.activeKeybindButton.UseVisualStyleBackColor = false;
            this.activeKeybindButton.Click += new System.EventHandler(this.ActiveKeybindButton_Click);
            // 
            // selectAstraButton
            // 
            this.selectAstraButton.Image = global::Autolocker.Properties.Resources.astra;
            this.selectAstraButton.Location = new System.Drawing.Point(33, 118);
            this.selectAstraButton.Name = "selectAstraButton";
            this.selectAstraButton.Size = new System.Drawing.Size(85, 85);
            this.selectAstraButton.TabIndex = 4;
            this.selectAstraButton.UseVisualStyleBackColor = true;
            this.selectAstraButton.Click += new System.EventHandler(this.SelectAstraButton_Click);
            // 
            // selectBreachButton
            // 
            this.selectBreachButton.Image = global::Autolocker.Properties.Resources.breach;
            this.selectBreachButton.Location = new System.Drawing.Point(124, 118);
            this.selectBreachButton.Name = "selectBreachButton";
            this.selectBreachButton.Size = new System.Drawing.Size(85, 85);
            this.selectBreachButton.TabIndex = 5;
            this.selectBreachButton.UseVisualStyleBackColor = true;
            this.selectBreachButton.Click += new System.EventHandler(this.SelectBreachButton_Click);
            // 
            // selectChamberButton
            // 
            this.selectChamberButton.Image = global::Autolocker.Properties.Resources.chamber;
            this.selectChamberButton.Location = new System.Drawing.Point(306, 118);
            this.selectChamberButton.Name = "selectChamberButton";
            this.selectChamberButton.Size = new System.Drawing.Size(85, 85);
            this.selectChamberButton.TabIndex = 7;
            this.selectChamberButton.UseVisualStyleBackColor = true;
            this.selectChamberButton.Click += new System.EventHandler(this.SelectChamberButton_Click);
            // 
            // selectCypherButton
            // 
            this.selectCypherButton.Image = global::Autolocker.Properties.Resources.cypher;
            this.selectCypherButton.Location = new System.Drawing.Point(397, 118);
            this.selectCypherButton.Name = "selectCypherButton";
            this.selectCypherButton.Size = new System.Drawing.Size(85, 85);
            this.selectCypherButton.TabIndex = 8;
            this.selectCypherButton.UseVisualStyleBackColor = true;
            this.selectCypherButton.Click += new System.EventHandler(this.SelectCypherButton_Click);
            // 
            // selectBrimstoneButton
            // 
            this.selectBrimstoneButton.Image = global::Autolocker.Properties.Resources.brimstone;
            this.selectBrimstoneButton.Location = new System.Drawing.Point(215, 118);
            this.selectBrimstoneButton.Name = "selectBrimstoneButton";
            this.selectBrimstoneButton.Size = new System.Drawing.Size(85, 85);
            this.selectBrimstoneButton.TabIndex = 6;
            this.selectBrimstoneButton.UseVisualStyleBackColor = true;
            this.selectBrimstoneButton.Click += new System.EventHandler(this.SelectBrimstoneButton_Click);
            // 
            // selectHarborButton
            // 
            this.selectHarborButton.Image = global::Autolocker.Properties.Resources.harbor;
            this.selectHarborButton.Location = new System.Drawing.Point(672, 118);
            this.selectHarborButton.Name = "selectHarborButton";
            this.selectHarborButton.Size = new System.Drawing.Size(85, 85);
            this.selectHarborButton.TabIndex = 11;
            this.selectHarborButton.UseVisualStyleBackColor = true;
            this.selectHarborButton.Click += new System.EventHandler(this.SelectHarborButton_Click);
            // 
            // selectGekkoButton
            // 
            this.selectGekkoButton.Image = global::Autolocker.Properties.Resources.gekko;
            this.selectGekkoButton.Location = new System.Drawing.Point(581, 118);
            this.selectGekkoButton.Name = "selectGekkoButton";
            this.selectGekkoButton.Size = new System.Drawing.Size(85, 85);
            this.selectGekkoButton.TabIndex = 10;
            this.selectGekkoButton.UseVisualStyleBackColor = true;
            this.selectGekkoButton.Click += new System.EventHandler(this.SelectGekkoButton_Click);
            // 
            // selectFadeButton
            // 
            this.selectFadeButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectFadeButton.Image = global::Autolocker.Properties.Resources.fade;
            this.selectFadeButton.Location = new System.Drawing.Point(488, 118);
            this.selectFadeButton.Name = "selectFadeButton";
            this.selectFadeButton.Size = new System.Drawing.Size(85, 85);
            this.selectFadeButton.TabIndex = 9;
            this.selectFadeButton.UseVisualStyleBackColor = false;
            this.selectFadeButton.Click += new System.EventHandler(this.SelectFadeButton_Click);
            // 
            // selectOmenButton
            // 
            this.selectOmenButton.Image = global::Autolocker.Properties.Resources.omen;
            this.selectOmenButton.Location = new System.Drawing.Point(124, 209);
            this.selectOmenButton.Name = "selectOmenButton";
            this.selectOmenButton.Size = new System.Drawing.Size(85, 85);
            this.selectOmenButton.TabIndex = 16;
            this.selectOmenButton.UseVisualStyleBackColor = true;
            this.selectOmenButton.Click += new System.EventHandler(this.SelectOmenButton_Click);
            // 
            // selectNeonButton
            // 
            this.selectNeonButton.Image = global::Autolocker.Properties.Resources.neon;
            this.selectNeonButton.Location = new System.Drawing.Point(33, 209);
            this.selectNeonButton.Name = "selectNeonButton";
            this.selectNeonButton.Size = new System.Drawing.Size(85, 85);
            this.selectNeonButton.TabIndex = 15;
            this.selectNeonButton.UseVisualStyleBackColor = true;
            this.selectNeonButton.Click += new System.EventHandler(this.SelectNeonButton_Click);
            // 
            // selectKilljoyButton
            // 
            this.selectKilljoyButton.Image = global::Autolocker.Properties.Resources.killjoy;
            this.selectKilljoyButton.Location = new System.Drawing.Point(945, 118);
            this.selectKilljoyButton.Name = "selectKilljoyButton";
            this.selectKilljoyButton.Size = new System.Drawing.Size(85, 85);
            this.selectKilljoyButton.TabIndex = 14;
            this.selectKilljoyButton.UseVisualStyleBackColor = true;
            this.selectKilljoyButton.Click += new System.EventHandler(this.SelectKilljoyButton_Click);
            // 
            // selectKayoButton
            // 
            this.selectKayoButton.Image = global::Autolocker.Properties.Resources.kayo;
            this.selectKayoButton.Location = new System.Drawing.Point(854, 118);
            this.selectKayoButton.Name = "selectKayoButton";
            this.selectKayoButton.Size = new System.Drawing.Size(85, 85);
            this.selectKayoButton.TabIndex = 13;
            this.selectKayoButton.UseVisualStyleBackColor = true;
            this.selectKayoButton.Click += new System.EventHandler(this.SelectKayoButton_Click);
            // 
            // selectJettButton
            // 
            this.selectJettButton.Image = global::Autolocker.Properties.Resources.jett;
            this.selectJettButton.Location = new System.Drawing.Point(763, 118);
            this.selectJettButton.Name = "selectJettButton";
            this.selectJettButton.Size = new System.Drawing.Size(85, 85);
            this.selectJettButton.TabIndex = 12;
            this.selectJettButton.UseVisualStyleBackColor = true;
            this.selectJettButton.Click += new System.EventHandler(this.SelectJettButton_Click);
            // 
            // selectSageButton
            // 
            this.selectSageButton.Image = global::Autolocker.Properties.Resources.sage;
            this.selectSageButton.Location = new System.Drawing.Point(488, 209);
            this.selectSageButton.Name = "selectSageButton";
            this.selectSageButton.Size = new System.Drawing.Size(85, 85);
            this.selectSageButton.TabIndex = 20;
            this.selectSageButton.UseVisualStyleBackColor = true;
            this.selectSageButton.Click += new System.EventHandler(this.SelectSageButton_Click);
            // 
            // selectReynaButton
            // 
            this.selectReynaButton.Image = global::Autolocker.Properties.Resources.reyna;
            this.selectReynaButton.Location = new System.Drawing.Point(397, 209);
            this.selectReynaButton.Name = "selectReynaButton";
            this.selectReynaButton.Size = new System.Drawing.Size(85, 85);
            this.selectReynaButton.TabIndex = 19;
            this.selectReynaButton.UseVisualStyleBackColor = true;
            this.selectReynaButton.Click += new System.EventHandler(this.SelectReynaButton_Click);
            // 
            // selectRazeButton
            // 
            this.selectRazeButton.Image = global::Autolocker.Properties.Resources.raze;
            this.selectRazeButton.Location = new System.Drawing.Point(306, 209);
            this.selectRazeButton.Name = "selectRazeButton";
            this.selectRazeButton.Size = new System.Drawing.Size(85, 85);
            this.selectRazeButton.TabIndex = 18;
            this.selectRazeButton.UseVisualStyleBackColor = true;
            this.selectRazeButton.Click += new System.EventHandler(this.SelectRazeButton_Click);
            // 
            // selectPhoenixButton
            // 
            this.selectPhoenixButton.Image = global::Autolocker.Properties.Resources.phoenix;
            this.selectPhoenixButton.Location = new System.Drawing.Point(215, 209);
            this.selectPhoenixButton.Name = "selectPhoenixButton";
            this.selectPhoenixButton.Size = new System.Drawing.Size(85, 85);
            this.selectPhoenixButton.TabIndex = 17;
            this.selectPhoenixButton.UseVisualStyleBackColor = true;
            this.selectPhoenixButton.Click += new System.EventHandler(this.SelectPhoenixButton_Click);
            // 
            // selectViperButton
            // 
            this.selectViperButton.Image = global::Autolocker.Properties.Resources.viper;
            this.selectViperButton.Location = new System.Drawing.Point(763, 209);
            this.selectViperButton.Name = "selectViperButton";
            this.selectViperButton.Size = new System.Drawing.Size(85, 85);
            this.selectViperButton.TabIndex = 23;
            this.selectViperButton.UseVisualStyleBackColor = true;
            this.selectViperButton.Click += new System.EventHandler(this.SelectViperButton_Click);
            // 
            // selectSovaButton
            // 
            this.selectSovaButton.Image = global::Autolocker.Properties.Resources.sova;
            this.selectSovaButton.Location = new System.Drawing.Point(672, 209);
            this.selectSovaButton.Name = "selectSovaButton";
            this.selectSovaButton.Size = new System.Drawing.Size(85, 85);
            this.selectSovaButton.TabIndex = 22;
            this.selectSovaButton.UseVisualStyleBackColor = true;
            this.selectSovaButton.Click += new System.EventHandler(this.SelectSovaButton_Click);
            // 
            // selectSkyeButton
            // 
            this.selectSkyeButton.Image = global::Autolocker.Properties.Resources.skye;
            this.selectSkyeButton.Location = new System.Drawing.Point(581, 209);
            this.selectSkyeButton.Name = "selectSkyeButton";
            this.selectSkyeButton.Size = new System.Drawing.Size(85, 85);
            this.selectSkyeButton.TabIndex = 21;
            this.selectSkyeButton.UseVisualStyleBackColor = true;
            this.selectSkyeButton.Click += new System.EventHandler(this.SelectSkyeButton_Click);
            // 
            // selectYoruButton
            // 
            this.selectYoruButton.Image = global::Autolocker.Properties.Resources.yoru;
            this.selectYoruButton.Location = new System.Drawing.Point(854, 209);
            this.selectYoruButton.Name = "selectYoruButton";
            this.selectYoruButton.Size = new System.Drawing.Size(85, 85);
            this.selectYoruButton.TabIndex = 24;
            this.selectYoruButton.UseVisualStyleBackColor = true;
            this.selectYoruButton.Click += new System.EventHandler(this.SelectYoruButton_Click);
            // 
            // selectedAgentLabel
            // 
            this.selectedAgentLabel.AutoSize = true;
            this.selectedAgentLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAgentLabel.Location = new System.Drawing.Point(420, 79);
            this.selectedAgentLabel.Name = "selectedAgentLabel";
            this.selectedAgentLabel.Size = new System.Drawing.Size(226, 27);
            this.selectedAgentLabel.TabIndex = 25;
            this.selectedAgentLabel.Text = "Selected agent: Jett";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 470);
            this.Controls.Add(this.selectedAgentLabel);
            this.Controls.Add(this.selectYoruButton);
            this.Controls.Add(this.selectSkyeButton);
            this.Controls.Add(this.selectSovaButton);
            this.Controls.Add(this.selectViperButton);
            this.Controls.Add(this.selectPhoenixButton);
            this.Controls.Add(this.selectRazeButton);
            this.Controls.Add(this.selectReynaButton);
            this.Controls.Add(this.selectSageButton);
            this.Controls.Add(this.selectJettButton);
            this.Controls.Add(this.selectKayoButton);
            this.Controls.Add(this.selectKilljoyButton);
            this.Controls.Add(this.selectNeonButton);
            this.Controls.Add(this.selectOmenButton);
            this.Controls.Add(this.selectFadeButton);
            this.Controls.Add(this.selectGekkoButton);
            this.Controls.Add(this.selectHarborButton);
            this.Controls.Add(this.selectBrimstoneButton);
            this.Controls.Add(this.selectCypherButton);
            this.Controls.Add(this.selectChamberButton);
            this.Controls.Add(this.selectBreachButton);
            this.Controls.Add(this.selectAstraButton);
            this.Controls.Add(this.activeKeybindButton);
            this.Controls.Add(this.randomKeybindButton);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.checkBoxRandomAgent);
            this.Icon = global::Autolocker.Properties.Resources.autolocker_valorant_64;
            this.Name = "Menu";
            this.Text = "Autolocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.CheckBox checkBoxRandomAgent;
        private Button randomKeybindButton;
        private Button activeKeybindButton;
        private Button selectAstraButton;
        private Button selectBreachButton;
        private Button selectChamberButton;
        private Button selectCypherButton;
        private Button selectBrimstoneButton;
        private Button selectHarborButton;
        private Button selectGekkoButton;
        private Button selectFadeButton;
        private Button selectOmenButton;
        private Button selectNeonButton;
        private Button selectKilljoyButton;
        private Button selectKayoButton;
        private Button selectJettButton;
        private Button selectSageButton;
        private Button selectReynaButton;
        private Button selectRazeButton;
        private Button selectPhoenixButton;
        private Button selectViperButton;
        private Button selectSovaButton;
        private Button selectSkyeButton;
        private Button selectYoruButton;
        private Label selectedAgentLabel;
    }
}

