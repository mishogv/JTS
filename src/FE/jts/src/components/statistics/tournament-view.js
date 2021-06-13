import { React } from 'react';

const TournamentView = ({ index, tournamentId, when }) => {
    return (
        <tr>
            <td>{index}</td>
            <td>{tournamentId}</td>
            <td>{when}</td>
        </tr>
    )
};

export default TournamentView;