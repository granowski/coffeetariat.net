import React, { Component } from 'react';
import './NavList.css';
import {Marquee} from "./Marquee";

export class NavList extends Component {
  static displayName = NavList.name;

  render () {
    return (
      <header>
        <Marquee text="rawr" />
        <ul>
          <li><a href="https://swungcat.coffeetariat.net/">Swungcat API</a></li>
          <li><a href="https://scauth0.coffeetariat.net/">Swungcat Auth API</a></li>
        </ul>
      </header>
    );
  }
}
