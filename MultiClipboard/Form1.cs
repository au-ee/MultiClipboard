using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiClipboard
{
    public partial class MultiClip : Form
    {
        public MultiClip()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            this.Paste1.Click += new System.EventHandler(this.Paste_Click);
            this.Paste2.Click += new System.EventHandler(this.Paste_Click);
            this.Paste3.Click += new System.EventHandler(this.Paste_Click);
            this.Paste4.Click += new System.EventHandler(this.Paste_Click);
            this.Paste5.Click += new System.EventHandler(this.Paste_Click);
            this.Paste6.Click += new System.EventHandler(this.Paste_Click);

            this.Copy1.Click += new System.EventHandler(this.Copy_Click);
            this.Copy2.Click += new System.EventHandler(this.Copy_Click);
            this.Copy3.Click += new System.EventHandler(this.Copy_Click);
            this.Copy4.Click += new System.EventHandler(this.Copy_Click);
            this.Copy5.Click += new System.EventHandler(this.Copy_Click);
            this.Copy6.Click += new System.EventHandler(this.Copy_Click);

            this.Text1.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text2.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text3.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text4.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text5.TextChanged += new System.EventHandler(this.Text_TextChanged);
            this.Text6.TextChanged += new System.EventHandler(this.Text_TextChanged);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            var targetTextBox = FindTextboxWithSameIndex(sender);

            if (targetTextBox != null)
            {
                Paste(targetTextBox);
            }
        }

        private TextBox FindTextboxWithSameIndex(object sender)
        {
            TextBox targetTextBox = null;

            if (sender is Button b)
            {
                var m = Regex.Match(b.Name, @"(\d+)$");
                if (m.Groups.Count > 0)
                {
                    var number = m.Groups[0].Value;
                    var controls = this.Controls.Find($"Text{number}", true);

                    if (controls.FirstOrDefault(_ => _ is TextBox) is TextBox target)
                    {
                        targetTextBox = target;
                    }
                }
            }

            return targetTextBox;
        }

        private void Paste(TextBox box)
        {
            string newText = Clipboard.GetText(TextDataFormat.Text);
            newText = newText.Trim();

            if(RemoveLineBreaks.Checked)
            {
                newText = Regex.Replace(newText, @"[\r\n]", " ");
            }

            newText = Regex.Replace(newText, @"\s{2,} ", " ");

            if (box.Text != newText)
            {
                box.Text = newText;
            }

            Copy(box);
        }

        private void Copy(TextBox box)
        {
            if (box.Text != null)
            {
                Clipboard.SetText(box.Text, TextDataFormat.Text);
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            var targetTextBox = FindTextboxWithSameIndex(sender);

            if (targetTextBox != null)
            {
                Copy(targetTextBox);
            }
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox b)
            {
                Copy(b);
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            Paste(CurrentSystemClipboard);
        }

        private void CurrentSystemClipboard_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(CurrentSystemClipboard.Text, TextDataFormat.Text);
        }
    }
}
