import MainLayout from "../layouts/main-layout";
import React, { useState, useEffect } from "react";
import JudokaService from './../services/judokas-service';
import Judoka from './../components/judokas/judoka';

const initialData = [{
    id: 0,
    name: "",
    category: {
        name: '',
        gender: ''
    },
    wins: 0,
    loses: 0,
}];

const Judokas = () => {
    const [judokas, setJudokas] = useState(initialData);

    useEffect(async () => {
        const data = await JudokaService.getJudokas();
        if (data) {
            setJudokas(data);
        }
    }, [])

    return (
        <MainLayout>
            <div>
                {judokas.map(t => (
                    <Judoka key={t.id} {...t} />
                )
                )}
            </div>
        </MainLayout>
    )
};

export default Judokas;