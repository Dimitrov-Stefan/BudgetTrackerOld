import { NgModule } from '@angular/core';
import { FinancialItemsListComponent } from './financial-items-list.component';
import { FinancialItemDetailComponent } from './financial-item-detail.component';
import { RouterModule } from '@angular/router';
import { FinancialItemService } from "./financial-item.service";
import { FinancialItemGuardService } from './financial-item-guard.service';
import { SharedModule } from './../shared/shared.module';
import { FinancialItemCreateComponent } from './financial-item-create.component';


@NgModule({
  imports: [
      RouterModule.forChild([
      { path: 'financialItems', component: FinancialItemsListComponent },
      { path: 'financialItems/:id', canActivate: [FinancialItemGuardService], component: FinancialItemDetailComponent },
      { path: 'financialItems/financialItem/Add', component: FinancialItemCreateComponent }
      ]),
      SharedModule
  ],
  declarations: [
      FinancialItemsListComponent,
      FinancialItemDetailComponent,
      FinancialItemCreateComponent
  ],
  providers: [
      FinancialItemService,
      FinancialItemGuardService
  ]
})
export class FinancialItemModule { }
