using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_prestamos_deportivo
{
    public partial class frm_configuracion : Form
    {
        public frm_configuracion()
        {
            InitializeComponent();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_configuracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_pretamos_deportivosDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_pretamos_deportivosDataSet.tbl_sexo);

        }
    }
}
