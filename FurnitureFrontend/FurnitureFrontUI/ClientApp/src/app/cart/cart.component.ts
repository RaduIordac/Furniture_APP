import { Component, Injectable } from '@angular/core';
import { Product } from '../products/Products';
import { CartService } from './cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})



export class CartComponent {
  
  items = this.cartService.getItems();
  totalPrice = this.cartService.gettotalPrice();
  constructor(
    private cartService: CartService
  ) { }


}
