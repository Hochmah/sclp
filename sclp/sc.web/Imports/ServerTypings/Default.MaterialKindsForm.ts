namespace sc.Default {
    export interface MaterialKindsForm {
        MaterialKind: Serenity.StringEditor;
    }

    export class MaterialKindsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.MaterialKinds';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MaterialKindsForm.init)  {
                MaterialKindsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MaterialKindsForm, [
                    'MaterialKind', w0
                ]);
            }
        }
    }
}

