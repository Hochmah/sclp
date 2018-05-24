
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class MaterialKindsGrid extends Serenity.EntityGrid<MaterialKindsRow, any> {
        protected getColumnsKey() { return 'Default.MaterialKinds'; }
        protected getDialogType() { return MaterialKindsDialog; }
        protected getIdProperty() { return MaterialKindsRow.idProperty; }
        protected getLocalTextPrefix() { return MaterialKindsRow.localTextPrefix; }
        protected getService() { return MaterialKindsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}