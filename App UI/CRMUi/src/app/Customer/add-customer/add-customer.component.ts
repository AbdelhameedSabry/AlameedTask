import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.css']
})
export class AddCustomerComponent implements OnInit {

  form!: FormGroup
  constructor(private productservice: CustomerService, private build: FormBuilder) {
  }
  ngOnInit(): void {
    this.form = this.build.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      Phone: ['', [Validators.required, Validators.minLength(6)]]
    })
  }
  SaveCustomer() {
    this.productservice.AddCustomer(this.form.value).subscribe((res: any) => {
      alert("Data add");
      this.form.reset();
    })
  }

}
