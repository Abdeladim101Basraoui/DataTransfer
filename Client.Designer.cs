
namespace DataTransfer
{
    partial class Client
    {
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
            this.cbx_Port = new System.Windows.Forms.ComboBox();
            this.cbx_Host = new System.Windows.Forms.ComboBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_Msgs = new System.Windows.Forms.TextBox();
            this.txt_Message = new MetroFramework.Controls.MetroTextBox();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_con = new MetroFramework.Controls.MetroButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Port
            // 
            this.cbx_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Items.AddRange(new object[] {
            "9000"});
            this.cbx_Port.Location = new System.Drawing.Point(430, 52);
            this.cbx_Port.Name = "cbx_Port";
            this.cbx_Port.Size = new System.Drawing.Size(104, 21);
            this.cbx_Port.TabIndex = 11;
            // 
            // cbx_Host
            // 
            this.cbx_Host.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Host.FormattingEnabled = true;
            this.cbx_Host.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cbx_Host.Location = new System.Drawing.Point(176, 54);
            this.cbx_Host.Name = "cbx_Host";
            this.cbx_Host.Size = new System.Drawing.Size(169, 21);
            this.cbx_Host.TabIndex = 12;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(430, 79);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(90, 15);
            this.metroCheckBox2.TabIndex = 9;
            this.metroCheckBox2.Text = "Add My Port";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(176, 81);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(78, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "Add My IP";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(390, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Port";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Host Adresse";
            // 
            // txt_Msgs
            // 
            this.txt_Msgs.Enabled = false;
            this.txt_Msgs.Location = new System.Drawing.Point(20, 102);
            this.txt_Msgs.Multiline = true;
            this.txt_Msgs.Name = "txt_Msgs";
            this.txt_Msgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msgs.Size = new System.Drawing.Size(590, 250);
            this.txt_Msgs.TabIndex = 13;
            // 
            // txt_Message
            // 
            // 
            // 
            // 
            this.txt_Message.CustomButton.Image = null;
            this.txt_Message.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txt_Message.CustomButton.Name = "";
            this.txt_Message.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Message.CustomButton.TabIndex = 1;
            this.txt_Message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Message.CustomButton.UseSelectable = true;
            this.txt_Message.CustomButton.Visible = false;
            this.txt_Message.Lines = new string[0];
            this.txt_Message.Location = new System.Drawing.Point(20, 358);
            this.txt_Message.MaxLength = 32767;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.PasswordChar = '\0';
            this.txt_Message.PromptText = "Tiping Here Your Message ....";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Message.SelectedText = "";
            this.txt_Message.SelectionLength = 0;
            this.txt_Message.SelectionStart = 0;
            this.txt_Message.ShortcutsEnabled = true;
            this.txt_Message.Size = new System.Drawing.Size(369, 23);
            this.txt_Message.TabIndex = 14;
            this.txt_Message.UseSelectable = true;
            this.txt_Message.WaterMark = "Tiping Here Your Message ....";
            this.txt_Message.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Message.Click += new System.EventHandler(this.txt_Message_Click);
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(395, 358);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(83, 23);
            this.btn_send.TabIndex = 15;
            this.btn_send.Text = "Send";
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_state});
            this.statusStrip1.Location = new System.Drawing.Point(20, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_state
            // 
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_con
            // 
            this.btn_con.Location = new System.Drawing.Point(527, 358);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(83, 23);
            this.btn_con.TabIndex = 15;
            this.btn_con.Text = "Disconnected";
            this.btn_con.UseSelectable = true;
            this.btn_con.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 433);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_Msgs);
            this.Controls.Add(this.cbx_Port);
            this.Controls.Add(this.cbx_Host);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Port;
        private System.Windows.Forms.ComboBox cbx_Host;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_Msgs;
        private MetroFramework.Controls.MetroTextBox txt_Message;
        private MetroFramework.Controls.MetroButton btn_send;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_state;
        private MetroFramework.Controls.MetroButton btn_con;
    }
}