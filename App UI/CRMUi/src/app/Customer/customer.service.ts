import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private httpData: HttpClient) { }

  getAllCustomer() {
    return this.httpData.get(environment.baseApi + 'Customer/GetAll');
  }

  getCustomerId(id: number) {
    return this.httpData.get(environment.baseApi + 'Customer/GetCustomerById?id=' + id)
  }

  AddCustomer(model: any) {
    return this.httpData.post(environment.baseApi + 'Customer/addCustomer', model)
  }

  EditCustomer(customer: any) {
    return this.httpData.put(environment.baseApi + 'Customer/updateCustomer', customer)
  }

  AddCustomerAddress(addres: any) {
    return this.httpData.post(environment.baseApi + 'CustomerAddress/addCustomerAddress', addres)
  }
}
