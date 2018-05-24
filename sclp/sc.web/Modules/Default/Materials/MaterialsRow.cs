namespace sc.Default.Entities {

    using System;
    using System.ComponentModel;

    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Materials]")]
    [DisplayName("Materials"), InstanceName("Materials")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class MaterialsRow : Row, IIdRow, INameRow {

        [DisplayName("Material Id"), NotNull]
        public Int32? MaterialId {
            get => Fields.MaterialId[this];
            set => Fields.MaterialId[this] = value;
        }

        [DisplayName("Material Kind Id"), NotNull]
        [LookupEditor(typeof(MaterialKindsRow))]
        public Int32? MaterialKindId {
            get => Fields.MaterialKindId[this];
            set => Fields.MaterialKindId[this] = value;
        }

        [DisplayName("Title"), Size(50), QuickSearch, NotNull]
        public String Title {
            get => Fields.Title[this];
            set => Fields.Title[this] = value;
        }

        [DisplayName("Description"), Size(144), QuickSearch]
        public String Description {
            get => Fields.Description[this];
            set => Fields.Description[this] = value;
        }

        IIdField IIdRow.IdField => Fields.MaterialId;

        StringField INameRow.NameField => Fields.Title;

        public static readonly RowFields Fields = new RowFields().Init();

        public MaterialsRow()
            : base(Fields) {
        }

        public class RowFields : RowFieldsBase {
            public Int32Field MaterialId;
            public Int32Field MaterialKindId;
            public StringField Title;
            public StringField Description;
        }
    }
}