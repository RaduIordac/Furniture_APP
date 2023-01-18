import { AfterViewInit, Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { WelcomeModalComponent } from './welcome-modal/welcome-modal.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit, AfterViewInit{
  title = 'FurnitureAppShop';
  


  constructor	(public matDialog: MatDialog){}
  
  ngAfterViewInit(): void {
    // this.openModal();
  }

  ngOnInit(): void {
    // this.openModal();
  }
  
  // openModal() {
  //   const dialogConfig = new MatDialogConfig();
  //   dialogConfig.disableClose = true;
  //   dialogConfig.id = "modal-component";
  //   dialogConfig.height = "350px";
  //   dialogConfig.width = "600px";
  //   const matDialog =this.matDialog.open(WelcomeModalComponent, dialogConfig);
  // }

  
}


