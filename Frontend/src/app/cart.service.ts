import { Injectable } from '@angular/core';
import { Cart } from './cart/cart.model';
import { Item } from './item/item.model';


@Injectable({
  providedIn: 'root'
})
export class CartService {

  private cart: Cart[] = [
    
  ];

  GetCart(){
    return this.cart;
  }

  AddToCart(item){
    this.cart.push(item);
  }



  constructor() {}
}
