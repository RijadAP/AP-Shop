import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LogInComponent } from './log-in/log-in.component';
import { HomepageComponent } from './homepage/homepage.component';
import { CartComponent } from './cart/cart.component';
import { ItemDetailsComponent } from './item-details/item-details.component';
import { PurchaseHistoryComponent } from './purchase-history/purchase-history.component';
import { ProductCheckoutComponent } from './product-checkout/product-checkout.component';


const routes: Routes = [
  { path: 'LogIn', component: LogInComponent},
  { path: 'HomePage', component: HomepageComponent },
  { path: 'MyCart', component: CartComponent },
  { path: 'ItemDetail', component: ItemDetailsComponent },
  { path: 'PurchaseHistory', component: PurchaseHistoryComponent },
  { path: 'ProductCheckOut', component: ProductCheckoutComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
