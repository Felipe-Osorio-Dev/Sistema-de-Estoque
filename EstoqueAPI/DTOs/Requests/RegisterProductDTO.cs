namespace EstoqueAPI.DTOs.Requests
{
    public record RegisterProductDTO(string Name, string BarCode, int Amount, DateOnly Validate);
}
