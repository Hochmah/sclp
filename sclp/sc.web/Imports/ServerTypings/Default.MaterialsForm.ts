namespace sc.Default {
    export interface MaterialsForm {
        MaterialKindId: Serenity.LookupEditor;
        Title: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class MaterialsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Materials';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MaterialsForm.init)  {
                MaterialsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(MaterialsForm, [
                    'MaterialKindId', w0,
                    'Title', w1,
                    'Description', w1
                ]);
            }
        }
    }
}

