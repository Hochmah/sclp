
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class MaterialKindsDialog extends Serenity.EntityDialog<MaterialKindsRow, any> {
        protected getFormKey() { return MaterialKindsForm.formKey; }
        protected getIdProperty() { return MaterialKindsRow.idProperty; }
        protected getLocalTextPrefix() { return MaterialKindsRow.localTextPrefix; }
        protected getNameProperty() { return MaterialKindsRow.nameProperty; }
        protected getService() { return MaterialKindsService.baseUrl; }

        protected form = new MaterialKindsForm(this.idPrefix);

    }
}