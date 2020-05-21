import React, { useEffect } from 'react';
import Order from '../../components/Order/Order';
import axios from '../../hoc/axios-orders';
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler';
import { connect } from 'react-redux';
import * as actions from '../../store/actions/index';
import Spinner from '../../components/UI/Spinner/Spinner';


const Orders = props => {


    const getOrder = props.onFetchOrders;
    const getToken = props.token;

    useEffect(() => {
        getOrder(getToken);
        // props.onFetchOrders(props.token);
    }, [getOrder, getToken])


    let orders = <Spinner />;
    if (!props.loading) {
        orders = props.orders.map(order => (
            <Order key={order.id}
                ingredients={order.ingredients}
                price={order.price}
                orderData={order.orderData} />
        ))
    }
    return (
        <div>
            {orders}
        </div>
    );

}

const mapStateToProps = state => {
    return {
        orders: state.order.orders,
        loading: state.order.loading,
        token: state.auth.token
    }
}

const mapDispatchToProps = dispatch => {
    return {
        onFetchOrders: (token) => dispatch(actions.fetchOrders(token))
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(withErrorHandler(Orders, axios));