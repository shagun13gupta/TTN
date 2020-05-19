// import React, { Component } from 'react';
// import Aux from '../Auxilary';
// import Modal from '../../components/UI/Modal/Modal';

// const withErrorHandler = (WrappedComponnet,axios) => {
//     return class extends Component {

//         state={
//             error:null
//         }
//         componentDidMount(){

//             axios.interceptors.request.use(req=>{
//                 this.setState({error:null});
//                 return req;
//             });
//             axios.interceptors.response.use(res=>res,error=>{
//                 this.setState({error:error});
//             });
//         }

//         errorConfirmedHandler=()=>{
//             this.setState({error:null})
//         }
//         render() {
//             return (
//                 <Aux>
//                     <Modal show={this.state.error}
//                         modalClosed={this.errorConfirmedHandler}> 
//                      {this.state.error ? this.state.error.message : null} 
//                      </Modal>


//                     <WrappedComponnet {...this.props} />
//                 </Aux>
//             );
//         }
//     }
// }

// export default withErrorHandler;


import React, { useState, useEffect } from 'react';

import Modal from '../../components/UI/Modal/Modal';
import Aux from '../Auxilary';

const withErrorHandler = (WrappedComponent, axios) => {
    return props => {
        const [error, setError] = useState(null)


        const reqInterceptor = axios.interceptors.request.use(req => {
            setError(null);
            return req;
        });
        const resInterceptor = axios.interceptors.response.use(res => res, err => {
            setError(err)
        });


        useEffect(() => {
            return () => {
                axios.interceptors.request.eject(reqInterceptor);
                axios.interceptors.response.eject(resInterceptor);
            };
        },[reqInterceptor,resInterceptor]);


        const errorConfirmedHandler = () => {
            setError(null);
        }

        
            return (
                <Aux>
                    <Modal
                        show={error}
                        modalClosed={errorConfirmedHandler}>
                        {error ? error.message : null}
                    </Modal>
                    <WrappedComponent {...props} />
                </Aux>
            );
        
    }
}

export default withErrorHandler;