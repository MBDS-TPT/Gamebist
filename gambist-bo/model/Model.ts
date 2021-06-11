export interface Team {
    id?: string;
    name: string;
    categoryId?: string;
    state?: number;
}

export interface Category {
    id?: string;
    label: string;
    state?: number;
}