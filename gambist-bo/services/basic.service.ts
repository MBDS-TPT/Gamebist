import Config from '../config/config.json';

export default abstract class BasicService {

    static async fetchData(uri: string)  {
        const res = await fetch(Config.BASE_URL + uri);
        return await res.json();
    }

    static async postData(uri: string, params: any) {
        fetch(Config.BASE_URL + uri, {
            method: "POST",
            body: JSON.stringify(params),
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        })
        .then(response => response.json())
        .then(json => console.log(json));
    }
}