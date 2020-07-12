import React, {Component} from "react";
import './IndexPage.css';
import JobExperience from "./JobExperience";

export class IndexPage extends Component {
  constructor(props) {
    super(props);
  }

  componentDidMount() {
  }

  componentWillUnmount() {
  }

  render() {
      const company = 'WOW! (Wide Open West)';
      const position = 'Principal Software Developer';
      const description = 'You wouldn\'t believe me.';
      
    return (
      <section>
        {/*<img src={background} alt="background image" />*/}
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
        </div>
        </main>
      </section>
    );
  }
}