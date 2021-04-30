
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbx_Port
            // 
            this.cbx_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Items.AddRange(new object[] {
            "9000"});
            this.cbx_Port.Location = new System.Drawing.Point(422, 63);
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
            this.cbx_Host.Location = new System.Drawing.Point(168, 65);
            this.cbx_Host.Name = "cbx_Host";
            this.cbx_Host.Size = new System.Drawing.Size(169, 21);
            this.cbx_Host.TabIndex = 12;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(422, 90);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(90, 15);
            this.metroCheckBox2.TabIndex = 9;
            this.metroCheckBox2.Text = "Add My Port";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(168, 92);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(78, 15);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "Add My IP";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(382, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Port";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(77, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Host Adresse";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(56, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(502, 250);
            this.textBox1.TabIndex = 13;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(372, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(56, 369);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Tiping Here Your Message ....";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(394, 23);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Tiping Here Your Message ....";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(475, 369);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(83, 23);
            this.btn_send.TabIndex = 15;
            this.btn_send.Text = "Send";
            this.btn_send.UseSelectable = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 433);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbx_Port);
            this.Controls.Add(this.cbx_Host);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btn_send;
    }
}