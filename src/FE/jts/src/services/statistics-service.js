import { BASE_URL, getData } from './common'

const STATISTICS_CONTROLLER_ENDPOINT = 'Statistics/';
const GET_JUDOKA_VIEWS_ENDPOINT = 'GetJudokaViews/';
const GET_TOURNAMENT_VIEWS_ENDPOINT = 'GetTouramentViews/';

const getJudokaViews = async (id) => {
    const endpointUrl = BASE_URL + STATISTICS_CONTROLLER_ENDPOINT + GET_JUDOKA_VIEWS_ENDPOINT + id;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const getTouramentViews = async (id) => {
    const endpointUrl = BASE_URL + STATISTICS_CONTROLLER_ENDPOINT + GET_TOURNAMENT_VIEWS_ENDPOINT + id;

    try {
        return await getData(endpointUrl);
    } catch (e) {
        console.log(e);
        return false;
    }
}

const StatisticsService = {
    getJudokaViews,
    getTouramentViews
}

export default StatisticsService;