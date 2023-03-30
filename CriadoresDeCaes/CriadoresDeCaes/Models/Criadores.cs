namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Descrição dos Criadores dos Cães
    /// </summary>
    public class Criadores
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome comercial do criador
        /// </summary>
        public string NomeCriador { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do criador
        /// </summary>
        public string CodPostal { get; set; }
        
        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do criador
        /// </summary>
        public int Telemovel { get; set; }
    }
}
