import { Component, OnInit } from '@angular/core';
import { Weather } from '../core/models/weather';
import { WeatherForecastService } from '../core/services/weather-forecast.service';

@Component({
  selector: 'app-weather-forecast',
  templateUrl: './weather-forecast.component.html'
})
export class WeatherForecastComponent implements OnInit {
  public weatherForecast: Weather[];

  constructor(private weatherForecastService: WeatherForecastService) {}

  ngOnInit() {
    this.weatherForecastService
      .getBillerResults()
      .subscribe(
        (weatherForecast: Weather[]) => (this.weatherForecast = weatherForecast)
      );
  }
}
