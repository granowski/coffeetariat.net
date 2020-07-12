import React, { Component } from 'react';
import './NavList.css';

export class NavList extends Component {
  static displayName = NavList.name;

  render () {
    return (
      <header>
        <ul>
          <li><a href="https://swungcat.coffeetariat.net/">Swungcat API</a></li>
          <li><a href="https://scauth0.coffeetariat.net/">Swungcat Auth API</a></li>
        </ul>
      </header>
    );
  }
}
