namespace ShamsiDateTimeHelperTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ShamsiDateTime GetInputValue()
        {
            if (rbGregorian.Checked)
            {
                return new ShamsiDateTime(DateTime.Parse(txtInputGregorian.Text));
            }
            else if (rbShamsi.Checked)
            {
                return new ShamsiDateTime(txtInputShamsi.Text);
            }
            else
            {
                int year = !string.IsNullOrEmpty(txtYear.Text) ? Convert.ToInt32(txtYear.Text) : 0;
                int month = !string.IsNullOrEmpty(txtMonth.Text) ? Convert.ToInt32(txtMonth.Text) : 0;
                int day = !string.IsNullOrEmpty(txtDay.Text) ? Convert.ToInt32(txtDay.Text) : 0;
                int hour = !string.IsNullOrEmpty(txtHour.Text) ? Convert.ToInt32(txtHour.Text) : 0;
                int minute = !string.IsNullOrEmpty(txtMinute.Text) ? Convert.ToInt32(txtMinute.Text) : 0;
                int second = !string.IsNullOrEmpty(txtSecond.Text) ? Convert.ToInt32(txtSecond.Text) : 0;

                return new ShamsiDateTime(year, month, day, hour, minute, second);
            }
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ShamsiDateTime.Now.DateTimeString, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(ShamsiDateTime.Today.DateString, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDateTimeNow_Click(object sender, EventArgs e)
        {
            try
            {
                txtInputGregorian.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDateTimeString_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.DateTimeString, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDateTimeStringWithoutLeadingZero_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.DateTimeStringWithoutLeadingZero, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDateString_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.DateString, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDateStringWithoutLeadingZero_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.DateStringWithoutLeadingZero, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimeString_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.TimeString, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimeStringWithoutLeadingZero_Click(object sender, EventArgs e)
        {
            try
            {
                ShamsiDateTime shamsiDateTime = GetInputValue();
                MessageBox.Show(shamsiDateTime.TimeStringWithoutLeadingZero, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    class PHTextBox : System.Windows.Forms.TextBox
    {
        System.Drawing.Color DefaultColor;
        public string PlaceHolderText { get; set; }
        public PHTextBox(string placeholdertext)
        {
            // get default color of text
            DefaultColor = this.ForeColor;
            // Add event handler for when the control gets focus
            this.GotFocus += (object sender, EventArgs e) =>
            {
                this.Text = String.Empty;
                this.ForeColor = DefaultColor;
            };

            // add event handling when focus is lost
            this.LostFocus += (Object sender, EventArgs e) => {
                if (String.IsNullOrEmpty(this.Text) || this.Text == PlaceHolderText)
                {
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = PlaceHolderText;
                }
                else
                {
                    this.ForeColor = DefaultColor;
                }
            };



            if (!string.IsNullOrEmpty(placeholdertext))
            {
                // change style   
                this.ForeColor = System.Drawing.Color.Gray;
                // Add text
                PlaceHolderText = placeholdertext;
                this.Text = placeholdertext;
            }



        }

        public PHTextBox()
        {
        }
    }
}