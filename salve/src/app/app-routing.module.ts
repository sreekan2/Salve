import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClinicsComponent } from './components/clinics/clinics.component';
import { PatientsComponent } from './components/patients/patients.component';

const routes: Routes = [
  {path: '', component: ClinicsComponent},
  {path: 'patients/:clinicId', component: PatientsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
