import React, { FunctionComponent } from 'react';

import './Marquee.css';

export let Marquee: FunctionComponent<{text: string}> = (props) => {
  let text = props.text || '';
  return (
    <div className="marquee">
      <div>
        <span>{text}</span>
        <span>{text}</span>
      </div>
    </div>
  )
};