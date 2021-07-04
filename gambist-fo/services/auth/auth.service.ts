import BasicService from "../basic.service";
import Config from "../../config/config.json";

export class AuthService extends BasicService {

    static async login(login: string, password: string) {
        return BasicService.postData(Config.Authentification.Login, {
            username: login,
            password: password
        }, 'POST');
    }

    static logout() {
        localStorage.removeItem('userinfos');
    }

    static getUserInfosFromLS() {
        const userinfos = localStorage.getItem('userinfos');
        if(userinfos)   
            return JSON.parse(userinfos);
        else return null;
    }

    static saveUserInfosFromLS(user: any) {
        localStorage.setItem('userinfos', JSON.stringify(user));
    }

}