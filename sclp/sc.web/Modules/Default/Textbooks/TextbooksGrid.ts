
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class TextbooksGrid extends Serenity.EntityGrid<TextbooksRow, any> {
        protected getColumnsKey() { return 'Default.Textbooks'; }
        protected getDialogType() { return TextbooksDialog; }
        protected getIdProperty() { return TextbooksRow.idProperty; }
        protected getLocalTextPrefix() { return TextbooksRow.localTextPrefix; }
        protected getService() { return TextbooksService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}