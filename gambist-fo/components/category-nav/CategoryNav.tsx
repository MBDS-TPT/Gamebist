import React, { useCallback } from 'react';
import styled from 'styled-components';
import { Category } from '../../model/Model';
import CTA from '../cta/CTA';
import CategoryCard from './CategoryCard';
import BetCategory from './ICategory';

export interface CategoryNavProps {
    className?: string;
    categories: BetCategory[];
    onChangeCategory?: Function;
}

const CategoryNav: React.FC<CategoryNavProps> = ({
    className = '',
    categories = [],
    onChangeCategory
}) => {

    const OnSelectCategory = (category: Category) => {
        if(onChangeCategory) {
            onChangeCategory(category);
        }
    } 

    return (
        <Wrapper className={["categories", className].join(' ')}>
            <div className="category-header">
                <span>Sports</span>
            </div>
            <div className="categories-container">
                {categories && categories.map((category) => {
                    return (
                        <CategoryCard onClick={() => {OnSelectCategory(category)}} key={category.id} category={category}/>
                    );
                })}
            </div>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    &.category-nav {
        min-width: 280px;
        background-color: var(--white);
        margin: 0 10px;
        min-height: 400px;
        border-radius: 5px;
        padding: 10px;
    }
    .category-header span {
        font-weight: 700;
        font-size: 16px;
    }
    .categories-container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
    }
    .category {
        width: 120px;
        height: 130px;
        display: flex;
        align-items: center;
        justify-content: center;
        font-weight: 700;
        text-transform: uppercase;
    }
    .category-link {
        color: #c0c0c0;
    }
    .category-link.active,
    .category-link:hover {
        color: var(--dark);
        background-color: unset;
    }
`;

export default CategoryNav;