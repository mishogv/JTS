import { BASE_URL, post } from './common'

const IDENTITY_CONTROLLER_ENDPOINT = 'Identity/';
const LOGIN_ENDPOINT = 'Login/';
const JWT = 'jwt';

const login = async (data) => {
    const endpointUrl = BASE_URL + IDENTITY_CONTROLLER_ENDPOINT + LOGIN_ENDPOINT;

    try {
        const result = await post(endpointUrl, data);
        const dataResult = await result.json();
        return dataResult;
        //TODO PARSE

        console.log(dataResult);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const saveJWT = (jwt) => {
    localStorage.setItem(JWT, 'Bearer ' + jwt);
}

const getJWT = () => {
    return localStorage.getItem(JWT);
}

const removeJWT = () => {
    localStorage.removeItem(JWT);
}

const isUserLogged = () => {
    const jwt = getJWT();
    if (jwt) {
        return true;
    }

    return false;
}

const IdentityService = {
    login,
    saveJWT,
    getJWT,
    removeJWT,
    isUserLogged
}

export default IdentityService;