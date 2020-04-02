import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fleet-select',
  templateUrl: './fleet-select.component.html',
  styleUrls: ['./fleet-select.component.css']
})
export class FleetSelectComponent implements OnInit {
  fleetSelection: String;
  constructor() {
    this.fleetSelection = "Unselected";
  }

  ngOnInit() {
  }

  onBoeingClick() {
    this.fleetSelection = "Boeing";
    console.log(this.fleetSelection);
  }

  onAirbusClick() {
    this.fleetSelection = "Airbus";
    console.log(this.fleetSelection);
  }

  onReset() {
    this.fleetSelection = "Unselected";
    console.log(this.fleetSelection);
  }

}
