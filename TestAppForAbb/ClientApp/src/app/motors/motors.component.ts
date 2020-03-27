import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Motor } from '../models/motor';
import { MotorType } from '../enum/motor-type';

@Component({
  selector: 'app-motors',
  templateUrl: './motors.component.html',
  styleUrls: ['./motors.component.css']
})
export class MotorsComponent implements OnInit {
    public motors: Motor[];

    constructor(
        public http: HttpClient, 
        @Inject('BASE_URL') public baseUrl: string) {
        this.getData();
    }

    ngOnInit() {
    }

    getType(type: MotorType) : string {
        return MotorType[type];
    }

    getData() {
        this.http.get<Motor[]>(this.baseUrl + 'api/motor').subscribe(result => {
            this.motors = result;
        }, error => console.error(error));
    }

    onDelete(motorId: number) {
        if (confirm('Are you sure you want to delete this item?')) {
            this.http.delete(this.baseUrl + 'api/motor/' + motorId).subscribe(() => {                
                this.getData();
            });
        }
    }
}
