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
            // Recorrer el árbol según la selección del ComboBox cbRecorrido
            string tipoRecorrido = cbRecorrido.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipoRecorrido))
            {
                MessageBox.Show("Seleccione un tipo de recorrido.");
                return;
            }
            List<string> recorrido = new List<string>();
            switch (tipoRecorrido)
            {
                case "Preorden":
                    RecorrerPreorden(treeView1.Nodes, recorrido);
                    break;
                case "Inorden":
                    RecorrerInorden(treeView1.Nodes, recorrido);
                    break;
                case "Postorden":
                    RecorrerPostorden(treeView1.Nodes, recorrido);
                    break;
                default:
                    MessageBox.Show("Tipo de recorrido no válido.");
                    return;
            }
            if (recorrido.Count > 0)
            {
                MessageBox.Show($"Recorrido en {tipoRecorrido.ToLower()}: " + string.Join(" -> ", recorrido));
            }
            else
            {
                MessageBox.Show("El árbol está vacío.");
            }
        }
        private void RecorrerPreorden(TreeNodeCollection nodes, List<string> lista)
        {
            // Método recursivo para recorrido en preorden
            foreach (TreeNode node in nodes)
            {
                lista.Add(node.Text);
                RecorrerPreorden(node.Nodes, lista);
            }
        }
        private void RecorrerInorden(TreeNodeCollection nodes, List<string> lista)
        {
            // Método recursivo para recorrido en inorden (adaptado para árbol general: primer hijo, raíz, resto de hijos)
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    RecorrerInorden(node.Nodes[0].Nodes, lista); // Inorden del primer hijo (si existe)
                }
                lista.Add(node.Text);
                for (int i = 1; i < node.Nodes.Count; i++)
                {
                    RecorrerInorden(node.Nodes[i].Nodes, lista); // Inorden del resto de hijos
                }
            }
        }
        private void RecorrerPostorden(TreeNodeCollection nodes, List<string> lista)
        {
            // Método recursivo para recorrido en postorden
            foreach (TreeNode node in nodes)
            {
                RecorrerPostorden(node.Nodes, lista);
                lista.Add(node.Text);
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

        private void btGrafo_Click(object sender, EventArgs e)
        {
            var grafo = new Grafo();
            grafo.Show();
        }
    }
}
    