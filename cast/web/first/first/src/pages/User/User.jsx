import React, { Component } from 'react';
import LoginPanel from './components/LoginPanel';

export default class User extends Component {
  static displayName = 'User';

  constructor(props) {
    super(props);
    this.state = {};
  }

  render() {
    return (
      <div className="user-page">
        <LoginPanel />
      </div>
    );
  }
}
