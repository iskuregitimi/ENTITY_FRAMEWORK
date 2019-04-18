using Iskur_EF.BLL;
using Iskur_EF.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskur_EF.UI.Win
{
    public partial class dlg_PersonelGuncelle : Form
    {
              Person person = new Person();
        public int BusiennesId;
        public dlg_PersonelGuncelle()
        {
            InitializeComponent();
        }


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
           person= PersonBLL.getPerson(BusiennesId);
           
     
            
          
            person.FirstName = txt_name.Text;
            person.LastName = txt_lastname.Text;
            person.MiddleName = txt_midlename.Text;
            PersonBLL.addPerson(person);
           
        }

    }
}
