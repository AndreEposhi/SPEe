namespace SPEe.ValueObjects
{
    /// <summary>
    /// Telefone
    /// </summary>
    public class Telefone
    {
        /// <summary>
        /// Código DDD do Telefone
        /// </summary>
        public string DDD { get; set; }

        /// <summary>
        /// Número do Telefone do Remetente
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Código DDD do Fax do Remetente
        /// </summary>
        public string DDDFax { get; set; }

        /// <summary>
        /// Número do Fax do Remetente
        /// </summary>
        public string NumeroFax { get; set; }
    }
}