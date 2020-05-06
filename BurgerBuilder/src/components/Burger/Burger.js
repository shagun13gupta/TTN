
import React from 'react';
import BurgerIngredient from './BurgerIngredient/BurgerIngredient';
import classes from './Burger.module.css';



const burger = (props) => {
    let newIngredients = Object.keys(props.ingredients).map(item => {
        return [...Array(props.ingredients[item])].map((_, i) => {
            return <BurgerIngredient key={item + i} type={item} />;
        });
    }).reduce((arr, el) => {
        return arr.concat(el)
    }, []);

    if (newIngredients.length === 0) {
        newIngredients = <p>Please start adding ingredients</p>
    }

    return (
        <div className={classes.Burger}>
            <BurgerIngredient type="bread-top" />
            {newIngredients}
            <BurgerIngredient type="bread-bottom" />
        </div>
    );
};

export default burger;
