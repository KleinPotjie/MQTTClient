namespace MQTTClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUbsubscribe = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtTopicSubscribe = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUbsubscribe
            // 
            this.btnUbsubscribe.Location = new System.Drawing.Point(713, 12);
            this.btnUbsubscribe.Name = "btnUbsubscribe";
            this.btnUbsubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnUbsubscribe.TabIndex = 1;
            this.btnUbsubscribe.Text = "Unsubscribe";
            this.btnUbsubscribe.UseVisualStyleBackColor = true;
            this.btnUbsubscribe.Click += new System.EventHandler(this.btnUbsubscribe_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 390);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(776, 48);
            this.txtInfo.TabIndex = 2;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(632, 12);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 3;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtTopicSubscribe
            // 
            this.txtTopicSubscribe.Location = new System.Drawing.Point(12, 12);
            this.txtTopicSubscribe.Name = "txtTopicSubscribe";
            this.txtTopicSubscribe.Size = new System.Drawing.Size(614, 20);
            this.txtTopicSubscribe.TabIndex = 4;
            this.txtTopicSubscribe.Text = "vgdc/9524410/status";
            // 
            // txtReceived
            // 
            this.txtReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceived.Location = new System.Drawing.Point(12, 41);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(776, 340);
            this.txtReceived.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtTopicSubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnUbsubscribe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MQTT Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUbsubscribe;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtTopicSubscribe;
        private System.Windows.Forms.TextBox txtReceived;
    }
}

