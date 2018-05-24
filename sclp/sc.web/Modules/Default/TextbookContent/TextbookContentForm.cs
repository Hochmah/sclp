namespace sc.Default.Forms {

    using System;

    using Serenity.ComponentModel;

    [FormScript("Default.TextbookContent")]
    [BasedOnRow(typeof(Entities.TextbookContentRow), CheckNames = true)]
    public class TextbookContentForm {
        public Int32 TextbookId { get; set; }
        public String LanguageId { get; set; }
        public Int32 ElementTypeId { get; set; }
        public String Content { get; set; }
        public Int32 ParentId { get; set; }
    }
}