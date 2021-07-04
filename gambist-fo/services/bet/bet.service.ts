import BasicService from "../basic.service";
import Config from "../../config/config.json";
import { Bet } from "../../model/Model";
import { AuthService } from "../auth/auth.service";

export class BetService extends BasicService {

    static async getUserBet () {
        return BasicService.fetchData(Config.Category.FindAll);
    } 

    static async postBet(bet: Bet) {
        const user = AuthService.getUserInfosFromLS();
        if(user) {
            bet.userId = user.id;
            return BasicService.postData(Config.Bet.Add, bet);
        }
        this.redirect('/login');
    }

}