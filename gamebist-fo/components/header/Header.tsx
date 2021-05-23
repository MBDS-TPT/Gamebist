import React from 'react';
import styled from 'styled-components';

export interface HeaderProps {
    className?: string;
}

const Header = (props: HeaderProps) => {
    return (
        <Wrapper>
            <div className={["header", props.className].join()}>
                Gambist
            </div>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    .header {
        min-height: 50px;
        width: 100%;
        background-color: black;
        color: white;
    }
`;

export default Header;