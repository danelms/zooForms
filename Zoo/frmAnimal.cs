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
        Animal _myAnimal = null;

        public Animal getAnimal()
        {
            return _myAnimal; //Test
        }

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
            String _name, _contextual;
            int _legs, _chosenIndex;

            switch (_frmType)
            {

                case frmZoo.FormType.ADD:
                    switch (comboSpecies.SelectedIndex)
                    {
                        case 0:
                            _name = txtBoxName.Text;
                            _contextual = txtBoxContextual.Text;
                            _legs = Int16.Parse(txtBoxLegs.Text); //NEED VALIDATION!!
                            Bear _bear = new Bear(_name, _legs, _contextual);
                            _myAnimal = _bear;
                            break;

                        case 1:
                            _name = txtBoxName.Text;
                            _contextual = txtBoxContextual.Text;
                            _legs = Int16.Parse(txtBoxLegs.Text); //NEED VALIDATION!!
                            Lion _lion = new Lion(_name, _legs, _contextual);
                            _myAnimal = _lion;
                            break;
                        case 2:
                            _name = txtBoxName.Text;
                            _contextual = txtBoxContextual.Text;
                            _legs = Int16.Parse(txtBoxLegs.Text); //NEED VALIDATION!!
                            Fox _fox = new Fox(_name, _legs, _contextual);
                            _myAnimal = _fox;
                            break;
                    }
                    break;

                case frmZoo.FormType.EDIT:
                    
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
