import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Motor } from '../models/motor';
import { MotorType } from '../enum/motor-type';
import { MotorsService } from '../services/motors.service';

@Component({
  selector: 'app-motors',
  templateUrl: './motors.component.html',
  styleUrls: ['./motors.component.css']
})
export class MotorsComponent implements OnInit {
    public motorToEdit: Motor | null = null;

    constructor(public motorsService: MotorsService) {
    }

    ngOnInit() {
    }

    getType(type: MotorType) : string {
        return MotorType[type];
    }

    get motors(): Motor[] {
        return this.motorsService.motors;
    }

    onEdit(motor: Motor) {
        this.motorToEdit = { ...motor };
    }

    onDelete(motorId: number) {
        if (confirm('Are you sure you want to delete this item?')) {
            this.motorsService.delete(motorId);
        }
    }

    onClose() {
        this.motorToEdit = null;
    }
}
