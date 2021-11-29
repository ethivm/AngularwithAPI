import { Injectable } from '@angular/core';
import { Members } from './members.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class MembersService {

  constructor(private http: HttpClient) {
    
  }
  readonly _baseUrl = "https://localhost:5001/api/Member";

  formData: Members = new Members();
  list: Members[];
  
  postMember() {
    return this.http.post(this._baseUrl ,this.formData);
  }

  

}
