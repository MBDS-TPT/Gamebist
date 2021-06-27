import BasicService from "../basic.service";
import Config from "../../config/config.json";

export class MatchService extends BasicService {
    
    static async getUpcomingMatchByCategory(categoryId: any) {
        return BasicService.fetchData(Config.Match.UpcomingMatch, {
            categoryId: categoryId
        });
    }

}