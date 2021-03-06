import { React } from 'react';
import { Card } from 'react-bootstrap';

const Judoka = ({ name, category, wins, loses }) => {
    return (
        <Card style={{ width: '18rem' }}>
            <Card.Body>
                <Card.Title>{name}</Card.Title>
                <Card.Subtitle className="mb-2 text-muted">{category.name}</Card.Subtitle>
                <Card.Text>
                    Total wins: {wins}
                    <br />
                    Total loses: {loses}
                </Card.Text>
                <Card.Link href="#">Details</Card.Link>
            </Card.Body>
        </Card>
    )
};

export default Judoka;