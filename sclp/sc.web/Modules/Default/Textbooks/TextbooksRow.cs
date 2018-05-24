namespace sc.Default.Entities {

    using System;
    using System.ComponentModel;

    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Textbooks]")]
    [DisplayName("Textbooks"), InstanceName("Textbooks")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class TextbooksRow : Row, IIdRow, INameRow {

        [DisplayName("Text Book Id"), PrimaryKey, Identity]
        public Int32? TextBookId {
            get => Fields.TextBookId[this];
            set => Fields.TextBookId[this] = value;
        }

        [DisplayName("Material Id"), NotNull]
        [LookupEditor(typeof(MaterialsRow))]
        public Int32? MaterialId {
            get => Fields.MaterialId[this];
            set => Fields.MaterialId[this] = value;
        }

        [DisplayName("Material Kind"), NotNull]
        [ReadOnly(true), DefaultValue(1)]
        [LookupEditor(typeof(MaterialKindsRow))]
        public Int32? MaterialKind {
            get => Fields.MaterialKind[this];
            set => Fields.MaterialKind[this] = value;
        }

        [DisplayName("Title"), Size(50), NotNull, QuickSearch]
        public String Title {
            get => Fields.Title[this];
            set => Fields.Title[this] = value;
        }

        [DisplayName("Author"), Size(50), NotNull]
        public String Author {
            get => Fields.Author[this];
            set => Fields.Author[this] = value;
        }

        [DisplayName("Version"), NotNull]
        public Int32? Version {
            get => Fields.Version[this];
            set => Fields.Version[this] = value;
        }

        [DisplayName("Revision"), NotNull]
        public Int32? Revision {
            get => Fields.Revision[this];
            set => Fields.Revision[this] = value;
        }

        [DisplayName("Last Revision"), NotNull]
        public DateTime? LastRevision {
            get => Fields.LastRevision[this];
            set => Fields.LastRevision[this] = value;
        }

        [DisplayName("Revisor Name"), Size(50), NotNull]
        public String RevisorName {
            get => Fields.RevisorName[this];
            set => Fields.RevisorName[this] = value;
        }

        IIdField IIdRow.IdField => Fields.TextBookId;

        StringField INameRow.NameField => Fields.Title;

        public static readonly RowFields Fields = new RowFields().Init();

        public TextbooksRow()
            : base(Fields) {
        }

        public class RowFields : RowFieldsBase {
            public Int32Field TextBookId;
            public Int32Field MaterialId;
            public Int32Field MaterialKind;
            public StringField Title;
            public StringField Author;
            public Int32Field Version;
            public Int32Field Revision;
            public DateTimeField LastRevision;
            public StringField RevisorName;
        }
    }
}