
namespace XaviBarajaForms
{
    partial class Form1
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
            this.listCartas = new System.Windows.Forms.ListBox();
            this.btnCrearBaraja = new System.Windows.Forms.Button();
            this.btnMezclarBaraja = new System.Windows.Forms.Button();
            this.btnNumCartas = new System.Windows.Forms.Button();
            this.btnRobarCarta = new System.Windows.Forms.Button();
            this.btnCartaAzar = new System.Windows.Forms.Button();
            this.btnCogerCarta = new System.Windows.Forms.Button();
            this.txtNumCartas = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.numCogerCarta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCogerCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // listCartas
            // 
            this.listCartas.FormattingEnabled = true;
            this.listCartas.ItemHeight = 16;
            this.listCartas.Location = new System.Drawing.Point(375, 36);
            this.listCartas.Name = "listCartas";
            this.listCartas.Size = new System.Drawing.Size(324, 324);
            this.listCartas.TabIndex = 0;
            // 
            // btnCrearBaraja
            // 
            this.btnCrearBaraja.Location = new System.Drawing.Point(74, 36);
            this.btnCrearBaraja.Name = "btnCrearBaraja";
            this.btnCrearBaraja.Size = new System.Drawing.Size(166, 23);
            this.btnCrearBaraja.TabIndex = 1;
            this.btnCrearBaraja.Text = "Crear Baraja";
            this.btnCrearBaraja.UseVisualStyleBackColor = true;
            this.btnCrearBaraja.Click += new System.EventHandler(this.btnCrearBaraja_Click);
            // 
            // btnMezclarBaraja
            // 
            this.btnMezclarBaraja.Location = new System.Drawing.Point(74, 129);
            this.btnMezclarBaraja.Name = "btnMezclarBaraja";
            this.btnMezclarBaraja.Size = new System.Drawing.Size(166, 23);
            this.btnMezclarBaraja.TabIndex = 2;
            this.btnMezclarBaraja.Text = "Mezclar Baraja";
            this.btnMezclarBaraja.UseVisualStyleBackColor = true;
            this.btnMezclarBaraja.Click += new System.EventHandler(this.btnMezclarBaraja_Click);
            // 
            // btnNumCartas
            // 
            this.btnNumCartas.Location = new System.Drawing.Point(74, 176);
            this.btnNumCartas.Name = "btnNumCartas";
            this.btnNumCartas.Size = new System.Drawing.Size(166, 23);
            this.btnNumCartas.TabIndex = 3;
            this.btnNumCartas.Text = "Numero de cartas";
            this.btnNumCartas.UseVisualStyleBackColor = true;
            this.btnNumCartas.Click += new System.EventHandler(this.btnNumCartas_Click);
            // 
            // btnRobarCarta
            // 
            this.btnRobarCarta.Location = new System.Drawing.Point(74, 229);
            this.btnRobarCarta.Name = "btnRobarCarta";
            this.btnRobarCarta.Size = new System.Drawing.Size(166, 23);
            this.btnRobarCarta.TabIndex = 4;
            this.btnRobarCarta.Text = "Robar primera carta";
            this.btnRobarCarta.UseVisualStyleBackColor = true;
            this.btnRobarCarta.Click += new System.EventHandler(this.btnRobarCarta_Click);
            // 
            // btnCartaAzar
            // 
            this.btnCartaAzar.Location = new System.Drawing.Point(74, 281);
            this.btnCartaAzar.Name = "btnCartaAzar";
            this.btnCartaAzar.Size = new System.Drawing.Size(166, 23);
            this.btnCartaAzar.TabIndex = 5;
            this.btnCartaAzar.Text = "Robar carta al azar";
            this.btnCartaAzar.UseVisualStyleBackColor = true;
            this.btnCartaAzar.Click += new System.EventHandler(this.btnCartaAzar_Click);
            // 
            // btnCogerCarta
            // 
            this.btnCogerCarta.Location = new System.Drawing.Point(74, 336);
            this.btnCogerCarta.Name = "btnCogerCarta";
            this.btnCogerCarta.Size = new System.Drawing.Size(166, 23);
            this.btnCogerCarta.TabIndex = 6;
            this.btnCogerCarta.Text = "Coger carta";
            this.btnCogerCarta.UseVisualStyleBackColor = true;
            this.btnCogerCarta.Click += new System.EventHandler(this.btnCogerCarta_Click);
            // 
            // txtNumCartas
            // 
            this.txtNumCartas.Location = new System.Drawing.Point(12, 178);
            this.txtNumCartas.Name = "txtNumCartas";
            this.txtNumCartas.Size = new System.Drawing.Size(48, 22);
            this.txtNumCartas.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(74, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(166, 23);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar Baraja";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // numCogerCarta
            // 
            this.numCogerCarta.Location = new System.Drawing.Point(12, 336);
            this.numCogerCarta.Name = "numCogerCarta";
            this.numCogerCarta.Size = new System.Drawing.Size(54, 22);
            this.numCogerCarta.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numCogerCarta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNumCartas);
            this.Controls.Add(this.btnCogerCarta);
            this.Controls.Add(this.btnCartaAzar);
            this.Controls.Add(this.btnRobarCarta);
            this.Controls.Add(this.btnNumCartas);
            this.Controls.Add(this.btnMezclarBaraja);
            this.Controls.Add(this.btnCrearBaraja);
            this.Controls.Add(this.listCartas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCogerCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCartas;
        private System.Windows.Forms.Button btnCrearBaraja;
        private System.Windows.Forms.Button btnMezclarBaraja;
        private System.Windows.Forms.Button btnNumCartas;
        private System.Windows.Forms.Button btnRobarCarta;
        private System.Windows.Forms.Button btnCartaAzar;
        private System.Windows.Forms.Button btnCogerCarta;
        private System.Windows.Forms.TextBox txtNumCartas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.NumericUpDown numCogerCarta;
    }
}

