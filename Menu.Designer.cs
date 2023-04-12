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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.agentPage = new System.Windows.Forms.TabPage();
            this.checkBoxUseConfig = new System.Windows.Forms.CheckBox();
            this.selectedAgentLabel = new System.Windows.Forms.Label();
            this.selectYoruButton = new System.Windows.Forms.Button();
            this.selectSkyeButton = new System.Windows.Forms.Button();
            this.selectSovaButton = new System.Windows.Forms.Button();
            this.selectViperButton = new System.Windows.Forms.Button();
            this.selectPhoenixButton = new System.Windows.Forms.Button();
            this.selectRazeButton = new System.Windows.Forms.Button();
            this.selectReynaButton = new System.Windows.Forms.Button();
            this.selectSageButton = new System.Windows.Forms.Button();
            this.selectJettButton = new System.Windows.Forms.Button();
            this.selectKayoButton = new System.Windows.Forms.Button();
            this.selectKilljoyButton = new System.Windows.Forms.Button();
            this.selectNeonButton = new System.Windows.Forms.Button();
            this.selectOmenButton = new System.Windows.Forms.Button();
            this.selectFadeButton = new System.Windows.Forms.Button();
            this.selectGekkoButton = new System.Windows.Forms.Button();
            this.selectHarborButton = new System.Windows.Forms.Button();
            this.selectBrimstoneButton = new System.Windows.Forms.Button();
            this.selectCypherButton = new System.Windows.Forms.Button();
            this.selectChamberButton = new System.Windows.Forms.Button();
            this.selectBreachButton = new System.Windows.Forms.Button();
            this.selectAstraButton = new System.Windows.Forms.Button();
            this.activeKeybindButton = new System.Windows.Forms.Button();
            this.randomKeybindButton = new System.Windows.Forms.Button();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomAgent = new System.Windows.Forms.CheckBox();
            this.configPage = new System.Windows.Forms.TabPage();
            this.havenConfigLabel = new System.Windows.Forms.Label();
            this.havenConfigDropdown = new System.Windows.Forms.ComboBox();
            this.splitConfigLabel = new System.Windows.Forms.Label();
            this.splitConfigDropdown = new System.Windows.Forms.ComboBox();
            this.pearlConfigLabel = new System.Windows.Forms.Label();
            this.pearlConfigDropdown = new System.Windows.Forms.ComboBox();
            this.lotusConfigLabel = new System.Windows.Forms.Label();
            this.lotusConfigDropdown = new System.Windows.Forms.ComboBox();
            this.iceboxConfigLabel = new System.Windows.Forms.Label();
            this.iceboxConfigDropdown = new System.Windows.Forms.ComboBox();
            this.fractureConfigLabel = new System.Windows.Forms.Label();
            this.fractureConfigDropdown = new System.Windows.Forms.ComboBox();
            this.breezeConfigLabel = new System.Windows.Forms.Label();
            this.breezeConfigDropdown = new System.Windows.Forms.ComboBox();
            this.bindConfigLabel = new System.Windows.Forms.Label();
            this.bindConfigDropdown = new System.Windows.Forms.ComboBox();
            this.ascentConfigLabel = new System.Windows.Forms.Label();
            this.ascentConfigDropdown = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.agentPage.SuspendLayout();
            this.configPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.agentPage);
            this.tabControl1.Controls.Add(this.configPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 470);
            this.tabControl1.TabIndex = 27;
            // 
            // agentPage
            // 
            this.agentPage.Controls.Add(this.checkBoxUseConfig);
            this.agentPage.Controls.Add(this.selectedAgentLabel);
            this.agentPage.Controls.Add(this.selectYoruButton);
            this.agentPage.Controls.Add(this.selectSkyeButton);
            this.agentPage.Controls.Add(this.selectSovaButton);
            this.agentPage.Controls.Add(this.selectViperButton);
            this.agentPage.Controls.Add(this.selectPhoenixButton);
            this.agentPage.Controls.Add(this.selectRazeButton);
            this.agentPage.Controls.Add(this.selectReynaButton);
            this.agentPage.Controls.Add(this.selectSageButton);
            this.agentPage.Controls.Add(this.selectJettButton);
            this.agentPage.Controls.Add(this.selectKayoButton);
            this.agentPage.Controls.Add(this.selectKilljoyButton);
            this.agentPage.Controls.Add(this.selectNeonButton);
            this.agentPage.Controls.Add(this.selectOmenButton);
            this.agentPage.Controls.Add(this.selectFadeButton);
            this.agentPage.Controls.Add(this.selectGekkoButton);
            this.agentPage.Controls.Add(this.selectHarborButton);
            this.agentPage.Controls.Add(this.selectBrimstoneButton);
            this.agentPage.Controls.Add(this.selectCypherButton);
            this.agentPage.Controls.Add(this.selectChamberButton);
            this.agentPage.Controls.Add(this.selectBreachButton);
            this.agentPage.Controls.Add(this.selectAstraButton);
            this.agentPage.Controls.Add(this.activeKeybindButton);
            this.agentPage.Controls.Add(this.randomKeybindButton);
            this.agentPage.Controls.Add(this.checkBoxActive);
            this.agentPage.Controls.Add(this.checkBoxRandomAgent);
            this.agentPage.Location = new System.Drawing.Point(4, 28);
            this.agentPage.Name = "agentPage";
            this.agentPage.Padding = new System.Windows.Forms.Padding(3);
            this.agentPage.Size = new System.Drawing.Size(1057, 438);
            this.agentPage.TabIndex = 0;
            this.agentPage.Text = "Agent Select";
            this.agentPage.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseConfig
            // 
            this.checkBoxUseConfig.AutoSize = true;
            this.checkBoxUseConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxUseConfig.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseConfig.Location = new System.Drawing.Point(440, 320);
            this.checkBoxUseConfig.Name = "checkBoxUseConfig";
            this.checkBoxUseConfig.Size = new System.Drawing.Size(146, 31);
            this.checkBoxUseConfig.TabIndex = 52;
            this.checkBoxUseConfig.Text = "use config";
            this.checkBoxUseConfig.UseVisualStyleBackColor = true;
            // 
            // selectedAgentLabel
            // 
            this.selectedAgentLabel.AutoSize = true;
            this.selectedAgentLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedAgentLabel.Location = new System.Drawing.Point(424, 22);
            this.selectedAgentLabel.Name = "selectedAgentLabel";
            this.selectedAgentLabel.Size = new System.Drawing.Size(226, 27);
            this.selectedAgentLabel.TabIndex = 51;
            this.selectedAgentLabel.Text = "Selected agent: Jett";
            // 
            // selectYoruButton
            // 
            this.selectYoruButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectYoruButton.Image = global::Autolocker.Properties.Resources.yoru;
            this.selectYoruButton.Location = new System.Drawing.Point(853, 153);
            this.selectYoruButton.Name = "selectYoruButton";
            this.selectYoruButton.Size = new System.Drawing.Size(85, 85);
            this.selectYoruButton.TabIndex = 50;
            this.selectYoruButton.UseVisualStyleBackColor = true;
            this.selectYoruButton.Click += new System.EventHandler(this.SelectYoruButton_Click);
            // 
            // selectSkyeButton
            // 
            this.selectSkyeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSkyeButton.Image = global::Autolocker.Properties.Resources.skye;
            this.selectSkyeButton.Location = new System.Drawing.Point(580, 153);
            this.selectSkyeButton.Name = "selectSkyeButton";
            this.selectSkyeButton.Size = new System.Drawing.Size(85, 85);
            this.selectSkyeButton.TabIndex = 47;
            this.selectSkyeButton.UseVisualStyleBackColor = true;
            this.selectSkyeButton.Click += new System.EventHandler(this.SelectSkyeButton_Click);
            // 
            // selectSovaButton
            // 
            this.selectSovaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSovaButton.Image = global::Autolocker.Properties.Resources.sova;
            this.selectSovaButton.Location = new System.Drawing.Point(671, 153);
            this.selectSovaButton.Name = "selectSovaButton";
            this.selectSovaButton.Size = new System.Drawing.Size(85, 85);
            this.selectSovaButton.TabIndex = 48;
            this.selectSovaButton.UseVisualStyleBackColor = true;
            this.selectSovaButton.Click += new System.EventHandler(this.SelectSovaButton_Click);
            // 
            // selectViperButton
            // 
            this.selectViperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectViperButton.Image = global::Autolocker.Properties.Resources.viper;
            this.selectViperButton.Location = new System.Drawing.Point(762, 153);
            this.selectViperButton.Name = "selectViperButton";
            this.selectViperButton.Size = new System.Drawing.Size(85, 85);
            this.selectViperButton.TabIndex = 49;
            this.selectViperButton.UseVisualStyleBackColor = true;
            this.selectViperButton.Click += new System.EventHandler(this.SelectViperButton_Click);
            // 
            // selectPhoenixButton
            // 
            this.selectPhoenixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPhoenixButton.Image = global::Autolocker.Properties.Resources.phoenix;
            this.selectPhoenixButton.Location = new System.Drawing.Point(214, 153);
            this.selectPhoenixButton.Name = "selectPhoenixButton";
            this.selectPhoenixButton.Size = new System.Drawing.Size(85, 85);
            this.selectPhoenixButton.TabIndex = 43;
            this.selectPhoenixButton.UseVisualStyleBackColor = true;
            this.selectPhoenixButton.Click += new System.EventHandler(this.SelectPhoenixButton_Click);
            // 
            // selectRazeButton
            // 
            this.selectRazeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectRazeButton.Image = global::Autolocker.Properties.Resources.raze;
            this.selectRazeButton.Location = new System.Drawing.Point(305, 153);
            this.selectRazeButton.Name = "selectRazeButton";
            this.selectRazeButton.Size = new System.Drawing.Size(85, 85);
            this.selectRazeButton.TabIndex = 44;
            this.selectRazeButton.UseVisualStyleBackColor = true;
            this.selectRazeButton.Click += new System.EventHandler(this.SelectRazeButton_Click);
            // 
            // selectReynaButton
            // 
            this.selectReynaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectReynaButton.Image = global::Autolocker.Properties.Resources.reyna;
            this.selectReynaButton.Location = new System.Drawing.Point(396, 153);
            this.selectReynaButton.Name = "selectReynaButton";
            this.selectReynaButton.Size = new System.Drawing.Size(85, 85);
            this.selectReynaButton.TabIndex = 45;
            this.selectReynaButton.UseVisualStyleBackColor = true;
            this.selectReynaButton.Click += new System.EventHandler(this.SelectReynaButton_Click);
            // 
            // selectSageButton
            // 
            this.selectSageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSageButton.Image = global::Autolocker.Properties.Resources.sage;
            this.selectSageButton.Location = new System.Drawing.Point(487, 153);
            this.selectSageButton.Name = "selectSageButton";
            this.selectSageButton.Size = new System.Drawing.Size(85, 85);
            this.selectSageButton.TabIndex = 46;
            this.selectSageButton.UseVisualStyleBackColor = true;
            this.selectSageButton.Click += new System.EventHandler(this.SelectSageButton_Click);
            // 
            // selectJettButton
            // 
            this.selectJettButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectJettButton.Image = global::Autolocker.Properties.Resources.jett;
            this.selectJettButton.Location = new System.Drawing.Point(762, 62);
            this.selectJettButton.Name = "selectJettButton";
            this.selectJettButton.Size = new System.Drawing.Size(85, 85);
            this.selectJettButton.TabIndex = 38;
            this.selectJettButton.UseVisualStyleBackColor = true;
            this.selectJettButton.Click += new System.EventHandler(this.SelectJettButton_Click);
            // 
            // selectKayoButton
            // 
            this.selectKayoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectKayoButton.Image = global::Autolocker.Properties.Resources.kayo;
            this.selectKayoButton.Location = new System.Drawing.Point(853, 62);
            this.selectKayoButton.Name = "selectKayoButton";
            this.selectKayoButton.Size = new System.Drawing.Size(85, 85);
            this.selectKayoButton.TabIndex = 39;
            this.selectKayoButton.UseVisualStyleBackColor = true;
            this.selectKayoButton.Click += new System.EventHandler(this.SelectKayoButton_Click);
            // 
            // selectKilljoyButton
            // 
            this.selectKilljoyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectKilljoyButton.Image = global::Autolocker.Properties.Resources.killjoy;
            this.selectKilljoyButton.Location = new System.Drawing.Point(944, 62);
            this.selectKilljoyButton.Name = "selectKilljoyButton";
            this.selectKilljoyButton.Size = new System.Drawing.Size(85, 85);
            this.selectKilljoyButton.TabIndex = 40;
            this.selectKilljoyButton.UseVisualStyleBackColor = true;
            this.selectKilljoyButton.Click += new System.EventHandler(this.SelectKilljoyButton_Click);
            // 
            // selectNeonButton
            // 
            this.selectNeonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectNeonButton.Image = global::Autolocker.Properties.Resources.neon;
            this.selectNeonButton.Location = new System.Drawing.Point(32, 153);
            this.selectNeonButton.Name = "selectNeonButton";
            this.selectNeonButton.Size = new System.Drawing.Size(85, 85);
            this.selectNeonButton.TabIndex = 41;
            this.selectNeonButton.UseVisualStyleBackColor = true;
            this.selectNeonButton.Click += new System.EventHandler(this.SelectNeonButton_Click);
            // 
            // selectOmenButton
            // 
            this.selectOmenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectOmenButton.Image = global::Autolocker.Properties.Resources.omen;
            this.selectOmenButton.Location = new System.Drawing.Point(123, 153);
            this.selectOmenButton.Name = "selectOmenButton";
            this.selectOmenButton.Size = new System.Drawing.Size(85, 85);
            this.selectOmenButton.TabIndex = 42;
            this.selectOmenButton.UseVisualStyleBackColor = true;
            this.selectOmenButton.Click += new System.EventHandler(this.SelectOmenButton_Click);
            // 
            // selectFadeButton
            // 
            this.selectFadeButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectFadeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFadeButton.Image = global::Autolocker.Properties.Resources.fade;
            this.selectFadeButton.Location = new System.Drawing.Point(487, 62);
            this.selectFadeButton.Name = "selectFadeButton";
            this.selectFadeButton.Size = new System.Drawing.Size(85, 85);
            this.selectFadeButton.TabIndex = 35;
            this.selectFadeButton.UseVisualStyleBackColor = false;
            this.selectFadeButton.Click += new System.EventHandler(this.SelectFadeButton_Click);
            // 
            // selectGekkoButton
            // 
            this.selectGekkoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectGekkoButton.Image = global::Autolocker.Properties.Resources.gekko;
            this.selectGekkoButton.Location = new System.Drawing.Point(580, 62);
            this.selectGekkoButton.Name = "selectGekkoButton";
            this.selectGekkoButton.Size = new System.Drawing.Size(85, 85);
            this.selectGekkoButton.TabIndex = 36;
            this.selectGekkoButton.UseVisualStyleBackColor = true;
            this.selectGekkoButton.Click += new System.EventHandler(this.SelectGekkoButton_Click);
            // 
            // selectHarborButton
            // 
            this.selectHarborButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectHarborButton.Image = global::Autolocker.Properties.Resources.harbor;
            this.selectHarborButton.Location = new System.Drawing.Point(671, 62);
            this.selectHarborButton.Name = "selectHarborButton";
            this.selectHarborButton.Size = new System.Drawing.Size(85, 85);
            this.selectHarborButton.TabIndex = 37;
            this.selectHarborButton.UseVisualStyleBackColor = true;
            this.selectHarborButton.Click += new System.EventHandler(this.SelectHarborButton_Click);
            // 
            // selectBrimstoneButton
            // 
            this.selectBrimstoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBrimstoneButton.Image = global::Autolocker.Properties.Resources.brimstone;
            this.selectBrimstoneButton.Location = new System.Drawing.Point(214, 62);
            this.selectBrimstoneButton.Name = "selectBrimstoneButton";
            this.selectBrimstoneButton.Size = new System.Drawing.Size(85, 85);
            this.selectBrimstoneButton.TabIndex = 32;
            this.selectBrimstoneButton.UseVisualStyleBackColor = true;
            this.selectBrimstoneButton.Click += new System.EventHandler(this.SelectBrimstoneButton_Click);
            // 
            // selectCypherButton
            // 
            this.selectCypherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectCypherButton.Image = global::Autolocker.Properties.Resources.cypher;
            this.selectCypherButton.Location = new System.Drawing.Point(396, 62);
            this.selectCypherButton.Name = "selectCypherButton";
            this.selectCypherButton.Size = new System.Drawing.Size(85, 85);
            this.selectCypherButton.TabIndex = 34;
            this.selectCypherButton.UseVisualStyleBackColor = true;
            this.selectCypherButton.Click += new System.EventHandler(this.SelectCypherButton_Click);
            // 
            // selectChamberButton
            // 
            this.selectChamberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectChamberButton.Image = global::Autolocker.Properties.Resources.chamber;
            this.selectChamberButton.Location = new System.Drawing.Point(305, 62);
            this.selectChamberButton.Name = "selectChamberButton";
            this.selectChamberButton.Size = new System.Drawing.Size(85, 85);
            this.selectChamberButton.TabIndex = 33;
            this.selectChamberButton.UseVisualStyleBackColor = true;
            this.selectChamberButton.Click += new System.EventHandler(this.SelectChamberButton_Click);
            // 
            // selectBreachButton
            // 
            this.selectBreachButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBreachButton.Image = global::Autolocker.Properties.Resources.breach;
            this.selectBreachButton.Location = new System.Drawing.Point(123, 62);
            this.selectBreachButton.Name = "selectBreachButton";
            this.selectBreachButton.Size = new System.Drawing.Size(85, 85);
            this.selectBreachButton.TabIndex = 31;
            this.selectBreachButton.UseVisualStyleBackColor = true;
            this.selectBreachButton.Click += new System.EventHandler(this.SelectBreachButton_Click);
            // 
            // selectAstraButton
            // 
            this.selectAstraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAstraButton.Image = global::Autolocker.Properties.Resources.astra;
            this.selectAstraButton.Location = new System.Drawing.Point(32, 62);
            this.selectAstraButton.Name = "selectAstraButton";
            this.selectAstraButton.Size = new System.Drawing.Size(85, 85);
            this.selectAstraButton.TabIndex = 30;
            this.selectAstraButton.UseVisualStyleBackColor = true;
            this.selectAstraButton.Click += new System.EventHandler(this.SelectAstraButton_Click);
            // 
            // activeKeybindButton
            // 
            this.activeKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.activeKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeKeybindButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeKeybindButton.Location = new System.Drawing.Point(564, 375);
            this.activeKeybindButton.Name = "activeKeybindButton";
            this.activeKeybindButton.Size = new System.Drawing.Size(70, 40);
            this.activeKeybindButton.TabIndex = 29;
            this.activeKeybindButton.Text = "[F8]";
            this.activeKeybindButton.UseVisualStyleBackColor = false;
            this.activeKeybindButton.Click += new System.EventHandler(this.ActiveKeybindButton_Click);
            // 
            // randomKeybindButton
            // 
            this.randomKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.randomKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomKeybindButton.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomKeybindButton.Location = new System.Drawing.Point(564, 258);
            this.randomKeybindButton.Name = "randomKeybindButton";
            this.randomKeybindButton.Size = new System.Drawing.Size(70, 40);
            this.randomKeybindButton.TabIndex = 28;
            this.randomKeybindButton.Text = "[F7]";
            this.randomKeybindButton.UseVisualStyleBackColor = false;
            this.randomKeybindButton.Click += new System.EventHandler(this.RandomKeybindButton_Click);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(440, 379);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(98, 31);
            this.checkBoxActive.TabIndex = 27;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.CheckBoxActive_CheckedChanged);
            // 
            // checkBoxRandomAgent
            // 
            this.checkBoxRandomAgent.AutoSize = true;
            this.checkBoxRandomAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRandomAgent.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRandomAgent.Location = new System.Drawing.Point(440, 262);
            this.checkBoxRandomAgent.Name = "checkBoxRandomAgent";
            this.checkBoxRandomAgent.Size = new System.Drawing.Size(118, 31);
            this.checkBoxRandomAgent.TabIndex = 26;
            this.checkBoxRandomAgent.Text = "random";
            this.checkBoxRandomAgent.UseVisualStyleBackColor = true;
            this.checkBoxRandomAgent.CheckedChanged += new System.EventHandler(this.CheckBoxRandomAgent_CheckedChanged);
            // 
            // configPage
            // 
            this.configPage.Controls.Add(this.havenConfigLabel);
            this.configPage.Controls.Add(this.havenConfigDropdown);
            this.configPage.Controls.Add(this.splitConfigLabel);
            this.configPage.Controls.Add(this.splitConfigDropdown);
            this.configPage.Controls.Add(this.pearlConfigLabel);
            this.configPage.Controls.Add(this.pearlConfigDropdown);
            this.configPage.Controls.Add(this.lotusConfigLabel);
            this.configPage.Controls.Add(this.lotusConfigDropdown);
            this.configPage.Controls.Add(this.iceboxConfigLabel);
            this.configPage.Controls.Add(this.iceboxConfigDropdown);
            this.configPage.Controls.Add(this.fractureConfigLabel);
            this.configPage.Controls.Add(this.fractureConfigDropdown);
            this.configPage.Controls.Add(this.breezeConfigLabel);
            this.configPage.Controls.Add(this.breezeConfigDropdown);
            this.configPage.Controls.Add(this.bindConfigLabel);
            this.configPage.Controls.Add(this.bindConfigDropdown);
            this.configPage.Controls.Add(this.ascentConfigLabel);
            this.configPage.Controls.Add(this.ascentConfigDropdown);
            this.configPage.Location = new System.Drawing.Point(4, 28);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(3);
            this.configPage.Size = new System.Drawing.Size(1057, 438);
            this.configPage.TabIndex = 1;
            this.configPage.Text = "Config";
            this.configPage.UseVisualStyleBackColor = true;
            // 
            // havenConfigLabel
            // 
            this.havenConfigLabel.AutoSize = true;
            this.havenConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.havenConfigLabel.Location = new System.Drawing.Point(154, 274);
            this.havenConfigLabel.Name = "havenConfigLabel";
            this.havenConfigLabel.Size = new System.Drawing.Size(63, 22);
            this.havenConfigLabel.TabIndex = 17;
            this.havenConfigLabel.Text = "Haven";
            // 
            // havenConfigDropdown
            // 
            this.havenConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.havenConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.havenConfigDropdown.FormattingEnabled = true;
            this.havenConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.havenConfigDropdown.Location = new System.Drawing.Point(244, 274);
            this.havenConfigDropdown.Name = "havenConfigDropdown";
            this.havenConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.havenConfigDropdown.TabIndex = 16;
            // 
            // splitConfigLabel
            // 
            this.splitConfigLabel.AutoSize = true;
            this.splitConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitConfigLabel.Location = new System.Drawing.Point(474, 224);
            this.splitConfigLabel.Name = "splitConfigLabel";
            this.splitConfigLabel.Size = new System.Drawing.Size(46, 22);
            this.splitConfigLabel.TabIndex = 15;
            this.splitConfigLabel.Text = "Split";
            // 
            // splitConfigDropdown
            // 
            this.splitConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.splitConfigDropdown.FormattingEnabled = true;
            this.splitConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.splitConfigDropdown.Location = new System.Drawing.Point(564, 224);
            this.splitConfigDropdown.Name = "splitConfigDropdown";
            this.splitConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.splitConfigDropdown.TabIndex = 14;
            // 
            // pearlConfigLabel
            // 
            this.pearlConfigLabel.AutoSize = true;
            this.pearlConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pearlConfigLabel.Location = new System.Drawing.Point(474, 174);
            this.pearlConfigLabel.Name = "pearlConfigLabel";
            this.pearlConfigLabel.Size = new System.Drawing.Size(52, 22);
            this.pearlConfigLabel.TabIndex = 13;
            this.pearlConfigLabel.Text = "Pearl";
            // 
            // pearlConfigDropdown
            // 
            this.pearlConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pearlConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pearlConfigDropdown.FormattingEnabled = true;
            this.pearlConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.pearlConfigDropdown.Location = new System.Drawing.Point(564, 174);
            this.pearlConfigDropdown.Name = "pearlConfigDropdown";
            this.pearlConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.pearlConfigDropdown.TabIndex = 12;
            // 
            // lotusConfigLabel
            // 
            this.lotusConfigLabel.AutoSize = true;
            this.lotusConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotusConfigLabel.Location = new System.Drawing.Point(474, 124);
            this.lotusConfigLabel.Name = "lotusConfigLabel";
            this.lotusConfigLabel.Size = new System.Drawing.Size(55, 22);
            this.lotusConfigLabel.TabIndex = 11;
            this.lotusConfigLabel.Text = "Lotus";
            // 
            // lotusConfigDropdown
            // 
            this.lotusConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lotusConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lotusConfigDropdown.FormattingEnabled = true;
            this.lotusConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.lotusConfigDropdown.Location = new System.Drawing.Point(564, 124);
            this.lotusConfigDropdown.Name = "lotusConfigDropdown";
            this.lotusConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.lotusConfigDropdown.TabIndex = 10;
            // 
            // iceboxConfigLabel
            // 
            this.iceboxConfigLabel.AutoSize = true;
            this.iceboxConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceboxConfigLabel.Location = new System.Drawing.Point(474, 74);
            this.iceboxConfigLabel.Name = "iceboxConfigLabel";
            this.iceboxConfigLabel.Size = new System.Drawing.Size(65, 22);
            this.iceboxConfigLabel.TabIndex = 9;
            this.iceboxConfigLabel.Text = "Icebox";
            // 
            // iceboxConfigDropdown
            // 
            this.iceboxConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iceboxConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iceboxConfigDropdown.FormattingEnabled = true;
            this.iceboxConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.iceboxConfigDropdown.Location = new System.Drawing.Point(564, 74);
            this.iceboxConfigDropdown.Name = "iceboxConfigDropdown";
            this.iceboxConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.iceboxConfigDropdown.TabIndex = 8;
            // 
            // fractureConfigLabel
            // 
            this.fractureConfigLabel.AutoSize = true;
            this.fractureConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fractureConfigLabel.Location = new System.Drawing.Point(154, 224);
            this.fractureConfigLabel.Name = "fractureConfigLabel";
            this.fractureConfigLabel.Size = new System.Drawing.Size(79, 22);
            this.fractureConfigLabel.TabIndex = 7;
            this.fractureConfigLabel.Text = "Fracture";
            // 
            // fractureConfigDropdown
            // 
            this.fractureConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fractureConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fractureConfigDropdown.FormattingEnabled = true;
            this.fractureConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.fractureConfigDropdown.Location = new System.Drawing.Point(244, 224);
            this.fractureConfigDropdown.Name = "fractureConfigDropdown";
            this.fractureConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.fractureConfigDropdown.TabIndex = 6;
            // 
            // breezeConfigLabel
            // 
            this.breezeConfigLabel.AutoSize = true;
            this.breezeConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breezeConfigLabel.Location = new System.Drawing.Point(154, 174);
            this.breezeConfigLabel.Name = "breezeConfigLabel";
            this.breezeConfigLabel.Size = new System.Drawing.Size(65, 22);
            this.breezeConfigLabel.TabIndex = 5;
            this.breezeConfigLabel.Text = "Breeze";
            // 
            // breezeConfigDropdown
            // 
            this.breezeConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breezeConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breezeConfigDropdown.FormattingEnabled = true;
            this.breezeConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.breezeConfigDropdown.Location = new System.Drawing.Point(244, 174);
            this.breezeConfigDropdown.Name = "breezeConfigDropdown";
            this.breezeConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.breezeConfigDropdown.TabIndex = 4;
            // 
            // bindConfigLabel
            // 
            this.bindConfigLabel.AutoSize = true;
            this.bindConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindConfigLabel.Location = new System.Drawing.Point(154, 124);
            this.bindConfigLabel.Name = "bindConfigLabel";
            this.bindConfigLabel.Size = new System.Drawing.Size(47, 22);
            this.bindConfigLabel.TabIndex = 3;
            this.bindConfigLabel.Text = "Bind";
            // 
            // bindConfigDropdown
            // 
            this.bindConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bindConfigDropdown.FormattingEnabled = true;
            this.bindConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.bindConfigDropdown.Location = new System.Drawing.Point(244, 124);
            this.bindConfigDropdown.Name = "bindConfigDropdown";
            this.bindConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.bindConfigDropdown.TabIndex = 2;
            // 
            // ascentConfigLabel
            // 
            this.ascentConfigLabel.AutoSize = true;
            this.ascentConfigLabel.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascentConfigLabel.Location = new System.Drawing.Point(154, 74);
            this.ascentConfigLabel.Name = "ascentConfigLabel";
            this.ascentConfigLabel.Size = new System.Drawing.Size(66, 22);
            this.ascentConfigLabel.TabIndex = 1;
            this.ascentConfigLabel.Text = "Ascent";
            // 
            // ascentConfigDropdown
            // 
            this.ascentConfigDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ascentConfigDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ascentConfigDropdown.FormattingEnabled = true;
            this.ascentConfigDropdown.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "Kayo",
            "Killjoy",
            "Neon",
            "Omen",
            "Phoenix",
            "Raze",
            "Reyna",
            "Sage",
            "Skye",
            "Sova",
            "Viper",
            "Yoru"});
            this.ascentConfigDropdown.Location = new System.Drawing.Point(244, 74);
            this.ascentConfigDropdown.Name = "ascentConfigDropdown";
            this.ascentConfigDropdown.Size = new System.Drawing.Size(121, 27);
            this.ascentConfigDropdown.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 470);
            this.Controls.Add(this.tabControl1);
            this.Icon = global::Autolocker.Properties.Resources.autolocker_valorant_64;
            this.Name = "Menu";
            this.Text = "Autolocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.agentPage.ResumeLayout(false);
            this.agentPage.PerformLayout();
            this.configPage.ResumeLayout(false);
            this.configPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage agentPage;
        private Label selectedAgentLabel;
        private Button selectYoruButton;
        private Button selectSkyeButton;
        private Button selectSovaButton;
        private Button selectViperButton;
        private Button selectPhoenixButton;
        private Button selectRazeButton;
        private Button selectReynaButton;
        private Button selectSageButton;
        private Button selectJettButton;
        private Button selectKayoButton;
        private Button selectKilljoyButton;
        private Button selectNeonButton;
        private Button selectOmenButton;
        private Button selectFadeButton;
        private Button selectGekkoButton;
        private Button selectHarborButton;
        private Button selectBrimstoneButton;
        private Button selectCypherButton;
        private Button selectChamberButton;
        private Button selectBreachButton;
        private Button selectAstraButton;
        private Button activeKeybindButton;
        private Button randomKeybindButton;
        private CheckBox checkBoxActive;
        private CheckBox checkBoxRandomAgent;
        private TabPage configPage;
        private ComboBox ascentConfigDropdown;
        private CheckBox checkBoxUseConfig;
        private Label ascentConfigLabel;
        private Label havenConfigLabel;
        private ComboBox havenConfigDropdown;
        private Label splitConfigLabel;
        private ComboBox splitConfigDropdown;
        private Label pearlConfigLabel;
        private ComboBox pearlConfigDropdown;
        private Label lotusConfigLabel;
        private ComboBox lotusConfigDropdown;
        private Label iceboxConfigLabel;
        private ComboBox iceboxConfigDropdown;
        private Label fractureConfigLabel;
        private ComboBox fractureConfigDropdown;
        private Label breezeConfigLabel;
        private ComboBox breezeConfigDropdown;
        private Label bindConfigLabel;
        private ComboBox bindConfigDropdown;
    }
}

