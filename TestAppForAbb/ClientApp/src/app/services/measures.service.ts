import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Measure } from '../models/measure';

@Injectable({
  providedIn: 'root'
})
export class MeasuresService {
    public measures: Measure[];

    constructor(public http: HttpClient, 
        @Inject('BASE_URL') public baseUrl: string) {
        this.getData();
    }

    getData() {
        this.http.get<Measure[]>(this.baseUrl + 'api/measure').subscribe(result => {
            this.measures = result;
        }, error => console.error(error));
    }
}
