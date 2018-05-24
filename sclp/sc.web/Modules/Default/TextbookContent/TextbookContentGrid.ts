
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class TextbookContentGrid extends Serenity.EntityGrid<TextbookContentRow, any> {
        protected getColumnsKey() { return 'Default.TextbookContent'; }
        protected getDialogType() { return TextbookContentDialog; }
        protected getIdProperty() { return TextbookContentRow.idProperty; }
        protected getLocalTextPrefix() { return TextbookContentRow.localTextPrefix; }
        protected getService() { return TextbookContentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}