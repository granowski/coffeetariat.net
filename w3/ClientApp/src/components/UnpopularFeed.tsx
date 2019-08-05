import * as React from "react";

export class UnpopularFeed extends React.Component {
  constructor(props) {
    super(props);
  }
  
  render() {
    let placeholder = '...';
    return (
      <section>
        <header>
          <h3>Unpopular Opinions</h3>
          <div>
            { placeholder }
          </div>
        </header>
      </section>);
  }
}

