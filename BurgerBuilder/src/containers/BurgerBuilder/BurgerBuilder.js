import React, { Component } from 'react';
import Aux from '../../hoc/Auxilary';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UI/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';




const INGREDIENTS_PRICE={
    salad:10,
    paneer:5,
    alootikki:20,
    cheese:30 
}

class BurgerBuilder extends Component {
    state={
        ingredients:{
            salad:0,
            paneer:0,
            alootikki:0,
            cheese:0
           
        },
        totalPrice:50,
        purchasable:false,
        purchasing:false
    }


    updatePurchase(ingredients){
        
        const sum=Object.keys(ingredients).map(
            igkey=>{
                return ingredients[igkey];
            }).reduce((sum,el)=>{
                return sum + el;
            },0);
            this.setState({purchasable: sum>0});
    }

    purchaseHandler=()=>{
        this.setState({purchasing:true});
    }

    purchaseCancelHandler=()=>{
        this.setState({purchasing:false})
    }

    purchaseContinueHandler=()=>{
        alert("You continue");
 
 
     
      
    }

    addIngredientHandler=(type)=>{
        
        const updateIngredients={...this.state.ingredients};        
        updateIngredients[type]=this.state.ingredients[type]+1;
        const price=INGREDIENTS_PRICE[type];
        const newPrice=this.state.totalPrice + price;
        this.setState(
        { totalPrice:newPrice,
          ingredients:updateIngredients
        })
        this.updatePurchase(updateIngredients);
    }

    removeIngredientHandler=(type)=>{
        
        const updateIngredients={...this.state.ingredients};
        updateIngredients[type]=this.state.ingredients[type]-1;
        const priceMinus=INGREDIENTS_PRICE[type];
        const newPrice=this.state.totalPrice - priceMinus;
        this.setState({totalPrice:newPrice,ingredients:updateIngredients})
        this.updatePurchase(updateIngredients);
    }
    render() {
        const disabledInfo={
            ...this.state.ingredients
        };
        for(let key in disabledInfo)
        {
            disabledInfo[key]=disabledInfo[key]<=0
        }
        return (
           
            <Aux>
                <Modal show={this.state.purchasing} modalClosed={this.purchaseCancelHandler}>
                    <OrderSummary ingredients={this.state.ingredients}
                                  purchaseCancelled={this.purchaseCancelHandler}
                                  purchaseContinue={this.purchaseContinueHandler} 
                                  price={this.state.totalPrice} />
                </Modal>

                <Burger ingredients={this.state.ingredients}/>
                <BuildControls
                    ingredientsAdded={this.addIngredientHandler}
                    ingredientsMinus={this.removeIngredientHandler}
                    disabled={disabledInfo}
                    price={this.state.totalPrice}
                    purchasable={this.state.purchasable}
                    ordered={this.purchaseHandler} />
            </Aux>
        );
    }
}

export default BurgerBuilder;