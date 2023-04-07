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
            this.Icon = Properties.Resources.autolocker_valorant_64;

            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomAgent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Select agent dropdown menu
            // 
            this.comboBoxAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Items.AddRange(new object[] {
                "Astra","Breach","Brimstone","Chamber","Cypher","Fade","Gekko","Harbor","Jett","KAYO","Killjoy","Neon","Omen","Phoenix","Raze","Reyna","Sage","Skye","Sova","Viper","Yoru"
            });
            this.comboBoxAgents.Location = new System.Drawing.Point(138, 45);
            this.comboBoxAgents.Name = "comboBox1";
            this.comboBoxAgents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgents.TabIndex = 0;
            this.comboBoxAgents.SelectedIndex = 0;
            this.comboBoxAgents.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // Active checkbox
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(168, 120);
            this.checkBoxActive.Name = "checkBox1";
            this.checkBoxActive.Size = new System.Drawing.Size(55, 17);
            this.checkBoxActive.TabIndex = 1;
            this.checkBoxActive.Text = "active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += ActiveCheckBoxChanged;
            //
            // Randompick checkbox
            //
            this.checkBoxRandomAgent.AutoSize = true;
            this.checkBoxRandomAgent.Location = new System.Drawing.Point(168, 87);
            this.checkBoxRandomAgent.Name = "checkBox2";
            this.checkBoxRandomAgent.Size = new System.Drawing.Size(55, 17);
            this.checkBoxRandomAgent.TabIndex = 1;
            this.checkBoxRandomAgent.Text = "random agent";
            this.checkBoxRandomAgent.UseVisualStyleBackColor = true;


            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.checkBoxRandomAgent);
            this.Name = "Menu";
            this.Text = "Autolocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.CheckBox checkBoxRandomAgent;
    }
}

