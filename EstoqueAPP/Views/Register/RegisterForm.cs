using EstoqueAPP.DTO.Requests;

namespace EstoqueAPP.Views.Register
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public event EventHandler<RegisterProductEventArgs> ClickRegisterProduct;

        private async void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            var product = new RegisterProductDTO
            (
                txtBoxName.Text,
                txtBoxBarCode.Text,
                int.Parse(txtBoxAmount.Text),
                DateOnly.FromDateTime(dateTimeValidate.Value)
            );



            ClickRegisterProduct?.Invoke(this, new RegisterProductEventArgs(product));
        }
    }
}
