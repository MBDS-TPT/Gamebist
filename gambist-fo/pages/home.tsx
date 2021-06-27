import { GetServerSideProps } from 'next';
import React from 'react'; 
import styled from 'styled-components';
import { BannerProps } from '../components/banner/Banner';
import CategoryNav, { CategoryNavProps } from '../components/category-nav/CategoryNav';
import MatchList from '../components/match-list/MatchList';
import Page from '../components/page-wrapper/Page';
import CategoriesData from '../dumy-data/categories.content.json';
import MatchsData from '../dumy-data/matchs.content.json';
import { Category } from '../model/Model';
import { CategoryService } from '../services/category/category.service';
import { MatchService } from '../services/match/match.service';

interface PageProps {
    categories: any;
    matches: any;
}


const HomePage = (props: PageProps) => {
    
    const {
        categories,
        matches,
    } = props;
    
    const bannerProps:BannerProps = {
        imageUrl: "/images/banner/banner-1.jpg"
    }

    const categoryNavProps: CategoryNavProps = {
        categories: categories,
        onChangeCategory: (category: Category) => {
            console.log(category);
        }
    }

    return (
        <Wrapper>
            <Page bannerProps={bannerProps} categories={categories}>
                <div>
                    <CategoryNav { ...categoryNavProps }/>
                    <MatchList tableHeader="NATIONAL CHAMPIONSHIP" matches={matches} />
                </div>            
            </Page>
        </Wrapper>
    );
}


const Wrapper = styled.div`

`;

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    const categories = await CategoryService.getCategories();
    if(categories) {
        categories.unshift({
            id: -1,
            label: "All",
            state: 0
        })
    }
    const matches = await MatchService.getUpcomingMatchByCategory(1);
    return {
        props: {
            categories: categories || [],
            matches: matches
        }
    }
}

export default HomePage;