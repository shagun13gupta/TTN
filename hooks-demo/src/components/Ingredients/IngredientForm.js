import React, { useState } from 'react';
import LoadingIndicator from '../UI/LoadingIndicator';
import Card from '../UI/Card';
import './IngredientForm.css';

/**
 * React memo is used to avoid unnnecassary re-renders so that it only renders
 *  when the props changed not when the parents changed.
 */
const IngredientForm = React.memo(props => {

  const [title, setTitle] = useState('');
  const [amount, setAmount] = useState('');

  const submitHandler = event => {
    event.preventDefault();

    if(title.length === 0  || amount.length ===0){
      alert("Enter Name and Amount both");
      return;
    }
    console.log("abc")
    props.onAddIngredient({ title: title, amount: amount });
    setTitle("");
    setAmount("");
  };

 
  return (
    <section className="ingredient-form">
      <Card>
        <form onSubmit={submitHandler}>
          <div className="form-control">
            <label htmlFor="title">Name</label>
            <input type="text" id="title" value={title}
              onChange={event => {
                setTitle(event.target.value);
              }} />
          </div>
          <div className="form-control">
            <label htmlFor="amount">Amount</label>
            <input type="number" id="amount" value={amount}
              onChange={event => {
                setAmount(event.target.value)
              }} />
          </div>
          <div className="ingredient-form__actions">
            <button type="submit">Add Ingredient</button>
            {props.loading ? <LoadingIndicator/> : null}
          </div>
        </form>
      </Card>
    </section>
  );
});

export default IngredientForm;
