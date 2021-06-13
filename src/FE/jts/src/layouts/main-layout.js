import Header from '../components/common/header'
import Footer from '../components/common/footer'

const MainLayout = ({ children }) => {
    return (
        <div>
            <Header />
            <main role='main'>
                <div className='container mt-4'>
                    {children}
                </div>
            </main>
            <Footer />
        </ div>
    )
};

export default MainLayout;