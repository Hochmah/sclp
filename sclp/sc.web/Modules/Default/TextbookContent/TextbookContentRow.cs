namespace sc.Default.Entities {

    using System;
    using System.ComponentModel;

    using sc.Administration.Entities;

    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[TextbookContent]")]
    [DisplayName("Textbook Content"), InstanceName("Textbook Content")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class TextbookContentRow : Row, IIdRow, INameRow {

        [DisplayName("Textbook Content Id"), PrimaryKey, Identity, NotNull]
        public Int32? TextbookContentId {
            get => Fields.TextbookContentId[this];
            set => Fields.TextbookContentId[this] = value;
        }

        [DisplayName("Text Book Id")]
        [ForeignKey(typeof(TextbooksRow))]
        [LookupEditor(typeof(TextbooksRow)), QuickFilter]
        public Int32? TextbookId {
            get => Fields.TextbookId[this];
            set => Fields.TextbookId[this] = value;
        }

        [DisplayName("Language Id"), NotNull]
        [ForeignKey(typeof(LanguageRow))]
        [LookupEditor(typeof(LanguageRow)), QuickFilter]
        public String LanguageId {
            get => Fields.LanguageId[this];
            set => Fields.LanguageId[this] = value;
        }

        [DisplayName("Parent Id")]
        [ForeignKey(typeof(TextbookContentRow), "TextbookContentId")]
        [LookupEditor(typeof(TextbookContentRow))]
        public Int32? ParentId {
            get => Fields.ParentId[this];
            set => Fields.ParentId[this] = value;
        }

        [DisplayName("Element Type"), NotNull]
        public ElementType ElementTypeId {
            get => (ElementType)Fields.ElementTypeId[this];
            set => Fields.ElementTypeId[this] = (Int32)value;
        }

        [DisplayName("Content"), NotNull, QuickSearch]
        public String Content {
            get => Fields.Content[this];
            set => Fields.Content[this] = value;
        }

        IIdField IIdRow.IdField => Fields.TextbookContentId;

        StringField INameRow.NameField => Fields.Content;

        public static readonly RowFields Fields = new RowFields().Init();

        public TextbookContentRow()
            : base(Fields) {
        }

        public class RowFields : RowFieldsBase {
            public Int32Field TextbookContentId;
            public Int32Field TextbookId;
            public Int32Field ParentId;
            public Int32Field ElementTypeId;
            public StringField Content;
            public StringField LanguageId;
        }
    }
}