namespace EstoqueAPP.DTO.Requests
{
    public record RegisterProductDTO(string Name, string BarCode, int Amount, DateOnly Validate);
}
