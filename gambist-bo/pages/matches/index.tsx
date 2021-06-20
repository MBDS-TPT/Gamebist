import React from 'react';
import styled from 'styled-components';
import Page from '../../components/page-wrapper/Page';
import MatchTable from '../../components/table/MatchTable';
import { GetStaticProps } from 'next';
import MatchForm from '../../components/form/MatchForm';
import TitleBorder from '../../components/border/TitleBorder';
import { useState } from 'react';
import { Category, Match, Team } from '../../model/Model';
import MatchService from '../../services/matches/match.service';
import CategoryService from '../../services/categories/category.service';
import TeamService from '../../services/teams/team.service';
import { useEffect } from 'react';
import DateUtil from '../../utils/date.utils';
import TablePagination from '@material-ui/core/TablePagination';
import { PageResultList } from '../../model/ApiModel';
import MatchSearchForm from '../../components/form/search/MatchSearchFrom';

interface PageProps {
    matches: PageResultList<Match>;
    categories: Category[];
    teams: Team[];
}

const MatchsPage = (props: PageProps) => {

    const {
        matches,
        categories,
        teams
    } = props;

    const [matchList, setMatchList] = useState<Match[]>(matches.data);
    const [currentPage, setCurrentPage] = useState<number>(0);
    const [rowsPerPage, setRowsPerPage] = useState<number>(10);
    const [dataLoading, setDataLoading] = useState<Boolean>(false);

    useEffect(()=>{
        if(matches) {
            setMatchList(matches.data.map((match) => { 
                return formatDate(match)
            }))
        }
    }, [])

    const onAddMatch = async (match: any) => {
        await MatchService.PostMatch(match)
        .then(data => {
            data = formatDate(data)
            setMatchList([
                ...matchList,
                data
            ])
        });
    }

    const formatDate = (match: Match) => {
        const date = match.matchDate
        match.matchDate = DateUtil.parseDate(date)
        match.matchTime = DateUtil.getTime(date)
        return match
    }

    const onDeleteMatch = async (match: any) => {
        await MatchService.DeleteMatch(match)
        .then(data => {
            const matchList_ = matchList.filter((match_) => match_.id !== match.id)
            setMatchList(matchList_);
        });
    }
    
    const onEditMatch = async (match: any) => {
        await MatchService.EditMatch(match)
        .then(data => {
            const matchList_ = matchList.map((match_) => {
                if(match_.id === match.id)
                    return formatDate(data)
                return match_
            })
            setMatchList([
                ...matchList_,
            ])
        });
    }

    const onSearch = async (searchQuery: any) => {
        setCurrentPage(0);
        const result = await MatchService.getPaginatedMatch(currentPage, rowsPerPage, searchQuery)
        const matchList_ = result.data.map((match: any) => {
            return formatDate(match)
        })
        setMatchList([
            ...matchList_,
        ])
    }
    
    const onChangePage = async (e: any, page: number) => {
        setDataLoading(true);
        const result = await MatchService.getPaginatedMatch(page, rowsPerPage);
        if(result) {
            const matchList_ = result.data.map((match: any) => {
                return formatDate(match)
            })
            setMatchList([
                ...matchList_,
            ])
            setCurrentPage(page);
        }
        setDataLoading(false);
    }

    const onChangeRowsPerPage = (e: any) => {
        setRowsPerPage(e.target.value)
        console.log(e.target.value)
    }

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Match">
                    <MatchSearchForm teams={teams} onSearch={onSearch} categories={categories} />
                </TitleBorder>
                <TitleBorder title="Match List">
                    <MatchTable onLoad={dataLoading} matches={matchList} teams={teams} categories={categories} onDelete={onDeleteMatch} onEdit={onEditMatch} />
                    <TablePagination
                        component="div"
                        count={matches.totalCount}
                        page={currentPage}
                        onChangePage={onChangePage}
                        rowsPerPage={rowsPerPage}
                        onChangeRowsPerPage={onChangeRowsPerPage}
                    />
                </TitleBorder>
            </Page>
        </PageWrapper>
    )
}

const PageWrapper = styled.div`

`;

export const getStaticProps: GetStaticProps = async (ctx) => {
    const matchService = new MatchService();
    const teamService = new TeamService();
    const categoryService = new CategoryService();
    const matches = await MatchService.getPaginatedMatch(0, 10);
    const categories = await categoryService.getAllCategories();
    const teams = await teamService.getAllTeam();
    return {
        props: {
            matches: matches,
            categories,
            teams
        }
    }
}

export default MatchsPage;