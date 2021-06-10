import React from 'react';
import styled from 'styled-components';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import { Team } from '../../model/Model';
import StateText from '../state-text/StateText';
import Paper from '@material-ui/core/Paper';

export interface TeamsTableProps {
    className?: string;
    teams: Team[];
}

const TeamsTable: React.FC<TeamsTableProps> = ({
    className='',
    teams
}) => {
    const columns:string[] = ["ID", "Team name", "State"];
    return (
        <Wrapper className={[className, "teams-table"].join(' ')}>
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
                            {teams && teams.map((team, index) => {
                                return (
                                    <TableRow hover key={team.id}>
                                        <TableCell>{ team.id }</TableCell>
                                        <TableCell>{ team.name }</TableCell>
                                        <TableCell>
                                            <StateText state={team.state} />    
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
    &.teams-table {
        padding: 10px;
        /*background-color: #f5f5f5;*/
        border-radius: 5px;
    }
    .table-header {
        font-weight: 700;
        font-size: 14px;
    }
`;

export default TeamsTable;