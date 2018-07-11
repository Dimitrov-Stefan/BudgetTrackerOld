import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot} from "@angular/router";
import { Observable } from "rxjs/Observable";

@Injectable()
export class FinancialItemGuardService implements CanActivate {

    constructor(private _router: Router) { }

    canActivate(route: ActivatedRouteSnapshot): boolean | Observable<boolean> | Promise<boolean> {
        //let id = +route.url[1].path;

        //if (isNaN(id) || id < 1) {
        //    this._router.navigate(['financialItems']);
        //    return false;
        //}

        return true;
    }
}
