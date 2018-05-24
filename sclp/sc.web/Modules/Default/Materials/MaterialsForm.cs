namespace sc.Default.Forms {

    using System;

    using Serenity.ComponentModel;

    [FormScript("Default.Materials")]
    [BasedOnRow(typeof(Entities.MaterialsRow), CheckNames = true)]
    public class MaterialsForm {
        public Int32 MaterialKindId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
    }
}