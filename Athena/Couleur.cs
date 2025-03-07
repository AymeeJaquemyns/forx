/**
 * Ce fichier contient la classe Couleur qui gère les couleurs des contrôles dans l'application.
 * Elle inclut des méthodes pour définir les couleurs des fenêtres, des boutons, des panneaux, etc.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public static class Couleur
    {
        // Méthode pour définir la couleur de la fenêtre
        // public static void setCouleurFenetre(Form fenetre)
        // {
        //     if (Globale.EstEnModeSombre)
        //         fenetre.BackColor = Color.FromArgb(255, Globale.CouleurDeFondSombre[0],
        //             Globale.CouleurDeFondSombre[1], Globale.CouleurDeFondSombre[2]);
        //     else
        //         fenetre.BackColor = Color.FromArgb(255, Globale.CouleurDeFondClaire[0],
        //             Globale.CouleurDeFondClaire[1], Globale.CouleurDeFondClaire[2]);

        //     foreach (Control controle in fenetre.Controls)
        //     {
        //         var panel = controle as Panel;
        //         var groupBox = controle as GroupBox;
        //         var button = controle as Button;
        //         var textBox = controle as TextBox;
        //         var listBox = controle as ListBox;
        //         if (panel != null)
        //             setCouleurPanel((Panel) controle);
        //         else if (groupBox != null)
        //             setCouleurGroupeBox((GroupBox) controle);

        //         else if (button != null)
        //             setCouleurBouton((Button) controle);
        //         else if (textBox != null)
        //             setCouleurTextBox((TextBox) controle);
        //         else if (listBox != null)
        //             setCouleurListBox((ListBox) controle);
        //         else
        //             setCouleurAutre(controle);
        //     }
        // }

        /// <summary>
        /// Méthode pour définir la couleur d'un panneau
        /// </summary>
        /// <param name="panel"></param>
        public static void setCouleurPanel(Panel panel)
        {
            foreach (Control controle in panel.Controls)
            {
                var panel2 = controle as Panel;
                var groupBox = controle as GroupBox;
                var button = controle as Button;
                var textBox = controle as TextBox;
                var listBox = controle as ListBox;
                if (panel2 != null)
                    setCouleurPanel((Panel) controle);
                else if (groupBox != null)
                    setCouleurGroupeBox((GroupBox) controle);

                else if (button != null)
                    setCouleurBouton((Button) controle);
                else if (textBox != null)
                    setCouleurTextBox((TextBox) controle);
                else if (listBox != null)
                    setCouleurListBox((ListBox) controle);
                else
                    setCouleurAutre(controle);
            }
        }

        /// <summary>
        /// Méthode pour définir la couleur d'un groupe de contrôles
        /// </summary>
        /// <param name="groupeBox"></param>
        public static void setCouleurGroupeBox(GroupBox groupeBox)
        {
            foreach (Control controle in groupeBox.Controls)
            {
                var panel = controle as Panel;
                var groupBox = controle as GroupBox;
                var button = controle as Button;
                var textBox = controle as TextBox;
                var listBox = controle as ListBox;
                if (panel != null)
                    setCouleurPanel((Panel) controle);
                else if (groupBox != null)
                    setCouleurGroupeBox((GroupBox) controle);

                else if (button != null)
                    setCouleurBouton((Button) controle);
                else if (textBox != null)
                    setCouleurTextBox((TextBox) controle);
                else if (listBox != null)
                    setCouleurListBox((ListBox) controle);
                else
                    setCouleurAutre(controle);
            }
        }

        /// <summary>
        /// Méthode pour définir la couleur d'un bouton
        /// </summary>
        /// <param name="btn"></param>
        public static void setCouleurBouton(Button btn)
        {
            if (Globale.EstEnModeSombre)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteSombre[0],
                    Globale.CouleurDuTexteSombre[1], Globale.CouleurDuTexteSombre[2]);
                if (btn.Enabled)
                    btn.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsSombre[0],
                        Globale.CouleurBoutonsSombre[1], Globale.CouleurBoutonsSombre[2]);
                else
                    btn.BackColor = Color.FromArgb(255, Globale.CouleurBoutonOffSombre[0],
                        Globale.CouleurBoutonOffSombre[1], Globale.CouleurBoutonOffSombre[2]);
                btn.EnabledChanged += changement_state_btn;
            }
            else
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteclaire[0],
                    Globale.CouleurDuTexteclaire[1], Globale.CouleurDuTexteclaire[2]);
                if (btn.Enabled)
                    btn.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsClaire[0],
                        Globale.CouleurBoutonsClaire[1], Globale.CouleurBoutonsClaire[2]);
                else
                    btn.BackColor = Color.FromArgb(255, Globale.CouleurBoutonOffClaire[0],
                        Globale.CouleurBoutonOffClaire[1], Globale.CouleurBoutonOffClaire[2]);
                btn.EnabledChanged += changement_state_btn;
            }
        }

        /// <summary>
        /// Méthode pour définir la couleur d'autres contrôles
        /// </summary>
        /// <param name="controle"></param>
        public static void setCouleurAutre(Control controle)
        {
            if (Globale.EstEnModeSombre)
                controle.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteSombre[0],
                    Globale.CouleurDuTexteSombre[1], Globale.CouleurDuTexteSombre[2]);
            else
                controle.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteclaire[0],
                    Globale.CouleurDuTexteclaire[1], Globale.CouleurDuTexteclaire[2]);
        }

        /// <summary>
        /// Méthode pour définir la couleur d'une zone de texte
        /// </summary>
        /// <param name="txt"></param>
        public static void setCouleurTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            if (Globale.EstEnModeSombre)
            {
                txt.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteSombre[0],
                    Globale.CouleurDuTexteSombre[1], Globale.CouleurDuTexteSombre[2]);
                txt.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsSombre[0],
                    Globale.CouleurBoutonsSombre[1], Globale.CouleurBoutonsSombre[2]);
            }
            else
            {
                txt.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteclaire[0],
                    Globale.CouleurDuTexteclaire[1], Globale.CouleurDuTexteclaire[2]);
                txt.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsClaire[0],
                    Globale.CouleurBoutonsClaire[1], Globale.CouleurBoutonsClaire[2]);
            }
        }

        /// <summary>
        /// Méthode pour définir la couleur d'une liste
        /// </summary>
        /// <param name="lst"></param>
        public static void setCouleurListBox(ListBox lst)
        {
            lst.BorderStyle = BorderStyle.None;
            if (Globale.EstEnModeSombre)
            {
                lst.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteSombre[0],
                    Globale.CouleurDuTexteSombre[1], Globale.CouleurDuTexteSombre[2]);
                lst.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsSombre[0],
                    Globale.CouleurBoutonsSombre[1], Globale.CouleurBoutonsSombre[2]);
            }
            else
            {
                lst.ForeColor = Color.FromArgb(255, Globale.CouleurDuTexteclaire[0],
                    Globale.CouleurDuTexteclaire[1], Globale.CouleurDuTexteclaire[2]);
                lst.BackColor = Color.FromArgb(255, Globale.CouleurBoutonsClaire[0],
                    Globale.CouleurBoutonsClaire[1], Globale.CouleurBoutonsClaire[2]);
            }
        }

        /// <summary>
        /// Méthode pour gérer le changement d'état d'un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void changement_state_btn(object sender, EventArgs e)
        {
            Button btn;
            try
            {
                btn = sender as Button;
            }
            catch
            {
                return;
            }

            setCouleurBouton(btn);
        }
    }
}

/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */