namespace sc.Default {
    export interface MaterialKindsRow {
        MaterialKindId?: number;
        MaterialKind?: string;
    }

    export namespace MaterialKindsRow {
        export const idProperty = 'MaterialKindId';
        export const nameProperty = 'MaterialKind';
        export const localTextPrefix = 'Default.MaterialKinds';
        export const lookupKey = 'Default.MaterialKinds';

        export function getLookup(): Q.Lookup<MaterialKindsRow> {
            return Q.getLookup<MaterialKindsRow>('Default.MaterialKinds');
        }

        export declare const enum Fields {
            MaterialKindId = "MaterialKindId",
            MaterialKind = "MaterialKind"
        }
    }
}

