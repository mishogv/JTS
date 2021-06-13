import IdentityService from './identity-service';
export const BASE_URL = 'https://localhost:5001/';
export const CREATE_ENDPOINT = 'Create/';
export const EDIT_ENDPOINT = 'Edit/';
export const DELETE_ENDPOINT = 'Delete/';

export const post = (url, data) => {
    return fetch(url, {
        method: "POST",
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    });
}

export const getData = async (endpointUrl) => {
    try {
        let result;
        if (IdentityService.isUserLogged()) {
            const jwt = IdentityService.getJWT();
            result = await fetch(endpointUrl, {
                headers: {
                    'authorization': jwt
                }
            });

        }

        const data = await result.json();
        console.log(data);

        return data;
    } catch (e) {
        console.log(e);
        return false;
    }
}