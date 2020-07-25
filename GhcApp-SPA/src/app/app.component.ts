import { Component } from '@angular/core';

// Decorator
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
// JS/TS class w/ ng properties.
export class AppComponent {
  title = 'app';
}
