import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {

  myapp:string='I am Interpolation';
  mynumber:number=677;
  imagePath:string='../assets/hrishi.jpg'
 
 isdisabled=false;
  constructor() { }

  ngOnInit(): void {
  }
  display():string{
  return ' aaaaaa   i am in Display';
  }
}
