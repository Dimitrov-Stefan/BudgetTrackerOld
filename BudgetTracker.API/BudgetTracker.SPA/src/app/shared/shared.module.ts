import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StarComponent } from './star.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms/';

@NgModule({
  imports: [
      CommonModule,
      FormsModule,
      ReactiveFormsModule
  ],
  declarations: [StarComponent],
  exports: [
      CommonModule,
      FormsModule,
      ReactiveFormsModule,
      StarComponent
  ]
})
export class SharedModule { }
