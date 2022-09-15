using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class frmZoo : Form
    {
        Zoo _zoo = new Zoo();
        Bear _bear = new Bear("Reginald", 2, "Fez");

        public frmZoo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form _anForm = new frmAnimal("Add animal", false, "Add");
            _anForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form _anForm = new frmAnimal("Save changes", true, "Edit");
            _anForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form _anForm = new frmAnimal("Remove animal", true, "Remove");
            _anForm.Show();
        }
    }
}
