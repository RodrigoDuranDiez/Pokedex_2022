namespace Pokedex_2022
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.pokedex = new System.Windows.Forms.PictureBox();
            this.descripcionPokemons = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(333, 564);
            this.izquierda.Margin = new System.Windows.Forms.Padding(5);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(34, 27);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(123, 270);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(399, 563);
            this.derecha.Margin = new System.Windows.Forms.Padding(5);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(39, 27);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ControlText;
            this.nombrePokemon.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.Color.Lime;
            this.nombrePokemon.Location = new System.Drawing.Point(546, 232);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(354, 97);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "label1";
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombrePokemon.Click += new System.EventHandler(this.label1_Click);
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.BackColor = System.Drawing.SystemColors.ControlText;
            this.tipoPokemon.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon.ForeColor = System.Drawing.Color.Lime;
            this.tipoPokemon.Location = new System.Drawing.Point(746, 588);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(161, 39);
            this.tipoPokemon.TabIndex = 4;
            this.tipoPokemon.Text = "tipoPokemon";
            this.tipoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipoPokemon.Click += new System.EventHandler(this.tipoPokemon_Click);
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.BackColor = System.Drawing.SystemColors.ControlText;
            this.pesoPokemon.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPokemon.ForeColor = System.Drawing.Color.Lime;
            this.pesoPokemon.Location = new System.Drawing.Point(549, 579);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(152, 48);
            this.pesoPokemon.TabIndex = 5;
            this.pesoPokemon.Text = "pesoPokemon";
            this.pesoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pesoPokemon.Click += new System.EventHandler(this.pesoPokemon_Click);
            // 
            // pokedex
            // 
            this.pokedex.Image = ((System.Drawing.Image)(resources.GetObject("pokedex.Image")));
            this.pokedex.Location = new System.Drawing.Point(-3, 4);
            this.pokedex.Name = "pokedex";
            this.pokedex.Size = new System.Drawing.Size(999, 694);
            this.pokedex.TabIndex = 6;
            this.pokedex.TabStop = false;
            // 
            // descripcionPokemons
            // 
            this.descripcionPokemons.BackColor = System.Drawing.SystemColors.MenuText;
            this.descripcionPokemons.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionPokemons.ForeColor = System.Drawing.Color.Lime;
            this.descripcionPokemons.Location = new System.Drawing.Point(554, 356);
            this.descripcionPokemons.Multiline = true;
            this.descripcionPokemons.Name = "descripcionPokemons";
            this.descripcionPokemons.Size = new System.Drawing.Size(353, 103);
            this.descripcionPokemons.TabIndex = 7;
            this.descripcionPokemons.Text = "Descripción";
            this.descripcionPokemons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descripcionPokemons.TextChanged += new System.EventHandler(this.descripcionPokemons_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(719, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(522, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(998, 699);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.descripcionPokemons);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.pesoPokemon);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pokedex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.Label pesoPokemon;
        private System.Windows.Forms.PictureBox pokedex;
        private System.Windows.Forms.TextBox descripcionPokemons;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

