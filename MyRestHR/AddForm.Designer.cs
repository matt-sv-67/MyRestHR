
namespace MyRestHR
{
    partial class AddForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.lastlbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.snrlbl = new System.Windows.Forms.Label();
            this.extralbl = new System.Windows.Forms.Label();
            this.managerbtn = new System.Windows.Forms.RadioButton();
            this.barbtn = new System.Windows.Forms.RadioButton();
            this.waiterbtn = new System.Windows.Forms.RadioButton();
            this.nametext = new System.Windows.Forms.TextBox();
            this.lasttext = new System.Windows.Forms.TextBox();
            this.agetext = new System.Windows.Forms.TextBox();
            this.snrtext = new System.Windows.Forms.TextBox();
            this.extratext = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 675);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(1, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(336, 165);
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "My\r\n   Little\r\n      Restaurant";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.namelbl.Location = new System.Drawing.Point(7, 249);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(75, 25);
            this.namelbl.TabIndex = 7;
            this.namelbl.Text = "Name:";
            this.namelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastlbl.Location = new System.Drawing.Point(7, 304);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(106, 25);
            this.lastlbl.TabIndex = 8;
            this.lastlbl.Text = "Surname:";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.agelbl.Location = new System.Drawing.Point(7, 359);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(58, 25);
            this.agelbl.TabIndex = 9;
            this.agelbl.Text = "Age:";
            // 
            // snrlbl
            // 
            this.snrlbl.AutoSize = true;
            this.snrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.snrlbl.Location = new System.Drawing.Point(7, 414);
            this.snrlbl.Name = "snrlbl";
            this.snrlbl.Size = new System.Drawing.Size(104, 25);
            this.snrlbl.TabIndex = 10;
            this.snrlbl.Text = "Seniority:";
            // 
            // extralbl
            // 
            this.extralbl.AutoSize = true;
            this.extralbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.extralbl.Location = new System.Drawing.Point(7, 469);
            this.extralbl.Name = "extralbl";
            this.extralbl.Size = new System.Drawing.Size(0, 25);
            this.extralbl.TabIndex = 11;
            // 
            // managerbtn
            // 
            this.managerbtn.AutoSize = true;
            this.managerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.managerbtn.Location = new System.Drawing.Point(27, 192);
            this.managerbtn.Name = "managerbtn";
            this.managerbtn.Size = new System.Drawing.Size(106, 28);
            this.managerbtn.TabIndex = 12;
            this.managerbtn.TabStop = true;
            this.managerbtn.Text = "Manager";
            this.managerbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.managerbtn.UseVisualStyleBackColor = true;
            this.managerbtn.CheckedChanged += new System.EventHandler(this.managerbtn_CheckedChanged);
            // 
            // barbtn
            // 
            this.barbtn.AutoSize = true;
            this.barbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.barbtn.Location = new System.Drawing.Point(226, 192);
            this.barbtn.Name = "barbtn";
            this.barbtn.Size = new System.Drawing.Size(113, 28);
            this.barbtn.TabIndex = 13;
            this.barbtn.TabStop = true;
            this.barbtn.Text = "Bartender";
            this.barbtn.UseVisualStyleBackColor = true;
            this.barbtn.CheckedChanged += new System.EventHandler(this.barbtn_CheckedChanged);
            // 
            // waiterbtn
            // 
            this.waiterbtn.AutoSize = true;
            this.waiterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.waiterbtn.Location = new System.Drawing.Point(134, 192);
            this.waiterbtn.Name = "waiterbtn";
            this.waiterbtn.Size = new System.Drawing.Size(84, 28);
            this.waiterbtn.TabIndex = 14;
            this.waiterbtn.TabStop = true;
            this.waiterbtn.Text = "Waiter";
            this.waiterbtn.UseVisualStyleBackColor = true;
            this.waiterbtn.CheckedChanged += new System.EventHandler(this.waiterbtn_CheckedChanged);
            // 
            // nametext
            // 
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nametext.Location = new System.Drawing.Point(202, 248);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(145, 30);
            this.nametext.TabIndex = 15;
            // 
            // lasttext
            // 
            this.lasttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lasttext.Location = new System.Drawing.Point(202, 303);
            this.lasttext.Name = "lasttext";
            this.lasttext.Size = new System.Drawing.Size(145, 30);
            this.lasttext.TabIndex = 16;
            // 
            // agetext
            // 
            this.agetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.agetext.Location = new System.Drawing.Point(202, 358);
            this.agetext.Name = "agetext";
            this.agetext.Size = new System.Drawing.Size(145, 30);
            this.agetext.TabIndex = 17;
            // 
            // snrtext
            // 
            this.snrtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.snrtext.Location = new System.Drawing.Point(202, 413);
            this.snrtext.Name = "snrtext";
            this.snrtext.Size = new System.Drawing.Size(145, 30);
            this.snrtext.TabIndex = 18;
            // 
            // extratext
            // 
            this.extratext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.extratext.Location = new System.Drawing.Point(202, 468);
            this.extratext.Name = "extratext";
            this.extratext.Size = new System.Drawing.Size(145, 30);
            this.extratext.TabIndex = 19;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addbtn.Location = new System.Drawing.Point(100, 543);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(156, 59);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "Add Employee";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(368, 800);
            this.ControlBox = false;
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.extratext);
            this.Controls.Add(this.snrtext);
            this.Controls.Add(this.agetext);
            this.Controls.Add(this.lasttext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.waiterbtn);
            this.Controls.Add(this.barbtn);
            this.Controls.Add(this.managerbtn);
            this.Controls.Add(this.extralbl);
            this.Controls.Add(this.snrlbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label snrlbl;
        private System.Windows.Forms.Label extralbl;
        private System.Windows.Forms.RadioButton managerbtn;
        private System.Windows.Forms.RadioButton barbtn;
        private System.Windows.Forms.RadioButton waiterbtn;
        private System.Windows.Forms.TextBox lasttext;
        private System.Windows.Forms.TextBox agetext;
        private System.Windows.Forms.TextBox snrtext;
        private System.Windows.Forms.TextBox extratext;
        private System.Windows.Forms.Button addbtn;
        public System.Windows.Forms.TextBox nametext;
    }
}