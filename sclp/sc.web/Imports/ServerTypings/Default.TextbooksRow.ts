namespace sc.Default {
    export interface TextbooksRow {
        TextBookId?: number;
        MaterialId?: number;
        MaterialKind?: number;
        Title?: string;
        Author?: string;
        Version?: number;
        Revision?: number;
        LastRevision?: string;
        RevisorName?: string;
    }

    export namespace TextbooksRow {
        export const idProperty = 'TextBookId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Textbooks';
        export const lookupKey = 'Default.Textbooks';

        export function getLookup(): Q.Lookup<TextbooksRow> {
            return Q.getLookup<TextbooksRow>('Default.Textbooks');
        }

        export declare const enum Fields {
            TextBookId = "TextBookId",
            MaterialId = "MaterialId",
            MaterialKind = "MaterialKind",
            Title = "Title",
            Author = "Author",
            Version = "Version",
            Revision = "Revision",
            LastRevision = "LastRevision",
            RevisorName = "RevisorName"
        }
    }
}

