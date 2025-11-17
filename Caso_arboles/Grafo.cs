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
    // Formulario para gestionar y visualizar un grafo no dirigido (lista de adyacencia).
    public partial class Grafo : Form
    {
        // Diccionario que representa el grafo:
        // La clave es un edificio y la lista contiene los edificios conectados a él.
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

        public Grafo()
        {
            InitializeComponent();

            // Configuramos 2 columnas en el DataGridView donde mostraremos las conexiones.
            dtGrafo.ColumnCount = 2;
            dtGrafo.Columns[0].Name = "Origen";
            dtGrafo.Columns[1].Name = "Destino";
        }

        // Limpia la tabla y agrega una fila por cada conexión almacenada en el grafo.
        private void ActualizarTabla()
        {
            dtGrafo.Rows.Clear(); // Borra las filas anteriores

            foreach (var nodo in grafo) // Recorre cada edificio
            {
                foreach (var vecino in nodo.Value) // Recorre sus vecinos
                {
                    dtGrafo.Rows.Add(nodo.Key, vecino); // Agrega fila a la tabla
                }
            }
        }
        private void btMostrarc_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        // Verifica si el grafo está conectado
        private void btValidarc_Click(object sender, EventArgs e)
        {
            if (grafo.Count == 0) // Si no hay edificios
            {
                MessageBox.Show("No hay edificios.");
                return;
            }
            // Lista de edificios visitados (cambiado de HashSet a List)
            List<string> visitados = new List<string>();
            Queue<string> cola = new Queue<string>();
            // Tomamos el primer edificio registrado como punto de inicio
            string inicio = grafo.Keys.First();
            cola.Enqueue(inicio);
            visitados.Add(inicio);
            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                // Recorremos sus vecinos
                foreach (var vecino in grafo[actual])
                {
                    if (!visitados.Contains(vecino))
                    {
                        visitados.Add(vecino);
                        cola.Enqueue(vecino);
                    }
                }
            }
        }
        // Calcula ruta entre dos edificios guardando la ruta completa.
        private void btCalcular_Click(object sender, EventArgs e)
        {
            string texto = tbRutas.Text.Trim();
            // Validamos formato correcto A-B
            if (!texto.Contains("-"))
            {
                MessageBox.Show("Formato inválido. Ejemplo: A-B");
                return;
            }
            // Separamos origen y destino
            string[] partes = texto.Split('-');
            string origen = partes[0].Trim();
            string destino = partes[1].Trim();
            // Verificamos que existan en el grafo
            if (!grafo.ContainsKey(origen) || !grafo.ContainsKey(destino))
            {
                MessageBox.Show("Ambos edificios deben existir.");
                return;
            }
            // Cola donde cada elemento es una ruta completa (lista de nodos)
            Queue<List<string>> cola = new Queue<List<string>>();
            List<string> visitados = new List<string>();  // Cambiado de HashSet a List
            cola.Enqueue(new List<string> { origen }); // Ruta inicial
            visitados.Add(origen);
        }

        // Agrega un edificio (nodo) al grafo si no existe.
        private void btEdificio_Click(object sender, EventArgs e)
        {
            string edificio = tbEdificio.Text.Trim();

            if (string.IsNullOrEmpty(edificio))
            {
                MessageBox.Show("Ingrese un nombre de edificio.");
                return;
            }

            if (!grafo.ContainsKey(edificio))
            {
                // Inicializar lista de vecinos vacía para el nuevo nodo.
                grafo[edificio] = new List<string>();
                MessageBox.Show($"Edificio '{edificio}' agregado.");
            }
            else
            {
                MessageBox.Show("Ese edificio ya existe.");
            }

            tbEdificio.Clear();
        }

        // Agrega una conexión no dirigida entre dos edificios (formato tbConexion: "A-B").
        private void btConexion_Click(object sender, EventArgs e)
        {
            string texto = tbConexion.Text.Trim();

            if (!texto.Contains("-"))
            {
                MessageBox.Show("Formato inválido. Ejemplo: A-B");
                return;
            }

            string[] partes = texto.Split('-');
            string a = partes[0].Trim();
            string b = partes[1].Trim();

            if (!grafo.ContainsKey(a) || !grafo.ContainsKey(b))
            {
                MessageBox.Show("Ambos edificios deben existir.");
                return;
            }

            // Evitar duplicados simples al agregar la conexión
            if (!grafo[a].Contains(b, StringComparer.OrdinalIgnoreCase))
                grafo[a].Add(b);
            if (!grafo[b].Contains(a, StringComparer.OrdinalIgnoreCase))
                grafo[b].Add(a);

            MessageBox.Show($"Conexión agregada entre {a} y {b}");

            ActualizarTabla();
            tbConexion.Clear();
        }
        private void dtGrafo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

}
