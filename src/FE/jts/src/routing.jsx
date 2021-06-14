import React, { Suspense, lazy } from 'react'
import { BrowserRouter, Route, Switch, Redirect } from 'react-router-dom';
import IdentityService from './services/identity-service';


const Home = lazy(() => import('./views/home'));
const Tournaments = lazy(() => import('./views/tournaments'));
const Judokas = lazy(() => import('./views/judokas'));
const Statistics = lazy(() => import('./views/statistics'));
const Login = lazy(() => import('./views/login-view'));
const TournamentDetails = lazy(() => import('./views/tournament-details'));

const PrivateRoute = ({ component: Component, ...rest }) => (
    <Route {...rest} render={(props) => {
        if (!IdentityService.isUserLogged()) {
            return <Redirect to="/" />
        }

        return <Component {...props} />
    }} />
)

const NotLoggedRoute = ({ component: Component, ...rest }) => (
    <Route {...rest} render={(props) => {
        if (IdentityService.isUserLogged()) {
            return <Redirect to="/" />
        }

        return <Component {...props} />
    }} />
)

const Routing = () => {
    return (
        <BrowserRouter>
            <Suspense fallback={<div />}>
                <Switch>
                    <Route path="/" exact component={Home} />
                    <Route path="/tournaments" exact component={Tournaments} />
                    <Route path="/judokas" exact component={Judokas} />
                    <Route path="/tournament-details" exact component={TournamentDetails} />
                    <NotLoggedRoute path="/login" exact component={Login} />
                    <PrivateRoute path="/statistics" exact component={Statistics} />
                </Switch>
            </Suspense>
        </BrowserRouter>
    )
}

export default Routing;