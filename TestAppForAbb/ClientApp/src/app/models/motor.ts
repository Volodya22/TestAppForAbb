import { AbstractEntity } from "./abstract-entity";
import { MotorType } from "../enum/motor-type";

export class Motor extends AbstractEntity {
    constructor(
        public name: string,
        public type: MotorType,
        public maxPower: number | null,
        public voltage: number | null,
        public fuelConsumption: number | null,
        public current: number | null,
        public maxTorque: number | null,
        public maxPressure: number | null,
        public displacement: number | null,
        public motorId: number,
        public id: number
    ) {
        super(id);
    }
}