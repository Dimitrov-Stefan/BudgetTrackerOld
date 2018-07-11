import { Component, OnInit } from '@angular/core';
import { FinancialOperation } from "./financial-operation";
import { FinancialOperationService } from "./financial-operation.service";

@Component({
    selector: 'pm-financial-operation-list',
    templateUrl: './financial-operation-list.component.html',
    styleUrls: ['./financial-operation-list.component.css']
})
export class FinancialOperationListComponent implements OnInit {

    pageTitle: string = 'Financial Operations';
    financialOperations: FinancialOperation[];

    constructor(private service: FinancialOperationService) { }

    ngOnInit() {
        this.service.getFinancialOperations().subscribe(fo => {
            this.financialOperations = fo;
        });
    }

}
