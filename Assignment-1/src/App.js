import React,{Component} from 'react';
import Counter from './containers/Counter/Counter';
import './App.css';


class App extends Component{
  render(){
    return(
      <div className="App">
        <h1 style={{textAlign:'center'}}>Assignment-1</h1>
        
        <Counter/>

      </div>
    )
  }
}

export default App;
