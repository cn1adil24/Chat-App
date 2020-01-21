namespace ClientApp
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
            this.send_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.chat_window = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(12, 431);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(270, 115);
            this.message_box.TabIndex = 0;
            this.message_box.Enter += new System.EventHandler(this.message_box_Enter);
            this.message_box.Leave += new System.EventHandler(this.message_box_Leave);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(288, 431);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 40);
            this.send_button.TabIndex = 2;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(288, 486);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 41);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // chat_window
            // 
            this.chat_window.Location = new System.Drawing.Point(12, 12);
            this.chat_window.Multiline = true;
            this.chat_window.Name = "chat_window";
            this.chat_window.Size = new System.Drawing.Size(343, 402);
            this.chat_window.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 558);
            this.Controls.Add(this.chat_window);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_box);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox chat_window;
    }
}

