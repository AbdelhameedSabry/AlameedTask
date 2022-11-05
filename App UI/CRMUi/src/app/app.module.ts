import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllcustomerComponent } from './Customer/allcustomer/allcustomer.component';
import { EditCustomerComponent } from './Customer/edit-customer/edit-customer.component';
import { AddCustomerComponent } from './Customer/add-customer/add-customer.component';
import { AllProductComponent } from './Product/all-product/all-product.component';
import { AddProductComponent } from './Product/add-product/add-product.component';
import { EdtitProductComponent } from './Product/edtit-product/edtit-product.component';
import { HeaderComponent } from './Shared/header/header.component';
import { FooterComponent } from './Shared/footer/footer.component';
import { NotFoundComponent } from './Shared/not-found/not-found.component';
import { CustomerdetailsComponent } from './Customer/customerdetails/customerdetails.component';
import { CustomerAddressComponent } from './Customer/customer-address/customer-address.component';

@NgModule({
  declarations: [
    AppComponent,
    AllcustomerComponent,
    EditCustomerComponent,
    AddCustomerComponent,
    AllProductComponent,
    AddProductComponent,
    EdtitProductComponent,
    HeaderComponent,
    FooterComponent,
    NotFoundComponent,
    CustomerdetailsComponent,
    CustomerAddressComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
