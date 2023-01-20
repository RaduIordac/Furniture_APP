import { Component} from '@angular/core';
import { FormControl, NgForm } from '@angular/forms';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.css']
})

export class ContactFormComponent  {
  
  onSubmit(form: NgForm) {
    console.log(form);
  }

  departmentControl = new FormControl('');
  departmentList: string[] = ['Sales', 'Marketing', 'Purchasing', 'Logistics', 'Production', 'Management'];
  
}
