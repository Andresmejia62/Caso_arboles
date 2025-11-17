namespace Caso_arboles
{
    partial class Grafo
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
            this.btEdificio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.dtGrafo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConexion = new System.Windows.Forms.Button();
            this.tbConexion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btValidarc = new System.Windows.Forms.Button();
            this.btMostrarc = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbRutas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrafo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEdificio
            // 
            this.btEdificio.Location = new System.Drawing.Point(175, 33);
            this.btEdificio.Name = "btEdificio";
            this.btEdificio.Size = new System.Drawing.Size(88, 53);
            this.btEdificio.TabIndex = 0;
            this.btEdificio.Text = "Insertar edificio";
            this.btEdificio.UseVisualStyleBackColor = true;
            this.btEdificio.Click += new System.EventHandler(this.btEdificio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del edificio:";
            // 
            // tbEdificio
            // 
            this.tbEdificio.Location = new System.Drawing.Point(6, 62);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(155, 26);
            this.tbEdificio.TabIndex = 3;
            // 
            // dtGrafo
            // 
            this.dtGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrafo.Location = new System.Drawing.Point(334, 55);
            this.dtGrafo.Name = "dtGrafo";
            this.dtGrafo.RowHeadersWidth = 62;
            this.dtGrafo.Size = new System.Drawing.Size(425, 416);
            this.dtGrafo.TabIndex = 4;
            this.dtGrafo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrafo_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbConexion);
            this.groupBox1.Controls.Add(this.btConexion);
            this.groupBox1.Controls.Add(this.tbEdificio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btEdificio);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btConexion
            // 
            this.btConexion.Location = new System.Drawing.Point(175, 104);
            this.btConexion.Name = "btConexion";
            this.btConexion.Size = new System.Drawing.Size(88, 53);
            this.btConexion.TabIndex = 4;
            this.btConexion.Text = "Insertar conexion";
            this.btConexion.UseVisualStyleBackColor = true;
            this.btConexion.Click += new System.EventHandler(this.btConexion_Click);
            // 
            // tbConexion
            // 
            this.tbConexion.Location = new System.Drawing.Point(6, 131);
            this.tbConexion.Name = "tbConexion";
            this.tbConexion.Size = new System.Drawing.Size(155, 26);
            this.tbConexion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre conexion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbRutas);
            this.groupBox2.Controls.Add(this.btCalcular);
            this.groupBox2.Controls.Add(this.btValidarc);
            this.groupBox2.Controls.Add(this.btMostrarc);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 306);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btValidarc
            // 
            this.btValidarc.Location = new System.Drawing.Point(6, 84);
            this.btValidarc.Name = "btValidarc";
            this.btValidarc.Size = new System.Drawing.Size(257, 53);
            this.btValidarc.TabIndex = 4;
            this.btValidarc.Text = "Validar conexidad";
            this.btValidarc.UseVisualStyleBackColor = true;
            this.btValidarc.Click += new System.EventHandler(this.btValidarc_Click);
            // 
            // btMostrarc
            // 
            this.btMostrarc.Location = new System.Drawing.Point(6, 25);
            this.btMostrarc.Name = "btMostrarc";
            this.btMostrarc.Size = new System.Drawing.Size(257, 53);
            this.btMostrarc.TabIndex = 0;
            this.btMostrarc.Text = "Mostrar conexiones";
            this.btMostrarc.UseVisualStyleBackColor = true;
            this.btMostrarc.Click += new System.EventHandler(this.btMostrarc_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(6, 218);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(257, 53);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular rutas";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbRutas
            // 
            this.tbRutas.Location = new System.Drawing.Point(6, 186);
            this.tbRutas.Name = "tbRutas";
            this.tbRutas.Size = new System.Drawing.Size(257, 26);
            this.tbRutas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingresa la ruta:";
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGrafo);
            this.Name = "Grafo";
            this.Text = "Grafo";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrafo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.DataGridView dtGrafo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConexion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btValidarc;
        private System.Windows.Forms.Button btMostrarc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRutas;
    }
}