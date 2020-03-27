export class Measure {
    constructor(
        public time: Date,
        public motorName: string,
        public current: number | null,
        public currentDifference: number | null,
        public torque: number | null,
        public torqueDifference: number | null,
        public pressure: number | null,
        public pressureDifference: number | null
    ) { }
}