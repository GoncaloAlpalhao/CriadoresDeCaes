namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Descrição das Raças dos Cães
    /// </summary>
    public class Racas
    {

        public Racas()
        {
            ListaAnimais = new HashSet<Animais>();
            ListaCriadores = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Designação da raça
        /// </summary>
        public int Nome { get; set; }

        /// <summary>
        /// Lista de animais que são de uma determinada raça
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// M-N
        /// FK para a lista de Criadores que criam uma determinada raça
        /// </summary>
        public ICollection<Criadores> ListaCriadores { get; set;}

    }
}
