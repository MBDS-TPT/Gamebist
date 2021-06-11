import Config from '../../config/config.json';
import BasicService from '../basic.service';

export default class TeamService extends BasicService{

    async getAllTeam() {
        return await BasicService.fetchData(Config.Team.FindAll);
    }

    static async PostTeam(team: any) {
        BasicService.postData(Config.Team.Add, team);
    }

}