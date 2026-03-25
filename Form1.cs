namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GeneratePassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghikjlmnopqrstuvwxyz1234567890!@#$";
            Random random = new Random();
            return chars[random.Next(chars.Length)].ToString();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
            }
        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                txtPassword.Text = GeneratePassword();
            }
        }
    }
}
