import Config from '../config/config.json';

export default abstract class BasicService {

    async fetchData(uri: string)  {
        const res = await fetch(Config.BASE_URL + uri);
        return await res.json();
    }

}