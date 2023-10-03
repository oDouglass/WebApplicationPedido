using System.ComponentModel.DataAnnotations;

namespace Pedido.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public TipoStatus Status { get; set; }
        public float? SomaTotal { get; set; }
        public Cliente? Cliente { get; set; }
        public Garcom? Garcom { get; set; }
        public Mesa? Mesa{ get; set; }
        public List<Produto>? Produto { get; set; }
        public Pagamento? Pagamento { get; set; }
        public Desconto? Desconto { get; set; }
        public Taxa? Taxa { get; set; } 
        public enum TipoStatus
        {
            PedidoAnotado,
            EmPreparacao,
            PedidoConcluido,
            AguardandoPagamento,
            PagamentoConfirmado,
            EmProcessamento
        }
    }
}
