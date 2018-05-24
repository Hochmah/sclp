
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class MaterialsDialog extends Serenity.EntityDialog<MaterialsRow, any> {
        protected getFormKey() { return MaterialsForm.formKey; }
        protected getIdProperty() { return MaterialsRow.idProperty; }
        protected getLocalTextPrefix() { return MaterialsRow.localTextPrefix; }
        protected getNameProperty() { return MaterialsRow.nameProperty; }
        protected getService() { return MaterialsService.baseUrl; }

        protected form = new MaterialsForm(this.idPrefix);

    }
}