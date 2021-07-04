import React from 'react';
import styled from 'styled-components';
import { Category } from '../../model/Model';
import Banner, { BannerProps } from '../banner/Banner';
import BetCategory from '../category-nav/ICategory';
import Footer from '../footer/Footer';
import Header from '../header/Header';

export interface PageProps {
    categories?: Category[];
    bannerProps?: BannerProps;
}

const Page: React.FC<PageProps> = ({
    categories,
    children,
    bannerProps,
}) => {


    const headerNavigationLink = [
        {
            text: 'Home',
            link: '/home'
        },
        {
            text: 'Results',
            link: '/'
        },
        {
            text: 'My bets',
            link: '/'
        }
    ]

    return (
        <Wrapper className="page-wrapper">
            <div className="page-header">
                <Header loginLink="/login" navigationLinks={headerNavigationLink} />
                {bannerProps && <Banner {...bannerProps} />}
            </div>
            <div className="page-container">
                {/* <CategorySideNav className="page-side-nav" categories={categories}/> */}
                <div className="container">
                    {children}
                </div>
            </div>
            <Footer/>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.page-wrapper {
        background-color: var(--light-gray);
        padding-bottom: 10px;
    }
    .page-header {
        margin-bottom: 50px;
    }
    .page-container {
        display: flex;
        flex-direction: row;
        margin-bottom: 40px;
    }
    .page-content {
        width: 100%;
        margin-right: 10px;
    }
`;

export default Page;