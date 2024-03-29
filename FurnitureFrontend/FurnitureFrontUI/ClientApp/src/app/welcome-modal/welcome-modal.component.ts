import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialogRef } from '@angular/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-welcome-modal',
  templateUrl: './welcome-modal.component.html',
  styleUrls: ['./welcome-modal.component.css']
})
export class WelcomeModalComponent implements OnInit {
  name = 'Welcome!';
  constructor(public dialogRef: MatDialogRef<WelcomeModalComponent>, private router:Router) { };

  ngOnInit() {
  }

  actionFunction() {
    alert("You will log in now");
    this.router.navigateByUrl("/login");
  }

  
  closeModal() {
    this.dialogRef.close();
  }

  whatName = new FormControl('');
  submitted = false;
  toggleTheme = new FormControl(false);
  clear() {
   this.whatName.reset();
   this.submitted = false;
  }
 
  submit() {
   this.submitted = true;
  }

}
