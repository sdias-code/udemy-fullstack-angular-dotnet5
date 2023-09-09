import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
    Tema: "Angular 11",
    Local: "São Paulo"
  },
  {
    Tema: ".Net 5",
    Local: "Rio de Janeiro"
  },
  {
    Tema: "Angular 11",
    Local: "Campo Grande MS"
  }
]
  constructor() { }

  ngOnInit(): void {
  }

}
