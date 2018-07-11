import { Injectable } from '@angular/core';
import { FinancialItem } from './financial-item';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { HttpParams } from "@angular/common/http";
import { FinancialItemCreateDto } from './financial-item-create-dto';


@Injectable()
export class FinancialItemService {

    financialItemsurl: string = 'http://localhost:51215/api/FinancialItems/GetAll';
    singleFinancialItemUrl: string = 'http://localhost:51215/api/FinancialItems/';
    addFinancialItemUrl: string = 'http://localhost:51215/api/FinancialItems/Create';

    constructor(private _http: HttpClient) { }

    getFinancialItems(): Observable<FinancialItem[]> {

        return this._http.get<FinancialItem[]>(this.financialItemsurl).do(data => console.log(JSON.stringify(data)))
            .catch(this.handleError);
    }

    getFinancialItem(id: string): Observable<FinancialItem> {

        //let params = new HttpParams().set('id', id);

        let url = this.singleFinancialItemUrl + id;
        return this._http.get<FinancialItem>(url).do(data => console.log(JSON.stringify(data)))
            .catch(this.handleError)
    }

    addFinancialItem(financialItem: FinancialItemCreateDto) {
        this._http.post(this.addFinancialItemUrl, financialItem).do(data => console.log(JSON.stringify(data)))
            .catch(this.handleError).subscribe();
    }

    private handleError(err: HttpErrorResponse) {
        console.log(err.message);
        return Observable.throw(err.message);
    }
}
