
namespace a
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.AnketGB = new System.Windows.Forms.GroupBox();
            this.ElaveEtBtn = new System.Windows.Forms.Button();
            this.DeyisBtn = new System.Windows.Forms.Button();
            this.DogumTxb = new System.Windows.Forms.TextBox();
            this.TelTxb = new System.Windows.Forms.TextBox();
            this.EmailTxb = new System.Windows.Forms.TextBox();
            this.SoyadTxb = new System.Windows.Forms.TextBox();
            this.AdTxb = new System.Windows.Forms.TextBox();
            this.DogumLbl = new System.Windows.Forms.Label();
            this.TelLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.SoyadLbl = new System.Windows.Forms.Label();
            this.AdLbl = new System.Windows.Forms.Label();
            this._ = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.faylAdiBtn = new System.Windows.Forms.Button();
            this.AnketGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // AnketGB
            // 
            this.AnketGB.BackColor = System.Drawing.Color.White;
            this.AnketGB.Controls.Add(this.ElaveEtBtn);
            this.AnketGB.Controls.Add(this.DeyisBtn);
            this.AnketGB.Controls.Add(this.DogumTxb);
            this.AnketGB.Controls.Add(this.TelTxb);
            this.AnketGB.Controls.Add(this.EmailTxb);
            this.AnketGB.Controls.Add(this.SoyadTxb);
            this.AnketGB.Controls.Add(this.AdTxb);
            this.AnketGB.Controls.Add(this.DogumLbl);
            this.AnketGB.Controls.Add(this.TelLbl);
            this.AnketGB.Controls.Add(this.EmailLbl);
            this.AnketGB.Controls.Add(this.SoyadLbl);
            this.AnketGB.Controls.Add(this.AdLbl);
            this.AnketGB.Location = new System.Drawing.Point(69, 29);
            this.AnketGB.Name = "AnketGB";
            this.AnketGB.Size = new System.Drawing.Size(302, 272);
            this.AnketGB.TabIndex = 2;
            this.AnketGB.TabStop = false;
            this.AnketGB.Text = "Anket";
            // 
            // ElaveEtBtn
            // 
            this.ElaveEtBtn.Location = new System.Drawing.Point(206, 229);
            this.ElaveEtBtn.Name = "ElaveEtBtn";
            this.ElaveEtBtn.Size = new System.Drawing.Size(90, 29);
            this.ElaveEtBtn.TabIndex = 11;
            this.ElaveEtBtn.Text = "Elave et";
            this.ElaveEtBtn.UseVisualStyleBackColor = true;
            this.ElaveEtBtn.Click += new System.EventHandler(this.ElaveEtBtn_Click);
            // 
            // DeyisBtn
            // 
            this.DeyisBtn.Location = new System.Drawing.Point(206, 192);
            this.DeyisBtn.Name = "DeyisBtn";
            this.DeyisBtn.Size = new System.Drawing.Size(90, 31);
            this.DeyisBtn.TabIndex = 10;
            this.DeyisBtn.Text = "Deyis";
            this.DeyisBtn.UseVisualStyleBackColor = true;
            this.DeyisBtn.Click += new System.EventHandler(this.DeyisBtn_Click);
            // 
            // DogumTxb
            // 
            this.DogumTxb.Location = new System.Drawing.Point(88, 154);
            this.DogumTxb.Name = "DogumTxb";
            this.DogumTxb.Size = new System.Drawing.Size(152, 20);
            this.DogumTxb.TabIndex = 9;
            // 
            // TelTxb
            // 
            this.TelTxb.Location = new System.Drawing.Point(88, 123);
            this.TelTxb.Name = "TelTxb";
            this.TelTxb.Size = new System.Drawing.Size(152, 20);
            this.TelTxb.TabIndex = 8;
            // 
            // EmailTxb
            // 
            this.EmailTxb.Location = new System.Drawing.Point(88, 93);
            this.EmailTxb.Name = "EmailTxb";
            this.EmailTxb.Size = new System.Drawing.Size(152, 20);
            this.EmailTxb.TabIndex = 7;
            // 
            // SoyadTxb
            // 
            this.SoyadTxb.Location = new System.Drawing.Point(88, 62);
            this.SoyadTxb.Name = "SoyadTxb";
            this.SoyadTxb.Size = new System.Drawing.Size(152, 20);
            this.SoyadTxb.TabIndex = 6;
            // 
            // AdTxb
            // 
            this.AdTxb.Location = new System.Drawing.Point(88, 28);
            this.AdTxb.Name = "AdTxb";
            this.AdTxb.Size = new System.Drawing.Size(152, 20);
            this.AdTxb.TabIndex = 5;
            this.AdTxb.TextChanged += new System.EventHandler(this.AdTxb_TextChanged);
            // 
            // DogumLbl
            // 
            this.DogumLbl.AutoSize = true;
            this.DogumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogumLbl.Location = new System.Drawing.Point(18, 152);
            this.DogumLbl.Name = "DogumLbl";
            this.DogumLbl.Size = new System.Drawing.Size(61, 20);
            this.DogumLbl.TabIndex = 4;
            this.DogumLbl.Text = "Dogum";
            // 
            // TelLbl
            // 
            this.TelLbl.AutoSize = true;
            this.TelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelLbl.Location = new System.Drawing.Point(18, 121);
            this.TelLbl.Name = "TelLbl";
            this.TelLbl.Size = new System.Drawing.Size(30, 20);
            this.TelLbl.TabIndex = 3;
            this.TelLbl.Text = "Tel";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(18, 91);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // SoyadLbl
            // 
            this.SoyadLbl.AutoSize = true;
            this.SoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyadLbl.Location = new System.Drawing.Point(18, 60);
            this.SoyadLbl.Name = "SoyadLbl";
            this.SoyadLbl.Size = new System.Drawing.Size(54, 20);
            this.SoyadLbl.TabIndex = 1;
            this.SoyadLbl.Text = "Soyad";
            // 
            // AdLbl
            // 
            this.AdLbl.AutoSize = true;
            this.AdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLbl.Location = new System.Drawing.Point(18, 28);
            this.AdLbl.Name = "AdLbl";
            this.AdLbl.Size = new System.Drawing.Size(29, 20);
            this.AdLbl.TabIndex = 0;
            this.AdLbl.Text = "Ad";
            // 
            // _
            // 
            this._.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._.FormattingEnabled = true;
            this._.ItemHeight = 18;
            this._.Location = new System.Drawing.Point(425, 73);
            this._.Name = "_";
            this._.Size = new System.Drawing.Size(135, 166);
            this._.TabIndex = 3;
            this._.SelectedIndexChanged += new System.EventHandler(this._______ListBox________SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.LoadBtn);
            this.groupBox1.Controls.Add(this.faylAdiBtn);
            this.groupBox1.Controls.Add(this.AnketGB);
            this.groupBox1.Controls.Add(this._);
            this.groupBox1.Location = new System.Drawing.Point(58, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 334);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(425, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 33);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listbox";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(495, 278);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(65, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(425, 278);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(64, 23);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            // 
            // faylAdiBtn
            // 
            this.faylAdiBtn.Location = new System.Drawing.Point(425, 249);
            this.faylAdiBtn.Name = "faylAdiBtn";
            this.faylAdiBtn.Size = new System.Drawing.Size(135, 23);
            this.faylAdiBtn.TabIndex = 4;
            this.faylAdiBtn.Text = "Fayl Adi";
            this.faylAdiBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AnketGB.ResumeLayout(false);
            this.AnketGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox AnketGB;
        private System.Windows.Forms.Button ElaveEtBtn;
        private System.Windows.Forms.Button DeyisBtn;
        private System.Windows.Forms.TextBox DogumTxb;
        private System.Windows.Forms.TextBox TelTxb;
        private System.Windows.Forms.TextBox EmailTxb;
        private System.Windows.Forms.TextBox SoyadTxb;
        private System.Windows.Forms.TextBox AdTxb;
        private System.Windows.Forms.Label DogumLbl;
        private System.Windows.Forms.Label TelLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label SoyadLbl;
        private System.Windows.Forms.Label AdLbl;
        private System.Windows.Forms.ListBox _;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button faylAdiBtn;
    }
}

