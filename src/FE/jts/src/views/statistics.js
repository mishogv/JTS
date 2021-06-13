import MainLayout from "../layouts/main-layout";
import React, { useState, useEffect } from "react";
import { Table } from 'react-bootstrap';
import JudokaView from './../components/statistics/judoka-view';
import StatisticsService from "../services/statistics-service";
import TournamentView from './../components/statistics/tournament-view';

const initialDataJudokaView = [{
    id: 0,
    judokaId: 0,
    when: '',
}];

const initialDataTournamentView = [{
    id: 0,
    tournamentId: 0,
    when: '',
}];

const Statistics = () => {
    const [judokaViews, setJudokaViews] = useState(initialDataJudokaView);
    const [tournamentViews, setTournamentViews] = useState(initialDataTournamentView);

    useEffect(async () => {
        const id = 2;
        const judokaViewsData = await StatisticsService.getJudokaViews(id);
        if (judokaViewsData) {
            setJudokaViews(judokaViewsData);
        }

        const tournamentViewsData = await StatisticsService.getTouramentViews(id);
        if (tournamentViewsData) {
            setTournamentViews(tournamentViewsData);
        }
    }, [])

    return (
        <MainLayout>
            <h3 className="text-center">Judoka Views</h3>
            <Table striped bordered hover variant="dark" className="mb-4">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Judoka ID</th>
                        <th>Visited at</th>
                    </tr>
                </thead>
                <tbody>
                    {judokaViews.map((t, i) => (
                        <JudokaView key={i} index={i + 1} {...t} />
                    )
                    )}
                </tbody>
            </Table>

            <h3 className="text-center">Tournament Views</h3>
            <Table striped bordered hover variant="dark" className="mb-4">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Tournament ID</th>
                        <th>Visited at</th>
                    </tr>
                </thead>
                <tbody>
                    {tournamentViews.map((t, i) => (
                        <TournamentView key={i} index={i + 1} {...t} />
                    )
                    )}
                </tbody>
            </Table>
        </MainLayout>
    )
};

export default Statistics;