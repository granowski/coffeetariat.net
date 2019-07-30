import React, { FunctionComponent } from 'react';

import 'Marquee.css';

let marqueeStyle = {
  overflow: 'hidden',
  position: 'relative',
  height: '25px',
  width: '420px',
};

let marqueeDiv = {
  position: 'absolute',
  overflow: 'hidden',
  display: 'block',
  width: '200%',
  height: '30px',
  animation: 'marquee 5s linear infinite'
};

let marqueeSpan = {
  float: 'left',
  width: '50%'
};

export let Marquee: FunctionComponent<{}> = (props) => {
  let text = props.text || '';
  return (
    <div >
      {text}
    </div>
  )
};