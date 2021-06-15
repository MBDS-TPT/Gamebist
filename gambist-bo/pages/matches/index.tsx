import React from 'react';
import Button from '@material-ui/core/Button';
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

interface PageProps {
    matches: Match[];
    categories: Category[];
    teams: Team[];
}

const MatchsPage = (props: PageProps) => {

    const {
        matches,
        categories,
        teams
    } = props;

    const [matchList, setMatchList] = useState<Match[]>(matches);

    useEffect(()=>{
        if(matches) {
            setMatchList(matches.map((match) => { 
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
                    return match
                return match_
            }) 
            setMatchList([
                ...matchList_,
            ])
        });
    }

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Match">
                    <MatchForm teams={teams} postAction={onAddMatch} categories={categories} />
                </TitleBorder>
                <TitleBorder title="Match List">
                    <MatchTable matches={matchList} teams={teams} categories={categories} onDelete={onDeleteMatch} onEdit={onEditMatch} />
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
    const matches = await matchService.getAllMatch();
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