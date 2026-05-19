namespace EstoqueAPP.Views.Register
{
    internal interface IRegisterView
    {
        event EventHandler<RegisterProductEventArgs> ClickRegisterProduct;

        void ValidateBarCode(Object sender, KeyPressEventArgs eventArgs);
        void ValidateData(Object sender, EventArgs eventArgs);
    }
}
