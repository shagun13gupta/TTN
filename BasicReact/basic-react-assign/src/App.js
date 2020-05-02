import React, { Component } from 'react';
import './App.css';
import ListItems from './ListItems/ListItems';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      fruits: [],
      inputData: '',
      showlist: false
    }
    this.addItem = this.addItem.bind(this);
    this.updateItem = this.updateItem.bind(this);
    this.deleteItem = this.deleteItem.bind(this);
  }


  addItem = (evt) => {
    evt.preventDefault();
    const newItem = this.state.inputData;
    if (newItem.text !== "") {

      const [product, quantity] = newItem.split("-");
      let fruitItem = {
        text: product,
        quantity: quantity,
        key: Date.now()
      }

      // const arr=newItem.split("-");
      // let fruitItem={
      //   text:arr[0],
      //   quantity:arr[1],
      //   key:Date.now()
      // }  




      let temp = this.state.fruits;
      temp.push(fruitItem);
      console.log(fruitItem);
      console.log(temp);
      this.setState({
        fruits: temp,
        inputData: ' ',
      });
    }
  }

  updateItem = (evt) => {
    const getData = evt.target.value;

    this.setState({
      inputData: getData
    })

  }

  deleteItem(key) {
    const filterFruits = this.state.fruits.filter(item => item.key !== key);
    this.setState(
      { fruits: filterFruits }
    )
  }

  render() {

    return (
    
      <div className="App">
     
        <header>
          <form id="fruitform" onSubmit={(event) => this.addItem(event)}>
            
              
              <h2 className="heading">Fruits Details</h2>
             
              <input type="text" placeholder="Enter the fruit name - quantity "
              onChange={(event) => this.updateItem(event)} value={this.state.inputData} />
              <button type="submit"> Add </button>

           

              <table className="blueTable" >
                <thead>
                  <tr>
                    <th>
                      Fruit Name
                 </th>
                    <th>
                      Quantity
                 </th>
                  </tr>
                </thead>
                <tbody>
                  <ListItems fruits={this.state.fruits}
                    deleteItem={this.deleteItem} />
                </tbody>
              </table>
            
          </form>
        </header>
      
      
      </div>
      

    );
  }
}

export default App;


