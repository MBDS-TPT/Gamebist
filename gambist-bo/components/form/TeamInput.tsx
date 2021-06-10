import { Button, TextField } from '@material-ui/core';
import React from 'react';
import styled from 'styled-components';

export interface TeamInputProps {
    className?: string;
}

const TeamInput: React.FC<TeamInputProps> = ({
    className=''
}) => {

    return (
        <Wrapper className={[className, 'team-input'].join(' ')}>
            <form>
                <TextField id='team-name' label='Team name' variant='outlined' />
                <Button className="submit-button" variant="contained" color="primary">Create</Button>
            </form>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    &.team-input {
        display: flex;
        flex-direction: row;
        justify-content: center;
    }
    form {
        display: flex;
        flex-direction: row;
        justify-content: center;
    }
    .submit-button {
        border-radius: 0 4px 4px 0;
        left: -3px;
        bottom: 1px;
    }
`;

export default TeamInput;