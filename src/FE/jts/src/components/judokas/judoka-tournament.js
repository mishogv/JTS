import { React } from 'react';

const JudokaTournament = ({ index, name, category, wins, loses }) => {
    return (
        <tr>
            <td>{index}</td>
            <td>{name}</td>
            <td>{category.name}</td>
            <td>{category.gender.name}</td>
            <td>{wins}</td>
            <td>{loses}</td>
        </tr>
    )
};

export default JudokaTournament;