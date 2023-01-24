import { Component, Directive, HostListener, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Part } from './Parts';
import { Router } from '@angular/router';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-parts',
  templateUrl: './parts.component.html',
  styleUrls: ['./parts.component.css']
})


export class PartsComponent {
columnsToDisplay = ['id','name', 'quantityInStock', 'price', 'categories List', 'picture', 'options'];

public parts: Part[] = [];
public dataSource = new MatTableDataSource<Part>();
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    http.get<Part[]>(baseUrl + 'api/parts').subscribe({next: (result) => this.parts = result, error: (err) => console.error(err),complete: () => console.info('complete parts')});
    
  }

public updatedPartList(parts: Part[]){

  this.parts = parts;
}

  
  public goToEditPart(part: Part){
    this.router.navigate(['edit-part', part.id])
  }
}


