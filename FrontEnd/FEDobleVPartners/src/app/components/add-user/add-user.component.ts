import { Component } from '@angular/core';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})

export class AddUserComponent {
  type_document = 
  [
    {id: 1, type: 'Tarjeta de Identidad'},
    {id: 2, type: 'Cédula de Ciudadania'},
    {id: 3, type: 'Cédula de Extranjería'},
    {id: 4, type: 'Pasaporte'},
    {id: 5, type: 'NIT'},
  ]
}
