import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-product',
  templateUrl: './get-product.component.html'
})
export class GetProductsComponent {
  public forecasts: GetProducts[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<GetProducts[]>(baseUrl + 'api/products').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}

interface GetProducts {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
