import Config from '../../config/config.json';
import BasicService from '../basic.service';

export default class CategoryService extends BasicService{

    async getAllCategories() {
        return await BasicService.fetchData(Config.Category.FindAll);
    }

    static async PostTeam(category: any) {
        BasicService.postData(Config.Category.Add, category);
    }

}