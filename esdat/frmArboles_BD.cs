using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace esdat
{
    public partial class frmArboles_BD : Form
    {
        public frmArboles_BD()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand comd;
        MySqlDataReader dr;
        private void games()
        {
            tvPRUEBA.Nodes.Clear();
            con = new MySqlConnection("Server=127.0.0.1;username=root;password=siqueirosuth19;database=games");
            tvPRUEBA.Nodes.Add("Juegos");
            con.Open();
            string q = "SELECT * FROM juegos";
            comd = new MySqlCommand(q, con);
            dr = comd.ExecuteReader();
            while (dr.Read())
            {
                tvPRUEBA.Nodes[0].Nodes.Add(dr.GetString(0));
            }
            dr.Close();
            string q1 = "SELECT * FROM developers";
            comd = new MySqlCommand(q1, con);
            dr = comd.ExecuteReader();
            tvPRUEBA.Nodes.Add("developers");
            while (dr.Read())
            {
                tvPRUEBA.Nodes[1].Nodes.Add(dr.GetString(0) + " " + dr.GetString(1));
            }
            dr.Close();
            string q2 = "SELECT * FROM players";
            comd = new MySqlCommand(q2, con);
            dr = comd.ExecuteReader();
            tvPRUEBA.Nodes.Add("players");
            while (dr.Read())
            {
                tvPRUEBA.Nodes[2].Nodes.Add(dr.GetString(0) + " " + dr.GetString(1) + " " + dr.GetString(2));
            }
            dr.Close();
        }
        private void integradora()
        {
            tvpruebita.Nodes.Clear();
            con = new MySqlConnection("Server=127.0.0.1;username=root;password=siqueirosuth19;database=integradora");
            tvpruebita.Nodes.Add("Integradora");
            con.Open();
            string q = "SHOW TABLES FROM integradora";
            comd = new MySqlCommand(q, con);
            dr = comd.ExecuteReader();
            while (dr.Read())
            {
                tvpruebita.Nodes[0].Nodes.Add(dr.GetString(0));
            }
            dr.Close();
           
        }
        private void showtables()
        {
            tvSHOWTABLES.Nodes.Clear();
            con = new MySqlConnection("Server=127.0.0.1;username=root;password=siqueirosuth19");
            con.Open();
            string q = "SHOW DATABASES";
            comd = new MySqlCommand(q, con);
            dr = comd.ExecuteReader();
            while (dr.Read())
            {
                tvSHOWTABLES.Nodes.Add(dr.GetString(0));
            }
            dr.Close();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            tvBASEDATOS.Nodes.Add("tabla1");
            tvBASEDATOS.Nodes[0].Nodes.Add("Campo 1 Value");
            tvBASEDATOS.Nodes[0].Nodes.Add("Campo 1 Value");
            tvBASEDATOS.Nodes[0].Nodes[1].Nodes.Add("Campo 1 Value");
            tvBASEDATOS.Nodes.Add("tabla2");
            tvBASEDATOS.Nodes[1].Nodes.Add("Campo 2 Value Campo 2 Value");
            tvBASEDATOS.Nodes[1].Nodes.Add("Campo 2 Value Campo 2 Value");
            tvBASEDATOS.Nodes.Add("tabla3");
            tvBASEDATOS.Nodes[2].Nodes.Add("Campo 3 Value Campo 3 Value Campo 3 Value");
            tvBASEDATOS.Nodes[2].Nodes.Add("Campo 3 Value Campo 3 Value Campo 3 Value");
            tvBASEDATOS.Nodes[2].Nodes.Add("Campo 3 Value Campo 3 Value Campo 3 Value");
        }
        private void btnCERRAR_Click(object sender, EventArgs e) => this.Close();
        private void btnEJEMPLOS_Click(object sender, EventArgs e)
        {
            
            games();
            integradora();
            showtables();
        }
        private void btnExpandir_Click(object sender, EventArgs e)
        {
            tvBASEDATOS.ExpandAll();
            tvPRUEBA.ExpandAll();
            tvpruebita.ExpandAll();
            tvSHOWTABLES.ExpandAll();
        }
        private void btnContraer_Click(object sender, EventArgs e)
        {
            tvSHOWTABLES.CollapseAll();
            tvpruebita.CollapseAll();
            tvPRUEBA.CollapseAll();
            tvBASEDATOS.CollapseAll();
        }
    }
}