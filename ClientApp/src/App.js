import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import GuestList  from './components/GuestList';
import Venue from './components/Venue';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/guestList' component={GuestList} />
        <Route path='/venue' component={Venue} />
      </Layout>
    );
  }
}
