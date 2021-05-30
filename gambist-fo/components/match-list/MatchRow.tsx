import React from 'react';
import styled from 'styled-components';
import CTA from '../cta/CTA';
import Match from './IMatch';

export interface MatchRowProps {
    className?: string;
    match: Match;
    onOpenModal: Function;
} 

const MatchRow: React.FC<MatchRowProps> = ({
    className='',
    match,
    onOpenModal,
}) => {

    const OpenModal = (match: Match) => {
        onOpenModal(match);
    }

    return (
        <Wrapper className={["match", className].join(' ')}>
            <div className="teams-info">
                <div className="teams-name">
                    <div className="team-A">{match.teamA}</div>
                    <div className="team-B">{match.teamB}</div>
                </div>
                <div className="teams-score">
                    <div className="score">{2}</div>
                    <div className="score">{1}</div>
                </div>
            </div>
            <div className="bet-choice">
                <CTA className="match-team-A" onClick={() => { OpenModal(match) }}>
                    <div className="label">{match.teamA}</div>
                    <div className="team-bet"></div>
                </CTA>
                <CTA className="match-draw" onClick={() => { OpenModal(match) }}>
                    <div className="label">Match nul</div>
                    <div className="team-bet"></div>
                </CTA>
                <CTA className="match-team-B" onClick={() => { OpenModal(match) }}>
                    <div className="label">{match.teamB}</div>
                    <div className="team-bet"></div>
                </CTA>
            </div>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.match {
        display: flex;
        flex-direction: row;
        background-color: var(--white);
        border-bottom: 1px solid var(--light-gray);
    }
    .teams-info {
        width: 35%;
        text-transform: uppercase;
        font-weight: 600;
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        padding: 10px;
    }
    .teams-score {
        border-right: 1px solid var(--light-gray);
        padding-right: 10px;
        color: var(--green);
    }
    .bet-choice {
        width: 65%;
        display: flex;
        flex-direction: row;
    }
    .match-draw,
    .match-team-A,
    .match-team-B {
        width: 33.33%;
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 10px;
        border-radius: 5px;
        background-color: var(--light-gray);
        margin: 10px;
    }
    .label {
        font-weight: 600;
        font-size: 14px;
    }
`;

export default MatchRow;