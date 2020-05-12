import React, { Component } from 'react';
import {connect} from 'react-redux';
import * as actionCreators from '../../store/actions/index';
import CounterControl from '../../components/CounterControl/CounterControl';
import CounterOutput from '../../components/CounterOutput/CounterOutput';


class Counter extends Component {
    
    state = {
        counter: 0
    }

    
    counterChangedHandler = ( action, value ) => {
        switch ( action ) {
            case 'inc':
                this.setState( ( prevState ) => { return { counter: prevState.counter + 1 } } )
                break;
            case 'dec':
                this.setState( ( prevState ) => { return { counter: prevState.counter - 1 } } )
                break;
            case 'add':
                this.setState( ( prevState ) => { return { counter: prevState.counter + value } } )
                break;
            case 'sub':
                this.setState( ( prevState ) => { return { counter: prevState.counter - value } } )
                break;
            default :
                console.log('abc');
        }
    }

    render () {
        console.log(this.props);
        return (
            <div>
                <CounterOutput value={this.props.ctr} />
                <CounterControl label="Increment" clicked={this.props.OnIncrementCounter} />
                <CounterControl label="Decrement" clicked={this.props.OnDecrementCounter} />
                <CounterControl label="Add 5" clicked={this.props.OnAddCounter}  />
                <CounterControl label="Subtract 5" clicked={this.props.OnSubtractCounter}  />
                <hr/>
                <button onClick={()=>this.props.OnStoredResults(this.props.ctr)}>Store Result</button>
                <div>
                    {this.props.storedResults.map(strResult=>(
                        <li key={strResult.id} onClick={() => this.props.OnDeleteResults(strResult.id)}>{strResult.value}</li>
                    
                    ))}
                </div>
            </div>
        );
    }
}
const mapStateToProps = state =>{
    return{
        ctr:state.ctr.counter,
        storedResults:state.res.result

    };
  
}


const mapDispatchToPorps = dispatch =>{
    return{
        OnIncrementCounter:()=>dispatch(actionCreators.increment()),
        OnDecrementCounter:()=>dispatch(actionCreators.decrement()),
        OnAddCounter: ()=>dispatch(actionCreators.add(5)),
        OnSubtractCounter: ()=>dispatch(actionCreators.subtract(5)),
        OnStoredResults: (result)=>dispatch(actionCreators.storeResults(result)),
        OnDeleteResults: (id)=>dispatch(actionCreators.deleteResults(id))
    };
}
export default connect(mapStateToProps,mapDispatchToPorps)(Counter) ;