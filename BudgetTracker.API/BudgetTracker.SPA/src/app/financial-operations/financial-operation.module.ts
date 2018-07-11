import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FinancialOperationListComponent } from './financial-operation-list.component';
import { FinancialOperationDetailComponent } from './financial-operation-detail.component';
import { FinancialOperationCreateComponent } from './financial-operation-create.component';
import { RouterModule } from '@angular/router';
import { FinancialOperationService } from './financial-operation.service';
import { SharedModule } from '../shared/shared.module';

@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild([
            { path: 'financialOperations', component: FinancialOperationListComponent },
            { path: 'financialOperations/financialOperation/Add', component: FinancialOperationCreateComponent }
        ]),
        SharedModule
    ],
    declarations: [
        FinancialOperationListComponent,
        FinancialOperationDetailComponent,
        FinancialOperationCreateComponent],

    providers: [FinancialOperationService]
})
export class FinancialOperationModule { }
