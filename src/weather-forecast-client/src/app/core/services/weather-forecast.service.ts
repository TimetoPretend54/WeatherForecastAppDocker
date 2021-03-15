import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weather } from '../models/weather';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {
  private actionUrl = 'api/weatherforecast';

  constructor(private http: HttpClient) {}

  public getBillerResults(): Observable<Weather[]> {
    return this.http.get<Weather[]>(this.actionUrl);
  }
}
