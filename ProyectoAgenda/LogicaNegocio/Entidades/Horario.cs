namespace LogicaNegocio.Entidades
{
    public class Horario
    {
        public DayOfWeek Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}