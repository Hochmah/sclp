
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class TextbooksDialog extends Serenity.EntityDialog<TextbooksRow, any> {
        protected getFormKey() { return TextbooksForm.formKey; }
        protected getIdProperty() { return TextbooksRow.idProperty; }
        protected getLocalTextPrefix() { return TextbooksRow.localTextPrefix; }
        protected getNameProperty() { return TextbooksRow.nameProperty; }
        protected getService() { return TextbooksService.baseUrl; }

        protected form = new TextbooksForm(this.idPrefix);

    }
}