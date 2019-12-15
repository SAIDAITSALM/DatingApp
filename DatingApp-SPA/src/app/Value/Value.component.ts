import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';


@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Value',
  templateUrl: './Value.component.html',
  styleUrls: ['./Value.component.css']
})
export class ValueComponent implements OnInit {
  values: any;

  constructor( private http: HttpClient ) { }

  ngOnInit() {
    this.GetValue();
  }
  GetValue() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response;
    },  error => {
      console.log(error);
    }
    );
  }

}
