import React from 'react';
import {BurgerBuilder} from './BurgerBuilder';
import {configure , shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Burger from '../../components/Burger/Burger';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import Modal from '../../components/UI/Modal/Modal';


configure({adapter:new Adapter()});

describe('<BurgerBuilder/>',()=>{
    let wrapper;
    beforeEach(()=>{
        wrapper=shallow(<BurgerBuilder onInitIngredients={()=>{}}/>);
    });
    
    it('should render <BuildControls/> when recieving ingredients',()=>{
        wrapper.setProps({ings:{salad:0}});
        expect(wrapper.find(BuildControls)).toHaveLength(1);
    });

    it('should render <Burger/> when recieving ingredients',()=>{
        wrapper.setProps({ings:{salad:0}});
        expect(wrapper.find(Burger)).toHaveLength(1);
    });

    it('should render <OrderSummary/> when recieving ingredients',()=>{
        wrapper.setProps({ings:{salad:0}});
        expect(wrapper.find(OrderSummary)).toHaveLength(1);
    });

    it('should render <Modal/> when recieving ingredients',()=>{
        expect(wrapper.find(Modal)).toHaveLength(1);
    });

})
