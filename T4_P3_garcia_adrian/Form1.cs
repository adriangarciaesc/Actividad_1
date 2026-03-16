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

            cmbCategoria.SelectedIndex = 0;

            lblContadorTareas.Text = "0";

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTitulo.Text;
            string descripcion = textBoxDescripcion.Text;
            DateTime fecha = dateTimePickerFecha.Value;
            string categoria = cmbCategoria.Text;
            bool prioridadAlta = chkPrioridadAlta.Checked;

            if (titulo == "")
            {
                MessageBox.Show("Introduce un título");
                return;
            }

            Tarea nueva = new Tarea(titulo, descripcion, fecha, categoria, prioridadAlta);
            gestor.AñadirTarea(nueva);

            listBoxTareas.Items.Add(nueva);

            ActualizarContador();

            LimpiarCampos();

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

            ActualizarContador();

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

        void ActualizarContador()
        {
            lblContadorTareas.Text = gestor.ObtenerTareas().Count.ToString();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            textBoxTitulo.Clear();
            textBoxDescripcion.Clear();
            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = 0;
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
        public string Tipo { get; set; }
        public bool PrioridadAlta { get; set; }

        public Tarea(string titulo, string descripcion, DateTime fecha, string tipo, bool prioridad)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Fecha = fecha;
            Tipo = tipo;
            PrioridadAlta = prioridad;
            Completada = false;
        }

        public override string ToString()
        {
            string estado = Completada ? "Completada" : "No completada";
            string prioridad = PrioridadAlta ? "Prioridad Alta" : "";

            return $"{Titulo} - {Descripcion} - {Tipo} - {prioridad} - {estado} - {Fecha.ToShortDateString()}";
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

        public int NumeroTareas()
        {
            return tareas.Count;
        }
    }
}

