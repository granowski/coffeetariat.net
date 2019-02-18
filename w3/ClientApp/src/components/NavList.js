import React, { Component } from 'react';
import './NavList.css';
import {BrowserRouter, Link} from "react-router-dom";

export class NavList extends Component {
  static displayName = NavList.name;

  render () {
    return (
      <header>
        <ul>
          {/*<li><a href="#about">About</a></li>*/}
          {/*<li><a href="#blog">Blog</a></li>*/}
          {/*<li><Link to='about'>About</Link></li>*/}
          {/*<li><Link to='blog'>Blog</Link></li>*/}
          {/*<li><a href="https://github.com/granowski">Github</a></li>*/}
          {/*<li><a href="https://www.linkedin.com/in/derrick-granowski-91038033/">LinkedIn</a></li>*/}
          <li><a href="https://swungcat.coffeetariat.net/">Swungcat API</a></li>
          <li><a href="https://scauth0.coffeetariat.net/">Swungcat Auth API</a></li>
        </ul>
      </header>
    );
  }
}
