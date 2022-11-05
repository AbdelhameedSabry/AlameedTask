import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/app/Models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-all-product',
  templateUrl: './all-product.component.html',
  styleUrls: ['./all-product.component.css']
})
export class AllProductComponent implements OnInit {

  Products: Product[] = []
  constructor(private productservice: ProductService, private router: Router) {
  }
  ngOnInit(): void {
    this.getProducts();
  }
  getProducts() {
    this.productservice.getAllProducts().subscribe((res: any) => {
      this.Products = res;
    })
  }
  editProduct(id: number) {
    this.router.navigate(['/Product', id])
  }
  AddProduct() {
    this.router.navigate(['/AddProduct'])
  }
}