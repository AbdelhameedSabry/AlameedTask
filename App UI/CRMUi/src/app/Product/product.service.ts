import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class ProductService {

  constructor(private httpData: HttpClient) { }

  getAllProducts() {
    return this.httpData.get(environment.baseApi + 'Product/getAllProducts');
  }

  getProductById(id: number) {
    return this.httpData.get(environment.baseApi + 'Product/getProductById?id=' + id)
  }

  CreateProduct(model: any) {
    return this.httpData.post(environment.baseApi + 'Product/AddProduct', model)
  }

  EditProduct(product: any) {
    return this.httpData.put(environment.baseApi + 'Product/EditProduct', product)
  }
}
