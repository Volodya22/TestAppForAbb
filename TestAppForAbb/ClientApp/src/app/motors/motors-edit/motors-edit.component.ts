import { Component, OnInit, Input, Inject } from '@angular/core';
import { Motor } from 'src/app/models/motor';
import { HttpClient } from '@angular/common/http';
import { MotorType } from 'src/app/enum/motor-type';

@Component({
  selector: 'app-motors-edit',
  templateUrl: './motors-edit.component.html',
  styleUrls: ['./motors-edit.component.css']
})
export class MotorsEditComponent implements OnInit {
    @Input("motor") motor: Motor;

    constructor(public http: HttpClient, 
        @Inject('BASE_URL') public baseUrl: string) { }

    ngOnInit() {
    }

    getType(type: MotorType) : string {
        return MotorType[type];
    }
}
