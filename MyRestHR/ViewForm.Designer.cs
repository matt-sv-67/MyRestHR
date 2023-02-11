
namespace MyRestHR
{
    partial class ViewForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Headerlbl = new System.Windows.Forms.Label();
            this.extralbl = new System.Windows.Forms.Label();
            this.snrlbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.lastlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Paylbl = new System.Windows.Forms.Label();
            this.Firebtn = new System.Windows.Forms.Button();
            this.Firelbl = new System.Windows.Forms.Label();
            this.fillid = new System.Windows.Forms.Label();
            this.fillname = new System.Windows.Forms.Label();
            this.filllast = new System.Windows.Forms.Label();
            this.fillage = new System.Windows.Forms.Label();
            this.fillextra = new System.Windows.Forms.Label();
            this.fillpay = new System.Windows.Forms.Label();
            this.fillsnr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(1, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(336, 165);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "My\r\n   Little\r\n      Restaurant";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 675);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Headerlbl
            // 
            this.Headerlbl.AutoSize = true;
            this.Headerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Headerlbl.Location = new System.Drawing.Point(28, 192);
            this.Headerlbl.Name = "Headerlbl";
            this.Headerlbl.Size = new System.Drawing.Size(284, 25);
            this.Headerlbl.TabIndex = 9;
            this.Headerlbl.Text = "Choose employee to display";
            // 
            // extralbl
            // 
            this.extralbl.AutoSize = true;
            this.extralbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.extralbl.Location = new System.Drawing.Point(7, 528);
            this.extralbl.Name = "extralbl";
            this.extralbl.Size = new System.Drawing.Size(0, 25);
            this.extralbl.TabIndex = 16;
            this.extralbl.Click += new System.EventHandler(this.extralbl_Click);
            // 
            // snrlbl
            // 
            this.snrlbl.AutoSize = true;
            this.snrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.snrlbl.Location = new System.Drawing.Point(7, 473);
            this.snrlbl.Name = "snrlbl";
            this.snrlbl.Size = new System.Drawing.Size(104, 25);
            this.snrlbl.TabIndex = 15;
            this.snrlbl.Text = "Seniority:";
            this.snrlbl.Click += new System.EventHandler(this.snrlbl_Click);
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.agelbl.Location = new System.Drawing.Point(7, 418);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(58, 25);
            this.agelbl.TabIndex = 14;
            this.agelbl.Text = "Age:";
            this.agelbl.Click += new System.EventHandler(this.agelbl_Click);
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastlbl.Location = new System.Drawing.Point(7, 363);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(106, 25);
            this.lastlbl.TabIndex = 13;
            this.lastlbl.Text = "Surname:";
            this.lastlbl.Click += new System.EventHandler(this.lastlbl_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.namelbl.Location = new System.Drawing.Point(7, 308);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(75, 25);
            this.namelbl.TabIndex = 12;
            this.namelbl.Text = "Name:";
            this.namelbl.Click += new System.EventHandler(this.namelbl_Click);
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDlbl.Location = new System.Drawing.Point(7, 250);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(40, 25);
            this.IDlbl.TabIndex = 17;
            this.IDlbl.Text = "ID:";
            this.IDlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Paylbl
            // 
            this.Paylbl.AutoSize = true;
            this.Paylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Paylbl.Location = new System.Drawing.Point(7, 581);
            this.Paylbl.Name = "Paylbl";
            this.Paylbl.Size = new System.Drawing.Size(81, 25);
            this.Paylbl.TabIndex = 18;
            this.Paylbl.Text = "Salary:";
            // 
            // Firebtn
            // 
            this.Firebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Firebtn.BackgroundImage = global::MyRestHR.Properties.Resources.fired;
            this.Firebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Firebtn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firebtn.Location = new System.Drawing.Point(237, 645);
            this.Firebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Firebtn.Name = "Firebtn";
            this.Firebtn.Size = new System.Drawing.Size(100, 100);
            this.Firebtn.TabIndex = 19;
            this.Firebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Firebtn.UseVisualStyleBackColor = false;
            this.Firebtn.Click += new System.EventHandler(this.Firebtn_Click);
            // 
            // Firelbl
            // 
            this.Firelbl.AutoSize = true;
            this.Firelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Firelbl.Location = new System.Drawing.Point(244, 621);
            this.Firelbl.Name = "Firelbl";
            this.Firelbl.Size = new System.Drawing.Size(88, 25);
            this.Firelbl.TabIndex = 20;
            this.Firelbl.Text = "To Fire:";
            // 
            // fillid
            // 
            this.fillid.AutoSize = true;
            this.fillid.Location = new System.Drawing.Point(181, 257);
            this.fillid.Name = "fillid";
            this.fillid.Size = new System.Drawing.Size(0, 17);
            this.fillid.TabIndex = 21;
            // 
            // fillname
            // 
            this.fillname.AutoSize = true;
            this.fillname.Location = new System.Drawing.Point(184, 315);
            this.fillname.Name = "fillname";
            this.fillname.Size = new System.Drawing.Size(0, 17);
            this.fillname.TabIndex = 22;
            this.fillname.Click += new System.EventHandler(this.fillname_Click);
            // 
            // filllast
            // 
            this.filllast.AutoSize = true;
            this.filllast.Location = new System.Drawing.Point(184, 370);
            this.filllast.Name = "filllast";
            this.filllast.Size = new System.Drawing.Size(0, 17);
            this.filllast.TabIndex = 23;
            // 
            // fillage
            // 
            this.fillage.AutoSize = true;
            this.fillage.Location = new System.Drawing.Point(184, 425);
            this.fillage.Name = "fillage";
            this.fillage.Size = new System.Drawing.Size(0, 17);
            this.fillage.TabIndex = 24;
            // 
            // fillextra
            // 
            this.fillextra.AutoSize = true;
            this.fillextra.Location = new System.Drawing.Point(184, 535);
            this.fillextra.Name = "fillextra";
            this.fillextra.Size = new System.Drawing.Size(0, 17);
            this.fillextra.TabIndex = 26;
            // 
            // fillpay
            // 
            this.fillpay.AutoSize = true;
            this.fillpay.Location = new System.Drawing.Point(181, 588);
            this.fillpay.Name = "fillpay";
            this.fillpay.Size = new System.Drawing.Size(0, 17);
            this.fillpay.TabIndex = 27;
            // 
            // fillsnr
            // 
            this.fillsnr.AutoSize = true;
            this.fillsnr.Location = new System.Drawing.Point(184, 480);
            this.fillsnr.Name = "fillsnr";
            this.fillsnr.Size = new System.Drawing.Size(0, 17);
            this.fillsnr.TabIndex = 25;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(368, 800);
            this.ControlBox = false;
            this.Controls.Add(this.fillpay);
            this.Controls.Add(this.fillextra);
            this.Controls.Add(this.fillsnr);
            this.Controls.Add(this.fillage);
            this.Controls.Add(this.filllast);
            this.Controls.Add(this.fillname);
            this.Controls.Add(this.fillid);
            this.Controls.Add(this.Firelbl);
            this.Controls.Add(this.Firebtn);
            this.Controls.Add(this.Paylbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.extralbl);
            this.Controls.Add(this.snrlbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.Headerlbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Headerlbl;
        private System.Windows.Forms.Label extralbl;
        private System.Windows.Forms.Label snrlbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Paylbl;
        private System.Windows.Forms.Button Firebtn;
        private System.Windows.Forms.Label Firelbl;
        public System.Windows.Forms.Label fillid;
        public System.Windows.Forms.Label fillname;
        public System.Windows.Forms.Label filllast;
        public System.Windows.Forms.Label fillage;
        public System.Windows.Forms.Label fillextra;
        public System.Windows.Forms.Label fillpay;
        public System.Windows.Forms.Label fillsnr;
    }
}