import { Link } from 'react-router-dom';
import { Nav, Navbar } from 'react-bootstrap';
import IdentityService from './../../services/identity-service';

const Header = () => {
    return (
        <Navbar bg="dark" expand="lg" variant="dark">
            <Navbar.Brand as={Link} to="/">Judo Tournament System</Navbar.Brand>
            <Navbar.Toggle aria-controls="basic-navbar-nav" />
            <Navbar.Collapse id="basic-navbar-nav">
                <Nav className="mr-auto">
                    <Nav.Link as={Link} to="/">Home</Nav.Link>
                    <Nav.Link as={Link} to="/tournaments">Tournaments</Nav.Link>
                    <Nav.Link as={Link} to="/judokas">Judokas</Nav.Link>
                    {
                        IdentityService.isUserLogged()
                            ? (<Nav.Link as={Link} to="/statistics">Statistics</Nav.Link>)
                            : ''
                    }
                </Nav>
            </Navbar.Collapse>
        </Navbar>
    )
};

export default Header;