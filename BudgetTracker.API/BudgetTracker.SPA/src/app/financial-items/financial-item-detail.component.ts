import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'
import { FinancialItem } from "./financial-item";
import { FinancialItemService } from "./financial-item.service";


@Component({
  selector: 'pm-financial-item-detail',
  templateUrl: './financial-item-detail.component.html',
  styleUrls: ['./financial-item-detail.component.css']
})
export class FinancialItemDetailComponent implements OnInit {
    financialItem: FinancialItem;
    errorGettingItemDetails: string;

    constructor(private _route: ActivatedRoute, private _service: FinancialItemService, private _router: Router) { }

    ngOnInit() {
        let id = this._route.snapshot.paramMap.get('id');
        this._service.getFinancialItem(id).subscribe(fi => this.financialItem = fi,
            error => this.errorGettingItemDetails = <any>error);
    }

    onBack() {
        this._router.navigate(['/financialItems']);
    }

}
