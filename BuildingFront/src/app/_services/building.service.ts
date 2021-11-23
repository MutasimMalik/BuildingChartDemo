import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Building } from '../_models/Building';
import { DataField } from '../_models/DataField';
import { Objects } from '../_models/Objects';
import { Reading } from '../_models/Reading';

@Injectable({
  providedIn: 'root'
})
export class BuildingService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getReadingData(startDate: string, endDate: string, buildingid?: number, objectId?: number, dataFieldId?: number): Observable<Reading[]> {
    return this.http.get<Reading[]>(this.baseUrl + 'reading?startDate=' + startDate + '&endDate=' + endDate + '&buildingId=' + buildingid + '&objectId=' + objectId + '&dataFieldId=' + dataFieldId);
  }

  getBuildingData(): Observable<Building[]> {
    return this.http.get<Building[]>(this.baseUrl + 'building/');
  }

  getObjectData(): Observable<Objects[]>{
    return this.http.get<Objects[]>(this.baseUrl + 'object/');
  }

  getDataFieldData(): Observable<DataField[]>{
    return this.http.get<DataField[]>(this.baseUrl + 'dataField/');
  }
}
