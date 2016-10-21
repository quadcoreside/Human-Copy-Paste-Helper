namespace AUTOcopiecolle
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //#region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.filepath_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nbr_elmt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ligne_reste_txt = new System.Windows.Forms.Label();
            this.ligne_txt = new System.Windows.Forms.Label();
            this.console_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decremraccourcie = new System.Windows.Forms.Button();
            this.decrseule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.videconsole = new System.Windows.Forms.Label();
            this.apropos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 537);
            this.listBox1.TabIndex = 0;
            // 
            // filepath_txt
            // 
            this.filepath_txt.Location = new System.Drawing.Point(6, 19);
            this.filepath_txt.Name = "filepath_txt";
            this.filepath_txt.Size = new System.Drawing.Size(197, 20);
            this.filepath_txt.TabIndex = 1;
            this.filepath_txt.Tag = "file path";
            this.filepath_txt.Text = "Chemun du fichier";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.filepath_txt);
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importer le fichier";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "incremente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(615, 136);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(131, 23);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copier";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Sauvegarder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(124, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Réinitialiser l\'état";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(530, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 78);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // nbr_elmt
            // 
            this.nbr_elmt.AutoSize = true;
            this.nbr_elmt.Location = new System.Drawing.Point(6, 16);
            this.nbr_elmt.Name = "nbr_elmt";
            this.nbr_elmt.Size = new System.Drawing.Size(92, 13);
            this.nbr_elmt.TabIndex = 9;
            this.nbr_elmt.Text = "Nombre de lignes:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ligne_reste_txt);
            this.groupBox3.Controls.Add(this.ligne_txt);
            this.groupBox3.Controls.Add(this.nbr_elmt);
            this.groupBox3.Location = new System.Drawing.Point(610, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tableaux de Bord:";
            // 
            // ligne_reste_txt
            // 
            this.ligne_reste_txt.AutoSize = true;
            this.ligne_reste_txt.Location = new System.Drawing.Point(7, 50);
            this.ligne_reste_txt.Name = "ligne_reste_txt";
            this.ligne_reste_txt.Size = new System.Drawing.Size(82, 13);
            this.ligne_reste_txt.TabIndex = 11;
            this.ligne_reste_txt.Text = "Lignes restante:";
            // 
            // ligne_txt
            // 
            this.ligne_txt.AutoSize = true;
            this.ligne_txt.Location = new System.Drawing.Point(7, 33);
            this.ligne_txt.Name = "ligne_txt";
            this.ligne_txt.Size = new System.Drawing.Size(41, 13);
            this.ligne_txt.TabIndex = 10;
            this.ligne_txt.Text = "Lignes:";
            // 
            // console_txt
            // 
            this.console_txt.Location = new System.Drawing.Point(524, 314);
            this.console_txt.Multiline = true;
            this.console_txt.Name = "console_txt";
            this.console_txt.Size = new System.Drawing.Size(358, 122);
            this.console_txt.TabIndex = 11;
            this.console_txt.Text = "Journal:";
            this.console_txt.TextChanged += new System.EventHandler(this.console_txt_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "En avant (AIC)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CTRL + X = AIC";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(785, 442);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 81);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raccourci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CTRL + S = DC";
            // 
            // decremraccourcie
            // 
            this.decremraccourcie.Location = new System.Drawing.Point(673, 107);
            this.decremraccourcie.Name = "decremraccourcie";
            this.decremraccourcie.Size = new System.Drawing.Size(137, 23);
            this.decremraccourcie.TabIndex = 14;
            this.decremraccourcie.Text = "En arriere(DC)";
            this.decremraccourcie.UseVisualStyleBackColor = true;
            // 
            // decrseule
            // 
            this.decrseule.Location = new System.Drawing.Point(673, 78);
            this.decrseule.Name = "decrseule";
            this.decrseule.Size = new System.Drawing.Size(137, 23);
            this.decrseule.TabIndex = 15;
            this.decrseule.Text = "décremente";
            this.decrseule.UseVisualStyleBackColor = true;
            this.decrseule.Click += new System.EventHandler(this.decrseule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Copie pas à pas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Copie";
            // 
            // videconsole
            // 
            this.videconsole.AutoSize = true;
            this.videconsole.Location = new System.Drawing.Point(804, 298);
            this.videconsole.Name = "videconsole";
            this.videconsole.Size = new System.Drawing.Size(75, 13);
            this.videconsole.TabIndex = 18;
            this.videconsole.Text = "vider le journal";
            this.videconsole.Click += new System.EventHandler(this.videconsole_Click);
            // 
            // apropos
            // 
            this.apropos.AutoSize = true;
            this.apropos.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.apropos.Location = new System.Drawing.Point(863, 520);
            this.apropos.Name = "apropos";
            this.apropos.Size = new System.Drawing.Size(31, 11);
            this.apropos.TabIndex = 20;
            this.apropos.Text = "About";
            this.apropos.Click += new System.EventHandler(this.apropos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.button5;
            this.ClientSize = new System.Drawing.Size(894, 531);
            this.Controls.Add(this.apropos);
            this.Controls.Add(this.videconsole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decrseule);
            this.Controls.Add(this.decremraccourcie);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.console_txt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 570);
            this.MinimumSize = new System.Drawing.Size(910, 570);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Copy Paste Helper";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox filepath_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nbr_elmt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ligne_reste_txt;
        private System.Windows.Forms.Label ligne_txt;
        private System.Windows.Forms.TextBox console_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decremraccourcie;
        private System.Windows.Forms.Button decrseule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label videconsole;
        private System.Windows.Forms.Label apropos;
    
        }

}

