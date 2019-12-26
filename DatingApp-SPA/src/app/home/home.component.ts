import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode = false;
  constructor(private http: HttpClient ) { }

  ngOnInit() {
  }
  RegisterToggle() {
    this.registerMode = true;
  }
  cancemRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

}
