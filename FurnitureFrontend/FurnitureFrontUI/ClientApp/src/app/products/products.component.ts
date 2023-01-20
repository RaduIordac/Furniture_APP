import { Component, Directive, HostListener, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from './Products';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html'
})


export class ProductsComponent {
  public products: Product[] = [];
  
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    http.get<Product[]>(baseUrl + 'api/products').subscribe({next: (result) => this.products = result, error: (err) => console.error(err),complete: () => console.info('complete')});
    
  }

  public increaseLikes(product: Product) {
    if (!product.likeCount){
      product.likeCount = 0;
    }
    
    product.likeCount++;
    
  }
  public decreaseLikes(product: Product) {
   
    if (!product.likeCount){
      product.likeCount = 0;
    }
    product.likeCount--;
    
  }
 
  public goToEditProduct(product: Product){
    this.router.navigate(['edit-product', product.id])
  }
}


