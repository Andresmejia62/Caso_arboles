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
            this.cbRecorrido = new System.Windows.Forms.ComboBox();
            this.btAgregarRaiz = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGrafo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDatos
            // 
            this.tbDatos.Location = new System.Drawing.Point(45, 48);
            this.tbDatos.Name = "tbDatos";
            this.tbDatos.Size = new System.Drawing.Size(264, 26);
            this.tbDatos.TabIndex = 0;
            this.tbDatos.TextChanged += new System.EventHandler(this.tbDatos_TextChanged);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(18, 30);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(195, 50);
            this.btInsertar.TabIndex = 1;
            this.btInsertar.Text = "Insertar nodo";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(301, 283);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(173, 41);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btRecorrer
            // 
            this.btRecorrer.Location = new System.Drawing.Point(34, 285);
            this.btRecorrer.Name = "btRecorrer";
            this.btRecorrer.Size = new System.Drawing.Size(159, 39);
            this.btRecorrer.TabIndex = 3;
            this.btRecorrer.Text = "Recorrer";
            this.btRecorrer.UseVisualStyleBackColor = true;
            this.btRecorrer.Click += new System.EventHandler(this.btRecorrer_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(18, 174);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(195, 61);
            this.btContar.TabIndex = 4;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(249, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 205);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRecorrido);
            this.groupBox1.Controls.Add(this.btAgregarRaiz);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btInsertar);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btRecorrer);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.btContar);
            this.groupBox1.Location = new System.Drawing.Point(45, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 376);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbol";
            // 
            // cbRecorrido
            // 
            this.cbRecorrido.FormattingEnabled = true;
            this.cbRecorrido.Items.AddRange(new object[] {
            "Preorden",
            "Inorden",
            "Postorden"});
            this.cbRecorrido.Location = new System.Drawing.Point(18, 251);
            this.cbRecorrido.Name = "cbRecorrido";
            this.cbRecorrido.Size = new System.Drawing.Size(195, 28);
            this.cbRecorrido.TabIndex = 8;
            // 
            // btAgregarRaiz
            // 
            this.btAgregarRaiz.Location = new System.Drawing.Point(18, 95);
            this.btAgregarRaiz.Name = "btAgregarRaiz";
            this.btAgregarRaiz.Size = new System.Drawing.Size(195, 50);
            this.btAgregarRaiz.TabIndex = 7;
            this.btAgregarRaiz.Text = "Agregar raiz";
            this.btAgregarRaiz.UseVisualStyleBackColor = true;
            this.btAgregarRaiz.Click += new System.EventHandler(this.btAgregarRaiz_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(249, 251);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(290, 26);
            this.tbBuscar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar dato:";
            // 
            // btGrafo
            // 
            this.btGrafo.Location = new System.Drawing.Point(485, 38);
            this.btGrafo.Name = "btGrafo";
            this.btGrafo.Size = new System.Drawing.Size(99, 46);
            this.btGrafo.TabIndex = 8;
            this.btGrafo.Text = "Grafo";
            this.btGrafo.UseVisualStyleBackColor = true;
            this.btGrafo.Click += new System.EventHandler(this.btGrafo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 490);
            this.Controls.Add(this.btGrafo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDatos);
            this.Name = "Form1";
            this.Text = "Arbol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgregarRaiz;
        private System.Windows.Forms.ComboBox cbRecorrido;
        private System.Windows.Forms.Button btGrafo;
    }
}

