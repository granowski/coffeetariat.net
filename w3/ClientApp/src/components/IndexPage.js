import React, {Component} from "react";
import './IndexPage.css';
import background from '../images/IMG_5814.jpg';

import githublogo from '../images/GitHub_Logo.png';
import githubicon from '../images/GitHub-Mark-120px-plus.png';
import inlogo from '../images/Logo-2C-121px-TM.png';

import {NavList} from "./NavList";
import {Route, Switch, HashRouter, BrowserRouter} from "react-router-dom";

export class IndexPage extends Component {
  
  render() {
    return (
      <section>
        <img src={background} alt="background image" />
        <main>
        <span className="content">
          <span className="title">Coffeetariat.net</span>
          <Route exact path="/" component={() => (
            <React.Fragment>
              <p>A class of web sites/services primarily developed by a coffee consuming human-kind.</p>
            </React.Fragment>
          )} />
          <Switch>
              {/*<Route path="/about" component={() => <p>ha ha ha</p>} />*/}
              {/*<Route path="/blog" component={() => <p>mwuh ha ha ha</p>} />*/}
          </Switch>
          <NavList />
          <Route path="/" component={() => {
            return (<ul className="social-media">
              <li>
                <a href="https://github.com/granowski">
                  <img src={githublogo} alt="github logo" />
                  <img src={githubicon} alt="github icon" />
                </a>
              </li>
              <li>
                <a href="https://www.linkedin.com/in/derrick-granowski-91038033/">
                  <img src={inlogo} alt="linkedin logo" />
                </a></li>
            </ul>);
          }} />
        </span>
        </main>
      </section>
    );
  }
}