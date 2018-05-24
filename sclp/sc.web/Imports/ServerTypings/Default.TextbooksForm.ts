namespace sc.Default {
    export interface TextbooksForm {
        MaterialId: Serenity.LookupEditor;
        MaterialKind: Serenity.LookupEditor;
        Title: Serenity.StringEditor;
        Author: Serenity.StringEditor;
        Version: Serenity.IntegerEditor;
        Revision: Serenity.IntegerEditor;
        LastRevision: Serenity.DateEditor;
        RevisorName: Serenity.StringEditor;
    }

    export class TextbooksForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Textbooks';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TextbooksForm.init)  {
                TextbooksForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;

                Q.initFormType(TextbooksForm, [
                    'MaterialId', w0,
                    'MaterialKind', w0,
                    'Title', w1,
                    'Author', w1,
                    'Version', w2,
                    'Revision', w2,
                    'LastRevision', w3,
                    'RevisorName', w1
                ]);
            }
        }
    }
}

