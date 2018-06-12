namespace Menu
{
    partial class melcoul
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(melcoul));
            this.EtiRouge = new System.Windows.Forms.Label();
            this.EtiVert = new System.Windows.Forms.Label();
            this.EtiBleu = new System.Windows.Forms.Label();
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.numericUpRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpVert = new System.Windows.Forms.NumericUpDown();
            this.numericUpBleu = new System.Windows.Forms.NumericUpDown();
            this.labelrouge = new System.Windows.Forms.Label();
            this.labelvert = new System.Windows.Forms.Label();
            this.labelbleu = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // EtiRouge
            // 
            this.EtiRouge.AutoSize = true;
            this.EtiRouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.EtiRouge.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiRouge.Location = new System.Drawing.Point(12, 32);
            this.EtiRouge.Name = "EtiRouge";
            this.EtiRouge.Size = new System.Drawing.Size(67, 33);
            this.EtiRouge.TabIndex = 0;
            this.EtiRouge.Text = "Rouge";
            // 
            // EtiVert
            // 
            this.EtiVert.AutoSize = true;
            this.EtiVert.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiVert.Location = new System.Drawing.Point(12, 82);
            this.EtiVert.Name = "EtiVert";
            this.EtiVert.Size = new System.Drawing.Size(53, 33);
            this.EtiVert.TabIndex = 1;
            this.EtiVert.Text = "Vert";
            // 
            // EtiBleu
            // 
            this.EtiBleu.AutoSize = true;
            this.EtiBleu.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiBleu.Location = new System.Drawing.Point(12, 127);
            this.EtiBleu.Name = "EtiBleu";
            this.EtiBleu.Size = new System.Drawing.Size(56, 33);
            this.EtiBleu.TabIndex = 2;
            this.EtiBleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.Location = new System.Drawing.Point(93, 42);
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(206, 23);
            this.hScrollBarRouge.TabIndex = 4;
            this.hScrollBarRouge.ValueChanged += new System.EventHandler(this.hScrollBarRouge_ValueChanged);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.Location = new System.Drawing.Point(93, 82);
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(206, 23);
            this.hScrollBarVert.TabIndex = 5;
            this.hScrollBarVert.ValueChanged += new System.EventHandler(this.hScrollBarVert_ValueChanged);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.Location = new System.Drawing.Point(93, 127);
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(206, 23);
            this.hScrollBarBleu.TabIndex = 6;
            this.hScrollBarBleu.ValueChanged += new System.EventHandler(this.hScrollBarBleu_ValueChanged);
            // 
            // numericUpRouge
            // 
            this.numericUpRouge.Location = new System.Drawing.Point(314, 45);
            this.numericUpRouge.Name = "numericUpRouge";
            this.numericUpRouge.Size = new System.Drawing.Size(51, 20);
            this.numericUpRouge.TabIndex = 7;
            this.numericUpRouge.ValueChanged += new System.EventHandler(this.numericUpRouge_ValueChanged);
            // 
            // numericUpVert
            // 
            this.numericUpVert.Location = new System.Drawing.Point(314, 85);
            this.numericUpVert.Name = "numericUpVert";
            this.numericUpVert.Size = new System.Drawing.Size(51, 20);
            this.numericUpVert.TabIndex = 8;
            this.numericUpVert.ValueChanged += new System.EventHandler(this.numericUpVert_ValueChanged);
            // 
            // numericUpBleu
            // 
            this.numericUpBleu.Location = new System.Drawing.Point(314, 130);
            this.numericUpBleu.Name = "numericUpBleu";
            this.numericUpBleu.Size = new System.Drawing.Size(51, 20);
            this.numericUpBleu.TabIndex = 9;
            this.numericUpBleu.ValueChanged += new System.EventHandler(this.numericUpBleu_ValueChanged);
            // 
            // labelrouge
            // 
            this.labelrouge.BackColor = System.Drawing.Color.Black;
            this.labelrouge.Location = new System.Drawing.Point(383, 45);
            this.labelrouge.Name = "labelrouge";
            this.labelrouge.Size = new System.Drawing.Size(70, 20);
            this.labelrouge.TabIndex = 10;
            // 
            // labelvert
            // 
            this.labelvert.BackColor = System.Drawing.Color.Black;
            this.labelvert.Location = new System.Drawing.Point(383, 87);
            this.labelvert.Name = "labelvert";
            this.labelvert.Size = new System.Drawing.Size(70, 20);
            this.labelvert.TabIndex = 11;
            // 
            // labelbleu
            // 
            this.labelbleu.BackColor = System.Drawing.Color.Black;
            this.labelbleu.Location = new System.Drawing.Point(383, 132);
            this.labelbleu.Name = "labelbleu";
            this.labelbleu.Size = new System.Drawing.Size(70, 20);
            this.labelbleu.TabIndex = 12;
            // 
            // labelresult
            // 
            this.labelresult.BackColor = System.Drawing.Color.Black;
            this.labelresult.Location = new System.Drawing.Point(18, 167);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(435, 63);
            this.labelresult.TabIndex = 13;
            this.labelresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelresult.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(650, 239);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.labelbleu);
            this.Controls.Add(this.labelvert);
            this.Controls.Add(this.labelrouge);
            this.Controls.Add(this.numericUpBleu);
            this.Controls.Add(this.numericUpVert);
            this.Controls.Add(this.numericUpRouge);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.hScrollBarRouge);
            this.Controls.Add(this.EtiBleu);
            this.Controls.Add(this.EtiVert);
            this.Controls.Add(this.EtiRouge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 306);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Défilement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiRouge;
        private System.Windows.Forms.Label EtiVert;
        private System.Windows.Forms.Label EtiBleu;
        private System.Windows.Forms.HScrollBar hScrollBarRouge;
        private System.Windows.Forms.HScrollBar hScrollBarVert;
        private System.Windows.Forms.HScrollBar hScrollBarBleu;
        private System.Windows.Forms.NumericUpDown numericUpRouge;
        private System.Windows.Forms.NumericUpDown numericUpVert;
        private System.Windows.Forms.NumericUpDown numericUpBleu;
        private System.Windows.Forms.Label labelrouge;
        private System.Windows.Forms.Label labelvert;
        private System.Windows.Forms.Label labelbleu;
        private System.Windows.Forms.Label labelresult;
    }
}

