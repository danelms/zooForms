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
            int _legs;

            if (formCheck())
            {
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
                        Animal x = _zoo.getAnimal(comboExisting.SelectedIndex);
                        switch (comboSpecies.SelectedIndex)
                        {
                            case 0:
                                Bear b = new Bear(x.getName(), Int32.Parse(txtBoxLegs.Text), txtBoxContextual.Text);
                                _zoo.removeAnimal(x);
                                _zoo.addAnimal(b);
                                break;
                            case 1:
                                Lion l = new Lion(x.getName(), Int32.Parse(txtBoxLegs.Text), txtBoxContextual.Text);
                                _zoo.removeAnimal(x);
                                _zoo.addAnimal(l);
                                break;
                            case 2:
                                Fox f = new Fox(x.getName(), Int32.Parse(txtBoxLegs.Text), txtBoxContextual.Text);
                                _zoo.removeAnimal(x);
                                _zoo.addAnimal(f);
                                break;
                        }

                        break;

                    case frmZoo.FormType.REMOVE:
                        Animal a = _zoo.getAnimal(comboExisting.SelectedIndex);
                        _zoo.removeAnimal(a);
                        break;
                }
            }
            else
            {
                MessageBox.Show("ERROR\n\nPlease ensure that all fields are filled in correctly, none are left blank, and try again.");
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

        private void UpdateEditRemoveFields(int index)
        {
            Animal a = _zoo.getAnimal(index);

            txtBoxName.Text = a.getName();
            txtBoxLegs.Text = a.getLegs().ToString();
            comboSpecies.Text = a.GetType().Name;
            String _cntxt;

            switch (a.GetType().Name)
            {
                case "Bear":
                    Bear b = (Bear)a;
                    _cntText = b.getHat();
                    break;

                case "Lion":
                    Lion l = (Lion)a;
                    _cntText = l.getCountry();
                    break;
                case "Fox":
                    Fox f = (Fox)a;
                    _cntText = f.getFurColour();
                    break;
            }

            txtBoxContextual.Text = _cntText;

        }

        private void comboExisting_SelectedIndexChanged(object sender, EventArgs e)
        {
                UpdateEditRemoveFields(comboExisting.SelectedIndex);
        }

        private bool formCheck()
        {
            int a;
            bool b = true;

            if (txtBoxName.Text.Equals(""))
            {
                b = false;
            }
            if (comboSpecies.Text.Equals(""))
            {
                b = false;
            }
            if (txtBoxLegs.Text.Equals(""))
            {
                b = false;
            }
            if (Int32.TryParse(txtBoxLegs.Text, out a).Equals(false))
            {
                b = false;
            }
            if (txtBoxContextual.Text.Equals(""))
            {
                b = false;
            }
            if (comboExisting.Visible && comboExisting.Text.Equals("Select Existing Animal"))
            {
                b = false;
            }

            return b;
        }
    }
}
