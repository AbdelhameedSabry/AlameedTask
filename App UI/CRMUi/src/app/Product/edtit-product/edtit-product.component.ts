import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/Models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-edtit-product',
  templateUrl: './edtit-product.component.html',
  styleUrls: ['./edtit-product.component.css']
})
export class EdtitProductComponent implements OnInit {

  currentId: number = 0
  form!: FormGroup
  product: Product = new Product
  constructor(
    private activedtedRoute: ActivatedRoute,
    private productservce: ProductService,
    private build: FormBuilder) {
  }
  ngOnInit(): void {
    this.currentId = Number(this.activedtedRoute.snapshot.paramMap.get('pid'));
    this.getproduct()
    this.form = this.build.group({
      id: [''],
      name: ['', Validators.required],
      description: ['', Validators.required],
      price: ['', [Validators.required, Validators.min(1), Validators.max(100)]]
    })
  }
  getproduct() {
    this.productservce.getProductById(this.currentId).subscribe((res: any) => {
      this.product = res;
    })
  }

  updateProduct() {
    this.form.value.id = this.currentId;
    this.productservce.EditProduct(this.form.value).subscribe((res: any) => {
      alert(res);
    }, error => { alert("data updated") })
  }
}
