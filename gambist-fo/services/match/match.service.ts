import BasicService from "../basic.service";
import Config from "../../config/config.json";
import { Match } from "../../model/Model";
import { AuthService } from "../auth/auth.service";

export class MatchService extends BasicService {
    
    static async getUpcomingMatchByCategory(categoryId: any) {
        return BasicService.fetchData(Config.Match.UpcomingMatch, {
            categoryId: categoryId
        });
    }
    
    static async getUpcomingMatchGroupedByCategory() {
        return BasicService.fetchData(Config.Match.UpcomingMatchGroupedByCategory);
    }

    static async getMatch(id: any) {
        return BasicService.fetchData(Config.Match.FindById, {
            id
        })
    }

    static async getAllMatchId() {
        return BasicService.fetchData(Config.Match.GetAllMatchId);
    }

    static getUpcomingMatchByCategoryName(matches: any, categoryName: string) {
        if(matches) {
            return matches[categoryName];
        }
        return [];
    }

    static getMatchTime(match: Match) {
        if(!match) return null;
        const date: Date = match.matchDate;
        return `${date.getHours}:${date.getMinutes()}`;
    }


}