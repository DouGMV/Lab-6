namespace Lab__6
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonLeerDatos = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonIngresarDatos = new System.Windows.Forms.Button();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(28, 94);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(250, 250);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(337, 94);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.RowHeadersWidth = 51;
            this.dataGridViewVehiculos.RowTemplate.Height = 24;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(250, 250);
            this.dataGridViewVehiculos.TabIndex = 1;
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(957, 94);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(250, 250);
            this.dataGridViewReporte.TabIndex = 2;
            // 
            // buttonLeerDatos
            // 
            this.buttonLeerDatos.Location = new System.Drawing.Point(350, 474);
            this.buttonLeerDatos.Name = "buttonLeerDatos";
            this.buttonLeerDatos.Size = new System.Drawing.Size(113, 33);
            this.buttonLeerDatos.TabIndex = 3;
            this.buttonLeerDatos.Text = "Leer Datos";
            this.buttonLeerDatos.UseVisualStyleBackColor = true;
            this.buttonLeerDatos.Click += new System.EventHandler(this.buttonLeerDatos_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(763, 474);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(83, 33);
            this.buttonReporte.TabIndex = 4;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(1261, 112);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(42, 16);
            this.labelPlaca.TabIndex = 5;
            this.labelPlaca.Text = "Placa";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(1263, 160);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(45, 16);
            this.labelMarca.TabIndex = 6;
            this.labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(1264, 201);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(53, 16);
            this.labelModelo.TabIndex = 7;
            this.labelModelo.Text = "Modelo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(1264, 248);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(39, 16);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Color";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(1265, 289);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(1320, 109);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlaca.TabIndex = 10;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(1320, 157);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 22);
            this.textBoxMarca.TabIndex = 11;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(1321, 198);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 22);
            this.textBoxModelo.TabIndex = 12;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(1320, 248);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 13;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(1321, 289);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecio.TabIndex = 14;
            // 
            // buttonIngresarDatos
            // 
            this.buttonIngresarDatos.Location = new System.Drawing.Point(1330, 341);
            this.buttonIngresarDatos.Name = "buttonIngresarDatos";
            this.buttonIngresarDatos.Size = new System.Drawing.Size(87, 47);
            this.buttonIngresarDatos.TabIndex = 15;
            this.buttonIngresarDatos.Text = "Ingresar Datos";
            this.buttonIngresarDatos.UseVisualStyleBackColor = true;
            this.buttonIngresarDatos.Click += new System.EventHandler(this.buttonIngresarDatos_Click);
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(639, 94);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.RowHeadersWidth = 51;
            this.dataGridViewAlquileres.RowTemplate.Height = 24;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(250, 250);
            this.dataGridViewAlquileres.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(892, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular Kilometraje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1041, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1293, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Controls.Add(this.buttonIngresarDatos);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonLeerDatos);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Button buttonLeerDatos;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonIngresarDatos;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

