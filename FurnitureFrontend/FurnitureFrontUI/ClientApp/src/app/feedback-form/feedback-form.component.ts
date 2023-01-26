import { Component, Injectable, OnInit } from '@angular/core';
declare var require: any;
// import * as countrycitystatejson from 'countrycitystatejson';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {    FormGroupDirective} from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';
// const countrycitystatejson= require('countrycitystatejson')

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(
    control: FormControl | null,
    form: FormGroupDirective | NgForm | null
  ): boolean {
    const isSubmitted = form && form.submitted;
    return !!(
      control &&
      control.invalid &&
      (control.dirty || control.touched || isSubmitted)
    );
  }
}
const countrycitystatejson= require('countrycitystatejson')

interface Country {
  shortName: string;
  name: string;
}


@Component({
  selector: 'app-feedback-form',
  templateUrl: './feedback-form.component.html',
  styleUrls: ['./feedback-form.component.css']
})

@Injectable()
export class FeedbackFormComponent implements OnInit {
  form: FormGroup;
  matcher = new MyErrorStateMatcher();
  private countryData = countrycitystatejson;
  countries: Country[];
  states: string[] | undefined;
  cities: string[] | undefined;

  country = new FormControl(null, [Validators.required]);
  state = new FormControl({ value: null, disabled: true }, [
    Validators.required,
  ]);
  city = new FormControl({ value: null, disabled: true }, [
    Validators.required,
  ]);

  FeedbackForm: FormGroup = new FormGroup({});

constructor(private formBuilder: FormBuilder) {this.countries = this.getCountries();
  this.form = new FormGroup({
    country: this.country,
    state: this.state,
    city: this.city,
  }); }

  ngOnInit(): void {
    this.FeedbackForm = this.formBuilder.group({
      firstName: [null, [Validators.required, Validators.minLength(3)]],
      lastName: [null, [Validators.required, Validators.minLength(3)]],
      email: [null, [Validators.required, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")], this.forbiddenEmails],
      address: this.formBuilder.group({
        street: [null, [Validators.required]],
        city: [null, [Validators.required]],
        country: [null, [Validators.required]]
      }),
    });

    this.country.valueChanges.subscribe((country) => {
      this.state.reset();
      this.state.disable();
      if (country) {
        this.states = this.getStatesByCountry(country);
        this.state.enable();
      }
    });

    this.state.valueChanges.subscribe((state) => {
      this.city.reset();
      this.city.disable();
      if (state) {
        this.cities = this.getCitiesByState(this.country.value, state);
        this.city.enable();
      }
    });
  }
  onSubmit(form: FormGroup) {
    console.log(form);
  }

  

  forbiddenEmails(control: FormControl): Promise<any> | Observable<any> | null {
    const promise = new Promise<any>((resolve, reject) => {
      setTimeout(() => {
        if(control.value != null && control.value === 'test@test.com') {
          resolve({'emailIsForbidden': true})
        } else {
          resolve(null)
        }
      }, 5000)
    })

    return promise;


}



  

  getCountries() {
    return this.countryData.getCountries();
  }

  getStatesByCountry(countryShotName: string) {
    return this.countryData.getStatesByShort(countryShotName);
  }

  getCitiesByState(country: any, state: string) {
    return this.countryData.getCities(country, state);
  }

}
