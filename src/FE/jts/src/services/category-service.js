import { BASE_URL, post, CREATE_ENDPOINT, EDIT_ENDPOINT, DELETE_ENDPOINT } from './common'

const CATEGORIES_CONTROLLER_ENDPOINT = 'Categories';

const createCategory = async (data) => {
    const endpointUrl = BASE_URL + CATEGORIES_CONTROLLER_ENDPOINT + CREATE_ENDPOINT;

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

const editCategory = async (data) => {
    const endpointUrl = BASE_URL + CATEGORIES_CONTROLLER_ENDPOINT + EDIT_ENDPOINT;

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

const deleteCategory = async (data) => {
    const endpointUrl = BASE_URL + CATEGORIES_CONTROLLER_ENDPOINT + DELETE_ENDPOINT;

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

const CategoryService = {
    createCategory,
    editCategory,
    deleteCategory
}

export default CategoryService;