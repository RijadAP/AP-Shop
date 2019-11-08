import { Component, OnInit } from '@angular/core';
import { ItemService } from '../item.service';
import { CartService } from '../cart.service';
import { Cart } from './cart.model';
import { Item } from '../item/item.model';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit {

  public CartContent = [];


  constructor(private _cartservice: CartService) { }


  ngOnInit() {
    this.CartContent = this._cartservice.GetCart();
  }

  AddToCart(item){
    
    this.CartContent.push(item);
  }

  getTotal (item: Item){
    item.ITotal = (item.IPrice * item.IChosenQuantity) + item.IShipping;
    return item.ITotal;
  }

  getLength(){
    if (this.CartContent.length > 0) return true;
    else return false;
  }



  DeleteFromCart(item){
    for( var i = 0; i < this.CartContent.length; i++){ 
      if ( this.CartContent[i] === item) {
        this.CartContent.splice(i, 1); 
      }
   }
  }

}