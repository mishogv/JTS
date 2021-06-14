import { React } from 'react';

const Category = ({ index, name, gender }) => {
    return (
        <tr>
            <td>{index}</td>
            <td>{name}</td>
            <td>{gender.name}</td>
        </tr>
    )
};

export default Category;