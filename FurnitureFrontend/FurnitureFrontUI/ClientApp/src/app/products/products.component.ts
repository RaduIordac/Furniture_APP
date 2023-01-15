import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html'
})
export class ProductsComponent {
  public products: Products[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Products[]>(baseUrl + 'api/products').subscribe({next: (result) => this.products = result, error: (err) => console.error(err),complete: () => console.info('complete')});
  }
}

interface Products {
  name: string;
  price: number;
  created: Date;
  }
