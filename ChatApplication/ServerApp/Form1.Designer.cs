namespace ServerApp
{
    partial class Form1
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
            this.message_box = new System.Windows.Forms.TextBox();
            this.chat_window = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(12, 428);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(270, 115);
            this.message_box.TabIndex = 1;
            this.message_box.Enter += new System.EventHandler(this.message_box_Enter);
            this.message_box.Leave += new System.EventHandler(this.message_box_Leave);
            // 
            // chat_window
            // 
            this.chat_window.Location = new System.Drawing.Point(12, 12);
            this.chat_window.Multiline = true;
            this.chat_window.Name = "chat_window";
            this.chat_window.Size = new System.Drawing.Size(343, 402);
            this.chat_window.TabIndex = 5;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(288, 483);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 41);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(288, 428);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 40);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 555);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.chat_window);
            this.Controls.Add(this.message_box);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.TextBox chat_window;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button send_button;
    }
}

