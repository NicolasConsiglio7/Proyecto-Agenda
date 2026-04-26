namespace LogicaNegocio.Entidades
{
    public class Pago
    {
        public int Id { get; set; }

        public Reserva Reserva { get; set; }

        public decimal Monto { get; set; }

        public MetodoPago Metodo { get; set; }

        public DateTime Fecha { get; set; }
    }
}