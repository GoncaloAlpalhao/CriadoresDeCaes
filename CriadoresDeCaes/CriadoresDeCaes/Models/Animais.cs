using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models {
    /// <summary>
    /// Descrição dos Animais
    /// </summary>
    public class Animais {
        public Animais() {
            ListaFotografias = new HashSet<Fotografias>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento do cão
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Sexo do cão
        /// F - Fêmea
        /// M - Macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// número de registo no LOP
        /// </summary>
        public string NumLOP { get; set; }

        // ****************************************

        /// <summary>
        /// lista das fotografias associadas a um animal
        /// </summary>
        public ICollection<Fotografias> ListaFotografias { get; set; }

        /// <summary>
        /// FK para a Raça do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Raca))]
        public int RacaFK { get; set; }
        public Racas Raca { get; set; }

        /// <summary>
        /// FK para o Criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }

    }
}
