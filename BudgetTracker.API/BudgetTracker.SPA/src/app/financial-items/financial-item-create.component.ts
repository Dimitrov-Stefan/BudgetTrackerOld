import { Component, OnInit } from '@angular/core';
import { FinancialItemService } from './financial-item.service';
import { FinancialItem } from "./financial-item";
import { FormBuilder, FormGroup } from '@angular/forms';
import { FinancialItemCreateDto } from './financial-item-create-dto';
import { Router } from '@angular/router';

@Component({
  selector: 'pm-financial-item-create.component',
  templateUrl: './financial-item-create.component.html',
  styleUrls: ['./financial-item-create.component.css']
})
export class FinancialItemCreateComponent implements OnInit {

    registerForm: FormGroup;
    _financialItemCreateDto: FinancialItemCreateDto;
    constructor(private _service: FinancialItemService, private formBuilder: FormBuilder, private _router: Router) { }

    ngOnInit() {
        this.registerForm = this.formBuilder.group({
            name: '',
            type: '',
            isActive: '',
            address: this.formBuilder.group({
                street: '',
                zip: '',
                city: ''
            })
        });
    }

    onBack() {
        this._router.navigate(['/financialItems']);
    }

    onSave() {
        this._financialItemCreateDto = {
            Name: this.registerForm.controls.name.value,
            Type: 1,//this.registerForm.controls.type.value,
            IsActive: this.registerForm.controls.isActive.value
        }
        //this._financialItem.name = this.registerForm.controls.name.value;
        //this._financialItem.type = this.registerForm.controls.type.value;
        //this._financialItem.isActive = this.registerForm.controls.isActive.value;

        alert(this.registerForm.controls.type.value);
        this._service.addFinancialItem(this._financialItemCreateDto);
  }
}
