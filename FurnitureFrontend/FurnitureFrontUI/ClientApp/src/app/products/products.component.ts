import { Component, Directive, HostListener, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from './Products';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';
import { CartService } from '../cart/cart.service'

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html'
})


export class ProductsComponent {
  public products: Product[] = [];
  
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, 
  // private route: ActivatedRoute,
  private cartService: CartService,  
  private router: Router   ) {
    http.get<Product[]>(baseUrl + 'api/products').subscribe({next: (result) => this.products = result, error: (err) => console.error(err),complete: () => console.info('complete')});
    
  }

  public addToCart(product: Product) {
    this.cartService.addToCart(product);
    window.alert('Your product has been added to the cart!');
  }
public updatedProductList(products: Product[]){

  this.products = products;
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

  public goToCreateProduct(){
    this.router.navigate(['create-product'])
  }

  

}


