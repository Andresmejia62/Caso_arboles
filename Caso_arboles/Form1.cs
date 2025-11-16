using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializar el TreeView con un nodo raíz
            treeView1.Nodes.Add(new TreeNode("jerarquía"));
        }


        private void tbDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            string dato = tbDatos.Text.Trim();
            if (string.IsNullOrEmpty(dato))
            {
                MessageBox.Show("Ingrese un dato válido.");
                return;
            }
            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode != null)
            {
                TreeNode newNode = new TreeNode(dato);
                selectedNode.Nodes.Add(newNode);
                treeView1.ExpandAll(); // Expandir para mostrar el nuevo nodo
            }
            else
            {
                // Insertar en la raíz si no hay selección
                TreeNode newNode = new TreeNode(dato);
                treeView1.Nodes[0].Nodes.Add(newNode);
                treeView1.ExpandAll();
            }
            tbDatos.Clear(); // Limpiar el TextBox después de insertar
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un nodo por su dato (recorrido en preorden)
            string busqueda = tbBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Ingrese un dato para buscar.");
                return;
            }
            TreeNode encontrado = BuscarNodo(treeView1.Nodes, busqueda);
            if (encontrado != null)
            {
                treeView1.SelectedNode = encontrado;
                MessageBox.Show("Nodo encontrado y seleccionado.");
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.");
            }
        }
        private TreeNode BuscarNodo(TreeNodeCollection nodes, string dato)
        {
            // Método recursivo para buscar un nodo
            foreach (TreeNode node in nodes)
            {
                if (node.Text.Equals(dato, StringComparison.OrdinalIgnoreCase))
                    return node;
                TreeNode hijo = BuscarNodo(node.Nodes, dato);
                if (hijo != null) return hijo;
            }
            return null;
        }

        private void btRecorrer_Click(object sender, EventArgs e)
        {
            // Recorrer el árbol en preorden y mostrar los datos en un MessageBox
            List<string> recorrido = new List<string>();
            Recorrer(treeView1.Nodes, recorrido);
            if (recorrido.Count > 0)
            {
                MessageBox.Show("Recorrido en preorden: " + string.Join(" -> ", recorrido));
            }
            else
            {
                MessageBox.Show("El árbol está vacío.");
            }
        }
        private void Recorrer(TreeNodeCollection nodes, List<string> lista)
        {
            // Método recursivo para recorrido en preorden
            foreach (TreeNode node in nodes)
            {
                lista.Add(node.Text);
                Recorrer(node.Nodes, lista);
            }
        }

        private void btContar_Click(object sender, EventArgs e)
        {
            // Contar nodos totales y calcular el número máximo de niveles
            int totalNodos = ContarNodos(treeView1.Nodes);
            int maxNiveles = NivelMax(treeView1.Nodes, 0);
            MessageBox.Show($"Total de nodos: {totalNodos}\nNúmero máximo de niveles: {maxNiveles}");

        }
        private int ContarNodos(TreeNodeCollection nodes)
        {
            // Contar nodos recursivamente
            int contador = 0;
            foreach (TreeNode node in nodes)
            {
                contador++;
                contador += ContarNodos(node.Nodes);
            }
            return contador;
        }
        private int NivelMax(TreeNodeCollection nodes, int nivelActual)
        {
            // Calcular el nivel máximo recursivamente
            int max = nivelActual;
            foreach (TreeNode node in nodes)
            {
                int maxHijo = NivelMax(node.Nodes, nivelActual + 1);
                if (maxHijo > max) max = maxHijo;
            }
            return max;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btAgregarRaiz_Click(object sender, EventArgs e)
        {
            // Agregar una nueva raíz al TreeView usando el texto del TextBox tbDatos
            string dato = tbDatos.Text.Trim();
            if (string.IsNullOrEmpty(dato))
            {
                MessageBox.Show("Ingrese un dato válido.");
                return;
            }
            TreeNode nuevaRaiz = new TreeNode(dato);
            treeView1.Nodes.Add(nuevaRaiz);
            treeView1.ExpandAll(); // Expandir para mostrar el nuevo nodo
            tbDatos.Clear(); // Limpiar el TextBox después de agregar
        }
    }
}
