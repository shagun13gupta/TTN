import React, { Component } from 'react';
import Button from '../../../components/UI/Button/Button';
import classes from './ContactData.module.css';
import axios from '../../../hoc/axios-orders';
import Spinner from '../../../components/UI/Spinner/Spinner';
import Input from '../../../components/UI/Input/Input';
import {connect} from 'react-redux';

class ContactData extends Component {

    state = {
        orderForm: {
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
                validation:{},
                valid:true,
                value: ''
            }

        },

        loading: false,
        formIsValid:false
    }

    checkValidity(value, rules) {

        let isValid = true;
        if(!rules){
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
    inputChangedHandler = (event, inputIdentifier) => {
        event.preventDefault();
        const updatedOrderForm = { ...this.state.orderForm };

        const updatedFormElement = { ...updatedOrderForm[inputIdentifier] };

        // console.log(updatedFormElement);
        // console.log(inputIdentifier);

        updatedFormElement.value = event.target.value;
        updatedFormElement.valid = this.checkValidity(updatedFormElement.value, updatedFormElement.validation)
        updatedFormElement.touched = true;
        updatedOrderForm[inputIdentifier] = updatedFormElement;
       // console.log(updatedFormElement);

        let formIsValid=true;
        for(let inputIdentifier in updatedOrderForm){
            formIsValid=updatedOrderForm[inputIdentifier].valid && formIsValid;


        }

        console.log(formIsValid);
        this.setState({ orderForm: updatedOrderForm, formIsValid:formIsValid });
    }

    componentDidMount() {
        this.isMount = true;
    }
    componentWillUnmount() {
        this.isMount = false;
    }



    orderHandler = async (event) => {

        event.preventDefault();
       
        console.log(this.props.ings);

        this.setState({ loading: true },()=>{} );

        const formData = {};
        for (let formElementIdentifier in this.state.orderForm) {
            formData[formElementIdentifier] = this.state.orderForm[formElementIdentifier].value;
        }   


        console.log(this.props);

        const order = {

            ingredients: this.props.ings,
            price: this.props.price,
            orderData: formData

        }

        await axios.post('/order.json', order)
            .then(response => {
                this.setState({ loading: false },()=>{this.props.history.push('/');});

                console.log(response);
                console.log(response.config.data);
                

            })
            .catch(error => {
                this.setState({ loading: false });
            })

        //   alert("Successfully added the order in the database..!!!");

    }
    render() {

        const formElementsArray = [];

        for (let key in this.state.orderForm) {
            formElementsArray.push({
                id: key,
                config: this.state.orderForm[key]
            });
        }
        let form = (
            <form onSubmit={this.orderHandler}>

                {formElementsArray.map(formElement => (
                    <Input
                        key={formElement.id}
                        elementType={formElement.config.elementType}
                        elementConfig={formElement.config.elementConfig}
                        value={formElement.config.value}
                        invalid={!formElement.config.valid}
                        shouldValidate={formElement.config.validation}
                        touched={formElement.config.touched}
                        changed={(event) => this.inputChangedHandler(event, formElement.id)} />


                ))}
                <Button btnType="Success" disabled={!this.state.formIsValid}>Order</Button>
            </form>
        );
        if (this.state.loading) {
            form = <Spinner />;
        }
        return (
            <div className={classes.ContactData}>
                <h2>Enter your contact details.....!!!!</h2>
                {form}

            </div>
        )
    }
}

const mapStateToProps = state =>{
    return{
        ings:state.ingredients,
        price:state.totalPrice

    }
}

export default connect(mapStateToProps)(ContactData) ;