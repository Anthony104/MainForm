namespace MainForm
{
    partial class ChannelDialog
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
            this.Folder = new System.Windows.Forms.Label();
            this.ChannelID = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.Label();
            this.LastUpdated = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Folder
            // 
            this.Folder.AutoSize = true;
            this.Folder.Location = new System.Drawing.Point(22, 44);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(39, 13);
            this.Folder.TabIndex = 0;
            this.Folder.Text = "Folder:";
            // 
            // ChannelID
            // 
            this.ChannelID.AutoSize = true;
            this.ChannelID.Location = new System.Drawing.Point(22, 95);
            this.ChannelID.Name = "ChannelID";
            this.ChannelID.Size = new System.Drawing.Size(60, 13);
            this.ChannelID.TabIndex = 1;
            this.ChannelID.Text = "Channel ID";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(22, 147);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(30, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title:";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(22, 201);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(32, 13);
            this.URL.TabIndex = 3;
            this.URL.Text = "URL:";
            // 
            // LastUpdated
            // 
            this.LastUpdated.AutoSize = true;
            this.LastUpdated.Location = new System.Drawing.Point(22, 252);
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Size = new System.Drawing.Size(74, 13);
            this.LastUpdated.TabIndex = 4;
            this.LastUpdated.Text = "Last Updated:";
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(176, 339);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 5;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(274, 339);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 11;
            // 
            // ChannelDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 384);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.LastUpdated);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ChannelID);
            this.Controls.Add(this.Folder);
            this.Name = "ChannelDialog";
            this.Text = "ChannelProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Folder;
        private System.Windows.Forms.Label ChannelID;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label LastUpdated;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}