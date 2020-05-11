import React, { Component } from 'react';
import Aux from '../../hoc/Auxilary';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UI/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import axios from '../../hoc/axios-orders';
import Spinner from '../../components/UI/Spinner/Spinner';
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler';
import {connect} from 'react-redux';
import * as actionTypes from '../../store/actions';



class BurgerBuilder extends Component {
    state = {      
        
      
        purchasing: false,
        loading: false
    }


   
    componentDidMount () {
        console.log(this.props);
        // axios.get( 'https://react-burger-app-bab24.firebaseio.com/ingredients.json' )
        //     .then( response => {
        //         console.log(response.data);
        //         this.setState( { ingredients: response.data } );

        //     } )
        //     .catch( error => {
        //         this.setState( { error: true } );
        //     } );

        console.log(this.state.ingredients);
    }


    updatePurchase(ingredients) {

        const sum = Object.keys(ingredients).map(
            igkey => {
                return ingredients[igkey];
            }).reduce((sum, el) => {
                return sum + el;
            }, 0);
        return sum > 0 ;
       
    }

    purchaseHandler = () => {
        this.setState({ purchasing: true });
    }

    purchaseCancelHandler = () => {
        this.setState({ purchasing: false })
    }

    purchaseContinueHandler = () => {            
        
        this.props.history.push('/checkout');
        console.log(this.state.ingredients);
    }

   
    render() {

        console.log(this.state.ingredients);
        
        const disabledInfo = {
            ...this.props.ings
        };
        for (let key in disabledInfo) {
            disabledInfo[key] = disabledInfo[key] <= 0
        }
         let orderSummary = null;
        let burger = this.state.error ? <p>Ingredients can't be loaded!</p> : <Spinner />;

        if ( this.props.ings) {
            burger = (
                <Aux>
                    <Burger ingredients={this.props.ings} />
                    <BuildControls
                        ingredientsAdded={this.props.onIngredientAdded}
                        ingredientsMinus={this.props.onIngredientRemoved}
                        disabled={disabledInfo}
                        purchasable={this.updatePurchase(this.props.ings)}
                        ordered={this.purchaseHandler}
                        price={this.props.price} />
                </Aux>
            );
            orderSummary = <OrderSummary
                ingredients={this.props.ings}
                price={this.props.price}
                purchaseCancelled={this.purchaseCancelHandler}
                purchaseContinue={this.purchaseContinueHandler} />;
        }
        if ( this.state.loading ) {
            orderSummary = <Spinner />;
        }
        // {salad: true, meat: false, ...}
        return (
            <Aux>
                <Modal show={this.state.purchasing} modalClosed={this.purchaseCancelHandler}>
                    {orderSummary}
                </Modal>
                {burger}
            </Aux>
        );
    }
}

const mapStateToProps = state =>{
    return{
        ings:state.ingredients,
        price:state.totalPrice
    };
}

const mapDispatchToProps= dispatch =>{
    return {
        onIngredientAdded: (igName) => dispatch({type:actionTypes.ADD_INGREDIENTS, ingredientName:igName}),
        onIngredientRemoved: (igName)=>dispatch({type:actionTypes.REMOVE_INGREDIENTS,ingredientName:igName})
    }
    

}

export default connect(mapStateToProps,mapDispatchToProps)(withErrorHandler(BurgerBuilder,axios))  ;