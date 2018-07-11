import { Component, OnInit } from '@angular/core';
import { FinancialItem } from "./financial-item";
import { FinancialItemService } from "./financial-item.service";

@Component({
    selector: 'bt-financial-items',
    templateUrl: './financial-items-list.component.html',
    styleUrls: ['./financial-items-list.component.css']
})

export class FinancialItemsListComponent implements OnInit {
    pageTitle: string = 'Financial Items';
    financialItems: FinancialItem[];
    _filterText: string;
    filteredFinancialItems: FinancialItem[];
    errorMessage: string;

    get filterText(): string {
        return this._filterText;
    }

    set filterText(value: string) {
        this._filterText = value;
        this.filteredFinancialItems = this.filterText ? this.performFilter(this.filterText) : this.financialItems;
    }

    constructor(private _financialItemService: FinancialItemService) {
        this.filterText = '';
    }

    performFilter(filterBy: string): FinancialItem[] {
        return this.financialItems.filter((item: FinancialItem) => item.name.toLocaleLowerCase().indexOf(filterBy) !== -1);
    }

    ngOnInit(): void{
        console.log('In On Init');

        this._financialItemService.getFinancialItems().subscribe(fi => {
            this.financialItems = fi;
            this.filteredFinancialItems = this.financialItems;
        },
            error => this.errorMessage = <any>error);
        this.filteredFinancialItems = this.financialItems;
    }

    showListLoadFailedError(data) {
        console.log(data)
    }

    onRatingClicked(message: string): void {
        this.pageTitle = 'Financial Items: ' + message;
    }
}
