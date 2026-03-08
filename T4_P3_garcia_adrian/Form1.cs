using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace T4_P3_garcia_adrian
{
    public partial class Form1 : Form
    {

        GestorTareas gestor = new GestorTareas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTitulo.Text;
            string descripcion = textBoxDescripcion.Text;
            DateTime fecha = dateTimePickerFecha.Value;

            if (titulo == "")
            {
                MessageBox.Show("Introduce un título");
                return;
            }

            Tarea nueva = new Tarea(titulo, descripcion, fecha);
            gestor.AñadirTarea(nueva);

            listBoxTareas.Items.Add(nueva);

            textBoxTitulo.Clear();
            textBoxDescripcion.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBoxTareas.SelectedIndex;


            if (indice == -1)
            {
                MessageBox.Show("Selecciona una tarea");
                return;
            }


            gestor.EliminarTarea(indice);
            listBoxTareas.Items.RemoveAt(indice);

        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            int indice = listBoxTareas.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Selecciona una tarea");
                return;
            }

            gestor.MarcarCompletada(indice);
            listBoxTareas.Items[indice] = gestor.ObtenerTareas()[indice];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace T4_P3_garcia_adrian
{
    internal class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public DateTime Fecha { get; set; }

        public Tarea(string titulo, string descripcion, DateTime fecha)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Fecha = fecha;
            Completada = false;
        }

        public override string ToString()
        {
            string estado = Completada ? "Completada" : "No completada";
            return $"{Titulo} - {Descripcion} - {estado} - {Fecha.ToShortDateString()}";
        }
    }
}


namespace T4_P3_garcia_adrian
{
    internal class GestorTareas
    {
        private List<Tarea> tareas;

        public GestorTareas()
        {
            tareas = new List<Tarea>();
        }

        public void AñadirTarea(Tarea t)
        {
            tareas.Add(t);
        }

        public void EliminarTarea(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
                tareas.RemoveAt(indice);
        }

        public void MarcarCompletada(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
                tareas[indice].Completada = true;
        }

        public List<Tarea> ObtenerTareas()
        {
            return tareas;
        }
    }
}

