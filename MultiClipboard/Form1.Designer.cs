namespace MultiClipboard
{
    partial class MultiClip
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
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Paste1 = new System.Windows.Forms.Button();
            this.Copy1 = new System.Windows.Forms.Button();
            this.CurrentSystemClipboard = new System.Windows.Forms.TextBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.Copy2 = new System.Windows.Forms.Button();
            this.Paste2 = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Copy3 = new System.Windows.Forms.Button();
            this.Paste3 = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Copy4 = new System.Windows.Forms.Button();
            this.Paste4 = new System.Windows.Forms.Button();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.Copy5 = new System.Windows.Forms.Button();
            this.Paste5 = new System.Windows.Forms.Button();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.Copy6 = new System.Windows.Forms.Button();
            this.Paste6 = new System.Windows.Forms.Button();
            this.Text6 = new System.Windows.Forms.TextBox();
            this.RemoveLineBreaks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text1.Location = new System.Drawing.Point(57, 15);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(171, 20);
            this.Text1.TabIndex = 0;
            // 
            // Paste1
            // 
            this.Paste1.Location = new System.Drawing.Point(13, 13);
            this.Paste1.Name = "Paste1";
            this.Paste1.Size = new System.Drawing.Size(38, 23);
            this.Paste1.TabIndex = 1;
            this.Paste1.Text = "📋➡️";
            this.Paste1.UseVisualStyleBackColor = true;
            // 
            // Copy1
            // 
            this.Copy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy1.Location = new System.Drawing.Point(234, 13);
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(38, 23);
            this.Copy1.TabIndex = 2;
            this.Copy1.Text = "➡️📋";
            this.Copy1.UseVisualStyleBackColor = true;
            // 
            // CurrentSystemClipboard
            // 
            this.CurrentSystemClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSystemClipboard.Location = new System.Drawing.Point(13, 229);
            this.CurrentSystemClipboard.Name = "CurrentSystemClipboard";
            this.CurrentSystemClipboard.Size = new System.Drawing.Size(259, 20);
            this.CurrentSystemClipboard.TabIndex = 3;
            this.CurrentSystemClipboard.TextChanged += new System.EventHandler(this.CurrentSystemClipboard_TextChanged);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // Copy2
            // 
            this.Copy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy2.Location = new System.Drawing.Point(234, 40);
            this.Copy2.Name = "Copy2";
            this.Copy2.Size = new System.Drawing.Size(38, 23);
            this.Copy2.TabIndex = 6;
            this.Copy2.Text = "➡️📋";
            this.Copy2.UseVisualStyleBackColor = true;
            // 
            // Paste2
            // 
            this.Paste2.Location = new System.Drawing.Point(13, 40);
            this.Paste2.Name = "Paste2";
            this.Paste2.Size = new System.Drawing.Size(38, 23);
            this.Paste2.TabIndex = 5;
            this.Paste2.Text = "📋➡️";
            this.Paste2.UseVisualStyleBackColor = true;
            // 
            // Text2
            // 
            this.Text2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text2.Location = new System.Drawing.Point(57, 42);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(171, 20);
            this.Text2.TabIndex = 4;
            // 
            // Copy3
            // 
            this.Copy3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy3.Location = new System.Drawing.Point(234, 67);
            this.Copy3.Name = "Copy3";
            this.Copy3.Size = new System.Drawing.Size(38, 23);
            this.Copy3.TabIndex = 9;
            this.Copy3.Text = "➡️📋";
            this.Copy3.UseVisualStyleBackColor = true;
            // 
            // Paste3
            // 
            this.Paste3.Location = new System.Drawing.Point(13, 67);
            this.Paste3.Name = "Paste3";
            this.Paste3.Size = new System.Drawing.Size(38, 23);
            this.Paste3.TabIndex = 8;
            this.Paste3.Text = "📋➡️";
            this.Paste3.UseVisualStyleBackColor = true;
            // 
            // Text3
            // 
            this.Text3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text3.Location = new System.Drawing.Point(57, 69);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(171, 20);
            this.Text3.TabIndex = 7;
            // 
            // Copy4
            // 
            this.Copy4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy4.Location = new System.Drawing.Point(234, 93);
            this.Copy4.Name = "Copy4";
            this.Copy4.Size = new System.Drawing.Size(38, 23);
            this.Copy4.TabIndex = 12;
            this.Copy4.Text = "➡️📋";
            this.Copy4.UseVisualStyleBackColor = true;
            // 
            // Paste4
            // 
            this.Paste4.Location = new System.Drawing.Point(13, 93);
            this.Paste4.Name = "Paste4";
            this.Paste4.Size = new System.Drawing.Size(38, 23);
            this.Paste4.TabIndex = 11;
            this.Paste4.Text = "📋➡️";
            this.Paste4.UseVisualStyleBackColor = true;
            // 
            // Text4
            // 
            this.Text4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text4.Location = new System.Drawing.Point(57, 95);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(171, 20);
            this.Text4.TabIndex = 10;
            // 
            // Copy5
            // 
            this.Copy5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy5.Location = new System.Drawing.Point(234, 119);
            this.Copy5.Name = "Copy5";
            this.Copy5.Size = new System.Drawing.Size(38, 23);
            this.Copy5.TabIndex = 15;
            this.Copy5.Text = "➡️📋";
            this.Copy5.UseVisualStyleBackColor = true;
            // 
            // Paste5
            // 
            this.Paste5.Location = new System.Drawing.Point(13, 119);
            this.Paste5.Name = "Paste5";
            this.Paste5.Size = new System.Drawing.Size(38, 23);
            this.Paste5.TabIndex = 14;
            this.Paste5.Text = "📋➡️";
            this.Paste5.UseVisualStyleBackColor = true;
            // 
            // Text5
            // 
            this.Text5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text5.Location = new System.Drawing.Point(57, 121);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(171, 20);
            this.Text5.TabIndex = 13;
            // 
            // Copy6
            // 
            this.Copy6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Copy6.Location = new System.Drawing.Point(234, 146);
            this.Copy6.Name = "Copy6";
            this.Copy6.Size = new System.Drawing.Size(38, 23);
            this.Copy6.TabIndex = 18;
            this.Copy6.Text = "➡️📋";
            this.Copy6.UseVisualStyleBackColor = true;
            // 
            // Paste6
            // 
            this.Paste6.Location = new System.Drawing.Point(13, 146);
            this.Paste6.Name = "Paste6";
            this.Paste6.Size = new System.Drawing.Size(38, 23);
            this.Paste6.TabIndex = 17;
            this.Paste6.Text = "📋➡️";
            this.Paste6.UseVisualStyleBackColor = true;
            // 
            // Text6
            // 
            this.Text6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text6.Location = new System.Drawing.Point(57, 148);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(171, 20);
            this.Text6.TabIndex = 16;
            // 
            // RemoveLineBreaks
            // 
            this.RemoveLineBreaks.AutoSize = true;
            this.RemoveLineBreaks.Location = new System.Drawing.Point(13, 176);
            this.RemoveLineBreaks.Name = "RemoveLineBreaks";
            this.RemoveLineBreaks.Size = new System.Drawing.Size(125, 17);
            this.RemoveLineBreaks.TabIndex = 19;
            this.RemoveLineBreaks.Text = "Remove Line Breaks";
            this.RemoveLineBreaks.UseVisualStyleBackColor = true;
            // 
            // MultiClip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RemoveLineBreaks);
            this.Controls.Add(this.Copy6);
            this.Controls.Add(this.Paste6);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.Copy5);
            this.Controls.Add(this.Paste5);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.Copy4);
            this.Controls.Add(this.Paste4);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Copy3);
            this.Controls.Add(this.Paste3);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Copy2);
            this.Controls.Add(this.Paste2);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.CurrentSystemClipboard);
            this.Controls.Add(this.Copy1);
            this.Controls.Add(this.Paste1);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MultiClip";
            this.Text = "MultiClipboard";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Button Paste1;
        private System.Windows.Forms.Button Copy1;
        private System.Windows.Forms.TextBox CurrentSystemClipboard;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button Copy2;
        private System.Windows.Forms.Button Paste2;
        private System.Windows.Forms.TextBox Text2;
        private System.Windows.Forms.Button Copy3;
        private System.Windows.Forms.Button Paste3;
        private System.Windows.Forms.TextBox Text3;
        private System.Windows.Forms.Button Copy4;
        private System.Windows.Forms.Button Paste4;
        private System.Windows.Forms.TextBox Text4;
        private System.Windows.Forms.Button Copy5;
        private System.Windows.Forms.Button Paste5;
        private System.Windows.Forms.TextBox Text5;
        private System.Windows.Forms.Button Copy6;
        private System.Windows.Forms.Button Paste6;
        private System.Windows.Forms.TextBox Text6;
        private System.Windows.Forms.CheckBox RemoveLineBreaks;
    }
}

