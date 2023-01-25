import { HttpClient } from '@angular/common/http';
import {
  Component,
  EventEmitter,
  Inject,
  Input,
  OnInit,
  Output,
} from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../Products';

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.css'],
})
export class CreateProductComponent {
  CreateProductForm: FormGroup = new FormGroup({});
  @Output() productCreated = new EventEmitter<Product>();
  product: Product = {} as Product;
  submitted = false;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    // this.route.params.subscribe(params => {
    //   let id = params['id'];
    //   this.getProductById(+id)
    // });

    this.CreateProductForm = this.formBuilder.group({
      productname: [null, [Validators.required, Validators.minLength(4)]],
      productinterest: [null, [Validators.required]], //Validators.pattern("^\-{0,1}\d+(.\d+){0,1}$")]],
    });
  }

  onSubmit(form: FormGroup) {
    console.log(form);
  }

  createProduct(product: Product) {
    this.http
      .post<Product>(this.baseUrl + `api/products`, product)
      .subscribe((product: Product) => this.productCreated.emit(product));
  }
}
