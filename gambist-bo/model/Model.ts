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

export interface Match {
    id?: string;
    teamAId?: string;
    teamA?: Team;
    teamBId?: string;
    teamB?: Team;
    categoryId?: string;
    category?: Category;
    state?: number;
    matchDate?: any;
    matchTime?: any;
}