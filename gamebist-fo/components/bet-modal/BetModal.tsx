import React from 'react';
import styled from 'styled-components';
import CategorySideNav from '../category-nav/CategorySideNav';
import BetCategory from '../category-nav/ICategory';
import BetSpinner from '../form/BetSpinner';
import Button from '../form/Button';
import Header from '../header/Header';
import Match from '../match-list/IMatch';
import Modal from '../modal/Modal';

export interface BetModalProps {
    match?: Match;
    betCategory?: string;
    show?: Boolean;
    onClose: Function;
}

const BetModal: React.FC<BetModalProps> = ({
    match,
    betCategory,
    onClose,
    show
}) => {
    return (
        <Modal onClose={onClose} show={show} title="Placing a bet">
            <Wrapper className="bet-modal" >
                <div className="bet-modal-details">
                    <span>{ betCategory }</span>
                </div>
                <div>
                    {match?.teamA} x {match?.teamB}
                </div>
                <BetSpinner className="bet-modal-spinner" name="bet-value"/>
                <Button className="bet-modal-btn" value="Place bet" />
            </Wrapper>
        </Modal>
    );
}

const Wrapper = styled.div`
    &.bet-modal {
        display: flex;
        flex-direction: column;
        align-items: center;
    }
    .bet-modal-spinner {
        margin-bottom: 10px;
    }
    .bet-modal-btn {
        width: 100%;
        height: 50px;
    }
`;

export default BetModal;