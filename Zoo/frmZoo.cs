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
        public enum FormType { ADD, EDIT, REMOVE }

        public frmZoo()
        {
            InitializeComponent();
            _zoo.addAnimal(_bear);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAnimal _anForm = new frmAnimal("Add animal", FormType.ADD, _zoo);
            //Opens form as "Dialog"
            if (_anForm.ShowDialog() == DialogResult.OK)
            {
                //Calls when DialogResult is OK (The context button is pressed)
                _zoo.addAnimal(_anForm.getAnimal());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form _anForm = new frmAnimal("Save changes", FormType.EDIT, _zoo);
            if (_anForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form _anForm = new frmAnimal("Remove animal", FormType.REMOVE, _zoo);
            if (_anForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
