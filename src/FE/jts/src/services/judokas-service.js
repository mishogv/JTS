import { BASE_URL, post, getData, CREATE_ENDPOINT, EDIT_ENDPOINT, DELETE_ENDPOINT } from './common'

const JUDOKA_CONTROLLER_ENDPOINT = 'Judokas/';
const GET_JUDOKA_DETAILS_ENDPOINT = 'GetJudokaDetails/';
const GET_JUDOKAS_ENDPOINT = 'GetJudokas/';
const GET_JUDOKA_BY_TOURNAMENT_ENDPOINT = 'GetJudokasByTournament/';

const getJudokas = async () => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + GET_JUDOKAS_ENDPOINT;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const getJudokaDetails = async () => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + GET_JUDOKA_DETAILS_ENDPOINT;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const getJudokasByTournament = async () => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + GET_JUDOKA_BY_TOURNAMENT_ENDPOINT;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const createJudoka = async (data) => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + CREATE_ENDPOINT;

    try {
        const result = await post(endpointUrl, data);
        const dataResult = await result.json();
        return data;
        //TODO PARSE

        console.log(dataResult);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const editJudoka = async (data) => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + EDIT_ENDPOINT;

    try {
        const result = await post(endpointUrl, data);
        const dataResult = await result.json();
        return data;
        //TODO PARSE

        console.log(dataResult);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const deleteJudoka = async (data) => {
    const endpointUrl = BASE_URL + JUDOKA_CONTROLLER_ENDPOINT + DELETE_ENDPOINT;

    try {
        const result = await post(endpointUrl, data);
        const dataResult = await result.json();
        return data;
        //TODO PARSE

        console.log(dataResult);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const JudokaService = {
    getJudokas,
    getJudokaDetails,
    getJudokasByTournament,
    createJudoka,
    editJudoka,
    deleteJudoka
}

export default JudokaService;