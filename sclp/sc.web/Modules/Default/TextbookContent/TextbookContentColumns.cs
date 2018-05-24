namespace sc.Default.Columns {

    using System;
    using System.ComponentModel;

    using Serenity.ComponentModel;

    [ColumnsScript("Default.TextbookContent")]
    [BasedOnRow(typeof(Entities.TextbookContentRow), CheckNames = true)]
    public class TextbookContentColumns {
        public Int32 TextbookId { get; set; }

        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 TextbookContentId { get; set; }

        public Int32 ParentId { get; set; }
        public ElementType ElementTypeId { get; set; }

        [EditLink]
        public String Content { get; set; }

        public String LanguageId { get; set; }
    }
}