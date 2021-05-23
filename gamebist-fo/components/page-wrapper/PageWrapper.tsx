import React from 'react';
import styled from 'styled-components';

export interface PageWrapperProps {
    children: any;
}

const PageWrapper = (props:PageWrapperProps) => {
    return (
        <Wrapper>
            <div className="page-container">
                {props.children}
            </div>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    .page-container {
        display: flex;
    }
`;

export default PageWrapper;