
namespace FirmStationary
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
            this.conbutton = new System.Windows.Forms.Button();
            this.conbox = new System.Windows.Forms.TextBox();
            this.allbutton = new System.Windows.Forms.Button();
            this.typebutton = new System.Windows.Forms.Button();
            this.mbutton = new System.Windows.Forms.Button();
            this.maxqbtn = new System.Windows.Forms.Button();
            this.minqbtn = new System.Windows.Forms.Button();
            this.maxpbtn = new System.Windows.Forms.Button();
            this.minpbutton = new System.Windows.Forms.Button();
            this.dataG = new System.Windows.Forms.DataGridView();
            this.ubutton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datebtn = new System.Windows.Forms.Button();
            this.avgbutton = new System.Windows.Forms.Button();
            this.ubutton2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ubutton3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // conbutton
            // 
            this.conbutton.Location = new System.Drawing.Point(26, 13);
            this.conbutton.Name = "conbutton";
            this.conbutton.Size = new System.Drawing.Size(75, 23);
            this.conbutton.TabIndex = 1;
            this.conbutton.Text = "Connection State";
            this.conbutton.UseVisualStyleBackColor = true;
            this.conbutton.Click += new System.EventHandler(this.conbutton_Click);
            // 
            // conbox
            // 
            this.conbox.Location = new System.Drawing.Point(115, 15);
            this.conbox.Name = "conbox";
            this.conbox.Size = new System.Drawing.Size(143, 20);
            this.conbox.TabIndex = 2;
            // 
            // allbutton
            // 
            this.allbutton.Location = new System.Drawing.Point(26, 43);
            this.allbutton.Name = "allbutton";
            this.allbutton.Size = new System.Drawing.Size(75, 23);
            this.allbutton.TabIndex = 3;
            this.allbutton.Text = "GetAll";
            this.allbutton.UseVisualStyleBackColor = true;
            this.allbutton.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // typebutton
            // 
            this.typebutton.Location = new System.Drawing.Point(107, 43);
            this.typebutton.Name = "typebutton";
            this.typebutton.Size = new System.Drawing.Size(61, 23);
            this.typebutton.TabIndex = 4;
            this.typebutton.Text = "Types";
            this.typebutton.UseVisualStyleBackColor = true;
            this.typebutton.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // mbutton
            // 
            this.mbutton.Location = new System.Drawing.Point(174, 43);
            this.mbutton.Name = "mbutton";
            this.mbutton.Size = new System.Drawing.Size(75, 23);
            this.mbutton.TabIndex = 5;
            this.mbutton.Text = "Managers";
            this.mbutton.UseVisualStyleBackColor = true;
            this.mbutton.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // maxqbtn
            // 
            this.maxqbtn.Location = new System.Drawing.Point(255, 43);
            this.maxqbtn.Name = "maxqbtn";
            this.maxqbtn.Size = new System.Drawing.Size(94, 23);
            this.maxqbtn.TabIndex = 6;
            this.maxqbtn.Text = "Max Quantity";
            this.maxqbtn.UseVisualStyleBackColor = true;
            this.maxqbtn.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // minqbtn
            // 
            this.minqbtn.Location = new System.Drawing.Point(355, 43);
            this.minqbtn.Name = "minqbtn";
            this.minqbtn.Size = new System.Drawing.Size(75, 23);
            this.minqbtn.TabIndex = 7;
            this.minqbtn.Text = "Min Quantity";
            this.minqbtn.UseVisualStyleBackColor = true;
            this.minqbtn.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // maxpbtn
            // 
            this.maxpbtn.Location = new System.Drawing.Point(436, 43);
            this.maxpbtn.Name = "maxpbtn";
            this.maxpbtn.Size = new System.Drawing.Size(75, 23);
            this.maxpbtn.TabIndex = 8;
            this.maxpbtn.Text = "Max Price";
            this.maxpbtn.UseVisualStyleBackColor = true;
            this.maxpbtn.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // minpbutton
            // 
            this.minpbutton.Location = new System.Drawing.Point(517, 43);
            this.minpbutton.Name = "minpbutton";
            this.minpbutton.Size = new System.Drawing.Size(75, 23);
            this.minpbutton.TabIndex = 9;
            this.minpbutton.Text = "Min Price";
            this.minpbutton.UseVisualStyleBackColor = true;
            this.minpbutton.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // dataG
            // 
            this.dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG.Location = new System.Drawing.Point(26, 133);
            this.dataG.Name = "dataG";
            this.dataG.Size = new System.Drawing.Size(566, 246);
            this.dataG.TabIndex = 10;
            // 
            // ubutton1
            // 
            this.ubutton1.Location = new System.Drawing.Point(174, 72);
            this.ubutton1.Name = "ubutton1";
            this.ubutton1.Size = new System.Drawing.Size(99, 23);
            this.ubutton1.TabIndex = 11;
            this.ubutton1.Text = "Products to type";
            this.ubutton1.UseVisualStyleBackColor = true;
            this.ubutton1.Click += new System.EventHandler(this.ubutton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // datebtn
            // 
            this.datebtn.Location = new System.Drawing.Point(26, 72);
            this.datebtn.Name = "datebtn";
            this.datebtn.Size = new System.Drawing.Size(75, 23);
            this.datebtn.TabIndex = 13;
            this.datebtn.Text = "Last Sale";
            this.datebtn.UseVisualStyleBackColor = true;
            this.datebtn.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // avgbutton
            // 
            this.avgbutton.Location = new System.Drawing.Point(107, 72);
            this.avgbutton.Name = "avgbutton";
            this.avgbutton.Size = new System.Drawing.Size(61, 23);
            this.avgbutton.TabIndex = 14;
            this.avgbutton.Text = "Average";
            this.avgbutton.UseVisualStyleBackColor = true;
            this.avgbutton.Click += new System.EventHandler(this.allbutton_Click);
            // 
            // ubutton2
            // 
            this.ubutton2.Location = new System.Drawing.Point(385, 72);
            this.ubutton2.Name = "ubutton2";
            this.ubutton2.Size = new System.Drawing.Size(109, 23);
            this.ubutton2.TabIndex = 15;
            this.ubutton2.Text = "Manager Sales";
            this.ubutton2.UseVisualStyleBackColor = true;
            this.ubutton2.Click += new System.EventHandler(this.ubutton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 16;
            // 
            // ubutton3
            // 
            this.ubutton3.Location = new System.Drawing.Point(26, 102);
            this.ubutton3.Name = "ubutton3";
            this.ubutton3.Size = new System.Drawing.Size(141, 23);
            this.ubutton3.TabIndex = 17;
            this.ubutton3.Text = "Company Purchases";
            this.ubutton3.UseVisualStyleBackColor = true;
            this.ubutton3.Click += new System.EventHandler(this.ubutton1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 391);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ubutton3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ubutton2);
            this.Controls.Add(this.avgbutton);
            this.Controls.Add(this.datebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ubutton1);
            this.Controls.Add(this.dataG);
            this.Controls.Add(this.minpbutton);
            this.Controls.Add(this.maxpbtn);
            this.Controls.Add(this.minqbtn);
            this.Controls.Add(this.maxqbtn);
            this.Controls.Add(this.mbutton);
            this.Controls.Add(this.typebutton);
            this.Controls.Add(this.allbutton);
            this.Controls.Add(this.conbox);
            this.Controls.Add(this.conbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button conbutton;
        private System.Windows.Forms.TextBox conbox;
        private System.Windows.Forms.Button allbutton;
        private System.Windows.Forms.Button typebutton;
        private System.Windows.Forms.Button mbutton;
        private System.Windows.Forms.Button maxqbtn;
        private System.Windows.Forms.Button minqbtn;
        private System.Windows.Forms.Button maxpbtn;
        private System.Windows.Forms.Button minpbutton;
        private System.Windows.Forms.DataGridView dataG;
        private System.Windows.Forms.Button ubutton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button datebtn;
        private System.Windows.Forms.Button avgbutton;
        private System.Windows.Forms.Button ubutton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ubutton3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

