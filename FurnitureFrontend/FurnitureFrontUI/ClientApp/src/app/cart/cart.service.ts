import { Injectable } from '@angular/core';
import { name } from '@azure/msal-angular/packageMetadata';
import { Product } from '../products/Products';

@Injectable({
  providedIn: 'root'
})
export class CartService {


  constructor() { }

  items: Product[] = [];
  
  // addToCart(item: Product) {
  //   const exists = this.items.find(({name}) => name === item.name);
  //   if (!exists) {
  //   this.items.push({...item, quantity:1}); 
  //    // enhance "porduct" opject with "num" property
  //    return;
  //  }
  //  exists.quantity += 1;

  // }

  // getItems() {
  //   return this.items;
  // }

  // clearCart() {
  //   this.items = [];
  //   return this.items;
  // }
  // gettotalPrice() {
  //   return this.items.reduce((p, { price }) => p + price, 0);
  // }

  additemToCart(addedItem: Product) {
    this.items.push(addedItem);
    console.log(addedItem);

    //-----check if there are items already added in cart
    let existingItems = [];
    if ( localStorage.getItem('cartitems')){//----- update by adding new items
      existingItems = JSON.parse(localStorage.getItems('cartitems'));
      existingItems = [addedItem, ...existingItems];
      console.log( 'Items exists');
    } 
    //-----if no items, add new items
    else{ 
      console.log( 'NO items exists');
      existingItems = [addedItem]
    } 

    this.saveCart();
  }

  getItems() {
    return this.items;
  } 

  loadCart(): void {
    this.items = JSON.parse(localStorage.getItems("cartitems")) ?? [];
  }

  saveCart(): void {
    localStorage.setItem('cartitems', JSON.stringify(this.items)); 
  }

  clearCart(items: any) {
    items = [];

    localStorage.removeItem("cartitems")
  }

  removeItem(item: { id: number; }) {
    const index = this.items.findIndex(o => o.id === item.id);

    if (index > -1) {
      this.items.splice(index, 1);
      this.saveCart();
    }
  }

  itemInCart(item: { id: number; }): boolean {
    return this.items.findIndex(o => o.id === item.id) > -1;
  }
}
  

