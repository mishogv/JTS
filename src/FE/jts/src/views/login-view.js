import MainLayout from "../layouts/main-layout";
import React from "react";
import Login from './../components/login/login';

const LoginView = () => {

    return (
        <MainLayout>
            <Login />
        </MainLayout>
    )
};

export default LoginView;