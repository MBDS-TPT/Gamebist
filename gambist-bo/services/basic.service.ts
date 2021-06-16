import Config from '../config/config.json';

export default abstract class BasicService {

    static async fetchData(uri: string)  {
        try {
            const res = await fetch(Config.BASE_URL + uri)
            return await res.json()
        } catch(error) {
            console.error("error >", error)
        }
        return []
    }

    static async postData(uri: string, params: any, method='POST') {
        const response = await fetch(Config.BASE_URL + uri, {
            method: method,
            body: JSON.stringify(params),
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        })
        
        return response.json();
        // .then(response => response.json())
        // .then(json => console.log(json));
    }
}