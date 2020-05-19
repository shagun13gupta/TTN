import React, { useState , useEffect } from 'react';
import Input from '../../components/UI/Input/Input';
import Button from '../../components/UI/Button/Button';
import classes from './Auth.module.css';
import * as actions from '../../store/actions/index';
import {connect} from 'react-redux';
import Spinner from '../../components/UI/Spinner/Spinner';
import {Redirect} from 'react-router-dom';

const Auth = props =>{

    const [authForm,setAuthForm]= useState({
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
           
        })
        const [isSignUp,setIsSignUp]= useState(true);

        const {buildingBurger,authRedirectPath,onSetAuthRedirectPath} = props;
        useEffect(()=>{
            if(!buildingBurger && authRedirectPath!=='/'){
                onSetAuthRedirectPath();
            }
        },[buildingBurger,authRedirectPath,onSetAuthRedirectPath]);
 


    const checkValidity=(value, rules)=> {

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

    const inputChangedHandler = (event, controlName) => {

        /**
         * Here controlName is the form id like email and password such that we can iterate inside 
         * the key elements too.
         */

        //console.log(controlName);
       // console.log(authForm[controlName]);
        const updatedControls = {
            ...authForm,
            [controlName]: {
                ...authForm[controlName],
                value: event.target.value,
                valid: checkValidity(event.target.value, authForm[controlName].validation),
                touched: true
            }
        };

        setAuthForm(updatedControls);
        

    }

    const submitHandler=(event)=>{
        event.preventDefault();
        props.onAuth(authForm.email.value,authForm.password.value,isSignUp);
    }

    const switchHandler=(event)=>{
        setIsSignUp(!isSignUp);
    }


      

        /**
         * we make an empty array and then we push the object inside object elements.
         * Id will be the email and password and config stores the value inside the key i.e Id.
         * After that we dynamically show the input controls using <Input/>
         */

        const formElementsArray = [];
        for (let key in authForm) {
          //  console.log(key);
            formElementsArray.push({
                id: key,
                config: authForm[key]
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
                changed={(event) => inputChangedHandler(event, formElement.id)} />


        ))

        if(props.loading){
            form=<Spinner/>
        }

        let errorMessage=null;
        if(props.error){
            errorMessage=(
                <p>{props.error.message}</p>
            )
        }

        let authRedirect=null;
        if(props.isAuthenticated){
            authRedirect=<Redirect to ={props.authRedirectPath}/>
        }
        return (
            <div className={classes.Auth}>
                {authRedirect}
                {errorMessage}
                <form onSubmit={submitHandler}>
                    {form}
                    <Button btnType="Success">Submit</Button>
                </form>
                <Button clicked={switchHandler}
                        btnType="Danger">Switch to {isSignUp ? 'SignIN' :'SignUp' } </Button>
            </div>
        )
    
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