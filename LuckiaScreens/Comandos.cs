using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckiaScreens
{
    internal class Comandos
    {
        private FileSystemWatcher watcher;
        private Form padre; // referencia al formulario para usar Invoke

        public Comandos(Form form)
        {
            padre = form;
        }

        public void IniciarWatcherComandos()
        {
            string path = Application.StartupPath + "\\Config\\comandos.txt";

            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(path);
            watcher.Filter = Path.GetFileName(path);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += Watcher_Changed;
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                string[] lineas = File.ReadAllLines(e.FullPath);
                if (lineas.Length > 0)
                {
                    string comando = lineas[0].Trim().ToLower();

                    // Usamos Invoke a través del formulario
                    padre.Invoke((MethodInvoker)(() =>
                    {
                        EjecutarComando(comando);
                    }));
                }
            }
            catch { }
        }

        /*private void EjecutarComando(string comando)
        {
            MessageBox.Show($"Comando recibido: {comando}");

        }*/
        private void EjecutarComando(string comando)
        {
            switch (comando)
            {
                case "lanzar":
                    MessageBox.Show("Lanzar");
                    break;
                case "auto":
                    MessageBox.Show("Auto");
                    break;
                case "kill":
                    MessageBox.Show("Kill");
                    break;
                case "cargarconfig":
                    MessageBox.Show("cargaconfig");
                    break;
                case "borrarcache 123":
                    //if (argumentos.Length > 1 && long.TryParse(argumentos[1], out long mb))
                    //{
                    //Funciones.BorrarCache(mb);
                    MessageBox.Show("Borrar " + " Mb");
                    //}
                    break;
                default:
                    MessageBox.Show("Comando no reconocido: " + comando);
                    break;
            }
        }
    }
}
