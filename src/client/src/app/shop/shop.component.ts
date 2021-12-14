import { Component, OnInit } from '@angular/core';
import {IProduct} from "../share/models/product";
import {ShopService} from "./shop.service";

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {

  products: IProduct[];
  constructor(private shopService: ShopService) { }

  ngOnInit(): void {

    this.products = this.shopService.getProducts();

    // this.shopService.getProducts().subscribe({
    //   next : value => {
    //     this.products = value.data;
    //   },
    //   error: err => {
    //     console.log(err);
    //   }
    // });
  }

}
