import React, { useState, useEffect, useCallback } from 'react';
import IngredientList from './IngredientList';
import IngredientForm from './IngredientForm';
import Search from './Search';
import ErrorModal from '../UI/ErrorModal';

const Ingredients = () => {

  const [userIngredients, setUserIngredients] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState();

  useEffect(() => {
    fetch('https://react-hooks-85ff1.firebaseio.com/ingredients.json')
      .then(response => {
        return response.json();
      })
      .then(responseData => {
        const loadIngredients = [];
        for (const key in responseData) {
          loadIngredients.push({
            id: key,
            title: responseData[key].title,
            amount: responseData[key].amount
          })
        }
        setUserIngredients(loadIngredients);
      })
  }, []);


  const addIngredientHandler = (ingredients) => {

    setIsLoading(true);
 
    fetch('https://react-hooks-85ff1.firebaseio.com/ingredients.json', {
      method: 'POST',
      body: JSON.stringify(ingredients),
      headers: { 'Content-Type': 'applictaion/json' }
    })
      .then(response => {
        //console.log(response.json());
        setIsLoading(false);
        return response.json();

      })
      .then(responseData => {

        
        setUserIngredients(prevIngredients =>
          [...prevIngredients,
          {
            id: responseData.name,
            ...ingredients
          }
          ]);
      })
  };


  const removeIngredientHandler = ingredientId => {
    setIsLoading(true);
    fetch(`https://react-hooks-85ff1.firebaseio.com/ingredients/${ingredientId}.json`, {
      method: 'DELETE',
    })
      .then(response => {
        setIsLoading(false);
        setUserIngredients(prevIngredients =>
          prevIngredients.filter(ingredient => ingredient.id !== ingredientId)
        );
      })
      .catch(error => {
        setError('Something went wrong!!!!');
        setIsLoading(false);
      })
    console.log(ingredientId);
  };


  const searchHandler = useCallback(searchIngredients => {    
    setUserIngredients(searchIngredients);
    
  }, []);


  const clearHandler = () => {
    setError(null);
  }

  
  return (
    <div className="App">
      {error && <ErrorModal onClose={clearHandler}>{error}</ErrorModal>}
      <IngredientForm onAddIngredient={addIngredientHandler} loading={isLoading} />

      <section>
        <Search onLoadIngredients={searchHandler} />
        <IngredientList ingredients={userIngredients} onRemoveItem={removeIngredientHandler} />
        {/* Need to add list here! */}
      </section>
    </div>
  );
}

export default Ingredients;
