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

const TeamsPage = (props: any) => {

    const {
        teams,
        categories
    } = props;

    const PostTeam = (team: any) => {
        TeamService.PostTeam(team);
    }

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Team">
                    <TeamInput postAction={PostTeam} categories={categories} />
                </TitleBorder>
                <TitleBorder title="Team List">
                    <TeamsTable teams={teams}/>
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