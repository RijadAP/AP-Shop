import { Injectable } from '@angular/core';
import { Item } from './item/item.model';



@Injectable({
  providedIn: 'root'
})
export class ItemService {

  private items: Item[] = [
    new Item('Teady Bear', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 25, 5, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603', 10),
    new Item('Doll', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 40, 7, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603', 10),
    new Item('Shirt', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 15, 1, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603', 10),
    new Item('Jeans', '31/10/2019', 'male', 'Blue', 'XZ', 'Rijad', 20, 0, 'Sarajevo', 'https://vignette.wikia.nocookie.net/made-for-tv-movie/images/6/62/Image_unavailable.png/revision/latest?cb=20171002225603', 10),
  ];
  

  getItems() : Item[] {
    return this.items;
  }

   SetSelected(item: Item){
     for( var i = 0; i < this.items.length; i++){ 
       if ( this.items[i].IName === item.IName){
         this.items[i].ISelected = true;
       }
   }
 }

 GetSelected(){
  for( var i = 0; i < this.items.length; i++){ 
    if (this.items[i].ISelected){
      return this.items[i];
    }
 }

}


  constructor() {}
}
