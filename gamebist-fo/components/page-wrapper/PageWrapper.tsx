import React from 'react';
import styled from 'styled-components';
import BetCategory from '../category-nav/ICategory';
import Footer from '../footer/Footer';
import Header from '../header/Header';

export interface PageWrapperProps {
    categories: BetCategory[];
}

const PageWrapper: React.FC<PageWrapperProps> = ({
    categories,
    children
}) => {
    return (
        <Wrapper className="page-wrapper">
            <Header className="page-header"/>
            <div className="page-container">
                {/* <CategorySideNav className="page-side-nav" categories={categories}/> */}
                <div className="container spage-content">
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
        margin-bottom: 10px;
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

export default PageWrapper;