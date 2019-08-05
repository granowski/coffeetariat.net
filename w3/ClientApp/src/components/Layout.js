import React, { Component } from 'react';
import { Marquee } from './Marquee';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <Marquee text="asdf qwer zxcv" />
        {this.props.children}
      </div>
    );
  }
}
