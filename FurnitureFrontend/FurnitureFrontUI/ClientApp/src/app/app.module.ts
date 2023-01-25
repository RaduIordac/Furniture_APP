import { BrowserModule } from '@angular/platform-browser';
import { WelcomeModalComponent } from './welcome-modal/welcome-modal.component';  
import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
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
import { MatGridListModule } from '@angular/material/grid-list';
import { ContactFormComponent } from './contact-form/contact-form.component';
import { FeedbackFormComponent } from './feedback-form/feedback-form.component';
import { LoginComponentComponent } from './login-component/login-component.component';
import { SidenavComponentComponent } from './sidenav-component/sidenav-component.component';
import { CarousselComponent } from './caroussel/caroussel.component';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ContactFormServiceService } from './contact-form-service.service';
import { PublicClientApplication } from '@azure/msal-browser';
import { MsalModule } from '@azure/msal-angular';
import { InteractionType } from '@azure/msal-browser';
import { MsalInterceptor } from '@azure/msal-angular';
import { MsalGuard } from '@azure/msal-angular';
import { MsalRedirectComponent } from '@azure/msal-angular';
import { MatCardModule} from '@angular/material/card';
import { MatListModule} from '@angular/material/list';
import { UserProfileComponent } from './userstuff/user-profile/user-profile.component';
import { AppRoutingModule } from './app-routing/app-routing.module';
import { UserRegisterComponent } from './userstuff/user-register/user-register.component';
import { UpdateProductComponent } from './products/update-product/update-product.component';
import { AboutComponent } from './about/about.component';
import { ProductNamePipe } from './product-name.pipe';
import { PartsComponent } from './Parts/parts.component';
import { UpdatePartComponent } from './Parts/update-part/update-part.component';
import { CreateProductComponent } from './products/create-product/create-product.component';
import { CartComponent } from './cart/cart.component';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';


const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;


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
    CarousselComponent,
    UserProfileComponent,
    UserRegisterComponent,
    UpdateProductComponent,
    AboutComponent,
    ProductNamePipe,
    PartsComponent,
    UpdatePartComponent,
    CreateProductComponent,
    CartComponent,
    
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
    MatListModule,
    MatIconModule,
    MatDividerModule,
    MatGridListModule,
    MatDialogModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatTableModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    
    MatIconModule,
    MatSelectModule,
    MatRadioModule,
    MatButtonModule,
    MatTableModule,
    MatCardModule,
    MsalModule.forRoot(new PublicClientApplication(
      {
        auth:{
          clientId:"c6560dac-6885-43a6-9964-3280f79232a3",
          redirectUri:"https://localhost:44494",
          authority:"https://login.microsoftonline.com/544f8ac3-ce4c-47d1-9b72-284ac54b8d1c"
        },
        cache:{
          cacheLocation:"localStorage",
          storeAuthStateInCookie:false
        }
      }
    ),
    {
      interactionType:InteractionType.Redirect,
      authRequest:{
        scopes:["user.read"]
      }
    },{
      interactionType:InteractionType.Redirect,
      protectedResourceMap:new Map([
        ["https://graph.microsoft.com/v1.0/me",["user.read"]]
      ])
    }
    ),   
    
    RouterModule.forRoot([
      { path: '', component: NavMenuComponent, pathMatch: 'full', title: 'FurnitureAppShop'}, // HomeComponent
      { path: 'counter', component: CounterComponent, title: " Counter" },
      { path: 'fetch-data', component: FetchDataComponent,title: "Weather data" },
      { path: 'products', component: ProductsComponent, title: "Products display" },
      { path: 'contact-form', component: ContactFormComponent, title: "Contact Form" },
      { path: 'login', component: LoginComponentComponent, title: "Login Form" },
      { path: 'register', component: UserRegisterComponent, title: "Register Form" },
      { path: 'user', component: UserProfileComponent, title: "User profile",canActivate:[MsalGuard] },
      { path: 'edit-product/:id', component: UpdateProductComponent, title: "Edit product"},
      { path: 'about', component: AboutComponent, title: "About us"},
      { path: 'parts', component: PartsComponent, title: "Parts display" },
      { path: 'edit-part/:id', component: UpdatePartComponent, title: "Edit part"},
      { path: 'create-product', component: CreateProductComponent, title: "Create Product"},
      { path: 'feedback-form', component: FeedbackFormComponent, title: "Feedback Form" },
      { path: 'cart', component: CartComponent, title:"Cart" },
      
     

      { path: '**', redirectTo: '' },
    ]), AppRoutingModule, CalendarModule.forRoot({ provide: DateAdapter, useFactory: adapterFactory })
  ],
  providers: [
    ContactFormServiceService,
    {
    provide:HTTP_INTERCEPTORS,
    useClass:MsalInterceptor,
    multi:true
    },
    MsalGuard
],
  bootstrap: [AppComponent,MsalRedirectComponent],
  entryComponents: [WelcomeModalComponent]
})
export class AppModule { }
