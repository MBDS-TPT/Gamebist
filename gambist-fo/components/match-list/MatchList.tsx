import React, { useState } from 'react';
import styled from 'styled-components';
import { Match, Team } from '../../model/Model';
import BetModal from '../bet-modal/BetModal';
import BetSpinner from '../form/BetSpinner';
import Modal from '../modal/Modal';
import MatchRow from './MatchRow';

export interface MatchListProps {
    className?: string;
    tableHeader: string;
    matches: Match[];
    userBets?: any[];
    matchDetailPath?: string;
    onPostBet: Function;
}

const MatchList: React.FC<MatchListProps> = ({
    className='',
    tableHeader,
    matches=[],
    matchDetailPath,
    onPostBet,
    userBets
}) => {

    const [modalVisible, setModalVisible] = useState<Boolean>(false);
    const [selectedMatch, setSelectedMatch] = useState<Match>();
    const [selectedTeam, setSelectedTeam] = useState<Team | undefined>();
    const [betModalValue, setBetModalValue] = useState<number>(0);

    const OpenModal = (match: Match, selectedTeam: any, betModalValue=0) => {
        setSelectedMatch(match);
        setModalVisible(true);
        setSelectedTeam(selectedTeam);
        setBetModalValue(betModalValue);
    }

    const CloseModal = (event: any) => {
        setModalVisible(false)
    } 

    return (
        <Wrapper className={["match-list", className].join(' ')}>
            <div className="match-table-header">
                <span>{tableHeader}</span>
            </div>
            {matches.map((match) => {
                return <MatchRow userBets={userBets} onOpenModal={OpenModal} key={match.id} className="match-table-row" matchDetailUrl={`${matchDetailPath}/${match.id}`} match={match}/>
            })}
            <BetModal defaultValue={betModalValue} onSubmit={onPostBet} onClose={CloseModal} selectedTeam={selectedTeam} match={selectedMatch} show={modalVisible} />
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.match-list {
        display: flex;
        flex-direction: column;
        width: 100%;
    }
    .match-table-row,
    .match-table-header {
        width: 100%;
    }
    .match-table-header {
        background-color: var(--dark-gray);
        height: 45px;
        color: white;
        text-transform: uppercase;
        font-size: 14px;
        font-weight: 600;
        display: flex;
        align-items: center;
        padding-left: 15px;
    }
`;

export default MatchList;