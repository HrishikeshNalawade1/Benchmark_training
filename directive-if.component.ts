import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directive-if',
  templateUrl: './directive-if.component.html',
  styleUrls: ['./directive-if.component.css']
})
export class DirectiveIfComponent implements OnInit {

  display:boolean=true;
  num:number=0;

  constructor() { }

  ngOnInit(): void {
  }

}
