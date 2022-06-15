import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Clinic } from '../models/clinic';
import { Patient } from '../models/patient';

@Injectable({
  providedIn: 'root',
})
export class ClinicsService {
  constructor(private http: HttpClient) {}
  getClinics(): Observable<Clinic[]> {
    return this.http.get<Clinic[]>('http://localhost:5230/api/clinic/Get');
  }
  getPatients(clinicId: number): Observable<Patient[]> {
    return this.http.get<Patient[]>(
      'http://localhost:5230/api/patient/Get/' + clinicId
    );
  }
}
