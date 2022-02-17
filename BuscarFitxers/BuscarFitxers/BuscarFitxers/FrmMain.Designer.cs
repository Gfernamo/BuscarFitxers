
namespace BuscarFitxers
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.etqFitxers = new System.Windows.Forms.Label();
            this.llFitxers = new System.Windows.Forms.ListBox();
            this.btCarpeta = new System.Windows.Forms.Button();
            this.tbCarpeta = new System.Windows.Forms.TextBox();
            this.etqTria = new System.Windows.Forms.Label();
            this.dlgCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.tbExtensio = new System.Windows.Forms.TextBox();
            this.lbExtensio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etqFitxers
            // 
            this.etqFitxers.AutoSize = true;
            this.etqFitxers.BackColor = System.Drawing.Color.Orange;
            this.etqFitxers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etqFitxers.ForeColor = System.Drawing.Color.Black;
            this.etqFitxers.Location = new System.Drawing.Point(16, 73);
            this.etqFitxers.Margin = new System.Windows.Forms.Padding(3);
            this.etqFitxers.MinimumSize = new System.Drawing.Size(1789, 2);
            this.etqFitxers.Name = "etqFitxers";
            this.etqFitxers.Padding = new System.Windows.Forms.Padding(5);
            this.etqFitxers.Size = new System.Drawing.Size(1789, 29);
            this.etqFitxers.TabIndex = 13;
            this.etqFitxers.Text = "Fitxers";
            this.etqFitxers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llFitxers
            // 
            this.llFitxers.FormattingEnabled = true;
            this.llFitxers.ItemHeight = 16;
            this.llFitxers.Location = new System.Drawing.Point(16, 108);
            this.llFitxers.Name = "llFitxers";
            this.llFitxers.Size = new System.Drawing.Size(1789, 772);
            this.llFitxers.TabIndex = 12;
            // 
            // btCarpeta
            // 
            this.btCarpeta.BackColor = System.Drawing.Color.SteelBlue;
            this.btCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarpeta.Location = new System.Drawing.Point(1677, 40);
            this.btCarpeta.Name = "btCarpeta";
            this.btCarpeta.Size = new System.Drawing.Size(128, 29);
            this.btCarpeta.TabIndex = 9;
            this.btCarpeta.Text = "Examinar...";
            this.btCarpeta.UseVisualStyleBackColor = false;
            this.btCarpeta.Click += new System.EventHandler(this.btCarpeta_Click);
            // 
            // tbCarpeta
            // 
            this.tbCarpeta.Enabled = false;
            this.tbCarpeta.Location = new System.Drawing.Point(139, 43);
            this.tbCarpeta.Name = "tbCarpeta";
            this.tbCarpeta.ReadOnly = true;
            this.tbCarpeta.Size = new System.Drawing.Size(1513, 22);
            this.tbCarpeta.TabIndex = 8;
            // 
            // etqTria
            // 
            this.etqTria.AutoSize = true;
            this.etqTria.BackColor = System.Drawing.Color.Green;
            this.etqTria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etqTria.ForeColor = System.Drawing.Color.White;
            this.etqTria.Location = new System.Drawing.Point(12, 42);
            this.etqTria.Margin = new System.Windows.Forms.Padding(3);
            this.etqTria.Name = "etqTria";
            this.etqTria.Padding = new System.Windows.Forms.Padding(3);
            this.etqTria.Size = new System.Drawing.Size(121, 25);
            this.etqTria.TabIndex = 7;
            this.etqTria.Text = "Tria una carpeta";
            // 
            // dlgCarpeta
            // 
            this.dlgCarpeta.ShowNewFolderButton = false;
            // 
            // tbExtensio
            // 
            this.tbExtensio.Location = new System.Drawing.Point(145, 11);
            this.tbExtensio.Name = "tbExtensio";
            this.tbExtensio.Size = new System.Drawing.Size(89, 22);
            this.tbExtensio.TabIndex = 14;
            // 
            // lbExtensio
            // 
            this.lbExtensio.AutoSize = true;
            this.lbExtensio.BackColor = System.Drawing.Color.Green;
            this.lbExtensio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExtensio.ForeColor = System.Drawing.Color.White;
            this.lbExtensio.Location = new System.Drawing.Point(12, 9);
            this.lbExtensio.Margin = new System.Windows.Forms.Padding(3);
            this.lbExtensio.Name = "lbExtensio";
            this.lbExtensio.Padding = new System.Windows.Forms.Padding(3);
            this.lbExtensio.Size = new System.Drawing.Size(126, 25);
            this.lbExtensio.TabIndex = 15;
            this.lbExtensio.Text = "Escriu la extensio";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 893);
            this.Controls.Add(this.lbExtensio);
            this.Controls.Add(this.tbExtensio);
            this.Controls.Add(this.etqFitxers);
            this.Controls.Add(this.llFitxers);
            this.Controls.Add(this.btCarpeta);
            this.Controls.Add(this.tbCarpeta);
            this.Controls.Add(this.etqTria);
            this.Name = "FrmMain";
            this.Text = "Busca Fitxers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etqFitxers;
        private System.Windows.Forms.ListBox llFitxers;
        private System.Windows.Forms.Button btCarpeta;
        private System.Windows.Forms.TextBox tbCarpeta;
        private System.Windows.Forms.Label etqTria;
        private System.Windows.Forms.FolderBrowserDialog dlgCarpeta;
        private System.Windows.Forms.TextBox tbExtensio;
        private System.Windows.Forms.Label lbExtensio;
    }
}

