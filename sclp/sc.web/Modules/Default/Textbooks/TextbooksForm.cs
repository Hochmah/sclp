
namespace sc.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Textbooks")]
    [BasedOnRow(typeof(Entities.TextbooksRow), CheckNames = true)]
    public class TextbooksForm
    {
        public Int32 MaterialId { get; set; }
        public Int32 MaterialKind { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Int32 Version { get; set; }
        public Int32 Revision { get; set; }
        public DateTime LastRevision { get; set; }
        public String RevisorName { get; set; }
    }
}