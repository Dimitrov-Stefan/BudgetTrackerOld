import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { WelcomeComponent } from "./home/welcome.component";
import { FinancialItemModule } from './financial-items/financial-item.module';
import { FinancialOperationModule } from './financial-operations/financial-operation.module';

@NgModule({
  declarations: [
      AppComponent,
      WelcomeComponent
  ],
  imports: [
      BrowserModule,
      HttpClientModule,
      RouterModule.forRoot([
          { path: 'welcome', component: WelcomeComponent },
          { path: '', redirectTo: 'welcome', pathMatch: 'full' },
          { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
      ]),
      FinancialItemModule,
      FinancialOperationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
