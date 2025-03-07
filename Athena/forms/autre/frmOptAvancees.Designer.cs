﻿namespace CartesAcces2024
{
    partial class frmOptAvancees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptAvancees));
            this.btnModifMdp = new System.Windows.Forms.Button();
            this.btnRepartir = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDossier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifMdp
            // 
            this.btnModifMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnModifMdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnModifMdp.Location = new System.Drawing.Point(52, 52);
            this.btnModifMdp.Name = "btnModifMdp";
            this.btnModifMdp.Size = new System.Drawing.Size(359, 75);
            this.btnModifMdp.TabIndex = 0;
            this.btnModifMdp.Text = "🔑 Modifier le mot de passe";
            this.btnModifMdp.UseVisualStyleBackColor = false;
            this.btnModifMdp.Click += new System.EventHandler(this.btnModifMdp_Click);
            // 
            // btnRepartir
            // 
            this.btnRepartir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRepartir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepartir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepartir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnRepartir.Location = new System.Drawing.Point(52, 133);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(359, 75);
            this.btnRepartir.TabIndex = 1;
            this.btnRepartir.Text = "🔀 Répartir les photos";
            this.btnRepartir.UseVisualStyleBackColor = false;
            this.btnRepartir.Click += new System.EventHandler(this.btnRepartir_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnDel.Location = new System.Drawing.Point(52, 340);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(359, 75);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "🗑 Supprimer des données";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDossier
            // 
            this.btnDossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDossier.Enabled = false;
            this.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDossier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnDossier.Location = new System.Drawing.Point(52, 214);
            this.btnDossier.Name = "btnDossier";
            this.btnDossier.Size = new System.Drawing.Size(359, 75);
            this.btnDossier.TabIndex = 3;
            this.btnDossier.Text = "📁 Ouvrir le dossier des photos";
            this.btnDossier.UseVisualStyleBackColor = false;
            this.btnDossier.Visible = false;
            this.btnDossier.Click += new System.EventHandler(this.btnDossier_Click);
            // 
            // frmOptAvancees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(472, 464);
            this.Controls.Add(this.btnDossier);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRepartir);
            this.Controls.Add(this.btnModifMdp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOptAvancees";
            this.Text = "Athena - Options avancees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifMdp;
        private System.Windows.Forms.Button btnRepartir;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDossier;
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
 * 
 */