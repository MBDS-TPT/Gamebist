import Config from '../../config/config.json';
import BasicService from '../basic.service';

export default class MatchService extends BasicService{

    async getAllMatch() {
        return await BasicService.fetchData(Config.Match.FindAll);
    }

    static async PostMatch(category: any) {
        return BasicService.postData(Config.Match.Add, category);
    }

    static async EditMatch(category: any) {
        return BasicService.postData(Config.Match.Edit, category, 'PUT');
    }

    static async DeleteMatch(category: any) {
        return BasicService.postData(Config.Match.Delete, category, 'DELETE');
    }

}