import React from 'react';
import styled from 'styled-components';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import { Category, Match, Team } from '../../model/Model';
import StateText from '../state-text/StateText';
import Paper from '@material-ui/core/Paper';
import { Button, IconButton } from '@material-ui/core';
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';
import Modal from '../modal/Modal';
import { useState } from 'react';
import MatchForm from '../form/MatchForm';
import ConfirmDialog from '../modal/ConfirmDialog';

export interface MatchTableProps {
    className?: string;
    matches: Match[];
    teams: Team[];
    categories: Category[];
    onDelete?: any;
    onEdit?: any;
}

const MatchTable: React.FC<MatchTableProps> = ({
    className='',
    matches,
    onDelete,
    onEdit,
    categories=[],
    teams=[]
}) => {
    const columns:string[] = ["ID", "Team A", "Team B", "Category", "Date", "State", "Actions"];
    const [deleteModalVisible, setVisibleDeleteModal] = useState<Boolean>(false);
    const [editModalVisible, setVisibleEditModal] = useState<Boolean>(false);
    const [selectedMatch, setSelectedMatch] = useState<any>();


    const openDeleteModal = (match: Match) => {
        setSelectedMatch(match);
        setVisibleDeleteModal(true);
    }
    
    const closeDeleteModal = () => {
        setVisibleDeleteModal(false);
    }
    
    const openEditModal = (match: Match) => {
        setSelectedMatch(match);
        setVisibleEditModal(true);
    }

    const closeEditModal = () => {
        setVisibleEditModal(false);
    }

    const onEditMatch = (match: Match) => {
        if(onEdit) onEdit(match);
        setVisibleEditModal(false);
    } 

    const onDeleteMatch = () => {
        if(onDelete) onDelete(selectedMatch);
        setVisibleDeleteModal(false);
    }
    
    return (
        <Wrapper className={[className, "matches-table"].join(' ')}>
            <ConfirmDialog 
                visible={deleteModalVisible} 
                message="Are you sure you want to delete this match?" 
                onConfirm={onDeleteMatch} 
                onAbort={closeDeleteModal}/>
            <Modal title="Edit match" show={editModalVisible} onClose={closeEditModal} >
                <MatchForm categories={categories} teams={teams} postAction={onEditMatch} match={selectedMatch} />
            </Modal>
            <Paper>
                <TableContainer>
                    <Table stickyHeader>
                        <TableHead>
                            <TableRow>
                                {columns.map((column, index) => (
                                    <TableCell className="table-header" key={`${column}-${index}`}> { column }</TableCell>
                                ))}
                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {matches && matches.map((match: Match, index: number) => {
                                return (
                                    <TableRow hover key={match.id}>
                                        <TableCell>{ match.id }</TableCell>
                                        <TableCell>{ match.teamA?.name }</TableCell>
                                        <TableCell>{ match.teamB?.name }</TableCell>
                                        <TableCell>{ match.category?.label }</TableCell>
                                        <TableCell>{ match.matchDate }</TableCell>
                                        <TableCell>
                                            <StateText state={match.state || 0} />    
                                        </TableCell>
                                        <TableCell className="table-actions">
                                            <IconButton onClick={() => { openEditModal(match) }} aria-label="edit">
                                                <EditIcon/>
                                            </IconButton>
                                            <IconButton onClick={() => { openDeleteModal(match) }} aria-label="delete">
                                                <DeleteIcon color="error" />
                                            </IconButton>
                                        </TableCell>
                                    </TableRow>
                                )
                            })}
                        </TableBody>
                    </Table>
                </TableContainer>
            </Paper>
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.matches-table {
        padding: 10px;
        /*background-color: #f5f5f5;*/
        border-radius: 5px;
    }
    .table-header {
        font-weight: 700;
        font-size: 14px;
    }
    .table-header:last-child {
        text-align: center;
    }
    .table-actions {
        display: flex;
        flex-direction: row;
        justify-content: center;
    }
`;

export default MatchTable;