namespace sc.Default {
    export interface TextbookContentForm {
        TextbookId: Serenity.LookupEditor;
        LanguageId: Serenity.LookupEditor;
        ElementTypeId: Serenity.EnumEditor;
        Content: Serenity.StringEditor;
        ParentId: Serenity.LookupEditor;
    }

    export class TextbookContentForm extends Serenity.PrefixedContext {
        static formKey = 'Default.TextbookContent';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TextbookContentForm.init)  {
                TextbookContentForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.EnumEditor;
                var w2 = s.StringEditor;

                Q.initFormType(TextbookContentForm, [
                    'TextbookId', w0,
                    'LanguageId', w0,
                    'ElementTypeId', w1,
                    'Content', w2,
                    'ParentId', w0
                ]);
            }
        }
    }
}

