import BasicService from "../basic.service";
import Config from "../../config/config.json";

export class MatchService extends BasicService {
    
    static async getUpcomingMatchByCategory(categoryId: any) {
        return BasicService.fetchData(Config.Match.UpcomingMatch, {
            categoryId: categoryId
        });
    }
    
    static async getUpcomingMatchGroupedByCategory() {
        return BasicService.fetchData(Config.Match.UpcomingMatchGroupedByCategory);
    }

    static getUpcomingMatchByCategoryName(matches: any, categoryName: string) {
        if(matches) {
            return matches[categoryName];
        }
        return [];
    }

}