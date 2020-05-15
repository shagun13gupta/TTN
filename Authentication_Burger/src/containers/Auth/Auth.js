import React, { Component } from 'react';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';
import classes from './Auth.module.css';
import * as actions from '../../store/actions/index';
import {connect} from 'react-redux';
import Spinner from '../../components/UI/Spinner/Spinner';
import {Redirect} from 'react-router-dom';

class Auth extends Component {

    state = {
        controls: {
            email: {
                elementType: 'input',
                elementConfig: {
                    type: 'email',
                    placeholder: 'Enter Your Mail',

                },
                value: '',
                validation: {
                    required: true

                },
                valid: false,
                touched: false

            },
            password: {
                elementType: 'input',
                elementConfig: {
                    type: 'password',
                    placeholder: 'Password',

                },
                value: '',
                validation: {
                    required: true,
                    minLength: 6
                },
                valid: false,
                touched: false

            }
           
        },
        isSignUp:true
    }

    componentDidMount(){
        if(!this.props.buildingBurger && this.props.authRedirectPath!=='/'){
            this.props.onSetAuthRedirectPath();
        }
    }


    checkValidity(value, rules) {

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


        if (rules.isEmail) {
            const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
            isValid = pattern.test(value) && isValid
        }

        if (rules.isNumeric) {
            const pattern = /^\d+$/;
            isValid = pattern.test(value) && isValid
        }

        return isValid;


    }

    inputChangedHandler = (event, controlName) => {

        /**
         * Here controlName is the form id like email and password such that we can iterate inside 
         * the key elements too.
         */

        //console.log(controlName);
       // console.log(this.state.controls[controlName]);
        const updatedControls = {
            ...this.state.controls,
            [controlName]: {
                ...this.state.controls[controlName],
                value: event.target.value,
                valid: this.checkValidity(event.target.value, this.state.controls[controlName].validation),
                touched: true
            }
        };

        this.setState({ controls: updatedControls });

    }

    submitHandler=(event)=>{
        event.preventDefault();
        console.log(this.state.controls.email.value);
        this.props.onAuth(this.state.controls.email.value,this.state.controls.password.value,this.state.isSignUp);
    }

    switchHandler=(event)=>{

        console.log(this.state.isSignUp);

     //   event.preventDefault();
        this.setState(prevState=>{
            console.log(prevState);
            return { isSignUp : !prevState.isSignUp };
            
        })
    }
    render() {


      

        /**
         * we make an empty array and then we push the object inside object elements.
         * Id will be the email and password and config stores the value inside the key i.e Id.
         * After that we dynamically show the input controls using <Input/>
         */

        const formElementsArray = [];
        for (let key in this.state.controls) {
          //  console.log(key);
            formElementsArray.push({
                id: key,
                config: this.state.controls[key]
            });

        }

        //console.log(formElementsArray);
        let form = formElementsArray.map(formElement => (

            <Input
                key={formElement.id}
                elementType={formElement.config.elementType}
                elementConfig={formElement.config.elementConfig}
                value={formElement.config.value}
                invalid={!formElement.config.valid}
                shouldValidate={formElement.config.validation}
                touched={formElement.config.touched}
                changed={(event) => this.inputChangedHandler(event, formElement.id)} />


        ))

        if(this.props.loading){
            form=<Spinner/>
        }

        let errorMessage=null;
        if(this.props.error){
            errorMessage=(
                <p>{this.props.error.message}</p>
            )
        }

        let authRedirect=null;
        if(this.props.isAuthenticated){
            authRedirect=<Redirect to ={this.props.authRedirectPath}/>
        }
        return (
            <div className={classes.Auth}>
                {authRedirect}
                {errorMessage}
                <form onSubmit={this.submitHandler}>
                    {form}
                    <Button btnType="Success">Submit</Button>
                </form>
                <Button clicked={this.switchHandler}
                        btnType="Danger">Switch to {this.state.isSignUp ? 'SignIN' :'SignUp' } </Button>
            </div>
        )
    }
}

const mapStateToProps=state=>{
    return{
        loading:state.auth.loading,
        error:state.auth.error,
        isAuthenticated:state.auth.token !==null,
        buildingBurger:state.burgerBuilder.building,
        authRedirectPath:state.auth.authRedirectPath
    }
}

const mapDispatchToProp=(dispatch)=>{

    return{
        onAuth: (email,password,isSignUp)=>dispatch(actions.auth(email,password,isSignUp)),
        onSetAuthRedirectPath: ()=>dispatch(actions.setAuthRedirectPath('/'))
    }
}
export default connect(mapStateToProps,mapDispatchToProp)(Auth) ;