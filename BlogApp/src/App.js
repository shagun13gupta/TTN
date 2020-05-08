import React, { Component } from 'react';
import Blog from './container/Blog/Blog';
import { BrowserRouter } from 'react-router-dom';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div>
          <Blog />
        </div>
      </BrowserRouter>
    );
  }
}


export default App;
