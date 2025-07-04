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

namespace LuckiaScreens
{
    public partial class LuckiaScreens : Form
    {
        string[] argumentos;
        public LuckiaScreens()
        {
            InitializeComponent();
            Comandos comandos = new Comandos(this);
            comandos.IniciarWatcherComandos();
        }
        public LuckiaScreens(string[] args)
        {
            argumentos = args;
            //Funciones.setPadre(this);
            if (argumentos.Length > 0)
            {
                switch (argumentos[0].ToLower())
                {
                    case "lanzar":
                        MessageBox.Show("Lanzar");
                        InitializeComponent();
                        break;
                    case "auto":
                        MessageBox.Show("Auto");
                        InitializeComponent();
                        break;
                    case "kill":
                        MessageBox.Show("Kill");
                        InitializeComponent();
                        break;
                    case "cargarconfig":
                        MessageBox.Show("cargaconfig");
                        InitializeComponent();
                        break;
                    case "borrarcache":
                        if (argumentos.Length > 1 && long.TryParse(argumentos[1], out long mb))
                        {
                            //Funciones.BorrarCache(mb);
                            MessageBox.Show("Borrar " + argumentos[1] + "Mb");
                        }
                        InitializeComponent();
                        break;
                    default:
                        MessageBox.Show($"Parámetro no reconocido: {argumentos[0]}");
                        break;
                }
            }
            else
            {
                InitializeComponent();
            }
        }
        

        private void chkPantalla1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPantalla2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPantalla3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPantalla4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPantalla5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPantalla6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            Opciones formOpciones = new Opciones();
            formOpciones.Show();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
