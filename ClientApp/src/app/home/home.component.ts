import { Component } from '@angular/core';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  userName: string = 'trungTest@gmail.com'
  constructor(
    private apiService : ApiService
  ) {}

  loginToSSO() {
    /*window.location.href = 'https://localhost:44398/SAML/InitiateSingleSignOn?returnurl=https://localhost:44398/'*/
    this.apiService.loginSSO();
  }
}
