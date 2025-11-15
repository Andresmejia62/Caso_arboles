namespace Caso_arboles
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
            this.tbDatos = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btRecorrer = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDatos
            // 
            this.tbDatos.Location = new System.Drawing.Point(76, 38);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Size = new System.Drawing.Size(264, 26);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.TextChanged += new System.EventHandler(this.tbDatos_TextChanged);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(6, 25);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 66);
            this.btInsertar.TabIndex = 1;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(249, 27);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 66);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btRecorrer
            // 
            this.btRecorrer.Location = new System.Drawing.Point(87, 30);
            this.btRecorrer.Name = "btRecorrer";
            this.btRecorrer.Size = new System.Drawing.Size(75, 61);
            this.btRecorrer.TabIndex = 3;
            this.btRecorrer.Text = "Recorrer";
            this.btRecorrer.UseVisualStyleBackColor = true;
            this.btRecorrer.Click += new System.EventHandler(this.btRecorrer_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(168, 30);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(75, 61);
            this.btContar.TabIndex = 4;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 111);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 205);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInsertar);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btRecorrer);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.btContar);
            this.groupBox1.Location = new System.Drawing.Point(39, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 344);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDatos;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btRecorrer;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

