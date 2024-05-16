namespace Lab3
{
    partial class Bai3
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
            this.btnTCP_Client = new System.Windows.Forms.Button();
            this.btnTCP_Server = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTCP_Client
            // 
            this.btnTCP_Client.Location = new System.Drawing.Point(74, 62);
            this.btnTCP_Client.Name = "btnTCP_Client";
            this.btnTCP_Client.Size = new System.Drawing.Size(200, 51);
            this.btnTCP_Client.TabIndex = 1;
            this.btnTCP_Client.Text = "TCP Client";
            this.btnTCP_Client.UseVisualStyleBackColor = true;
            this.btnTCP_Client.Click += new System.EventHandler(this.btnTCP_Client_Click);
            // 
            // btnTCP_Server
            // 
            this.btnTCP_Server.Location = new System.Drawing.Point(476, 62);
            this.btnTCP_Server.Name = "btnTCP_Server";
            this.btnTCP_Server.Size = new System.Drawing.Size(200, 51);
            this.btnTCP_Server.TabIndex = 2;
            this.btnTCP_Server.Text = "TCP Server";
            this.btnTCP_Server.UseVisualStyleBackColor = true;
            this.btnTCP_Server.Click += new System.EventHandler(this.btnTCP_Server_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(105, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(571, 164);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "B1:  Chọn TCP Server và bấm Listen\nB2:  Chọn TCP Client, nhập tên, bấm connect, s" +
    "au đó soạn tin nhắn và bấm send để gửi";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTCP_Server);
            this.Controls.Add(this.btnTCP_Client);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCP_Client;
        private System.Windows.Forms.Button btnTCP_Server;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}