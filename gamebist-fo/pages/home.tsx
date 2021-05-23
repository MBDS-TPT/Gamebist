import React from 'react'; 
import styled from 'styled-components';
import CategorySideNav from '../components/category-nav/CategorySideNav';
import Header from '../components/header/Header';
import PageWrapper from '../components/page-wrapper/PageWrapper';

const HomePage = () => {
    return (
        <Wrapper>
            <PageWrapper>
                <div>
                    HomePage
                </div>
            </PageWrapper>
        </Wrapper>
    );
}

const Wrapper = styled.div`

`;

export default HomePage;