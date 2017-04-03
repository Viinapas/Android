namespace WaSkiJump
{
    partial class MainForm1
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
            this.TailWindchb = new System.Windows.Forms.CheckBox();
            this.BtnStartJump = new System.Windows.Forms.Button();
            this.Windchb1 = new System.Windows.Forms.CheckBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SkiJumpreTxb = new System.Windows.Forms.TextBox();
            this.paaMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaUusiSivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numMatka = new System.Windows.Forms.NumericUpDown();
            this.Hdwindchb = new System.Windows.Forms.CheckBox();
            this.JudgPointsTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.Label();
            this.LenghtTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OverallTxb = new System.Windows.Forms.TextBox();
            this.paaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatka)).BeginInit();
            this.SuspendLayout();
            // 
            // TailWindchb
            // 
            this.TailWindchb.AutoSize = true;
            this.TailWindchb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailWindchb.Location = new System.Drawing.Point(12, 305);
            this.TailWindchb.Name = "TailWindchb";
            this.TailWindchb.Size = new System.Drawing.Size(113, 28);
            this.TailWindchb.TabIndex = 0;
            this.TailWindchb.Text = "Tail wind";
            this.TailWindchb.UseVisualStyleBackColor = true;
            // 
            // BtnStartJump
            // 
            this.BtnStartJump.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnStartJump.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartJump.Location = new System.Drawing.Point(623, 103);
            this.BtnStartJump.Name = "BtnStartJump";
            this.BtnStartJump.Size = new System.Drawing.Size(203, 110);
            this.BtnStartJump.TabIndex = 1;
            this.BtnStartJump.Text = "START";
            this.BtnStartJump.UseVisualStyleBackColor = false;
            this.BtnStartJump.Click += new System.EventHandler(this.BtnStartJump_Click);
            // 
            // Windchb1
            // 
            this.Windchb1.AutoSize = true;
            this.Windchb1.Location = new System.Drawing.Point(15, 264);
            this.Windchb1.Name = "Windchb1";
            this.Windchb1.Size = new System.Drawing.Size(90, 17);
            this.Windchb1.TabIndex = 2;
            this.Windchb1.Text = "Wind change";
            this.Windchb1.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(228, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(365, 37);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "SKI JUMP score points";
            // 
            // SkiJumpreTxb
            // 
            this.SkiJumpreTxb.Location = new System.Drawing.Point(238, 305);
            this.SkiJumpreTxb.Multiline = true;
            this.SkiJumpreTxb.Name = "SkiJumpreTxb";
            this.SkiJumpreTxb.Size = new System.Drawing.Size(588, 243);
            this.SkiJumpreTxb.TabIndex = 4;
            this.SkiJumpreTxb.TextChanged += new System.EventHandler(this.SkiJumpreTxb_TextChanged);
            // 
            // paaMenu
            // 
            this.paaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.paaMenu.Location = new System.Drawing.Point(0, 0);
            this.paaMenu.Name = "paaMenu";
            this.paaMenu.Size = new System.Drawing.Size(924, 26);
            this.paaMenu.TabIndex = 9;
            this.paaMenu.Text = "Menu";
            // 
            // MainMenuToolStripMenuItem
            // 
            this.MainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaaUusiSivuToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MainMenuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
            this.MainMenuToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.MainMenuToolStripMenuItem.Text = "File";
            // 
            // avaaUusiSivuToolStripMenuItem
            // 
            this.avaaUusiSivuToolStripMenuItem.Name = "avaaUusiSivuToolStripMenuItem";
            this.avaaUusiSivuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avaaUusiSivuToolStripMenuItem.Text = "Result";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(135, 78);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(146, 20);
            this.NametextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wind";
            // 
            // numMatka
            // 
            this.numMatka.Location = new System.Drawing.Point(12, 393);
            this.numMatka.Name = "numMatka";
            this.numMatka.Size = new System.Drawing.Size(175, 20);
            this.numMatka.TabIndex = 13;
            // 
            // Hdwindchb
            // 
            this.Hdwindchb.AutoSize = true;
            this.Hdwindchb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hdwindchb.Location = new System.Drawing.Point(12, 339);
            this.Hdwindchb.Name = "Hdwindchb";
            this.Hdwindchb.Size = new System.Drawing.Size(129, 28);
            this.Hdwindchb.TabIndex = 14;
            this.Hdwindchb.Text = "Head wind";
            this.Hdwindchb.UseVisualStyleBackColor = true;
            // 
            // JudgPointsTxb
            // 
            this.JudgPointsTxb.Location = new System.Drawing.Point(135, 153);
            this.JudgPointsTxb.Name = "JudgPointsTxb";
            this.JudgPointsTxb.Size = new System.Drawing.Size(146, 20);
            this.JudgPointsTxb.TabIndex = 15;
            this.JudgPointsTxb.TextChanged += new System.EventHandler(this.JudgPointsTxb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Judge Points";
            // 
            // Lenght
            // 
            this.Lenght.AutoSize = true;
            this.Lenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lenght.Location = new System.Drawing.Point(8, 118);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(65, 20);
            this.Lenght.TabIndex = 17;
            this.Lenght.Text = "Lenght";
            // 
            // LenghtTxb
            // 
            this.LenghtTxb.Location = new System.Drawing.Point(135, 118);
            this.LenghtTxb.Name = "LenghtTxb";
            this.LenghtTxb.Size = new System.Drawing.Size(146, 20);
            this.LenghtTxb.TabIndex = 18;
            this.LenghtTxb.TextChanged += new System.EventHandler(this.LenghtTxb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Overall";
            // 
            // OverallTxb
            // 
            this.OverallTxb.Location = new System.Drawing.Point(135, 204);
            this.OverallTxb.Name = "OverallTxb";
            this.OverallTxb.Size = new System.Drawing.Size(146, 20);
            this.OverallTxb.TabIndex = 20;
            this.OverallTxb.TextChanged += new System.EventHandler(this.OverallTxb_TextChanged);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WaSkiJump.Properties.Resources.winter_260817_960_720;
            this.ClientSize = new System.Drawing.Size(924, 580);
            this.Controls.Add(this.OverallTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LenghtTxb);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JudgPointsTxb);
            this.Controls.Add(this.Hdwindchb);
            this.Controls.Add(this.numMatka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paaMenu);
            this.Controls.Add(this.SkiJumpreTxb);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.Windchb1);
            this.Controls.Add(this.BtnStartJump);
            this.Controls.Add(this.TailWindchb);
            this.Name = "MainForm1";
            this.Text = "SKI JUMP LAHTI2017";
            this.paaMenu.ResumeLayout(false);
            this.paaMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMatka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TailWindchb;
        private System.Windows.Forms.Button BtnStartJump;
        private System.Windows.Forms.CheckBox Windchb1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox SkiJumpreTxb;
        private System.Windows.Forms.MenuStrip paaMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaaUusiSivuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMatka;
        private System.Windows.Forms.CheckBox Hdwindchb;
        private System.Windows.Forms.TextBox JudgPointsTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lenght;
        private System.Windows.Forms.TextBox LenghtTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OverallTxb;
    }
}

