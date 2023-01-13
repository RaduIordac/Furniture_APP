import { Component, OnInit } from '@angular/core';
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

  // If the user clicks the cancel button a.k.a. the go back button, then\
  // just close the modal
  closeModal() {
    this.dialogRef.close();
  }

}
