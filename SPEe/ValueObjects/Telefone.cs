namespace SPEe.ValueObjects
{
    /// <summary>
    /// Telefone
    /// </summary>
    public class Telefone
    {
        #region Propriedades

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

        #endregion Propriedades

        /// <summary>
        /// Cria um objeto Telefone
        /// </summary>
        /// <param name="value">Informações do objeto Telefone</param>
        /// <returns></returns>
        public static Telefone Create(Telefone value)
        {
            return new Telefone
            {
                DDD = value.DDD?.Length > 4 ? value.DDD?.Replace("(", "").Replace(")", "").Substring(0, 4) : value.DDD?.Replace("(", "").Replace(")", ""),
                Numero = value.Numero?.Length > 20 ? value.Numero?.Replace("-", "").Substring(0, 20) : value.Numero?.Replace("-", ""),
                DDDFax = value.DDDFax?.Length > 4 ? value.DDDFax?.Replace("(", "").Replace(")", "").Substring(0, 4) : value.DDDFax?.Replace("(", "").Replace(")", ""),
                NumeroFax = value.NumeroFax?.Length > 20 ? value.NumeroFax?.Replace("-", "").Substring(0, 20) : value.NumeroFax?.Replace("-", "")
            };
        }
    }
}