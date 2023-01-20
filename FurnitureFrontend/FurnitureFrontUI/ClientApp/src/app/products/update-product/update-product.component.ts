import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../Products';



@Component({
  selector: 'app-update-product',
  templateUrl: './update-product.component.html',
  styleUrls: ['./update-product.component.css']
})
export class UpdateProductComponent implements OnInit{
  UpdateProductForm: FormGroup = new FormGroup({});

  product?:Product;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private formBuilder: FormBuilder, private route: ActivatedRoute ) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      let id = params['id'];
      this.getProductById(+id)
    });

    this.UpdateProductForm = this.formBuilder.group({
      productname: [null, [Validators.required, Validators.minLength(4)]],
      price: [null, [Validators.required, Validators.pattern("^\-{0,1}\d+(.\d+){0,1}$")]],
      
    });
  }
 
  getProductById(id: number){
    this.http.get<Product>(this.baseUrl + `api/products/${id}`).subscribe({next: (result) => this.product = result, error: (err) => console.error(err),complete: () => console.info('complete')});

  }

  onSubmit(form: FormGroup) {
    console.log(form);
  }

  updateProduct(product:Product){
    
  }

  createProduct(product:Product){
    
  }

  deleteProduct(product:Product){
    
  }

  
}
