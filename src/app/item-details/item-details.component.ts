import { Component, OnInit } from '@angular/core';
import { CartService } from '../cart.service';
import { Item } from '../item/item.model';
import { ItemService } from '../item.service';


@Component({
  selector: 'app-item-details',
  templateUrl: './item-details.component.html',
  styleUrls: ['./item-details.component.scss']
})
export class ItemDetailsComponent implements OnInit {

  public item: Item;

  constructor(private _itemservice: ItemService) { }



  ngOnInit() {
    this.item = this._itemservice.GetSelected();
    }

    getItemName(){
      return this.item.IName;
    }
  }




