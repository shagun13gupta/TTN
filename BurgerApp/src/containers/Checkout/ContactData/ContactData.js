import React, { Component } from 'react';
import Button from '../../../components/UI/Button/Button';
import classes from './ContactData.module.css';
import axios from '../../../hoc/axios-orders';
import Spinner from '../../../components/UI/Spinner/Spinner';
import Input from '../../../components/UI/Input/Input';


class ContactData extends Component {

    state = {
        orderForm: {
            name: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Your Name',

                },
                value: ''

            },
            email: {
                elementType: 'input',
                elementConfig: {
                    type: 'email',
                    placeholder: 'Your Email',

                },
                value: ''

            },
            street: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Street Name and No.',

                },
                value: ''

            },

            pincode: {
                elementType: 'input',
                elementConfig: {
                    type: 'text',
                    placeholder: 'Pincode ',

                },
                value: ''

            },
            deliveryMethod: {
                elementType: 'select',
                elementConfig: {
                    options: [
                        { value: 'fastest', displayValue: 'Fastest' },
                        { value: 'cheapest', displayValue: 'Cheapest' }

                    ]

                },
                value: ''
            }

        },

        loading: false
    }

    inputChangedHandler = (event, inputIdentifier) => {
        event.preventDefault();
        const updatedOrderForm = { ...this.state.orderForm };

        const updatedFormElement = { ...updatedOrderForm[inputIdentifier] };

        // console.log(updatedFormElement);
        // console.log(inputIdentifier);
        updatedFormElement.value = event.target.value;
        updatedOrderForm[inputIdentifier] = updatedFormElement;
        this.setState({ orderForm: updatedOrderForm });
    }

    componentDidMount() {
        this.isMount = true;
    }
    componentWillUnmount() {
        this.isMount = false;
    }

    

    orderHandler = async (event) => {
        event.preventDefault();
        console.log(this.props.ingredients);

        this.setState({ loading: true });
        const formData = {};
        for (let formElementIdentifier in this.state.orderForm) {
            formData[formElementIdentifier] = this.state.orderForm[formElementIdentifier].value;

        }

        console.log(this.props);

        const order = {

            ingredients: this.props.ingredients,
            price: this.props.price,
            orderData: formData

        }
        
        await axios.post('/order.json', order)
            .then(response => {
                this.setState({ loading: false });

                console.log(response);
                console.log(response.config.data);

                this.props.history.push('/');

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
                        changed={(event) => this.inputChangedHandler(event, formElement.id)} />


                ))}
                <Button btnType="Success">Order</Button>
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

export default ContactData;