import React, { Component } from 'react';
import {Redirect} from 'react-router-dom';
import classes from './FullPost.module.css';
import axios from 'axios';

class FullPost extends Component {
    state={
        loadedPost:null,
        submitted:false
    }
    
    componentDidMount(){
        console.log(this.props);
        if(this.props.match.params.id)
        {
            if(!this.state.loadedPost || (this.state.loadedPost && this.state.loadedPost.id!==this.props.id))
            {
                axios.get("http://jsonplaceholder.typicode.com/posts/"+this.props.match.params.id).then(response=>{
                    this.setState({loadedPost:response.data});
                })
            }

        }

       
    }

    deletePostHandler=()=>{
        axios.delete("http://jsonplaceholder.typicode.com/posts/"+this.props.match.params.id)
        .then(response=>{
            console.log(response);
        });

        this.setState({submitted:true});
        alert("Successfully deleted....!!!");
       
    }


    render () {
        let redirect=null;
        if(this.state.submitted)
        {
            redirect=<Redirect to="/post"/>;
        }
        let post = <p style={{textAlign:"center"}}>Please select a Post!</p>;
        if(this.props.id)
        {
          post= <p style={{textAlign:"center"}}>Loading</p>;
        }
        if(this.state.loadedPost)
        {
            post = (
                <div className={classes.FullPost}>
                    <h1>{this.state.loadedPost.title}</h1>
                    <p>{this.state.loadedPost.body}</p>
                    <div className={classes.Edit}>
                        <button className={classes.Delete} onClick={this.deletePostHandler}>Delete</button>
                         {redirect}
                    </div>
                </div>
    
            );
        }
      
        return post;
    }
}

export default FullPost;