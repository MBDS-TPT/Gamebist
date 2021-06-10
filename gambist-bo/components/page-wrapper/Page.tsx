import React from 'react';
import styled from 'styled-components';
import Header from '../header/Header';


export interface PageWrapperProps {
    className?: string;
}

const Page:React.FC<any> = ({
    className='',
    children
}) => {
    return (
        <Wrapper className={[className, "page"].join(' ')}>
            <div className="side-nav"></div>
            <div className="page-container">
                <Header/>
                <div className="page-content">
                    {children}
                </div>
            </div>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    &.page {
        display: flex;
        flex-direction: row;
    }
    .side-nav {
        width: 20%;
        min-width: 240px;
        background-color: var(--dark); 
    }
    .page-container {
        width: 80%;
        min-width: 400px;
        min-height: 100vh;
    }
    .page-content {
        padding: 20px;
    }
`;

export default Page;