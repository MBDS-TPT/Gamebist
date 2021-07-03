import { GetServerSideProps } from 'next';
import React, { useState } from 'react'; 
import styled from 'styled-components';
import { BannerProps } from '../components/banner/Banner';
import CategoryNav, { CategoryNavProps } from '../components/category-nav/CategoryNav';
import MatchList from '../components/match-list/MatchList';
import Page from '../components/page-wrapper/Page';
import SectionTitle from '../components/section-title/SectionTitle';
import { Category, Match } from '../model/Model';
import { BetService } from '../services/bet/bet.service';
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

    const [matchList, setMatchList] = useState<Match[]>([]);
    const [selectedCategory, setSelectedCategory] = useState<Category>(categories[0]);
    const [allCategorySelected, setAllCategorySelected] = useState<Boolean>(true);

    const bannerProps:BannerProps = {
        imageUrl: "/images/banner/banner-1.jpg"
    }
    
    const categoryNavProps: CategoryNavProps = {
        categories: categories,
        onChangeCategory: (category: Category) => {
            if(category) {
                setSelectedCategory(category)
                if(category.id == '-1') setAllCategorySelected(true);
                else  {
                    setMatchList(MatchService.getUpcomingMatchByCategoryName(matches, category.label));
                    setAllCategorySelected(false);
                }
            }
        }
    }

    const OnPostBet = (bet: any) => {
        BetService.postBet(bet);
    }

    return (
        <Wrapper>
            <Page categories={categories}>
                <div>
                    <CategoryNav { ...categoryNavProps }/>
                    
                    {!allCategorySelected ? 
                        <>
                            <SectionTitle title={`${selectedCategory.label} (${matchList.length})`} />
                            <MatchList onPostBet={OnPostBet} tableHeader="NATIONAL CHAMPIONSHIP" matchDetailPath='/match' matches={matchList} />
                        </>
                    : 
                        categories.filter((category: Category) => category.id != "-1").map((category: Category) => {
                            const matchList_ = MatchService.getUpcomingMatchByCategoryName(matches, category.label)
                            return (
                                <div key={category.id}>
                                    <SectionTitle title={`${category.label} (${matchList_.length})`} />
                                    <MatchList onPostBet={OnPostBet} tableHeader="NATIONAL CHAMPIONSHIP" matchDetailPath='/match' matches={matchList_} />
                                </div>
                            )
                        })
                    } 
                </div>            
            </Page>
        </Wrapper>
    );
}


const Wrapper = styled.div`

`;

export const getServerSideProps: GetServerSideProps = async (ctx) => {
    let categories = await CategoryService.getCategories();
    categories = [
        {
            id: -1,
            label: "All sports",
            state: 0
        },
        ...categories || [] 
    ];
    const matches = await MatchService.getUpcomingMatchGroupedByCategory();
    return {
        props: {
            categories: categories || [],
            matches: matches
        }
    }
}

export default HomePage;