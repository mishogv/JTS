import { React } from 'react';
import { Card } from 'react-bootstrap';
import { Link } from 'react-router-dom';


const Tournament = ({ id, name, winPrize, location, startDate, endDate }) => {
    return (
        <Card style={{ width: '18rem' }}>
            <Card.Body>
                <Card.Title>{name}</Card.Title>
                <Card.Subtitle className="mb-2 text-muted">{location}</Card.Subtitle>
                <Card.Text>
                    Tournament reward: {winPrize} $
                    <br />
                    Tournament start date: {startDate}
                    <br />
                    Tournament end date: {endDate}
                </Card.Text>
                <Card.Link as={Link} to={{ pathname: '/tournament-details', query: { id: id } }}>Details</Card.Link>
            </Card.Body>
        </Card>
    )
};

export default Tournament;