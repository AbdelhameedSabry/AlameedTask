import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AddCustomerComponent } from './Customer/add-customer/add-customer.component';
import { AllcustomerComponent } from './Customer/allcustomer/allcustomer.component';
import { CustomerAddressComponent } from './Customer/customer-address/customer-address.component';
import { CustomerdetailsComponent } from './Customer/customerdetails/customerdetails.component';
import { EditCustomerComponent } from './Customer/edit-customer/edit-customer.component';
import { AddProductComponent } from './Product/add-product/add-product.component';
import { AllProductComponent } from './Product/all-product/all-product.component';
import { EdtitProductComponent } from './Product/edtit-product/edtit-product.component';
import { NotFoundComponent } from './Shared/not-found/not-found.component';

const routes: Routes = [
  { path: '', redirectTo: "/Product", pathMatch: "full" },
  { path: "Home", component: AppComponent },
  { path: "Product", component: AllProductComponent },
  { path: "Product/:pid", component: EdtitProductComponent },
  { path: "AddProduct", component: AddProductComponent },
  { path: "Customer", component: AllcustomerComponent },
  { path: "Customer/:cid", component: CustomerdetailsComponent },
  { path: "Customer/edit/:cid", component: EditCustomerComponent },
  { path: "AddCustomer", component: AddCustomerComponent },
  { path: "Add_Address/:cid", component: CustomerAddressComponent },

  { path: "**", component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
