namespace SPEe.ValueObjects
{
    /// <summary>
    /// Nome, apelido e título
    /// </summary>
    public class Nominal
    {
        #region Propriedades

        /// <summary>
        /// Forma mais fácil e rápida de identificar
        /// </summary>
        public string Apelido { get; set; }

        /// <summary>
        /// Método formal para tratamento por escrito
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Nome completo
        /// </summary>
        public string Nome { get; set; }

        #endregion Propriedades

        #region Métodos

        /// <summary>
        /// Cria um objeto Nominal
        /// </summary>
        /// <param name="value">Informações do objeto Nominal</param>
        /// <returns></returns>
        public static Nominal Create(Nominal value)
        {
            return new Nominal
            {
                Apelido = value.Apelido?.Length > 60 ? value.Apelido?.Substring(0, 60) : value.Apelido,
                Titulo = value.Titulo?.Length > 40 ? value.Titulo?.Substring(0, 40) : value.Titulo,
                Nome = value.Nome?.Length > 50 ? value.Nome?.Substring(0, 50) : value.Nome
            };
        }

        #endregion Métodos
    }
}