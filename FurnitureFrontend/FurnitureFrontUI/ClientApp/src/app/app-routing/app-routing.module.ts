import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { UserProfileComponent } from '../userstuff/user-profile/user-profile.component';
import { BrowserUtils } from '@azure/msal-browser';
import { MsalGuard } from '@azure/msal-angular';

const routes: Routes = [
  { path: 'users', component: UserProfileComponent , canActivate:[MsalGuard]},
  {path: '', component: HomeComponent}
];
const isIframe = window !== window.parent && !window.opener;

@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes, {
      // Don't perform initial navigation in iframes or popups
     initialNavigation: !BrowserUtils.isInIframe() && !BrowserUtils.isInPopup() ? 'enabledNonBlocking' : 'disabled' // Set to enabledBlocking to use Angular Universal
    })
  ],
  exports: [RouterModule]

})
export class AppRoutingModule { }
