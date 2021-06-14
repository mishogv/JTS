import MainLayout from "../layouts/main-layout";
import React, { useState, useEffect } from "react";
import TournamentService from './../services/tournaments-service';
import { Table } from 'react-bootstrap';
import Category from './../components/categories/category';
import JudokaTournament from './../components/judokas/judoka-tournament';


const initialData = {
    id: 0,
    name: "",
    winPrize: 0,
    location: "",
    startDate: "",
    endDate: "",
    categories: [{
        name: "",
        gender: {
            value: 0,
            name: ""
        }
    }],
    judokas: [{
        id: 0,
        name: "",
        category: {
            name: '',
            gender: {
                value: 0,
                name: ""
            }
        },
        wins: 0,
        loses: 0,
    }]
};

const TournamentDetails = ({ location }) => {
    const [tournamentDetails, setTournamentDetails] = useState(initialData);

    useEffect(async () => {
        const data = await TournamentService.getTournamentDetails(location.query.id);
        if (data) {
            setTournamentDetails(data);
        }
    }, [])

    return (
        <MainLayout>
            <div>
                <h3 className="text-center">Tournament: {tournamentDetails.name}</h3>

                <h3 className="text-center">Categories</h3>
                <Table striped bordered hover variant="dark" className="mb-4">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Category Name</th>
                            <th>Category Gender</th>
                        </tr>
                    </thead>
                    <tbody>
                        {tournamentDetails.categories.map((c, i) => (
                            <Category key={i} index={i + 1} {...c} />
                        )
                        )}
                    </tbody>
                </Table>
                <h3 className="text-center">Judokas</h3>
                <Table striped bordered hover variant="dark" className="mb-4">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Judoka Name</th>
                            <th>Judoka Category</th>
                            <th>Judoka Gender</th>
                            <th>Judoka Wins</th>
                            <th>Judoka Loses</th>
                        </tr>
                    </thead>
                    <tbody>
                        {tournamentDetails.judokas.map((j, i) => (
                            <JudokaTournament key={i} index={i + 1} {...j} />
                        )
                        )}
                    </tbody>
                </Table>
            </div>
        </MainLayout>
    )
};

export default TournamentDetails;