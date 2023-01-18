import { AfterViewInit, Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { WelcomeModalComponent } from './welcome-modal/welcome-modal.component';
import { MsalBroadcastService, MsalGuardConfiguration, MsalService, MSAL_GUARD_CONFIG } from '@azure/msal-angular';
import { filter, Subject, takeUntil } from 'rxjs';
import { InteractionStatus, RedirectRequest } from '@azure/msal-browser';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit, AfterViewInit, OnDestroy{
  title = 'FurnitureAppShop';
  isIframe = false;
  loginDisplay = false;
  private readonly _destroying$ = new Subject<void>();

  constructor	(@Inject(
    MSAL_GUARD_CONFIG) private msalGuardConfig: MsalGuardConfiguration,
   matDialog: MatDialog, 
   private authService: MsalService, 
   private broadcastService: MsalBroadcastService){}
  
  ngAfterViewInit(): void {
    // this.openModal();
  }

  ngOnInit(): void {
    // this.openModal();
    this.isIframe = window !== window.parent && !window.opener;
    this.broadcastService.inProgress$
    .pipe(
      filter((status: InteractionStatus) => status === InteractionStatus.None),
      takeUntil(this._destroying$)
    )
    .subscribe(() => {
      this.setLoginDisplay();
    })
  }
  login() {
    if (this.msalGuardConfig.authRequest){
      this.authService.loginRedirect({...this.msalGuardConfig.authRequest} as RedirectRequest);
    } else {
      this.authService.loginRedirect();
    }
  }

  setLoginDisplay() {
    this.loginDisplay = this.authService.instance.getAllAccounts().length > 0;
  }
  
  // openModal() {
  //   const dialogConfig = new MatDialogConfig();
  //   dialogConfig.disableClose = true;
  //   dialogConfig.id = "modal-component";
  //   dialogConfig.height = "350px";
  //   dialogConfig.width = "600px";
  //   const matDialog =this.matDialog.open(WelcomeModalComponent, dialogConfig);
  // }

  ngOnDestroy(): void {
    this._destroying$.next(undefined);
    this._destroying$.complete();
  }
}


