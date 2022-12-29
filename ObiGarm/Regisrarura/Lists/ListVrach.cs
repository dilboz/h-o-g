using ObiGarm.ClassDatabase;
using System;
using System.Windows.Forms;

namespace ObiGarm.Regisrarura.Lists
{
    public partial class ListVrach : DevExpress.XtraEditors.XtraForm
    {

        SqlConfiguration sqlConfiguration;
        private readonly AddCllient addCllient_;
        private readonly EdirClient edirClient_;
        public ListVrach(AddCllient addCllient)
        {
            addCllient_ = addCllient;
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }

        public ListVrach(EdirClient edirClient)
        {
            edirClient_ = edirClient;
            InitializeComponent();
            sqlConfiguration = new SqlConfiguration();
        }
        string id_vrach;
        void dispLay()
        {
            string sql = "select id, concat(surname, ' ', name , ' (', summa_cliet , ')') as 'all_name', deleted " +
                         "from users where `point` = 3 and deleted is null " +
                         "order by summa_cliet desc;";
            sqlConfiguration.LoadList(sql, "all_name", "id", list_load_vrach);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_load_vrach_Click(object sender, EventArgs e)
        {
            id_vrach = list_load_vrach.SelectedValue.ToString();
            txt_vrach.Text = list_load_vrach.GetDisplayItemValue(list_load_vrach.SelectedIndex).ToString();
        }

        private void ListVrach_Shown(object sender, EventArgs e)
        {
            dispLay();
            if (list_load_vrach.ItemCount == 0)
            {
                MessageBox.Show("Дар система табиб", "Хатоги");
            }
            else
            {

                id_vrach = list_load_vrach.SelectedValue.ToString();

                txt_vrach.Text = list_load_vrach.GetDisplayItemValue(0).ToString();
            }
        }

        private void btn_inser_vrach_Click(object sender, EventArgs e)
        {

            if (addCllient_!=null)
            {
                addCllient_.name_doctor = txt_vrach.Text;
                addCllient_.id_vrach = id_vrach;
            }
            if (edirClient_!=null)
            {
                edirClient_.name_vrach_ = txt_vrach.Text;
                edirClient_.id_vrach_me = id_vrach;
                edirClient_.set_names_varch_();
            }
            
            this.Close();
        }

    }
}
