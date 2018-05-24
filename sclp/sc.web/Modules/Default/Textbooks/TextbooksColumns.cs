
namespace sc.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Textbooks")]
    [BasedOnRow(typeof(Entities.TextbooksRow), CheckNames = true)]
    public class TextbooksColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 TextBookId { get; set; }
        public Int32 MaterialId { get; set; }
        public Int32 MaterialKind { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Author { get; set; }
        public Int32 Version { get; set; }
        public Int32 Revision { get; set; }
        public DateTime LastRevision { get; set; }
        public String RevisorName { get; set; }
    }
}