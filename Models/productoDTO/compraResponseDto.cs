public class CompraResponseDto
{
    public int IdUser { get; set; }
    public int IdCompra { get; set; }
    public string UserName { get; set; }
    public List<ProductoCompraResponseDto> Productos { get; set; }
}