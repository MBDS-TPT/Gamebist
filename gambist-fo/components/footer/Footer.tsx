import React from 'react';
import styled from 'styled-components';

export interface FooterProps {
    className?: string;
}

const Footer: React.FC<FooterProps> = ({
    className=''
}) => {
    return (
        <Wrapper className={["footer", className].join(' ')}>
            <div className="container">

            </div>
        </Wrapper>
    )
}

const Wrapper = styled.footer`
    &.footer {
        min-height: 300px;
        width: 100%;
        background-color: #383838;
        color: white;
        display: flex;
        flex-direction: row;
    }
`;

export default Footer;