import { Injectable } from '@angular/core';
import { name } from '@azure/msal-angular/packageMetadata';
import { Product } from '../products/Products';

@Injectable({
  providedIn: 'root'
})
export class CartService {


  constructor() { }

  items: Product[] = [];
  
  addToCart(item: Product) {
    const exists = this.items.find(({name}) => name === item.name);
    if (!exists) {
    this.items.push({...item, quantity:1}); 
     // enhance "porduct" opject with "num" property
     return;
   }
   exists.quantity += 1;

  }

  getItems() {
    return this.items;
  }

  clearCart() {
    this.items = [];
    return this.items;
  }
  gettotalPrice() {
    return this.items.reduce((p, { price }) => p + price, 0);
  }

}
