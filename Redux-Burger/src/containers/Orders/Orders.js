import React, { Component } from 'react';
import Order from '../../components/Order/Order';
import axios from '../../hoc/axios-orders';
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler';

class Orders extends Component{


    state={
        orders:[],
        loading:true

    }
    componentDidMount(){
        axios.get('/order.json').then(response=>{

            const fetchedOrders=[];
            for(let key in response.data){
                fetchedOrders.push({
                    ...response.data[key],
                    id:key
                });

            }
            console.log(fetchedOrders);
            console.log(response);
            this.setState({loading:false, orders:fetchedOrders});
        }).catch(error=>{
            this.setState({loading:false});
        });
    }
    render(){

        
        return(
            <div>
               {this.state.orders.map(order=>(
                
                   <Order key={order.id}
                          ingredients={order.ingredients}
                          price={order.price}
                          orderData={order.orderData}/>

               ))}
               
            </div>
        );
    }
}


export default withErrorHandler(Orders,axios) ;