import { Component, OnInit } from '@angular/core';
import {IProduct} from "../share/models/product";
import {ShopService} from "./shop.service";
import {IProductType} from "../share/models/productType";
import {IBrand} from "../share/models/brand";

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {

  products: IProduct[];
  brands: IBrand[];
  types: IProductType[];
  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
    this.getProducts();
    this.getBrands();
    this.getTypes();


  }

  getProducts(){
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
  getBrands(){
    this.brands = this.shopService.getBrands();
    // this.shopService.getBrands().subscribe({
    //   next : value => {
    //     this.brands = value.data;
    //   },
    //   error: err => {
    //     console.log(err);
    //   }
    // });
  }
  getTypes(){
    this.types = this.shopService.getTypes();
    // this.shopService.getTypes().subscribe({
    //   next : value => {
    //     this.brands = value.data;
    //   },
    //   error: err => {
    //     console.log(err);
    //   }
    // });
  }

}
