import { Link } from 'react-router-dom';
import { Button } from 'react-bootstrap';
import IdentityService from './../../services/identity-service';

const Footer = () => {
    return (
        <footer className='footer fixed-bottom mt-auto py-3 bg-dark text-white'>
            <div className='container'>Judo Tournament System © 2021
            {
                    IdentityService.isUserLogged()
                        ? ''
                        : (<Button as={Link} to="/login" variant="dark" className="ml-5" size="sm">Login</Button>)
                }
            </div>
        </footer>
    )
};

export default Footer;