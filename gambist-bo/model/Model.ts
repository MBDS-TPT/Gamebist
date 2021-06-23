export interface Team {
    id?: string;
    logo: string;
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

export interface BetType {
    id?: string;
    label: string;
    description?: string;
    currentWinningRate: number;
    categoryId?: string;
    category?: Category;
    state?: number;
}

export interface User {
    id?: string;
    firstname: string;
    lastname: string;
    username: string;
    password?: string;
    email: string;
    dayOfBirth: any;
    state?: number;
}

export interface Bet {
    id?: string;
    betValue: number;
    winningRage: number;
    betDate: any;
    Match: Match;
    user: User;
    state?: number;
}