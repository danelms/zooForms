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
    public partial class frmAnimal : Form
    {
        String _cntText = "";
        Zoo _zoo = null;
        Enum _frmType = null;

        public frmAnimal(String useType, frmZoo.FormType formType, Zoo zoo)
        {
            InitializeComponent();
            comboSpecies.Items.Add("Bear");
            comboSpecies.Items.Add("Lion");
            comboSpecies.Items.Add("Fox");
            btnContextual.Text = useType;
            _zoo = zoo;
            _frmType = formType;

            if (formType == frmZoo.FormType.REMOVE || formType == frmZoo.FormType.EDIT)
            {
                txtBoxName.Enabled = false;
                comboSpecies.Enabled = false;

                foreach (Animal a in _zoo.getAllAnimals())
                {
                    if (a != null)
                    {
                        comboExisting.Items.Add(a.getName());
                    }
                }

                if (formType == frmZoo.FormType.REMOVE)
                {
                    txtBoxLegs.Enabled = false;
                    txtBoxContextual.Enabled = false;
                }
            }

            else
            {
                comboExisting.Enabled = false;
                comboExisting.Hide();
            }
        }

        private void btnContextual_Click(object sender, EventArgs e)
        {
            switch (_frmType)
            {
                case frmZoo.FormType.ADD:
                    //call method to add animal
                    break;

                case frmZoo.FormType.EDIT:
                    //call method to edit animal
                    break;

                case frmZoo.FormType.REMOVE:
                    //call method to remove animal
                    break;
            }
        }

        private void UpdateContextualText()
        {
            switch (comboSpecies.SelectedIndex)
            {
                case 0:
                    _cntText = "Hat Style";
                    break;
                case 1:
                    _cntText = "Country of Origin";
                    break;
                case 2:
                    _cntText = "Fur Colour";
                    break;
            }

            lblContextual.Text = _cntText;
            lblContextual.Show();
        }

        private void comboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContextualText();
        }

    }
}
