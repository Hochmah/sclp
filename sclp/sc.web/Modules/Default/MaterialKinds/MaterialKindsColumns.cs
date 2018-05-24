
namespace sc.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.MaterialKinds")]
    [BasedOnRow(typeof(Entities.MaterialKindsRow), CheckNames = true)]
    public class MaterialKindsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MaterialKindId { get; set; }
        [EditLink]
        public String MaterialKind { get; set; }
    }
}