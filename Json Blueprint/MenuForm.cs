using Json_Blueprint.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_Blueprint
{
    public partial class MenuForm : Form
    {
        List<Control> listControls = new List<Control>();
        int count = 0;
        int numOfAttributes;
        bool[] isCorrect;
        bool everythingIsCorrect = false;
        // structure variables
        string attrName, attrType;
        bool attrIsArray;
        int arraySize;

        public MenuForm()
        {
            InitializeComponent();
            formInit();
        }

        // ===== Events ==================================

        private void numberRestriction_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers on text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clearLayout();
            if (!string.IsNullOrWhiteSpace(txtNumAttr.Text))
            {
                numOfAttributes = Int32.Parse(txtNumAttr.Text);
                if (numOfAttributes <= 30)
                {
                    for (int i = 0; i < numOfAttributes; i++)
                    {
                        fillControlList(i);
                        FlowLayoutPanel flowLayout = ControlManager
                            .CreateLayout(new FlowLayoutPanel(),
                            FlowDirection.LeftToRight,
                            listControls);
                        flowLayoutPanel.Controls.Add(flowLayout);
                    }
                    isCorrect = new bool[numOfAttributes];
                    btnNext.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Maximum number of properties is 30.");
                }
            }
        }

        private void btnNextStage2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numOfAttributes; i++)
            {
                
            }
        }

        private void attrTxt_TextChanged(object sender, EventArgs e, int i)
        {
            checkTextBoxCorrectness(sender, i);
            checkAllValues();
        }

        private void txtNumAttr_TextChanged(object sender, EventArgs e)
        {
            checkNullValue(btnNext);
        }

        // ===== END OF Events ==================================


        // ===== Check Methods ==================================

        /// <summary>
        ///     Check if the text box is empty and disables the button passed as paremeter
        /// </summary>
        private void checkNullValue(Button btn)
        {
            if (btn.Text != "") btn.Enabled = true;
            else btn.Enabled = false;
        }

        /// <summary>
        ///     Check if the textbox about the attribute name, meets the correctness
        ///     requirments (the name doesnt start with a symbol or a number, the 
        ///     text box isn't empty etc.)
        /// </summary>
        private void checkTextBoxCorrectness(object sender, int i)
        {
            /*
            *  ^ : start of string
            *  [ : beginning of character group
            *  a-z : any lowercase letter
            *  A-Z : any uppercase letter
            *  0-9 : any digit
            *  _ : underscore
            *  ] : end of character group
            *  * : zero or more of the given characters
            *  $ : end of string
            */
            TextBox textBox;
            char firstLetter = '1'; // To avoid null
            textBox = (TextBox)sender;
            try
            {
                firstLetter = textBox.Text[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                isCorrect[i] = false;
            }
            ///<param name = "regex"> Allow characters, numbers and no symbols except underscore </ param >
            var regex = new Regex("^(?!_)[a-zA-Z0-9-'_]*$");
            if (!Char.IsLetter(firstLetter) || !regex.IsMatch(textBox.Text))
            {
                isCorrect[i] = false;
            }
            else
            {
                isCorrect[i] = true;
            }
        }

        /// <summary>
        ///     Check if all the text boxes contain valid values.
        /// </summary>
        private void checkAllValues()
        {
            count = 0;
            // Check if all text boxes have valid values
            for (int i = 0; i < isCorrect.Count(); i++)
            {
                if (isCorrect[i]) count++;
            }
            if (count == isCorrect.Count())
            {
                btnNext.Hide();
                btnNextStage2.Show();
                btnNextStage2.Enabled = true;
                everythingIsCorrect = true;
            }else
            {
                btnNextStage2.Enabled = false;
            }
        }

        // ===== END OF Check Methods ===========================


        // ===== Misc Methods ==================================

        private void clearLayout()
        {
            while (flowLayoutPanel.Controls.Count > 0)
            {
                flowLayoutPanel.Controls[0].Dispose();
            }
        }

        private Color setCustomColor(Int32 color)
        {
            Color temp = Color.FromArgb(color);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            return result;
        }

        private void centerControl(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }

        // ===== END OF Misc Methods ==================================

        // ===== Initialization Methods ==================================
        private void fillControlList(int i)
        {
            listControls.Clear();
            listControls.Add(createLabel(i));
            listControls.Add(createTextBox(i));
            listControls.Add(createLabel());
            listControls.Add(createComboBox(i));
            listControls.Add(createCheckBox(i));
            listControls.Add(createArraySizeTextBox(i));
        }

        private void listTypeIDLoad(List<DataTypeID> list)
        {
            list.Clear();
            list.Add(new DataTypeID(1, "string"));
            list.Add(new DataTypeID(2, "int"));
            list.Add(new DataTypeID(3, "char"));
            list.Add(new DataTypeID(4, "float"));
            list.Add(new DataTypeID(5, "double"));
            list.Add(new DataTypeID(6, "boolean"));
        }

        private void formInit()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            centerControl(btnNext);
            centerControl(btnNextStage2);
            centerControl(flowLayoutPanel);
            this.BackColor = setCustomColor(0xC4D4AF);
            menuStrip.BackColor = setCustomColor(0x6C8672);
            btnNext.BackColor = setCustomColor(0x68A8AD);
            btnNextStage2.BackColor = setCustomColor(0x68A8AD);
        }
        // ===== END OF Initialization Methods ==================================

        // ===== Dynamic UI Generation Methods ==================================
        private ComboBox createComboBox(int i)
        {
            int iteration = i + 1;
            List<DataTypeID> listTypeID = new List<DataTypeID>();
            listTypeIDLoad(listTypeID);
            ComboBox cmbox = new ComboBox();
            cmbox.Name = "cmboxDataType" + iteration;
            cmbox.DataSource = listTypeID;
            cmbox.DisplayMember = "dataType";
            cmbox.ValueMember = "ID";
            return cmbox;
        }

        private CheckBox createCheckBox(int i)
        {
            int iteration = i + 1;
            CheckBox cbx = new CheckBox();
            cbx.Text = "Array";
            cbx.Name = "cbxArray" + iteration;
            // lamda assignment
            cbx.CheckStateChanged += (sender, e) => 
            {
                CheckBox checkBox;
                checkBox = (CheckBox)sender;
                // Finds the text box control by name
                TextBox textBox = this.Controls.Find("txtArraySize" + iteration, true).FirstOrDefault() as TextBox;
                if (checkBox.Checked) textBox.Show();
                else textBox.Hide();
            };
            return cbx;
        }

        private TextBox createTextBox(int i)
        {
            int iteration = i + 1;
            TextBox txtBox = new TextBox();
            txtBox.Name = "txtAttrName" + iteration;
            txtBox.KeyUp += (sender, e) => attrTxt_TextChanged(sender, e, i);
            return txtBox;
        }

        private TextBox createArraySizeTextBox(int i)
        {
            int iteration = i + 1;
            TextBox txtBox = new TextBox();
            txtBox.Name = "txtArraySize" + iteration;
            // re-use of event to only number restriction
            txtBox.KeyPress += numberRestriction_KeyPress;
            txtBox.Hide();
            return txtBox;
        }

        private Label createLabel()
        {
            Label lbl = new Label();
            lbl.Text = ":";
            return lbl;
        }

        // Overload
        private Label createLabel(int i)
        {
            int count = i + 1;
            Label lbl = new Label();
            lbl.Text = count.ToString();
            return lbl;
        }
        // ===== END OF Dynamic UI Generation Methods ==================================
    }
}