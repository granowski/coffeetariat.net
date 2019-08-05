import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import {IndexPage} from './components/IndexPage';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route path='/' component={IndexPage} />
        <Route path='/' componetn={UnpopularFeed} />
      </Layout>
    );
  }
}
