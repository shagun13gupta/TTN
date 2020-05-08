import React, { Component } from 'react';
import Posts from '../Posts/Posts';
import { Route, NavLink, Switch, Redirect } from 'react-router-dom';
import NewPost from '../../component/NewPost/NewPost';
import classes from './Blog.module.css';
import FullPost from '../../component/FullPost/FullPost';

class Blog extends Component {

    state={
        auth:true
    }
    
    render() {
      

        return (
            <div className={classes.Blog}>
                <header>
                    <nav>
                        <ul>
                            <li><NavLink to="/post/" exact>Posts</NavLink></li>
                            <li><NavLink to="/new-post">New Post</NavLink></li>
                        </ul>
                    </nav>
                    <hr/>
                </header>
                <Switch>
                   {this.state.auth ? <Route path="/new-post" exact component={NewPost} /> : null} 
                   
                    <Route path="/post/:id" component={FullPost} />
                    <Route path="/post" component={Posts}/>
                    <Redirect from="/" to="/post"/>
                    {/* <Route path="/new-post" component={NewPost} /> */}
                   
                    
                </Switch>
            </div>


        );
    }
}

export default Blog;