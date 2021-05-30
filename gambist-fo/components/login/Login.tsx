import React from 'react';
import styled from 'styled-components';
import Button from '../form/Button';
import TextInput from '../form/TextInput';

export interface LoginProps {
    className?: string;
}

const Login: React.FC<LoginProps> = ({
    className=''
}) => {
    return (
        <Wrapper className={["login", className].join(' ')}>
            <div className="l-card">
                <div className="l-card-header">
                    Login
                </div>
                <div className="l-card-body">
                    <form>
                        <TextInput placeholder="Login" name="email" type="email" />
                        <TextInput placeholder="Password" name="password" type="password" />
                        <Button className="submit-btn" value="SIGN IN" />
                    </form>
                </div>
                <div className="l-card-footer"></div>
            </div>
        </Wrapper>
    )
}

const Wrapper = styled.div`
    &.login {
        min-height: 300px;
        width: 570px;
        background-color: var(--white);
        display: flex;
        flex-direction: column;
        margin: auto;
    }
    .l-card-header {
        background-color: var(--dark);
        height: 60px;
        text-align: center;
        color: white;
        padding-top: 15px;
        font-size: 20px;
        font-weight: 600;
    }
    .l-card-body {
        padding: 40px 25px;
        form {
            display: flex;
            flex-direction: column;
        }
    }
    .submit-btn {
        height: 60px;
        font-weight: 600;
    }
`;

export default Login;