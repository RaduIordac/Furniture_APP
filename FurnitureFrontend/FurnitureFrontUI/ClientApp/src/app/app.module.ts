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
import { MatDialog, MatDialogModule, MatDividerModule, MatSidenavModule, MatToolbarModule } from '@angular/material';
import {MatGridListModule} from '@angular/material/grid-list';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductsComponent,
    FooterComponent,
    WelcomeModalComponent
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
    
    
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full', title: 'FurnitureAppShop'},
      { path: 'counter', component: CounterComponent, title: " Counter" },
      { path: 'fetch-data', component: FetchDataComponent,title: "Weather data" },
      { path: 'products', component: ProductsComponent, title: "Products display" },
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [WelcomeModalComponent]
})
export class AppModule { }
