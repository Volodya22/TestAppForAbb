import { Component, OnInit } from '@angular/core';
import { MeasuresService } from '../services/measures.service';

@Component({
  selector: 'app-measures',
  templateUrl: './measures.component.html',
  styleUrls: ['./measures.component.css']
})
export class MeasuresComponent implements OnInit {
    constructor(public measuresService: MeasuresService) {
    }

    ngOnInit() {
    }

    get measures() {
        return this.measuresService.measures;
    }
}
