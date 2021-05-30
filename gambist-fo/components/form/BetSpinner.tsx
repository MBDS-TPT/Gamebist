import React, { useState } from 'react';
import styled from 'styled-components';

export interface BetSpinnerProps {
    className?: string;
    name: string;
}

const BetSpinner:React.FC<BetSpinnerProps> = ({
    className='',
    name=''
}) => {

    const [value, SetValue] = useState<number>(0);

    const Increment = () => {
        SetValue(value + 1);
    }

    const Decrement = () => {
        SetValue(value - 1 >= 0 ? value - 1 : 0);
    }

    const OnChange = (event: any) => {
        var value = event.target.value+"";
        if(value === "") 
            value="0";
        if(value.match("^[0-9]*$")) {
            value = value.replaceAll(/^0+(?!$)/g, '');
            SetValue(parseInt(value))
        }
    }

    return (
        <Wrapper className={["bet-spinner", className].join(' ')} >
            <span onMouseDown={Decrement} className="bet-spin-action unselectable">-</span>
            <input min="0" onChange={OnChange} value={value} name={name}/>
            <span onMouseDown={Increment} className="bet-spin-action unselectable">+</span>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.bet-spinner {
        display: flex;
        flex-direction: row;
        height: 60px;
        width: 180px;
    }
    .bet-spin-action {
        background-color: var(--dark-gray);
        border: none;
        color: white;
        width: 33.33%;
        cursor: pointer;
        height: 100%;
        font-weight: 500;
        font-size: 25px;
        display: flex;
        align-items: center;
        justify-content: center;
        padding-bottom: 8px;
    }
    input {
        width: 33.33%;
        height: 100%;
        text-align: center;
        border: 1px solid var(--light-gray);
    }
`;

export default BetSpinner;