import React, { Component } from 'react';

import Persons from './containers/Persons';

class App extends Component {
  render() {
    return (
      <div className="App">
        <ol>
          <h3 style={{textAlign:'center', color:'blue'}}>Assignment-2</h3>
          <h3 style={{textAlign:'center'}}>Add person by clicking add button and delete person simply clicking the text.</h3>
        </ol>
        <Persons />
      </div>
    );
  }
}

export default App;
