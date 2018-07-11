import { Injectable } from '@angular/core';
import { FinancialOperation } from './financial-operation'
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { HttpParams } from "@angular/common/http";

@Injectable()
export class FinancialOperationService {
    financialOperationsurl: string = 'http://localhost:51215/api/FinancialOperations/GetAll';
    singleFinancialOperationUrl: string = 'http://localhost:51215/api/FinancialOperations/';
    addFinancialOperationUrl: string = 'http://localhost:51215/api/FinancialOperations/Create';

    constructor(private _http: HttpClient) { }

    getFinancialOperations(): Observable<FinancialOperation[]> {

        return this._http.get<FinancialOperation[]>(this.financialOperationsurl).do(data => console.log(JSON.stringify(data)))
            .catch(this.handleError);
    }

    private handleError(err: HttpErrorResponse) {
        console.log(err.message);
        return Observable.throw(err.message);
    }

}
