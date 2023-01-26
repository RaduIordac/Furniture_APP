import { Component, Injectable } from '@angular/core';
import { Product } from '../products/Products';
import { CartService } from './cart.service';
import {  ElementRef,  OnInit,  QueryList,  VERSION,  ViewChildren} from "@angular/core";
import { CurrencyPipe } from "@angular/common";
import {  FormControl,  FormGroup,  Validators,  FormBuilder} from "@angular/forms";


@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})



export class CartComponent implements OnInit{
  
   items = this.cartService.getItems();
  // totalPrice = this.cartService.gettotalPrice();
  constructor(
    public cartService: CartService,
      public currencyPipe: CurrencyPipe,
       public builder: FormBuilder
  ) { }
// @ViewChildren('myitems') subTotalItems: QueryList<ElementRef>;
  @ViewChildren("subTotalWrap")
  subTotalItems!: QueryList<ElementRef>;
  @ViewChildren("subTotalWrap_existing")
  subTotalItems_existing!: QueryList<
    ElementRef
  >;

  

  
  //----- calculate total
  get total() {
    return this.items.reduce(
      (sum, x) => ({
        qtyTotal: 1,
        variationCost: sum.variationCost + x.quantity * x.price
      }),
      { qtyTotal: 1, variationCost: 0 }
    ).variationCost;
  }

  changeSubtotal(item:Product, index:number) {
    const qty = item.quantity;
    const amt = item.price;
    const subTotal = amt * qty;
    const subTotal_converted = this.currencyPipe.transform(subTotal, "EUR");

    this.subTotalItems.toArray()[index].nativeElement.innerHTML = subTotal_converted;
    this.cartService.saveCart();
  }

  //----- remove specific item
  removeFromCart(item:Product) {
    this.cartService.removeItem(item);
    this.items = this.cartService.getItems();
  }

  //----- clear cart item
  clearCart(items:Product[]) {
    // this.items.forEach((item, index) => this.cartService.removeItem(index));
    this.cartService.clearCart(items);
    this.items = [...this.cartService.getItems()];
  }

  //----- add item to cart
  addToCart(item:Product) {
    if (!this.cartService.itemInCart(item)) {
      item.quantity = 1;
      this.cartService.addToCart(item); //add items in cart
      this.items = [...this.cartService.getItems()];
    }
  }

  ngOnInit(): void {
    this.cartService.loadCart();
    this.items = this.cartService.getItems();
  }
}
  
  



