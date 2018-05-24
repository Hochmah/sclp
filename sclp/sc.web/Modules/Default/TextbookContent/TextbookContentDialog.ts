
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class TextbookContentDialog extends Serenity.EntityDialog<TextbookContentRow, any> {
        protected getFormKey() { return TextbookContentForm.formKey; }
        protected getIdProperty() { return TextbookContentRow.idProperty; }
        protected getLocalTextPrefix() { return TextbookContentRow.localTextPrefix; }
        protected getNameProperty() { return TextbookContentRow.nameProperty; }
        protected getService() { return TextbookContentService.baseUrl; }

        protected form = new TextbookContentForm(this.idPrefix);

    }
}