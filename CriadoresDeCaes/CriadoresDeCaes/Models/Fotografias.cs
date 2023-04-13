using System.ComponentModel.DataAnnotations.Schema;

namespace CriadoresDeCaes.Models
{
    /// <summary>
    /// Fotografias associadas aos cães
    /// </summary>
    public class Fotografias
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nome do documento com a fotografia do cão/cadela
        /// </summary>
        public string NomeFicheiro { get; set; }

        /// <summary>
        /// Data em que a fotografia foi tirada
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }

        //******************************************
        [ForeignKey(nameof(Animal))] // <=>  [ForeignKey("Animal")]
        public int AnimalFK { get; set; }
        
        public Animais Animal { get; set; }
    }
}
