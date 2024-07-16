import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Persona } from '../interfaces/persona';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  myAppurl: string = environment.endpoint;
  myApiUrl: string = 'api/Persona/'

  constructor(private http: HttpClient) { }

  addpersona(persona: Persona): Observable<Persona>{
    return this.http.post<Persona>(this.myAppurl + this.myApiUrl, persona);
  }
}
