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

        public frmAnimal(String useType, bool showCombo, String mode)
        {
            InitializeComponent();
            comboSpecies.Items.Add("Bear");
            comboSpecies.Items.Add("Lion");
            comboSpecies.Items.Add("Fox");
            btnContextual.Text = useType;

            if (!showCombo)
            {
                comboExisting.Enabled = false;
                comboExisting.Hide();
            }

            if (mode.Equals("Edit") || mode.Equals("Remove"))
            {
                txtBoxName.Enabled = false;
                comboSpecies.Enabled = false;

                if (mode.Equals("Remove"))
                {
                    txtBoxLegs.Enabled = false;
                    txtBoxContextual.Enabled = false;
                }
            }
        }

        private void btnContextual_Click(object sender, EventArgs e)
        {
            
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
        }

        private void comboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContextualText();
        }
    }
}
