import React from 'react';
import styled from 'styled-components';
import { Match, Team } from '../../model/Model';
import ArrowForwardIosIcon from '@material-ui/icons/ArrowForwardIos';
import CTA from '../cta/CTA';

export interface MatchRowProps {
    className?: string;
    match: Match;
    matchDetailUrl?: string;
    onOpenModal: Function;
    selectedTeam?: Team | any | undefined;
} 

const MatchRow: React.FC<MatchRowProps> = ({
    className='',
    match,
    matchDetailUrl,
    onOpenModal,
    selectedTeam
}) => {

    const OpenModal = (event: any, match: Match, selectedTeam: any) => {
        if(onOpenModal)
            onOpenModal(match, selectedTeam);
        event.preventDefault();
    }   

    return (
        <Wrapper className={["match", className].join(' ')}>
            <div className="teams-info">
                <div className="teams-name">
                    <div className="team-A">{match.teamA?.name}</div>
                    <div className="team-B">{match.teamB?.name}</div>
                </div>
                <div className="teams-score">
                    <div className="score">{match.scoreA}</div>
                    <div className="score">{match.scoreB}</div>
                </div>
            </div>
            <div className="bet-choice">
                <CTA className="match-team-A" onClick={(e: any) => { OpenModal(e, match, match.teamA) }}>
                    <div className="label">{match.teamA?.name}</div>
                    <div className="match-odds">{ match.oddsA?.toFixed(2) }</div>
                </CTA>
                <CTA className="match-draw" onClick={(e: any) => { OpenModal(e, match, null) }}>
                    <div className="label">Match nul</div>
                    <div className="match-odds">{ match.oddsNul?.toFixed(2) }</div>
                </CTA>
                <CTA className="match-team-B" onClick={(e: any) => { OpenModal(e, match, match.teamB) }}>
                    <div className="label">{match.teamB?.name}</div>
                    <div className="match-odds">{ match.oddsB?.toFixed(2) }</div>
                </CTA>
            </div>
            <a className="match-details-link" href={matchDetailUrl}>
                <ArrowForwardIosIcon/>
            </a>
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
        padding: 4px;
        border-radius: 5px;
        background-color: var(--light-gray);
        margin: 10px;
    }
    .label {
        font-weight: 600;
        font-size: 14px;
    }
    .match-details-link {
        width: 40px;
        display: flex;
        margin: 10px;
        align-items: center;
        justify-content: center;
        color: var(--gray)
    }
    .match-odds {
        font-weight: 700; 
    }
`;

export default MatchRow;