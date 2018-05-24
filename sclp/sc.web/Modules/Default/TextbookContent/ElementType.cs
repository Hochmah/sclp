using System.ComponentModel;

using Serenity.ComponentModel;

namespace sc.Default {

    [EnumKey("Default.ElementType")]
    public enum ElementType {

        [Description("Title 1")]
        Title1 = 0,

        [Description("Title 2")]
        Title2 = 2,

        [Description("Subtitle")]
        Subtitle = 3,

        [Description("Paragraph")]
        Paragraph = 4,

        [Description("Quote")]
        Quote = 5
    }
}