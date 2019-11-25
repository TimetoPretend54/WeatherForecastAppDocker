import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WeatherForecastComponent } from './weather-forecast/weather-forecast.component';

const routes: Routes = [
  { path: 'weather-forecast', component: WeatherForecastComponent },
  { path: '**', redirectTo: 'weather-forecast', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
