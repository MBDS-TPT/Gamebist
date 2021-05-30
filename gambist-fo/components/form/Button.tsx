import React from 'react';
import styled from 'styled-components';

export interface ButtonProps {
    className?: string;
    onClick?: any;
    value: string;
    success?: Boolean;
}

const Button:React.FC<ButtonProps> = ({
    className='',
    onClick,
    value
}) => {


    return (
        <Wrapper className={["btn", className].join(' ')} onClick={onClick}>
            { value }
        </Wrapper>
    );
}

const Wrapper = styled.button`
    &.btn {
        background-color: var(--green);
        color: white;
    }

    &.btn:hover {
        background-color: var(--yellow);
        color: var(--dark);
    }
`;

export default Button;