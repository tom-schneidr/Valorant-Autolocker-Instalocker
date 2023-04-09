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
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomAgent = new System.Windows.Forms.CheckBox();
            this.randomKeybindButton = new System.Windows.Forms.Button();
            this.activeKeybindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Items.AddRange(new object[] {
            "Astra",
            "Breach",
            "Brimstone",
            "Chamber",
            "Cypher",
            "Fade",
            "Gekko",
            "Harbor",
            "Jett",
            "KAYO",
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
            this.comboBoxAgents.Location = new System.Drawing.Point(138, 45);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgents.TabIndex = 0;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxActive.Location = new System.Drawing.Point(184, 120);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(55, 17);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.CheckBoxActive_CheckedChanged);
            // 
            // checkBoxRandomAgent
            // 
            this.checkBoxRandomAgent.AutoSize = true;
            this.checkBoxRandomAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRandomAgent.Location = new System.Drawing.Point(184, 91);
            this.checkBoxRandomAgent.Name = "checkBoxRandomAgent";
            this.checkBoxRandomAgent.Size = new System.Drawing.Size(61, 17);
            this.checkBoxRandomAgent.TabIndex = 1;
            this.checkBoxRandomAgent.Text = "random";
            this.checkBoxRandomAgent.UseVisualStyleBackColor = true;
            this.checkBoxRandomAgent.CheckedChanged += new System.EventHandler(this.CheckBoxRandomAgent_CheckedChanged);
            // 
            // randomKeybindButton
            // 
            this.randomKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.randomKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomKeybindButton.Location = new System.Drawing.Point(138, 87);
            this.randomKeybindButton.Name = "randomKeybindButton";
            this.randomKeybindButton.Size = new System.Drawing.Size(40, 23);
            this.randomKeybindButton.TabIndex = 2;
            this.randomKeybindButton.Text = "[F7]";
            this.randomKeybindButton.UseVisualStyleBackColor = false;
            this.randomKeybindButton.Click += new System.EventHandler(this.RandomKeybindButton_Click);
            // 
            // activeKeybindButton
            // 
            this.activeKeybindButton.BackColor = System.Drawing.Color.Transparent;
            this.activeKeybindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeKeybindButton.Location = new System.Drawing.Point(138, 116);
            this.activeKeybindButton.Name = "activeKeybindButton";
            this.activeKeybindButton.Size = new System.Drawing.Size(40, 23);
            this.activeKeybindButton.TabIndex = 3;
            this.activeKeybindButton.Text = "[F8]";
            this.activeKeybindButton.UseVisualStyleBackColor = false;
            this.activeKeybindButton.Click += new System.EventHandler(this.ActiveKeybindButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.activeKeybindButton);
            this.Controls.Add(this.randomKeybindButton);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.checkBoxRandomAgent);
            this.Icon = global::Autolocker.Properties.Resources.autolocker_valorant_64;
            this.Name = "Menu";
            this.Text = "Autolocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.CheckBox checkBoxRandomAgent;
        private Button randomKeybindButton;
        private Button activeKeybindButton;
    }
}

