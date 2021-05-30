import React from 'react';
import styled from 'styled-components';
import Match from '../match-list/IMatch';

export interface TeamCardProps {
    className?: string;
    size?: string | 'large' | 'medium';
}

const TeamCard:React.FC<TeamCardProps> = ({
    className='',
    size='large'
}) => {


    return (
        <Wrapper className={["team-card", size, className].join(' ')} >
            <img src="https://livedemo00.template-help.com/wt_prod-19186/images/team-atletico-100x100.png"/>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.team-card {
        display: flex;
        flex-direction: column;
        border: 1px solid var(--light-gray);
    }
    &.team-card.large,
    &.team-card.medium {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
    }
    &.team-card.large {
        width: 200px;
        height: 242px;
    }
    &.team-card.medium {
        width: 115px;
        height: 118px;
    }
    img {
        width: 100px;
        height: 100px;
    }
`;

export default TeamCard;