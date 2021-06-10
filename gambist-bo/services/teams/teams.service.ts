import Config from '../../config/config.json';
import BasicService from '../basic.service';

export default class TeamsService extends BasicService{

    async getAllTeam() {
        return await this.fetchData(Config.Team.FindAll);
    }

}