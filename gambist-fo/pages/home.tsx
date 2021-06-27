import { GetStaticProps } from 'next';
import React from 'react'; 
import styled from 'styled-components';
import Banner, { BannerProps } from '../components/banner/Banner';
import CategoryNav from '../components/category-nav/CategoryNav';
import Login from '../components/login/Login';
import MatchCard from '../components/match-detail/MatchCard';
import MatchList from '../components/match-list/MatchList';
import Page from '../components/page-wrapper/Page';
import Registration from '../components/registration/Registration';
import CategoriesData from '../dumy-data/categories.content.json';
import MatchsData from '../dumy-data/matchs.content.json';


const HomePage = () => {

    const bannerProps:BannerProps = {
        imageUrl: "/images/banner/banner-1.jpg"
    }

    return (
        <Wrapper>
            <Page bannerProps={bannerProps} categories={CategoriesData}>
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
            </Page>
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