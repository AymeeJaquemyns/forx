﻿/**
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
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public partial class frmClasseTemporaire : Form
    {
        public static bool annulation = true;
        public static string classeTemp = null;

        public frmClasseTemporaire()
        {
            InitializeComponent();
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNomClasse.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Un nom d'utilisateur ne peut comporter que des chiffres et des lettres !",
                    "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtNomClasse.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom.",
                    "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                annulation = false;
                classeTemp = numNiveau.Value.ToString() + txtNomClasse.Text;
                Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            annulation = true;
            Close();
        }
    }
}
