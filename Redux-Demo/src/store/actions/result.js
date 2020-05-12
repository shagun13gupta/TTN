import * as actionTypes from './actionsTypes';


export const saveResults =(result)=>{
    return{
        type:actionTypes.STORE_RESULTS,
        result:result
    }
}

export const storeResults=(result)=>{
    return dispatch=>{
        setTimeout(()=>{
            dispatch(saveResults(result));
        
        },2000);
    } 
  
}

export const deleteResults=(id)=>{
    return{
        type:actionTypes.DELETE_RESULTS,
        resId:id
    }
}