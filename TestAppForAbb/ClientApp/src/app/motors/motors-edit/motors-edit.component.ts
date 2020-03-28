import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Motor } from 'src/app/models/motor';
import { MotorType } from 'src/app/enum/motor-type';
import { MotorsService } from 'src/app/services/motors.service';

@Component({
  selector: 'app-motors-edit',
  templateUrl: './motors-edit.component.html',
  styleUrls: ['./motors-edit.component.css']
})
export class MotorsEditComponent implements OnInit {
    @Input("motor") motor: Motor;

    @Output() close = new EventEmitter<void>();

    constructor(public motorsService: MotorsService) { }

    ngOnInit() {
    }

    getType(type: MotorType) : string {
        return MotorType[type];
    }

    get isElectric() {
        return this.motor.type == MotorType.Electric;
    }

    get isHydraulic() {
        return this.motor.type == MotorType.Hydraulic;
    }

    get isCombustion() {
        return this.motor.type == MotorType.Combustion;
    }

    onSave() {
        this.motorsService.edit(this.motor);

        this.close.emit();
    }

    onCancel() {
        this.close.emit();
    }
}
