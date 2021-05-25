import React, { ChangeEventHandler } from 'react';
import styled from 'styled-components';

export interface TextInputProps {
    className?: string;
    onChange?: any;
    onFocus?: any;
    type?:string;
    value?: string;
    placeholder?: string;
    name: string;
}

const TextInput:React.FC<TextInputProps> = ({
    className='',
    onChange = () => {},
    onFocus = () => {},
    type = 'text',
    value,
    name,
    placeholder
}) => {


    return (
        <Wrapper className={["text-input", className].join(' ')} >
            <input 
                type={type} 
                onChange={onChange} 
                onFocus={onFocus}
                value={value}
                name={name}
                placeholder={placeholder}
                />
        </Wrapper>
    );
}

const Wrapper = styled.div`
    &.text-input {
        padding: 10px 0;
    }
    input {
        border: 1px solid var(--light-gray);
        min-height: 60px;
        width: 100%;
        padding: 17px 19px;
        color: #9b9b9b;
    }
`;

export default TextInput;