import { Component, OnInit } from '@angular/core';
// import { Item } from '../item/item.model';
import { ItemService } from '../item.service';
import { CartService } from '../cart.service';
import { Item } from '../item/item.model';


@Component({
  selector: 'app-item-card',
  templateUrl: './item-card.component.html',
  styleUrls: ['./item-card.component.scss']
})
export class ItemCardComponent implements OnInit {



  ItemQuantity: number;

//   items: Item[] = [
//     new Item('Teady Bear', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 250, 20, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603'),
//    new Item('Doll', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 250, 20, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603'),
//    new Item('Shirt', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 250, 20, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603'),
//    new Item('Jeans', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 250, 20, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603')
//  ];


  public items = [];
  public Cart = [];
  constructor(private _itemservice: ItemService, private _cartsevice: CartService) {}


  ngOnInit() {
    this.items = this._itemservice.getItems();
    this.Cart = this._cartsevice.GetCart();
  }


  AddToCart (item: Item){
    var a = true;
    for( var i = 0; i < this.Cart.length; i++){ 
      if ( this.Cart[i] === item) {
        a = false;
      }
    }
    if (a){
      this._cartsevice.AddToCart(item);
    }  
  }

  getTotal(item: Item){
    item.ITotal = (item.IPrice * item.IChosenQuantity) + item.IShipping;
    return item.ITotal;
  }

  OpenItem (item: Item){
    for( var i = 0; i < this.items.length; i++){ 
      if ( this.items[i].ISelected === true){
        this.items[i].ISelected = true;
        console.log();
        
      }
  }
  }


  
}
