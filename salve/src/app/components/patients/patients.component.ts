import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClinicsService } from 'src/app/services/clinics.service';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.scss'],
})
export class PatientsComponent implements OnInit {
  dataSource: any;
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'dateOfBirth'];
  clinicId!: number;
  constructor(
    private patientService: ClinicsService,
    private route: ActivatedRoute
  ) {}
  @ViewChild(MatSort) sort: MatSort | undefined;
  ngOnInit() {
    this.clinicId = this.route.snapshot.params.clinicId;
    this.patientService.getPatients(this.clinicId).subscribe((x) => {
      this.dataSource = new MatTableDataSource(x);
      this.dataSource.sort = this.sort;
    });
  }
}
