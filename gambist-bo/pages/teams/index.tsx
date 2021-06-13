import React from 'react';
import Button from '@material-ui/core/Button';
import styled from 'styled-components';
import Page from '../../components/page-wrapper/Page';
import TeamsTable from '../../components/table/TeamsTable';
import { GetStaticProps } from 'next';
import TeamService from '../../services/teams/team.service';
import TeamInput from '../../components/form/TeamInput';
import TitleBorder from '../../components/border/TitleBorder';
import CategoryService from '../../services/teams/category.service';
import { useState } from 'react';
import { Team } from '../../model/Model';

const TeamsPage = (props: any) => {

    const {
        teams,
        categories
    } = props;

    const [teamList, setTeamList] = useState<Team[]>(teams);

    const onAddTeam = async (team: any) => {
        await TeamService.PostTeam(team)
        .then(data => {
            setTeamList([
                ...teamList,
                data
            ])
        });
    }

    const onDeleteTeam = async (team: any) => {
        await TeamService.DeleteTeam(team)
        .then(data => {
            const teamList_ = teamList.filter((team_) => team_.id !== team.id)
            setTeamList(teamList_);
        });
    }
    
    const onEditTeam = async (team: any) => {
        await TeamService.EditTeam(team)
        .then(data => {
            const teamList_ = teamList.map((team_) => {
                if(team_.id === team.id)
                    return team
                return team_
            }) 
            setTeamList([
                ...teamList_,
            ])
        });
    }

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Team">
                    <TeamInput postAction={onAddTeam} categories={categories} />
                </TitleBorder>
                <TitleBorder title="Team List">
                    <TeamsTable teams={teamList} categories={categories} onDelete={onDeleteTeam} onEdit={onEditTeam} />
                </TitleBorder>
            </Page>
        </PageWrapper>
    )
}

const PageWrapper = styled.div`

`;

export const getStaticProps: GetStaticProps = async (ctx) => {
    const teamService = new TeamService();
    const categoryService = new CategoryService();
    const teams = await teamService.getAllTeam();
    const categories = await categoryService.getAllCategories();
    return {
        props: {
            teams: teams,
            categories
        }
    }
}

export default TeamsPage;