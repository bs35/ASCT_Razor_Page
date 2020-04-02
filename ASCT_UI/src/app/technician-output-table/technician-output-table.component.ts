import { Component, OnInit } from '@angular/core';

export interface SampleData {
  LRU_PART_NUMBER: string;
  OPS: string;
  OPC: string;
  MEDB: string;
  ADDB: string;
}


const SAMPLE_DATA: SampleData[] = [
  {
    LRU_PART_NUMBER: '176200-01-01',
    OPS: '5569090-001',
    OPC: 'BCG-01T-61',
    MEDB: 'BCG01TA0',
    ADDB: 'ASA1007A'
  },
  {
    LRU_PART_NUMBER: '171497-05-01',
    OPS: '5569090-001',
    OPC: 'BCG-01T-61',
    MEDB: 'BCG01TA0',
    ADDB: 'ASA1007A'
  }
];

@Component({
  selector: 'technician-output-table',
  templateUrl: './technician-output-table.component.html',
  styleUrls: ['./technician-output-table.component.css']
})
export class TechnicianOutputTableComponent {

  displayedColumns: string[] = ['LRU Part Number', 'OPS', 'OPC', 'MEDB', 'ADDB'];
  dataSource = SAMPLE_DATA;

}
