import BasicService from "../basic.service";
import Config from "../../config/config.json";
import { Bet } from "../../model/Model";

export class BetService extends BasicService {

    static async getUserBet () {
        return BasicService.fetchData(Config.Category.FindAll);
    } 

    static async postBet(bet: Bet) {
        return BasicService.postData(Config.Bet.Add, bet);
    }

}