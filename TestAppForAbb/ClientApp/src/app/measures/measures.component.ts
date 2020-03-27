import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Measure } from '../models/measure';

@Component({
  selector: 'app-measures',
  templateUrl: './measures.component.html',
  styleUrls: ['./measures.component.css']
})
export class MeasuresComponent implements OnInit {
    public measures: Measure[];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<Measure[]>(baseUrl + 'api/measure').subscribe(result => {
            this.measures = result;
        }, error => console.error(error));
    }

    ngOnInit() {
    }
}
