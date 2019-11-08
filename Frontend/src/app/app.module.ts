import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ItemCardComponent } from './item-card/item-card.component';
import { ItemDetailsComponent } from './item-details/item-details.component';
import { LogInComponent } from './log-in/log-in.component';
import { ItemComponent } from './item/item.component';
import { ItemListComponent } from './item-list/item-list.component';
import { CartComponent } from './cart/cart.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { ItemService } from './item.service';
import { CartService } from './cart.service';
import { FormsModule } from '@angular/forms';
import { PurchaseHistoryComponent } from './purchase-history/purchase-history.component';
import { ProductCheckoutComponent } from './product-checkout/product-checkout.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomepageComponent,
    ItemCardComponent,
    ItemDetailsComponent,
    LogInComponent,
    ItemComponent,
    ItemListComponent,
    CartComponent,
    SideBarComponent,
    PurchaseHistoryComponent,
    ProductCheckoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    ItemService,
    CartService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
