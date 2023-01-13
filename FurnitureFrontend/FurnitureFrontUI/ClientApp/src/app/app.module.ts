import { BrowserModule } from '@angular/platform-browser';
import { WelcomeModalComponent } from './welcome-modal/welcome-modal.component';  
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductsComponent } from './products/products.component';
import { FooterComponent } from './footer/footer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialog, MatDialogModule, MatDividerModule, MatFormFieldModule, MatSidenavModule, MatToolbarModule } from '@angular/material';
import {MatGridListModule} from '@angular/material/grid-list';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { FeedbackFormComponent } from './feedback-form/feedback-form.component';
import { LoginComponentComponent } from './login-component/login-component.component';
import { SidenavComponentComponent } from './sidenav-component/sidenav-component.component';
import { CarousselComponent } from './caroussel/caroussel.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductsComponent,
    FooterComponent,
    WelcomeModalComponent,
    ContactFormComponent,
    FeedbackFormComponent,
    LoginComponentComponent,
    SidenavComponentComponent,
    CarousselComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatIconModule,
    MatButtonModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatButtonModule,
    MatIconModule,
    MatDividerModule,
    MatGridListModule,
    MatDialogModule,
    MatFormFieldModule,
        
    
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full', title: 'FurnitureAppShop'},
      { path: 'counter', component: CounterComponent, title: " Counter" },
      { path: 'fetch-data', component: FetchDataComponent,title: "Weather data" },
      { path: 'products', component: ProductsComponent, title: "Products display" },
      { path: 'contact-form', component: ContactFormComponent, title: "Contact Form" },

      { path: '**', redirectTo: '' },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [WelcomeModalComponent]
})
export class AppModule { }
