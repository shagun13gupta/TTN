import React from 'react';
import {configure , shallow} from 'enzyme';
import Adapter from 'enzyme-adapter-react-16';
import Toolbar from './Toolbar';
import DrawerToggle from '../SideDrawer/DrawerToggle/DrawerToggle';
import Logo from '../../Logo/Logo';
import NavigationItems from '../NavigationItems/NavigationItems';

configure({adapter:new Adapter()});


describe('<Toolbar/>',()=>{
    let wrapper;
    
    beforeEach(()=>{
        wrapper=shallow(<Toolbar/>);
    });

    it('should render <DrawerToggle/> element',()=>{
        expect(wrapper.find(DrawerToggle)).toHaveLength(1);
    });

    it('should render <Logo/> element',()=>{
        expect(wrapper.find(Logo)).toHaveLength(1);
    });

    it('should render <NavigationItems/> element',()=>{
        expect(wrapper.find(NavigationItems)).toHaveLength(1);
    });
})