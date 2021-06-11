import React from 'react';
import styled from 'styled-components';
import Page from '../../components/page-wrapper/Page';
import TeamsTable from '../../components/table/TeamsTable';
import { GetStaticProps } from 'next';
import TeamsService from '../../services/teams/team.service';
import TitleBorder from '../../components/border/TitleBorder';

const TeamsPage = (props: any) => {

    const {
        teams
    } = props;

    return (
        <PageWrapper>
            <Page>
                <TitleBorder title="New Category">
                </TitleBorder>
                <TitleBorder title="Category List">
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