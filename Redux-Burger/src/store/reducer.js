import * as actionTypes from './actions';

const initialState={
    ingredients:{
        salad:0,
        alootikki:0,
        paneer:0,
        cheese:0
    },
    totalPrice:50
}

const INGREDIENTS_PRICE = {
    salad: 10,
    paneer: 5,
    alootikki: 20,
    cheese: 30
}

const reducer =(state=initialState,action)=>{
    switch (action.type){
        case actionTypes.ADD_INGREDIENTS:
            return{
                ...state,
                ingredients:{
                    ...state.ingredients,
                    [action.ingredientName]:state.ingredients[action.ingredientName] + 1
                },
                totalPrice:state.totalPrice + INGREDIENTS_PRICE[action.ingredientName]
            };
        case actionTypes.REMOVE_INGREDIENTS:
            return{
                ...state,
                ingredients:{
                    ...state.ingredients,
                    [action.ingredientName]:state.ingredients[action.ingredientName] - 1
                },
                totalPrice:state.totalPrice - INGREDIENTS_PRICE[action.ingredientName]
            };
        default:
            return state;
    }

}

export default reducer;////