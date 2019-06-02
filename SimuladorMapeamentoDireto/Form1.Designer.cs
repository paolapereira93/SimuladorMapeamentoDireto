namespace SimuladorMapeamentoDireto
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
            this.cache = new System.Windows.Forms.ListBox();
            this.mainMemory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbProgress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cache
            // 
            this.cache.FormattingEnabled = true;
            this.cache.Location = new System.Drawing.Point(12, 48);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(227, 316);
            this.cache.TabIndex = 0;
            // 
            // mainMemory
            // 
            this.mainMemory.FormattingEnabled = true;
            this.mainMemory.Location = new System.Drawing.Point(259, 47);
            this.mainMemory.Name = "mainMemory";
            this.mainMemory.Size = new System.Drawing.Size(233, 433);
            this.mainMemory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accessing..:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(93, 382);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(25, 13);
            this.end.TabIndex = 3;
            this.end.Text = "end";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(24, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(24, 460);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(100, 20);
            this.tbProgress.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(135, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cache";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Main Memory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMemory);
            this.Controls.Add(this.cache);
            this.Name = "Form1";
            this.Text = "Direct Mapping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cache;
        private System.Windows.Forms.ListBox mainMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbProgress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

