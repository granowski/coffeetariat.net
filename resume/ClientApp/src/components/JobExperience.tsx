import React, {Component} from "react";

interface IJobExperienceModel {
    company: string;
    position: string;
    description: string;
    startYear: number;
    startMonth: number;
    stopYear: number;
    stopMonth: number;
}

export default class JobExperience extends Component<any, any> {
    constructor(props: IJobExperienceModel) {
        super(props);

        const monthLookup = [
            'January',
            'February',
            'March',
            'April',
            'May',
            'June',
            'July',
            'August',
            'September',
            'October',
            'November',
            'December'
        ];
        
        let toMonthYear = "";
        
        if (props.stopMonth === 0 && props.stopYear === 0) {
            toMonthYear = 'Present';
        }
        
        this.state = {
            fromMonthYear: monthLookup[props.startMonth] + ' ' + props.startYear.toString(10),
            toMonthYear: toMonthYear
        }
    }
    
    render() {            
        return (
            <div className="job-experience">
                <div>
                    <span>{this.props.company}</span>
                    <span>{this.props.fromMonthYear}&nbsp;-&nbsp;{this.state.toMonthYear}</span>
                </div>
                <span>{this.props.position}</span>
                <p>{this.props.description}</p>
            </div>
        );
    }
}