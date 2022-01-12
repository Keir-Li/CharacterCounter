using System.Windows.Forms;

namespace CharacterCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_count_Click(object sender, System.EventArgs e)
        {
            // Textbox Validation Check for Empty String
            if (txtbox_characterstocount.Text == "")
            {
                lbl_errorblanktext.Visible = true;
                string errormessage = "Please type characters to count in the text box.";
                string errortitle = "Error";
                MessageBox.Show(errormessage, errortitle);
            }
            else
            {
                // Display Counter Characters in Count Textbox
                lbl_errorblanktext.Visible = false;
                int characterLength = txtbox_characterstocount.Text.Length;
                var characterLengthString = characterLength.ToString();
                txtbox_countercharacters.Text = characterLengthString;

            }
        }

        private void btn_copycountedcharacters_Click(object sender, System.EventArgs e)
        {
            // Textbox Validation Check for Empty String
            if (txtbox_countercharacters.Text == "")
            {
                lbl_errorblanktext.Visible = true;
                string errormessage = "Please type characters to count in the text box.";
                string errortitle = "Error";
                MessageBox.Show(errormessage, errortitle);
            }
            else
            {
                // Copy Characters to Clipboard
                lbl_errorblanktext.Visible = false;
                Clipboard.SetText(txtbox_countercharacters.Text);
                string message = "Counted Characters Copied!";
                string title = "Success";
                MessageBox.Show(message, title);
            }
        }
    }
}
