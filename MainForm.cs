using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using vbMaf.Utils;
using DevComponents.DotNetBar.Metro;

namespace AUTOcopiecolle
{
    public partial class MainForm : MetroForm
    {
        //Pour AIC
        private HotKey hotkeys;
        //pour decremente copier en arrier
        private HotKey hotkeysde;

        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists("save.xml"))
            {
                StreamWriter sw = File.CreateText("save.xml");
            }
            hotkeys = new HotKey(this); //touche controle + X
            hotkeys.RegisterHotKey(Keys.X, HotKey.HotKeyModifiers.Control // |
                /*HotKey.HotKeyModifiers.Alt*/);                         //ci dessous la fonction a applique des l appuie de la touche:
            hotkeys.HotKeyPress += new vbMaf.Utils.HotKey.HotKeyHandler(button3_Click);
            //------------------------------------------------------DECREMENTE RACOURCI
            hotkeysde = new HotKey(this); // touche controle + S
            hotkeysde.RegisterHotKey(Keys.S, HotKey.HotKeyModifiers.Control);
            hotkeysde.HotKeyPress += new vbMaf.Utils.HotKey.HotKeyHandler(decremraccourcie_Click);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                filepath_txt.Text = sv.FileName;
                listBox1.Items.AddRange(System.IO.File.ReadAllLines(sv.FileName));
                if (this.listBox1.Items.Count > 0)
                    s = 0;
                    this.listBox1.SelectedIndex = 0;
                    tableauBord();
            }
        }
        //Ou vous en ete variable:
        public int s = 0;
        public string selected;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                s++;
                this.listBox1.SelectedIndex = s;
                tableauBord();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur: Veuillez ouvrir un fichier d'abord");
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                selected = listBox1.GetItemText(listBox1.SelectedItem);
                console_txt.Text += Environment.NewLine + "\n copié: " + selected;
                Clipboard.SetText(selected);
            }
            catch { MessageBox.Show("Veuillez ouvrir un fichier d'abord"); }
        }

        //AIC:
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                s++;
                this.listBox1.SelectedIndex = s;
                selected = listBox1.GetItemText(listBox1.SelectedItem);
                Clipboard.SetText(selected);
                tableauBord();
                console_txt.Text += Environment.NewLine + "Racourci AIC Appuyé";
            }

            catch { MessageBox.Show("Veuillez ouvrir un fichier d'abord"); }
        }
        //Copier en arrier decremente
        public void decremraccourcie_Click(object sender, HotKeyArgs args)
        {
            try
            {
                //decremente 
                s--;
                this.listBox1.SelectedIndex = s;
                selected = listBox1.GetItemText(listBox1.SelectedItem);
                Clipboard.SetText(selected);
                tableauBord();
                console_txt.Text += Environment.NewLine + "Racourci DEC Appuyé";
            }
            catch { MessageBox.Show("Veuillez ouvrir un fichier d'abord !"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Envoie a label1 fonction Sauvegarde l etat
            save(filepath_txt.Text,s);
        }

        #region Sauvergarde l'etat et l'enrgistre
        public void save(string fichierchemin, int incremente)
        {

            
                if ((filepath_txt.Text != "Chemin du fichier") && (s != 0))
                { try
            {
                string incremente_str = incremente.ToString();
                // Ecriture du fichier
                XmlTextWriter fichier = new XmlTextWriter("save.xml", null);
                fichier.WriteStartDocument();
                fichier.WriteWhitespace("\n");
                fichier.WriteWhitespace("\t");
                fichier.WriteStartElement("fichier");

                fichier.WriteWhitespace("\n");
                fichier.WriteWhitespace("\t\t");
                fichier.WriteStartElement("chemin_fichier");
                fichier.WriteString(fichierchemin);
                fichier.WriteEndElement();
                fichier.WriteWhitespace("\n");

                fichier.WriteWhitespace("\n");
                fichier.WriteWhitespace("\t\t");
                fichier.WriteStartElement("incremente");
                fichier.WriteString(incremente_str);
                fichier.WriteEndElement();
                fichier.WriteWhitespace("\n");

                fichier.WriteWhitespace("\t");
                fichier.WriteEndElement();

                fichier.WriteEndDocument();
                fichier.Close();
                MessageBox.Show("Sauvegarder avec succés");
            }
                    catch (Exception)
                        {
                            MessageBox.Show("Erreur: Sauvegarde veuillez Ressayez");
                        }
                }
                else { MessageBox.Show("L'etat est vide !"); }
            
            
        } 
        #endregion


        #region Reinitialiser la Sauvegarde
        private void button5_Click(object sender, EventArgs e)
        {
            XmlTextReader config = new XmlTextReader("save.xml");
            config.WhitespaceHandling = WhitespaceHandling.None;

            string chemin = "";

            while (config.Read())
            {
                if (config.LocalName == "chemin_fichier")
                    chemin = config.ReadString();
                else if (config.LocalName == "incremente")
                    s = Convert.ToInt32(config.ReadString());
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(System.IO.File.ReadAllLines(chemin));

            //auto scoll
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            this.listBox1.SelectedIndex = s;
            filepath_txt.Text = chemin;
            nbr_elmt.Text = "Nombre de ligne: " + listBox1.Items.Count;
            ligne_txt.Text = "Ligne: " + s;
            int lg = listBox1.Items.Count - s;
            ligne_reste_txt.Text = "Ligne restante: " + lg;
        } 
        #endregion

        private void decrseule_Click(object sender, EventArgs e)
        {
            try
            {
                s++;
                this.listBox1.SelectedIndex = s;
                tableauBord();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez ouvrir un fichier d'abord");
            }
        }
         
        private void tableauBord()
        { //actualise le tableaux de bord
            nbr_elmt.Text = "Nombre de lignes: " + listBox1.Items.Count;
            ligne_txt.Text = "Lignes: " + s;
            int lg = listBox1.Items.Count - s;
            ligne_reste_txt.Text = "Lignes restante: " + lg;
        }

        private void console_txt_TextChanged(object sender, EventArgs e)
        {
            console_txt.SelectionStart = console_txt.Text.Length;
            console_txt.ScrollToCaret();
        }

        private void videconsole_Click(object sender, EventArgs e)
        {
            console_txt.Clear();
        }

        private void apropos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coding by ..QuadCoreEE - MSB94.. \n E-mail: moussbosse@gmail.com \n");
        }

    }
}
