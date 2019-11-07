import { Component, OnInit } from '@angular/core';
import { CartService } from '../cart.service';

@Component({
  selector: 'app-product-checkout',
  templateUrl: './product-checkout.component.html',
  styleUrls: ['./product-checkout.component.scss']
})
export class ProductCheckoutComponent implements OnInit {

  public CartContent = [];
  public TotalPrice: number = 0;

  constructor(private _cartservice: CartService) { }

  ngOnInit() {
    this.CartContent = this._cartservice.GetCart();

    for( var i = 0; i < this.CartContent.length; i++){ 
      this.TotalPrice += this.CartContent[i].ITotal;
    }
  }
}
