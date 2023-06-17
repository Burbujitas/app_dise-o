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
    public partial class Form1 : Form
    {
        private Menu menu;
        public Form1(Menu menu)
        {
            InitializeComponent();
            agregarCombobox();
            this.menu = menu;
        }
        public void agregarCombobox()
        {

            rjComboBox1.Items.Add("Perifericos");
            rjComboBox1.Items.Add("Laptops");
            rjComboBox1.Items.Add("Celulares");
            rjComboBox1.Items.Add("Componentes");
            rjComboBox1.Items.Add("Accesorios");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto { codigo = txtCodigo.Texts, categoria = rjComboBox1.SelectedItem.ToString(), descripcion = txtDescripcion.Text, stock = Int32.Parse(txtStock.Texts), precio = double.Parse(txtPrecio.Texts), activo = true };
            Console.WriteLine("esto se muestra "+txtDescripcion.Text);

            // { codigo= txtCodigo.Texts,categoria = rjComboBox1.SelectedItem.ToString(),descripcion=txtDescripcion.Text,stock=Int32.Parse(txtStock.Texts),precio=double.Parse(txtPrecio.Texts),activo=true};
            menu.listaProductos.Add(productoNuevo);
            menu.cambiar_texto();
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
