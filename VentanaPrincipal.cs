using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_2022
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; // guarda el id del pokemon que se esta viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            derecha.BackColor = Color.Transparent;
            derecha.Parent = pokedex;
            derecha.Location = new Point(395, 560);

            
            izquierda.BackColor = Color.Transparent;
            izquierda.Parent = pokedex;
            izquierda.Location = new Point(335, 560);

        }

        private void button1_Click(object sender, EventArgs e)//es el boton izquierdo
        {
            
            if(idActual > 1)
            {
                idActual--;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            tipoPokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPokemon.Text = misPokemons.Rows[0]["peso"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            if (idActual < 151)
            {
                idActual++;
            }
            
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            tipoPokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            pesoPokemon.Text = misPokemons.Rows[0]["peso"].ToString();
            descripcionPokemons.Text = misPokemons.Rows[0]["descripcion"].ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void tipoPokemon_Click(object sender, EventArgs e)
        {
            
        }

        private void pesoPokemon_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void descripcionPokemons_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
