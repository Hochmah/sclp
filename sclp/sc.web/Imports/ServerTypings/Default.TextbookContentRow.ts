namespace sc.Default {
    export interface TextbookContentRow {
        TextbookContentId?: number;
        TextbookId?: number;
        ParentId?: number;
        ElementTypeId?: ElementType;
        Content?: string;
        LanguageId?: string;
    }

    export namespace TextbookContentRow {
        export const idProperty = 'TextbookContentId';
        export const nameProperty = 'Content';
        export const localTextPrefix = 'Default.TextbookContent';
        export const lookupKey = 'Default.TextbookContent';

        export function getLookup(): Q.Lookup<TextbookContentRow> {
            return Q.getLookup<TextbookContentRow>('Default.TextbookContent');
        }

        export declare const enum Fields {
            TextbookContentId = "TextbookContentId",
            TextbookId = "TextbookId",
            ParentId = "ParentId",
            ElementTypeId = "ElementTypeId",
            Content = "Content",
            LanguageId = "LanguageId"
        }
    }
}

