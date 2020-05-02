import React from 'react'


const listItems=(props) => {
    const fruits = props.fruits;
    const listItems = fruits.map(item=>
        {
           
            return(              
              <tr className="list" key={item.key}>
                      <td>
                        {item.text}
                      </td>
                      <td>
                        {item.quantity}
                      </td>
                      <td>
                        <button type="button" onClick={()=>props.deleteItem(item.key)}>Delete</button>
                      </td>
                     </tr>

            )
          
        } )
        return listItems;
    

};


export default listItems;



// const listItems=(props) => {
//     const fruits = props.fruits;
//     const listItems = fruits.map(item=>
//         {
//             return <div className="list" key={item.key}>
//                 <p>{item.text} {item.quantity}
//                 <span>
//                     <button type="button" onClick={()=>props.deleteItem(item.key)}>Delete</button>
//                 </span>
//                 </p>
                
//             </div>
//         } )
//         return(
//             <table>
//                 <tbody>
//                 <tr>
//                    <th> Name </th>
//                    <th> Quantity </th>
//                 </tr>
//                 <tr>
//                     <td>{listItems}</td>
//                     <td>           </td>
//                 </tr>
//                 </tbody>
    
//             </table>
           
//         )
    

// };


// export default listItems;