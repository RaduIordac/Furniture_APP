import { Component, Inject, inject, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material';
import { MsalBroadcastService, MsalGuardConfiguration, MsalService, MSAL_GUARD_CONFIG } from '@azure/msal-angular';
import { InteractionStatus, RedirectRequest } from '@azure/msal-browser';
import { filter, Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit, OnDestroy {
  isShowing = false;
  isExpanded = false;
  isUserLoggedIn : boolean = false;
  changeText: boolean;
  private readonly _destroy= new Subject<void>();

  constructor(@Inject(MSAL_GUARD_CONFIG) private msalGuardConf:MsalGuardConfiguration, 
  private msalBroadcastServ: MsalBroadcastService,
  private authServ: MsalService){
    this.changeText = false;
  }
 
    
  ngOnInit(): void {
    this.msalBroadcastServ.inProgress$.pipe
    (filter((interactionStatus:InteractionStatus) => 
    interactionStatus == InteractionStatus.None),
    takeUntil(this._destroy))
    .subscribe(x =>{
      this.isUserLoggedIn = this.authServ.instance.getAllAccounts().length>0
    })
  }
  ngOnDestroy(): void {
    this._destroy.next(undefined);
    this._destroy.complete();
  }

  login(){
    if(this.msalGuardConf.authRequest){
      this.authServ.loginRedirect({...this.msalGuardConf.authRequest} as RedirectRequest)
    }
    else{
      this.authServ.loginRedirect();
    }
  }

  logout(){
    this.authServ.logoutRedirect();
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

}
