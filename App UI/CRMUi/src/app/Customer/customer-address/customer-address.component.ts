import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { CustomerAddress } from 'src/app/Models/CustomerAddress';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customer-address',
  templateUrl: './customer-address.component.html',
  styleUrls: ['./customer-address.component.css']
})
export class CustomerAddressComponent implements OnInit {

  currentId: number = 0
  form!: FormGroup

  constructor(private customerserivce: CustomerService,
    private build: FormBuilder,
    private activedtedRoute: ActivatedRoute,) {
  }
  ngOnInit(): void {
    this.currentId = Number(this.activedtedRoute.snapshot.paramMap.get('cid'));
    this.form = this.build.group({
      addressLineOne: ['', Validators.required],
      addressLineTwo: [''],
      city: [''],
      state: [''],
      postalCode: [''],
      country: ['', Validators.required],
      customerId: [this.currentId, [Validators.required]]
    })
  }

  SaveAddress() {
    this.customerserivce.AddCustomerAddress(this.form.value).subscribe((res: any) => {
      alert("Data add")
      this.form.reset()
    })
  }
}
