import { Component, OnInit } from '@angular/core';
import { UserInternService } from '../Services/user-intern.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  public doctor:any

  constructor(private userInternService:UserInternService
  )
{
}
  ngOnInit(): void {
    this.viewDoctor();
  }
 
  viewDoctor()
  {
    
      this.userInternService.getDoctor().subscribe(data=>
        {
               this.doctor =data;
  
        });
    
  }
  
}
