import React from 'react';
import {configure , shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import {Checkout} from './Checkout';
import CheckoutSummary from '../../components/Order/CheckoutSummary/CheckoutSummary';

configure({adapter:new Adapter()});

describe('<Checkout/>',()=>{
    let wrapper;

    beforeEach(()=>{
        wrapper=shallow(<Checkout  match={{ path: ""}}/>);
    });

    it('should render <CheckoutSummary/> when recieving ingredients',()=>{
        wrapper.setProps({ings:{salad:0},})
        expect(wrapper.find(CheckoutSummary)).toHaveLength(1);
    });
});