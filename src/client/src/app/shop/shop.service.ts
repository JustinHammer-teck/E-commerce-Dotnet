import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IPagination} from "../share/models/pagination";
import {IProduct} from "../share/models/product";

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = "http://localhost:5001/api/";

  products: IProduct[];

  constructor(private http: HttpClient) {
  }

  getProducts() {

    this.products =
      [
        {
          id: 1,
          name: "product 1",
          description: "something1",
          price: 120.00,
          pictureUrl: "string",
          productBrand: "brand 1",
          productType: "type 1"
        },
        {
          id: 2,
          name: "product 2",
          description: "something 2",
          price: 75.00,
          pictureUrl: "string",
          productBrand: "brand 2",
          productType: "type 2"
        },
        {
          id: 3,
          name: "product 3",
          description: "something 3",
          price: 100.00,
          pictureUrl: "string",
          productBrand: "brand 3",
          productType: "type 3"
        },
        {
          id: 4,
          name: "product 4",
          description: "something 4",
          price: 150.00,
          pictureUrl: "string",
          productBrand: "brand 4",
          productType: "type 4"
        },
        {
          id: 5,
          name: "product 5",
          description: "something 5",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 5",
          productType: "type 5"
        },
        {
          id: 6,
          name: "product 6",
          description: "something 6",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 6",
          productType: "type 6"
        },
        {
          id: 7,
          name: "product 7",
          description: "something 7",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 7",
          productType: "type 7"
        },
        {
          id: 8,
          name: "product 8",
          description: "something 8",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 8",
          productType: "type 8"
        },
        {
          id: 9,
          name: "product 9",
          description: "something 9",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 9",
          productType: "type 9"
        },
        {
          id: 10,
          name: "product 10",
          description: "something 10",
          price: 25.00,
          pictureUrl: "string",
          productBrand: "brand 10",
          productType: "type 10"
        },
      ];

    return this.products;

    // return this.http.get<IPagination>(this.baseUrl + 'products')
  }
}
