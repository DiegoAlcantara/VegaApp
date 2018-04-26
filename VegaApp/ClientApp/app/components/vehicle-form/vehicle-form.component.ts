import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { MakeService } from '../../services/make.services';

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicle-form.component.html'
})
export class VehicleFormComponent implements OnInit{
    public makes :any [];
    public models :any [];
    public vehicle : any = {};

    constructor(private makeService: MakeService) { }

    ngOnInit() { 

        this.makeService.getMakes().subscribe(m => this.makes = m  );

    }

    onMakeChange() {
        var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
        this.models = selectedMake ? selectedMake.models : [] ;
    }
 



}