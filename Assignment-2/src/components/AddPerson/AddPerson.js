import React, { Component } from 'react';

import './AddPerson.css';

class AddPerson extends Component {

    state = {
      
        name:'',
        age:''
    }

    nameChangeHandler = (event) =>{
        this.setState({name:event.target.value});  
           
    }

    ageChangeHandler =(event) =>{
        this.setState({age:event.target.value});
    }

    clearHandler=()=>{
       
        this.setState({
            name:'',
            age:''
        })
    }
    render() {
       
        return (
            <div className="AddPerson">
                <input type="text" 
                       placeholder="Enter your Name" 
                       onChange={this.nameChangeHandler}
                       value={this.state.name} />
                <input type="number"  
                       placeholder="Enter your Age"
                       onChange={this.ageChangeHandler} 
                       value={this.state.age} />
                <button style={{backgroundColor:'pink'}} onClick={()=>this.props.personAdded(this.state.name,this.state.age)} >Add </button>


                <button style={{backgroundColor:'lightblue'}} onClick={this.clearHandler}>Clear</button>
            </div>
        );
    }
}

export default AddPerson;