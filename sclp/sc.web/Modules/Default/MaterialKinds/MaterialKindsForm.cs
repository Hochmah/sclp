
namespace sc.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.MaterialKinds")]
    [BasedOnRow(typeof(Entities.MaterialKindsRow), CheckNames = true)]
    public class MaterialKindsForm
    {
        public String MaterialKind { get; set; }
    }
}