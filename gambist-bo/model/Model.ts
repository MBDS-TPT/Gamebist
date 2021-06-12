export interface Team {
    id?: string;
    name: string;
    categoryId?: string;
    category?: Category;
    state?: number;
}

export interface Category {
    id?: string;
    label: string;
    state?: number;
}