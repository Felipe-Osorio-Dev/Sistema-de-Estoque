using EstoqueAPP.Views.Main;

namespace EstoqueAPP
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler RegisterProduct;

        private void menuItemRegister_Click(object sender, EventArgs e)
        {
            RegisterProduct?.Invoke(this, EventArgs.Empty);
        }
    }
}
