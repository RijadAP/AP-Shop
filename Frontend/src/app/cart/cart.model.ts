 import { Item } from '../item/item.model';

 export class Cart{
     public CartItem: Item;

     constructor(item: Item){
        this.CartItem = item;
     }
   }
