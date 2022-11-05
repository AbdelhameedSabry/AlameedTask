import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Customer } from 'src/app/Models/Customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-edit-customer',
  templateUrl: './edit-customer.component.html',
  styleUrls: ['./edit-customer.component.css']
})
export class EditCustomerComponent implements OnInit {
  currentId: number = 0
  form!: FormGroup
  customer: Customer = new Customer()
  constructor(
    private activedtedRoute: ActivatedRoute,
    private customerservce: CustomerService,
    private build: FormBuilder) {
  }
  ngOnInit(): void {
    this.currentId = Number(this.activedtedRoute.snapshot.paramMap.get('cid'));
    this.getcustomer()
    this.form = this.build.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      Phone: ['', [Validators.required, Validators.minLength(6)]]
    })
  }
  getcustomer() {
    this.customerservce.getCustomerId(this.currentId).subscribe((res: any) => {
      this.customer = res;
    })
  }

  updatecustomer() {
    this.form.value.id = this.currentId;
    this.customerservce.EditCustomer(this.form.value).subscribe((res: any) => {
      alert("data updated");
    }, error => { alert("data updated") })
  }
}
