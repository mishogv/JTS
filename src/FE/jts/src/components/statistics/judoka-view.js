import { React } from 'react';

const JudokaView = ({ index, judokaId, when }) => {
    return (
        <tr>
            <td>{index}</td>
            <td>{judokaId}</td>
            <td>{when}</td>
        </tr>
    )
};

export default JudokaView;