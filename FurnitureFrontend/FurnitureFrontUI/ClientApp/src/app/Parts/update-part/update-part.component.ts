import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Inject, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Part } from '../Parts';

@Component({
  selector: 'app-update-part',
  templateUrl: './update-part.component.html',
  styleUrls: ['./update-part.component.css']
})
export class UpdatePartComponent implements OnInit{
  
    UpdatePartForm: FormGroup = new FormGroup({});
    @Output() partUpdated = new EventEmitter<Part>();
    part?:Part;
  
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, 
                      private formBuilder: FormBuilder, private route: ActivatedRoute ) { }
  
    ngOnInit(): void {
      this.route.params.subscribe(params => {
        let id = params['id'];
        this.getPartById(+id)
      });
  
      this.UpdatePartForm = this.formBuilder.group({
        productname: [null, [Validators.required, Validators.minLength(4)]],
        interest: [null, [Validators.required]] 
        
      });
    }
   
    getPartById(id: number){
      this.http.get<Part>(this.baseUrl + `api/parts/${id}`).subscribe({next: (result) => this.part = result, error: (err) => console.error(err),complete: () => console.info('complete')});
  
    }
  
    onSubmit(form: FormGroup) {
      console.log(form);
    }
  
    updatePart(part:Part){
      this.http.put<Part>(this.baseUrl + `api/parts/${part.id}`,part).subscribe( (part: Part) =>this.partUpdated.emit(part));
      
    }
  
    createPart(part:Part){
      this.http.post<Part>(this.baseUrl + `api/parts/`,part).subscribe( (part: Part) =>this.partUpdated.emit(part));
      
    }
  
    deletePart(part:Part){
      this.http.delete<Part>(this.baseUrl + `api/parts/${part.id}`).subscribe( (part: Part) =>this.partUpdated.emit(part));
      
    }
  
    
  }


