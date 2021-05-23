import React from 'react';
import styled from 'styled-components';

const CategorySideNav = () => {
    return (
        <Wrapper>
            <div className="category-nav">
                <div className="category-title">
                    <span>Bet Category</span>
                </div>
            </div>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    .category-nav {
        min-width: 280px;
        background-color: gray;
        position: fixed;
        margin-left: 10px;
    }
`;

export default CategorySideNav;