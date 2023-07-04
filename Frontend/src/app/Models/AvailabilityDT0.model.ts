import { UserModel } from "./user.model";

export class availabilityDto
{
    constructor(
         public unavailableDate:string="",
         public count:number=0,
         public availableTimeSlot:string="",

       ){

        }
  
}