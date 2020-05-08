import React, { Component } from 'react';
import {Redirect} from 'react-router-dom';
import classes from './NewPost.module.css';
import axios from 'axios';


class NewPost extends Component {
    state = {
        title: '',
        content: '',
        author: 'Max',
        submitted:false
    }
    componentDidMount(){
        console.log(this.props);
    }

    postDataHandler=()=>{
        const data={
            title:this.state.title,
            content:this.state.content,
            author:this.state.author
        };
        axios.post("http://jsonplaceholder.typicode.com/posts",data).then(response=>{
            console.log(response.data);

            /** Alternative way of redirecting the pages replace keyword will replace the page in 
             * the stack such that after redirecting to the page we cannot goback.
             */

           // this.props.history.push('/');
            
           this.setState({submitted:true});
            alert("Post successfully submitted");
        });
    }
    render () {
        let redirect=null;
        if(this.state.submitted)
        {
            redirect=<Redirect to="/post"/>;
        }
        return (
           

            <div className={classes.NewPost}>
                {redirect}
                <h1>Add a Post</h1>
                <label>Title</label>
                <input type="text" value={this.state.title} onChange={(event) => this.setState({title: event.target.value})} />
                <label>Content</label>
                <textarea rows="4" value={this.state.content} onChange={(event) => this.setState({content: event.target.value})} />
                <label>Author</label>
                <select value={this.state.author} onChange={(event) => this.setState({author: event.target.value})}>
                    <option value="Max">Max</option>
                    <option value="Manu">Manu</option>
                </select>
                <button onClick={this.postDataHandler}>Add Post</button>
            </div>
        );
    }
}

export default NewPost;