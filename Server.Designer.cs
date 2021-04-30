
namespace DataTransfer
{
    partial class Server
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.txt_Msgs = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_Host = new System.Windows.Forms.ComboBox();
            this.cbx_Port = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.taping_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Message = new MetroFramework.Controls.MetroTextBox();
            this.btn_Send = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(145, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Client IP";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(422, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Port";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(208, 132);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(78, 15);
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Add My IP";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // txt_Msgs
            // 
            // 
            // 
            // 
            this.txt_Msgs.CustomButton.Image = null;
            this.txt_Msgs.CustomButton.Location = new System.Drawing.Point(406, 1);
            this.txt_Msgs.CustomButton.Name = "";
            this.txt_Msgs.CustomButton.Size = new System.Drawing.Size(299, 299);
            this.txt_Msgs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Msgs.CustomButton.TabIndex = 1;
            this.txt_Msgs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Msgs.CustomButton.UseSelectable = true;
            this.txt_Msgs.CustomButton.Visible = false;
            this.txt_Msgs.Enabled = false;
            this.txt_Msgs.Lines = new string[0];
            this.txt_Msgs.Location = new System.Drawing.Point(32, 171);
            this.txt_Msgs.MaxLength = 32767;
            this.txt_Msgs.Multiline = true;
            this.txt_Msgs.Name = "txt_Msgs";
            this.txt_Msgs.PasswordChar = '\0';
            this.txt_Msgs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Msgs.SelectedText = "";
            this.txt_Msgs.SelectionLength = 0;
            this.txt_Msgs.SelectionStart = 0;
            this.txt_Msgs.ShortcutsEnabled = true;
            this.txt_Msgs.Size = new System.Drawing.Size(706, 203);
            this.txt_Msgs.TabIndex = 5;
            this.txt_Msgs.UseSelectable = true;
            this.txt_Msgs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Msgs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(462, 130);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(90, 15);
            this.metroCheckBox2.TabIndex = 2;
            this.metroCheckBox2.Text = "Add My Port";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // cbx_Host
            // 
            this.cbx_Host.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Host.FormattingEnabled = true;
            this.cbx_Host.Location = new System.Drawing.Point(208, 105);
            this.cbx_Host.Name = "cbx_Host";
            this.cbx_Host.Size = new System.Drawing.Size(169, 21);
            this.cbx_Host.TabIndex = 6;
            // 
            // cbx_Port
            // 
            this.cbx_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Location = new System.Drawing.Point(462, 103);
            this.cbx_Port.Name = "cbx_Port";
            this.cbx_Port.Size = new System.Drawing.Size(104, 21);
            this.cbx_Port.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_lbl,
            this.taping_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_lbl
            // 
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // taping_lbl
            // 
            this.taping_lbl.Name = "taping_lbl";
            this.taping_lbl.Size = new System.Drawing.Size(16, 17);
            this.taping_lbl.Text = "...";
            // 
            // txt_Message
            // 
            // 
            // 
            // 
            this.txt_Message.CustomButton.Image = null;
            this.txt_Message.CustomButton.Location = new System.Drawing.Point(560, 1);
            this.txt_Message.CustomButton.Name = "";
            this.txt_Message.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Message.CustomButton.TabIndex = 1;
            this.txt_Message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Message.CustomButton.UseSelectable = true;
            this.txt_Message.CustomButton.Visible = false;
            this.txt_Message.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_Message.Lines = new string[0];
            this.txt_Message.Location = new System.Drawing.Point(32, 380);
            this.txt_Message.MaxLength = 32767;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.PasswordChar = '\0';
            this.txt_Message.PromptText = "Tiping ...";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Message.SelectedText = "";
            this.txt_Message.SelectionLength = 0;
            this.txt_Message.SelectionStart = 0;
            this.txt_Message.ShortcutsEnabled = true;
            this.txt_Message.Size = new System.Drawing.Size(582, 23);
            this.txt_Message.TabIndex = 8;
            this.txt_Message.UseSelectable = true;
            this.txt_Message.WaterMark = "Tiping ...";
            this.txt_Message.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Message.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(636, 380);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(102, 23);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseSelectable = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.Location = new System.Drawing.Point(291, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(205, 41);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Server";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbx_Port);
            this.Controls.Add(this.cbx_Host);
            this.Controls.Add(this.txt_Msgs);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox txt_Msgs;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private System.Windows.Forms.ComboBox cbx_Host;
        private System.Windows.Forms.ComboBox cbx_Port;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_lbl;
        private System.Windows.Forms.ToolStripStatusLabel taping_lbl;
        private MetroFramework.Controls.MetroTextBox txt_Message;
        private MetroFramework.Controls.MetroButton btn_Send;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

