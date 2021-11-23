import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Chart } from 'chart.js';
import { Building } from './_models/Building';
import { DataField } from './_models/DataField';
import { Objects } from './_models/Objects';
import { Reading } from './_models/Reading';
import { BuildingService } from './_services/building.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
    
  title = 'BuildingFront';

  chartData: Reading[] = [];
  chartArray: Array<Reading> = [];
  chartDataX : string[] = [];
  chartDataY: number[] = [];
  buildingData : Building[] = [];
  objectData: Objects[] = [];
  dataFieldData: DataField[] = [];
  selectedBuildingId: number = 0;
  selectedObjectId: number = 0
  selectedDataFieldId: number = 0;
  range = new FormGroup({
    start: new FormControl(),
    end: new FormControl(),
  });

  constructor(private buildingService: BuildingService) { }

  ngOnInit() {
    this.loadBuildingData();
    this.loadObjectData();
    this.loadDataFieldData();
  }

  loadChart() {
    this.buildingService.getReadingData(new Date(this.range.value.start).toISOString(), new Date(this.range.value.end).toISOString(), this.selectedBuildingId, this.selectedObjectId, this.selectedDataFieldId).subscribe((values) => {
      this.chartData = values;
      this.chartDataX = values.map(t=>t.timeStamp.toString());
      this.chartDataY = values.map(u=>u.value);
      console.log('chartData', this.chartData);
      console.log('chartDataX', this.chartDataX);
      console.log('charDataY', this.chartDataY);

      const chart = new Chart('canvas', {
        type: 'line',
        data: {
          labels: this.chartDataX,
          datasets: [
            {
              data: this.chartDataY,
              borderColor: '#3cbs9f',
              fill: false
            }
          ]
        },
        options: {
          legend: {
            display: false
          },
          scales: {
            xAxes: [{
              display: true
            }],
            yAxes: [{
              display:true
            }]
          }
        }
      })
    })   
  }

  loadBuildingData() {
    this.buildingService.getBuildingData().subscribe(values => {
      this.buildingData = values;
      console.log('buildingData', this.buildingData);
    })
  }

  loadObjectData() {
    this.buildingService.getObjectData().subscribe(values => {
      this.objectData = values;
      console.log('objectData', this.buildingData);
    })
  }

  loadDataFieldData(){
    this.buildingService.getDataFieldData().subscribe(values => {
      this.dataFieldData=values;
      console.log('dataFieldData', this.dataFieldData);
    })
  }

  search(){
    this.loadChart();
  }
}
