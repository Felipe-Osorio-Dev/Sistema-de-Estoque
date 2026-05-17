using EstoqueAPP.DTO.Requests;

namespace EstoqueAPP.Views.Register
{
    public class RegisterProductEventArgs : EventArgs
    {
        public RegisterProductDTO Product { get; }

        public RegisterProductEventArgs(RegisterProductDTO product)
        {
            Product = product;
        }
    }
}
