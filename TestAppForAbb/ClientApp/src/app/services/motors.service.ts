import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Motor } from '../models/motor';
import { MeasuresService } from './measures.service';

@Injectable({
    providedIn: 'root'
})
export class MotorsService {
    public motors: Motor[];

    constructor(
        public http: HttpClient, 
        @Inject('BASE_URL') public baseUrl: string,
        public measuresService: MeasuresService) {
        this.getData();
    }

    getData() {
        this.http.get<Motor[]>(this.baseUrl + 'api/motor').subscribe(result => {
            this.motors = result;
        }, error => console.error(error));
    }

    edit(motor: Motor) {
        this.http.put(this.baseUrl + 'api/motor/' + motor.id, motor).subscribe(() => {
            this.getData();

            // update measures
            this.measuresService.getData();
        });
    }

    delete(motorId: number) {
        this.http.delete(this.baseUrl + 'api/motor/' + motorId).subscribe(() => {                
            this.getData();

            // update measures
            this.measuresService.getData();
        });
    }
}