namespace sc.Default.Columns {

    using System;
    using System.ComponentModel;

    using Serenity.ComponentModel;

    [ColumnsScript("Default.Materials")]
    [BasedOnRow(typeof(Entities.MaterialsRow), CheckNames = true)]
    public class MaterialsColumns {

        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MaterialId { get; set; }

        public Int32 MaterialKindId { get; set; }

        [EditLink]
        public String Title { get; set; }

        public String Description { get; set; }
    }
}