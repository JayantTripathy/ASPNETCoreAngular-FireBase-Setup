import { Component } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  cricketers: any;
  constructor(private apiservice: ApiService) { }
  ngOnInit() {
    this.apiservice.get('Cricketers/cricketers-list').subscribe(res => {
      this.cricketers = res;
    });
  }
}
