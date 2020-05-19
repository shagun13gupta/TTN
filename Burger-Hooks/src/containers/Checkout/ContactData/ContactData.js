import React, { useState } from 'react';
import Button from '../../../components/UI/Button/Button';
import classes from './ContactData.module.css';
import axios from '../../../hoc/axios-orders';
import Spinner from '../../../components/UI/Spinner/Spinner';
import Input from '../../../components/UI/Input/Input';
import { connect } from 'react-redux';
import withErrorHandler from '../../../hoc/withErrorHandler/withErrorHandler';
import * as actions from '../../../store/actions/index';


const ContactData = props => {

    const [orderForm, setOrderForm] = useState({

        name: {
            elementType: 'input',
            elementConfig: {
                type: 'text',
                placeholder: 'Enter your Name',

            },
            value: '',
            validation: {
                required: true
            },
            valid: false,
            touched: false

        },
        email: {
            elementType: 'input',
            elementConfig: {
                type: 'email',
                placeholder: 'Enter Email in xxx@gmail.com format',

            },
            value: '',
            validation: {
                required: true
            },
            valid: false,
            touched: false

        },
        street: {
            elementType: 'input',
            elementConfig: {
                type: 'text',
                placeholder: 'Street Name and No.',

            },
            value: '',
            validation: {
                required: true
            },
            valid: false,
            touched: false

        },

        pincode: {
            elementType: 'input',
            elementConfig: {
                type: 'text',
                placeholder: 'Enter 6 digit valid Pincode ',

            },
            value: '',
            validation: {
                required: true,
                minLength: 6,
                maxLength: 6
            },
            valid: false,
            touched: false


        },
        deliveryMethod: {
            elementType: 'select',
            elementConfig: {
                options: [
                    { value: 'fastest', displayValue: 'Fastest' },
                    { value: 'cheapest', displayValue: 'Cheapest' }

                ]

            },
            validation: {},
            valid: true,
            value: 'fastest'
        }
    });
    const [formIsValid, setFormIsValid] = useState(false)
    const [loading] = useState(false)

    const checkValidity = (value, rules) => {

        let isValid = true;
        if (!rules) {
            return true;
        }

        if (rules.required) {
            isValid = value.trim() !== '' && isValid;
        }
        if (rules.minLength) {
            isValid = value.length >= rules.minLength && isValid
        }
        if (rules.maxLength) {
            isValid = value.length <= rules.maxLength && isValid
        }

        return isValid;


    }
    const inputChangedHandler = (event, inputIdentifier) => {
        event.preventDefault();
        const updatedOrderForm = { ...orderForm };

        const updatedFormElement = { ...updatedOrderForm[inputIdentifier] };

        // console.log(updatedFormElement);
        // console.log(inputIdentifier);

        updatedFormElement.value = event.target.value;
        updatedFormElement.valid = checkValidity(updatedFormElement.value, updatedFormElement.validation)
        updatedFormElement.touched = true;
        updatedOrderForm[inputIdentifier] = updatedFormElement;
        // console.log(updatedFormElement);

        let formIsValid = true;
        for (let inputIdentifier in updatedOrderForm) {
            formIsValid = updatedOrderForm[inputIdentifier].valid && formIsValid;


        }

        console.log(formIsValid);
        setOrderForm(updatedOrderForm);
        setFormIsValid(formIsValid)
    }





    const orderHandler = async (event) => {

        event.preventDefault();
        
        const formData = {};
        for (let formElementIdentifier in orderForm) {
            formData[formElementIdentifier] = orderForm[formElementIdentifier].value;
        }




        const order = {

            ingredients: props.ings,
            price: props.price,
            orderData: formData,
            userId: props.userId

        }
        props.onOrderBurger(order, props.token);


        //   alert("Successfully added the order in the database..!!!");

    }


    const formElementsArray = [];

    for (let key in orderForm) {
        formElementsArray.push({
            id: key,
            config: orderForm[key]
        });
    }
    let form = (
        <form onSubmit={orderHandler}>

            {formElementsArray.map(formElement => (
                <Input
                    key={formElement.id}
                    elementType={formElement.config.elementType}
                    elementConfig={formElement.config.elementConfig}
                    value={formElement.config.value}
                    invalid={!formElement.config.valid}
                    shouldValidate={formElement.config.validation}
                    touched={formElement.config.touched}
                    changed={(event) => inputChangedHandler(event, formElement.id)} />


            ))}
            <Button btnType="Success" disabled={!formIsValid}>Order</Button>
        </form>
    );
    if (loading) {
        form = <Spinner />;
    }
    return (
        <div className={classes.ContactData}>
            <h2>Enter your contact details.....!!!!</h2>
            {form}

        </div>
    )

}

const mapStateToProps = state => {
    return {
        ings: state.burgerBuilder.ingredients,
        price: state.burgerBuilder.totalPrice,
        loading: state.order.loading,
        token: state.auth.token,
        userId: state.auth.userId

    }
}

const mapDispatchToProps = dispatch => {
    return {
        onOrderBurger: (orderData, token) => dispatch(actions.purchaseBurger(orderData, token))
    }

}

export default connect(mapStateToProps, mapDispatchToProps)(withErrorHandler(ContactData, axios));