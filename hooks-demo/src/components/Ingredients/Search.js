import React, { useState, useEffect } from 'react';

import Card from '../UI/Card';
import './Search.css';

const Search = React.memo(props => {

  const {onLoadIngredients}=props;
  const [search, setSearch] = useState('');

  useEffect(() => {

    const query=search.length===0?'': `?orderBy="title"&equalTo="${search}"`;
 
    console.log(query);
    console.log(search);
  
    fetch('https://react-hooks-85ff1.firebaseio.com/ingredients.json' + query)
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
        onLoadIngredients(loadIngredients);
      }, [search, onLoadIngredients])
     
  })
  return (
    <section className="search">
      <Card>
        <div className="search-input">
          <label>Search</label>
          <input type="text"
            value={search}
            onChange={event => setSearch(event.target.value)}
          />
        </div>
      </Card>
    </section>
  );
});

export default Search;
