using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Menu : Form
    {
        public List<Producto> listaProductos;
        public Menu()
        {
            InitializeComponent();
            
            agregarDatos();
            agregarCombobox();
         
        }
        public void agregarDatos()
        {
            listaProductos = new List<Producto>();
            listaProductos.Add(new Producto { codigo = "ZAP-09454", categoria = "Perifericos", stock = 10, precio = 100, descripcion = "audiofonos inhalambricos", activo = true });
            listaProductos.Add(new Producto { codigo = "ZAP-32452", categoria = "Componentes", stock = 10, precio = 800, descripcion = "procesador core i5", activo = true });
            listaProductos.Add(new Producto { codigo = "ZAP-23425", categoria = "Perifericos", stock = 10, precio = 50, descripcion = "teclado generico", activo = false });

            dataGridView1.DataSource = listaProductos;
        }
  
        public void agregarCombobox()
        {
            
            rjComboBox1.Items.Add("Perifericos");
            rjComboBox1.Items.Add("Laptops");
            rjComboBox1.Items.Add("Celulares");
            rjComboBox1.Items.Add("Componentes");
            rjComboBox1.Items.Add("Accesorios");
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string textoBusqueda = rjComboBox1.SelectedItem.ToString();

            Console.WriteLine(textoBusqueda);

            List<Producto> listaFiltrada = listaProductos.Where(p => p.categoria.Contains(textoBusqueda)).ToList();

            dataGridView1.DataSource = listaFiltrada;

            dataGridView1.Refresh();
        }

      

        public void cambiar_texto()
        {
            string textoBusqueda = rjTextBox1.Texts;

            Console.WriteLine(textoBusqueda);

            List<Producto> listaFiltrada = listaProductos.Where(p => p.codigo.Contains(textoBusqueda)).ToList();

            dataGridView1.DataSource = listaFiltrada;

            dataGridView1.Refresh();
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            cambiar_texto();
        }
    }
}
