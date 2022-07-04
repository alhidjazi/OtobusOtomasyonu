namespace OtobusOtomasyon
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
            this.components = new System.ComponentModel.Container();
            this.timergizle = new System.Windows.Forms.Timer(this.components);
            this.timergoster = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsistmegiris = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timergizle
            // 
            this.timergizle.Interval = 10;
            this.timergizle.Tick += new System.EventHandler(this.timergizle_Tick);
            // 
            // timergoster
            // 
            this.timergoster.Enabled = true;
            this.timergoster.Interval = 10;
            this.timergoster.Tick += new System.EventHandler(this.timergoster_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::OtobusOtomasyon.Properties.Resources.intoform;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnsistmegiris);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 300);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(3, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnsistmegiris
            // 
            this.btnsistmegiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsistmegiris.Location = new System.Drawing.Point(262, 258);
            this.btnsistmegiris.Name = "btnsistmegiris";
            this.btnsistmegiris.Size = new System.Drawing.Size(84, 38);
            this.btnsistmegiris.TabIndex = 1;
            this.btnsistmegiris.Text = "Sisteme Giriş";
            this.btnsistmegiris.UseVisualStyleBackColor = true;
            this.btnsistmegiris.Click += new System.EventHandler(this.btnsistmegiris_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 29);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timergizle;
        private System.Windows.Forms.Timer timergoster;
        private System.Windows.Forms.Button btnsistmegiris;
        private System.Windows.Forms.Button button1;
    }
}

