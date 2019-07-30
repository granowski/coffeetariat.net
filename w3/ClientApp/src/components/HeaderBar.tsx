import * as React from "react";
import {Marquee} from "./Marquee";

export class HeaderBar extends React.Component<any, any> {
    constructor(props) {
        super(props);
    }
    
    render() {
        return (
            <div>
                <Marquee text="wtf" />
            </div>
        );
    }
}

