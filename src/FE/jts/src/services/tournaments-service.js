import { BASE_URL, post, getData, CREATE_ENDPOINT, EDIT_ENDPOINT, DELETE_ENDPOINT } from './common'

const TOURNAMENTS_CONTROLLER_ENDPOINT = 'Tournaments/';
const GET_TOURNAMENT_DETAILS_ENDPOINT = 'GetTournamentDetails/';

const getTournaments = async () => {
    const endpointUrl = BASE_URL + TOURNAMENTS_CONTROLLER_ENDPOINT;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const getTournamentDetails = async (id) => {
    const endpointUrl = BASE_URL +
        TOURNAMENTS_CONTROLLER_ENDPOINT +
        GET_TOURNAMENT_DETAILS_ENDPOINT +
        id;

    try {
        return await getData(endpointUrl);

    } catch (e) {
        console.log(e);
        return false;
    }
}

const createTournament = async (data) => {
    const endpointUrl = BASE_URL + TOURNAMENTS_CONTROLLER_ENDPOINT + CREATE_ENDPOINT;

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

const editTournament = async (data) => {
    const endpointUrl = BASE_URL + TOURNAMENTS_CONTROLLER_ENDPOINT + EDIT_ENDPOINT;

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

const deleteTournament = async (data) => {
    const endpointUrl = BASE_URL + TOURNAMENTS_CONTROLLER_ENDPOINT + DELETE_ENDPOINT;

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

const TournamentService = {
    getTournaments,
    getTournamentDetails,
    createTournament,
    editTournament,
    deleteTournament
}

export default TournamentService;