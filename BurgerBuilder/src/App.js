import React,{Component} from 'react';
import './App.css';
import Layout from './components/Layout/Layout';
import BurgerBuilder from './containers/BurgerBuilder/BurgerBuilder';
import {Route, Switch} from 'react-router-dom';


class App extends Component {
  render(){
    return (
      <div>
       <Layout>
         <Switch>
           <Route path="/" exact component={BurgerBuilder}/>
           {/* <Route path="/checkout" component={Checkout}/> */}
         </Switch>
       </Layout>
      </div>
    );
  }
 
}

export default App;
