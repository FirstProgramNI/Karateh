using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karate_tournament
{
    public partial class Create_T : Form
    {
        public Create_T()
        {
            InitializeComponent();
        }

        public void Main_Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.database1DataSet1.Players);
            // TODO: This line of code loads data into the 'database1DataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.database1DataSet.Players);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::karate_tournament.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO Players(TurNum,PlayerName) values("+txtTur.Text+",'"+txtPlayer.Text+"')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show(" !! تم الحفظ بنجاح ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.playersTableAdapter.Fill(this.database1DataSet.Players);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.database1DataSet.Players);
        }

        
            
    }
}
