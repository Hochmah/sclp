namespace sc.Default.Entities {

    using System;
    using System.ComponentModel;

    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[MaterialKinds]")]
    [DisplayName("Material Kinds"), InstanceName("Material Kinds")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class MaterialKindsRow : Row, IIdRow, INameRow {

        [DisplayName("Material Kind Id"), PrimaryKey, Identity]
        public Int32? MaterialKindId {
            get => Fields.MaterialKindId[this];
            set => Fields.MaterialKindId[this] = value;
        }

        [DisplayName("Material Kind"), Size(50), NotNull, QuickSearch]
        public String MaterialKind {
            get => Fields.MaterialKind[this];
            set => Fields.MaterialKind[this] = value;
        }

        IIdField IIdRow.IdField => Fields.MaterialKindId;

        StringField INameRow.NameField => Fields.MaterialKind;

        public static readonly RowFields Fields = new RowFields().Init();

        public MaterialKindsRow()
            : base(Fields) {
        }

        public class RowFields : RowFieldsBase {
            public Int32Field MaterialKindId;
            public StringField MaterialKind;
        }
    }
}