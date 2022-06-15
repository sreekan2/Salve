import { Component, OnInit } from '@angular/core';
import { Clinic } from 'src/app/models/clinic';
import { ClinicsService } from './../../services/clinics.service';

@Component({
  selector: 'app-clinics',
  templateUrl: './clinics.component.html',
  styleUrls: ['./clinics.component.scss'],
})
export class ClinicsComponent implements OnInit {
  clinics: Clinic[] = [];
  constructor(private clinicsService: ClinicsService) {}

  ngOnInit(): void {
    this.clinicsService.getClinics().subscribe((x) => {
      this.clinics = x;
    });
  }
}
