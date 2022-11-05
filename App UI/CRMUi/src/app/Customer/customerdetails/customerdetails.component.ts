import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Customer } from 'src/app/Models/Customer';
import { CustomerService } from '../customer.service';

@Component({
  selector: 'app-customerdetails',
  templateUrl: './customerdetails.component.html',
  styleUrls: ['./customerdetails.component.css']
})
export class CustomerdetailsComponent implements OnInit {

  customer: Customer = new Customer()
  currentId: number = 0;

  constructor(
    private customerservice: CustomerService,
    private activedtedRoute: ActivatedRoute,) { }

  ngOnInit(): void {
    this.currentId = Number(this.activedtedRoute.snapshot.paramMap.get('cid'));
    this.getcustomer()
  }

  getcustomer() {
    this.customerservice.getCustomerId(this.currentId).subscribe((res: any) => {
      this.customer = res;
    })
  }
}
