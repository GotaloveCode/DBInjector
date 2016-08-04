namespace DBinterceptor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Error")]
    public partial class Error
    {
        public int ErrorId { get; set; }

        public string Query { get; set; }

        public string Parameters { get; set; }

        public string CommandType { get; set; }

        public decimal TotalSeconds { get; set; }

        public string Exception { get; set; }

        public string InnerException { get; set; }

        public int RequestId { get; set; }

        public string FileName { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Active { get; set; }
    }
}
