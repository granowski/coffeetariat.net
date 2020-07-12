import React, {Component} from "react";
import './IndexPage.css';
import background from '../images/IMG_5814.shrunken.jpg';
//
// import githublogo from '../images/GitHub_Logo.png';
// import githubicon from '../images/GitHub-Mark-120px-plus.png';
// import inlogo from '../images/Logo-2C-121px-TM.png';
//
// import {Route} from "react-router-dom";
//
// import {NavList} from "./NavList";
// import {HeaderBar} from "./HeaderBar";
import JobExperience from "./JobExperience";

export class IndexPage extends Component {
  constructor(props) {
    super(props);
    
    // this.resizeListener = this.resizeListener.bind(this);
    // this.recalculateContentPosition = this.recalculateContentPosition.bind(this);
  }
  //
  // resizeListener(e) {
  //   this.recalculateContentPosition();
  // }
  //
  // recalculateContentPosition() {
  //   let content = document.getElementsByClassName('content')[0];
  //   if (!content) return;
  //  
  //   if (content.clientHeight > window.innerHeight) {
  //     content.style.top = 0;
  //     return;
  //   }
  //  
  //   let clientHeightPercent = (content.clientHeight / window.innerHeight) * 100;
  //   let clientRelativePositionPercent = (100 - clientHeightPercent) / 2 /* margins */;
  //  
  //   content.style.top = clientRelativePositionPercent + '%';
  // }
  //
  componentDidMount() {
    // window.addEventListener('resize', this.resizeListener);
    
    //this.recalculateContentPosition();
  }

  componentWillUnmount() {
    // window.removeEventListener('resize', this.resizeListener);
  }

  render() {
      const company = 'WOW! (Wide Open West)';
      const position = 'Principal Software Developer';
      const description = 'You wouldn\'t believe me.';
      
    return (
      <section>
        <img src={background} alt="background image" />
        <main>
        <div className="content">
          <h1>Derrick&nbsp;Granowski</h1>
          <JobExperience 
              company={company} 
              position={position} 
              description={description}
              startYear={2019}
              startMonth={8}
              stopYear={0}
              stopMonth={0}
          />
          {/*<span className="title">Coffeetariat.net</span>*/}
          {/*<Route exact path="/" component={() => (*/}
          {/*  <React.Fragment>*/}
          {/*    <p>A class of web sites/services primarily developed by a coffee consuming human-kind.</p>*/}
          {/*  </React.Fragment>*/}
          {/*)} />*/}
          {/*<hr />*/}
          {/*<NavList />*/}
          {/*<hr />*/}
          {/*<Route path="/" component={() => {*/}
          {/*  return (<ul className="social-media">*/}
          {/*    <li>*/}
          {/*      <a href="https://github.com/granowski">*/}
          {/*        <img src={githublogo} alt="github logo" />*/}
          {/*        <img src={githubicon} alt="github icon" />*/}
          {/*      </a>*/}
          {/*    </li>*/}
          {/*    <li>*/}
          {/*      <a href="https://www.linkedin.com/in/derrick-granowski-91038033/">*/}
          {/*        <img src={inlogo} alt="linkedin logo" />*/}
          {/*      </a></li>*/}
          {/*  </ul>);*/}
          {/*}} />*/}
        </div>
        </main>
      </section>
    );
  }
}