namespace CriadoresDeCaes.Models {
    /// <summary>
    /// Descrição dos Criadores dos Cães
    /// </summary>
    public class Criadores {

        public Criadores() {
            ListaAnimais = new HashSet<Animais>();
            ListaRacas = new HashSet<Racas>();
        }

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

        /// <summary>
        /// FK para a lista de cães/cadelas, propriedade do Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// M-N
        /// FK para a lista de Raças atribuidas aos Criadores
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }


    }
}
