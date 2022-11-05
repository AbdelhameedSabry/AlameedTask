import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Product } from 'src/app/Models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  form!: FormGroup
  constructor(private productservice: ProductService, private build: FormBuilder) {
  }
  ngOnInit(): void {
    this.form = this.build.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      price: ['', [Validators.required, Validators.min(1), Validators.max(100)]]
    })
  }
  AddProduct() {
    this.productservice.CreateProduct(this.form.value).subscribe((res: any) => {
      alert("Data add");
      this.form.reset();
    })
  }
}
