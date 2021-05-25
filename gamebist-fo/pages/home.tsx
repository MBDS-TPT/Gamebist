import { GetStaticProps } from 'next';
import React from 'react'; 
import styled from 'styled-components';
import CategoryNav from '../components/category-nav/CategoryNav';
import Login from '../components/login/Login';
import MatchCard from '../components/match-detail/MatchCard';
import MatchList from '../components/match-list/MatchList';
import PageWrapper from '../components/page-wrapper/PageWrapper';
import Registration from '../components/registration/Registration';
import CategoriesData from '../dumy-data/categories.content.json';
import MatchsData from '../dumy-data/matchs.content.json';

const HomePage = () => {
    return (
        <Wrapper>
            <PageWrapper categories={CategoriesData}>
                <div>
                    <CategoryNav categories={CategoriesData}/>
                    <MatchList tableHeader="NATIONAL CHAMPIONSHIP" matchs={MatchsData} />
                </div>
                <hr/>
                <MatchCard/>
                <hr/>
                <Login/>
                <hr/>
                <Registration/>
                <hr/>
            </PageWrapper>
        </Wrapper>
    );
}

export const getStaticProps: GetStaticProps = async (ctx) => {
    return {
        props: {
            categories: []
        }
    }
}

const Wrapper = styled.div`

`;

export default HomePage;