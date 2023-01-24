import { AfterViewInit, Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { WelcomeModalComponent } from './welcome-modal/welcome-modal.component';
import { MsalBroadcastService, MsalGuardConfiguration, MsalService, MSAL_GUARD_CONFIG } from '@azure/msal-angular';
import { filter, Subject, takeUntil } from 'rxjs';
import { InteractionStatus, PopupRequest, RedirectRequest } from '@azure/msal-browser';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit, AfterViewInit{
  title = 'FurnitureAppShop';
  isIframe = false;
  
  


  constructor	(){}
  
  ngAfterViewInit(): void {
    // this.openModal();
  }

  ngOnInit(): void {
    // this.openModal();
    
  }
  
}

  
  // openModal() {
  //   const dialogConfig = new MatDialogConfig();
  //   dialogConfig.disableClose = true;
  //   dialogConfig.id = "modal-component";
  //   dialogConfig.height = "350px";
  //   dialogConfig.width = "600px";
  //   const matDialog =this.matDialog.open(WelcomeModalComponent, dialogConfig);
  // }

  



