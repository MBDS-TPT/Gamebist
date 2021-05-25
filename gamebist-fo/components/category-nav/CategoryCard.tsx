import React, { useEffect, useState } from 'react';
import styled from 'styled-components';
import CTA from '../cta/CTA';
import BetCategory from './ICategory';

export interface CategoryCardProps {
    className?: string;
    category: BetCategory;
    onClick: Function;
}

const CategoryCard: React.FC<CategoryCardProps> = ({
    className = '',
    category,
    onClick
}) => {

    const [active, SetActive] = useState<Boolean>(false);

    const OnClick = (e:any) => {
        onClick();
        const parent = e.target.parentElement.parentElement;
        if(parent) {
            const categoryBtns: HTMLElement[] = parent.querySelectorAll('.category-link');
            categoryBtns.forEach(btn => {
                if(btn.classList.contains('active'))
                    btn.classList.remove('active')
            });
        }
        SetActive(true);
    }

    return (
        <Wrapper  onClick={OnClick} className={["category-link", active ? 'active' : ''].join(' ')}>
            <div className="category">
                { category.label }
            </div>
        </Wrapper>
    )
}

const Wrapper = styled(CTA)`
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

export default CategoryCard;