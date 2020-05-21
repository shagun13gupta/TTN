import React from 'react';
import {configure , shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import CheckoutSummary from './CheckoutSummary';
import Burger from '../../Burger/Burger';
import Button from '../../UI/Button/Button';

configure({adapter:new Adapter()});

describe('<CheckoutSummary/>',()=>{
    let wrapper;
    beforeEach(()=>{
        wrapper=shallow(<CheckoutSummary/>);
    });

    it('should render <Burger/> element ',()=>{
        expect(wrapper.find(Burger)).toHaveLength(1);
    });

    it('should render <Button/> element ',()=>{       
        expect(wrapper.find(Button)).toHaveLength(2);
    });

  
})