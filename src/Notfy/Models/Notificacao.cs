//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notfy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Notificacao
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "� obrigat�rio informar o notificando", AllowEmptyStrings = false)]
        public int NotificandoID { get; set; }

        [Required(ErrorMessage = "� obrigat�rio informar a matr�cula do im�vel", AllowEmptyStrings = false)]
        [DisplayName("Matr�cula")]
        public int MatriculaImovel { get; set; }

        [Required(ErrorMessage = "� obrigat�rio informar o notificador", AllowEmptyStrings = false)]
        [DisplayName("Notificador")]
        public int NotificadorID { get; set; }

        [DisplayName("Sequ�ncia")]
        public Nullable<int> Sequencia { get; set; }

        [DisplayName("Tentativa 1")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inv�lido")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Tentativa1 { get; set; }

        [DisplayName("Tentativa 2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inv�lido")]
        public Nullable<System.DateTime> Tentativa2 { get; set; }

        [DisplayName("Tentativa 3")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inv�lido")]
        public Nullable<System.DateTime> Tentativa3 { get; set; }

        [DisplayName("Conclu�do")]
        public Nullable<byte> Concluido { get; set; }

        [DisplayName("Observa��o")]
        public string Observacao { get; set; }
    
        public virtual Notificando Notificando { get; set; }
        public virtual Notificador Notificador { get; set; }
    }
}