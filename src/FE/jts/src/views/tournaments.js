import MainLayout from "../layouts/main-layout";
import React, { useState, useEffect } from "react";
import TournamentService from './../services/tournaments-service';
import Tournament from '../components/tournaments/tournament';

const initialData = [{
    id: 0,
    name: "",
    winPrize: 0,
    location: "",
    startDate: "",
    endDate: "",
}];

const Tournaments = () => {
    const [tournaments, setTournaments] = useState(initialData);

    useEffect(async () => {
        const data = await TournamentService.getTournaments();
        if (data) {
            setTournaments(data);
        }
    }, [])

    return (
        <MainLayout>
            <div>
                {tournaments.map(t => (
                    <Tournament key={t.id} {...t} />
                )
                )}
            </div>
        </MainLayout>
    )
};

export default Tournaments;