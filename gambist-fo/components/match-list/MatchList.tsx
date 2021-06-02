import React, { useState } from 'react';
import styled from 'styled-components';
import BetModal from '../bet-modal/BetModal';
import BetSpinner from '../form/BetSpinner';
import Modal from '../modal/Modal';
import Match from './IMatch';
import MatchRow from './MatchRow';

export interface MatchListProps {
    className?: string;
    tableHeader: string;
    matchs: Match[];
}

const MatchList: React.FC<MatchListProps> = ({
    className='',
    tableHeader,
    matchs
}) => {

    const [modalVisible, SetModalVisible] = useState<Boolean>(false);
    const [selectedMatch, SetSelectedMatch] = useState<Match>();


    const OpenModal = (match: Match) => {
        SetSelectedMatch(match);
        SetModalVisible(true);
    }

    const CloseModal = (event: any) => {
        SetModalVisible(false)
    } 

    return (
        <Wrapper className={["match-list", className].join(' ')}>
            <div className="match-table-header">
                <span>{tableHeader}</span>
            </div>
            {matchs.map((match) => {
                return <MatchRow onOpenModal={OpenModal} key={match.id} className="match-table-row" match={match}/>
            })}
            <BetModal onClose={CloseModal} match={selectedMatch} show={modalVisible} />
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