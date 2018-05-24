
namespace sc.Default {

    @Serenity.Decorators.registerClass()
    export class MaterialsGrid extends Serenity.EntityGrid<MaterialsRow, any> {
        protected getColumnsKey() { return 'Default.Materials'; }
        protected getDialogType() { return MaterialsDialog; }
        protected getIdProperty() { return MaterialsRow.idProperty; }
        protected getLocalTextPrefix() { return MaterialsRow.localTextPrefix; }
        protected getService() { return MaterialsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}