import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Album } from './model/album';
import { Title } from './model/title';

import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  url = 'http://localhost:5155/';
  libary: Album[] | undefined;


  constructor(private http: HttpClient) {
    this.http.get<Album[]>(this.url + 'WeatherForecast').subscribe({
      next: (v) => {
        this.libary = v;
        console.log(v)
        console.log(this.libary)
      }
    });
  }
}
