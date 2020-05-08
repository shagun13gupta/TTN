import React, { Component } from 'react';
import axios from 'axios';
import Post from '../../component/Post/Post';
import classes from './Posts.module.css';
import {Route,Link} from 'react-router-dom';
import FullPost from '../../component/FullPost/FullPost';

class Posts extends Component {

    state = {
        posts: [],
        selectedPostId: null
    }
    componentDidMount() {
        console.log(this.props);
        axios.get("http://jsonplaceholder.typicode.com/posts").then(response => {
            const posts = response.data.slice(0, 4);
            const newPosts = posts.map(post => {
                return {
                    ...post,
                    author: "Shagun Gupta"
                }
            })
            this.setState({ posts: newPosts });
            console.log(response);
        });
    }

    showClickedPostHandler = (id) => {
      this.setState({ selectedPostId: id })
    //  this.props.history.push( '/post/' + id );
    }

    render() {
        const posts = this.state.posts.map(post => {
            return (
            <Link to={"/post/" + post.id}  key={post.id}>
                <Post
                    key={post.id}
                    title={post.title}
                    author={post.author}
                    clicked={() => this.showClickedPostHandler(post.id)} />
            </Link>
           )
        })
        return (
            <div>
                <section className={classes.Posts}>
                    {posts}
                </section>
                <Route path={this.props.match.url + '/:id'} exact component={FullPost} />
            </div>
        )
    }

}


export default Posts;