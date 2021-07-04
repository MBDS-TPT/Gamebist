import React from 'react';
import { useState } from 'react';
import { useEffect } from 'react';
import styled from 'styled-components';
import { Category } from '../../model/Model';
import { AuthService } from '../../services/auth/auth.service';
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

    const [headerNavigation, setHeaderNavigation] = useState<any>([{
        text: 'Home',
        link: '/home'
    }]);

    const userNavigationLinks = [
        {
            text: 'Results',
            link: '/'
        },
        {
            text: 'My bets',
            link: '/'
        }
    ]

    useEffect(() => {
        const user = AuthService.getUserInfosFromLS();
        if(user) {
            setHeaderNavigation([
                ...headerNavigation,
                ...userNavigationLinks
            ]);
        }
    }, [])

    const logout = (e: any) => {
        AuthService.logout();
        document.location.href = '/home'
        // e.preventDefault();
    }

    return (
        <Wrapper className="page-wrapper">
            <div className="page-header">
                <Header onLogout={logout} loginLink="/login" navigationLinks={headerNavigation} />
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