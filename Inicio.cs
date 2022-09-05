using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyeria_Molina
{
    public partial class Inicio : Form
    {
        private static IconMenuItem active_menu = null;
        private static Form formulario_activo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Función que abre un nuevo formulario y l adapta para que se pueda
        /// ver dentro de un panel
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="new_form"></param>
        private void AbrirFormulario(IconMenuItem menu, Form new_form)
        {
            if (active_menu != null)
            {
                active_menu.BackColor = Color.Silver;
            }

            menu.BackColor = Color.White;
            active_menu = menu;

            if (formulario_activo != null)
            {
                formulario_activo.Close();
            }

            formulario_activo = new_form;
            new_form.TopLevel = false;
            new_form.FormBorderStyle = FormBorderStyle.None;
            new_form.Dock = DockStyle.Fill;
            //new_form.BackColor = Color.SteelBlue;
            pnl_principal.Controls.Add(new_form);
            new_form.Show();
        }

        /// <summary>
        /// Función que sirve para abrir formularios dentro del panel principal
        /// segun a que icono se haga click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void user_ico_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Client_Form());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new User_form());
        }

        private void product_ico_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new ProductForm());
        }
    }
}
