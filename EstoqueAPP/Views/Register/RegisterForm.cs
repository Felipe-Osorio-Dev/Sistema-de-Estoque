using EstoqueAPP.DTO.Requests;

namespace EstoqueAPP.Views.Register
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();
            btnRegisterProduct.Enabled = false;

            txtBoxBarCode.KeyPress += ValidateBarCode;
            txtBoxName.TextChanged += ValidateData;
            txtBoxBarCode.TextChanged += ValidateData;
        }

        public event EventHandler<RegisterProductEventArgs> ClickRegisterProduct;

        public void ValidateBarCode(object sender, KeyPressEventArgs eventArgs)
        {
            if(!char.IsDigit(eventArgs.KeyChar) && eventArgs.KeyChar != (char)Keys.Back)
            {
                eventArgs.Handled = true;
            };
        }

        public void ValidateData(object sender, EventArgs eventArgs)
        {
            btnRegisterProduct.Enabled = !string.IsNullOrWhiteSpace(txtBoxName.Text) 
                && !string.IsNullOrWhiteSpace(txtBoxBarCode.Text);
        }

        private async void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new RegisterProductDTO(
                    txtBoxName.Text,
                    txtBoxBarCode.Text,
                    (int)numericAmount.Value,
                    DateOnly.FromDateTime(dateTimeValidate.Value)
                );

                ClickRegisterProduct?.Invoke(this, new RegisterProductEventArgs(product));
            }
            catch (Exception)
            {
                MessageBox.Show
                    (
                        "Erro ao Tentar registrar o produto",
                        "Dados Invalidos/Incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }
    }
}
