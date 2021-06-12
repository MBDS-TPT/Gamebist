import Config from '../../config/config.json';
import BasicService from '../basic.service';

export default class TeamService extends BasicService{

    async getAllTeam() {
        return await BasicService.fetchData(Config.Team.FindAll);
    }

    static async PostTeam(team: any) {
        BasicService.postData(Config.Team.Add, team);
    }

    static async EditTeam(team: any) {
        BasicService.postData(Config.Team.Edit, team, 'PUT');
    }

    static async DeleteTeam(team: any) {
        BasicService.postData(Config.Team.Delete, team, 'DELETE');
    }

}