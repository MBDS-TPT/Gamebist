import { GetStaticProps } from "next";
import React from "react";
import styled from "styled-components";
import Page from "../../components/page-wrapper/Page";
import Login from "../../components/login/Login";
import CategoriesData from '../../dumy-data/categories.content.json';
import MatchsData from '../../dumy-data/matchs.content.json';

interface PageProps {
    categories: any;
    matches: any;
}

const LoginPage = (props: PageProps) => {

    const {
        categories,
        matches
    } = props;

    return (
        <Wrapper>
            <Page categories={categories}>
                <Login/>
            </Page>
        </Wrapper>
    );
}

export const getStaticProps: GetStaticProps = async (ctx) => {
    return {
        props: {
            categories: CategoriesData,
            matches: MatchsData
        }
    }
}

const Wrapper = styled.div`
    @media (min-width: 700px) {
        .page-container {
            padding-top: 150px;
        }
        .login {
            margin-bottom: 200px;
        }
    }
`;

export default LoginPage;