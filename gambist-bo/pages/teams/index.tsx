import React from 'react';
import Button from '@material-ui/core/Button';
import styled from 'styled-components';
import Page from '../../components/page-wrapper/Page';
import TeamsTable from '../../components/table/TeamsTable';
import { GetStaticProps } from 'next';
import TeamsService from '../../services/teams/teams.service';
import TeamInput from '../../components/form/TeamInput';
import TitleBorder from '../../components/border/TitleBorder';

const TeamsPage = (props: any) => {

    const {
        teams
    } = props;

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Team">
                    <TeamInput/>
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
    const teamService = new TeamsService();
    const teams = await teamService.getAllTeam();
    return {
        props: {
            teams: teams
        }
    }
}

export default TeamsPage;