import React from 'react';
import {withRouter} from 'react-router-dom';
import classes from './Post.module.css';

const post = (props) => (

    
  
    <article className={classes.Post} onClick={props.clicked}>
        <h1>{props.title}</h1>
        <div className={classes.Info}>
            <div className={classes.Author}>{props.author}</div>
        </div>
    </article>
    
)

/** withRouter is a nice way of making that component route aware  and it will 
 * use it and will get the props containing information about the nearest loaded route 
 */

export default withRouter(post) 