namespace sc.Default {
    export interface MaterialsRow {
        MaterialId?: number;
        MaterialKindId?: number;
        Title?: string;
        Description?: string;
    }

    export namespace MaterialsRow {
        export const idProperty = 'MaterialId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Materials';
        export const lookupKey = 'Default.Materials';

        export function getLookup(): Q.Lookup<MaterialsRow> {
            return Q.getLookup<MaterialsRow>('Default.Materials');
        }

        export declare const enum Fields {
            MaterialId = "MaterialId",
            MaterialKindId = "MaterialKindId",
            Title = "Title",
            Description = "Description"
        }
    }
}

