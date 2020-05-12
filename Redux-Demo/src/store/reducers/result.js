import * as actionTypes from  '../actions/actionsTypes';
import {updateObject} from '../utility';

const initialState={
 
    result:[]
}

const result=(state = initialState , action)=>{

    switch(action.type){
       
        case actionTypes.STORE_RESULTS:
            return updateObject(state,{ result :state.result.concat({ id : new Date(), value: action.result})});
            
        case actionTypes.DELETE_RESULTS:
            // const id=2;
            // const resId=action.resId;
            // const newArray=[...state.result];
            // newArray.splice(id,1);
            // let updateArray = state.result.slice();
            // updateArray.splice(action.resId, 1);
            // console.log(updateArray);
         
            const newArray= state.result.filter(res=>res.id !== action.resId);
            console.log(newArray);
            return updateObject(state,{  result: newArray});
          
          
        default:
            console.log("abc");

    }
   
   
    return state;
}


export default result;